﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GHM.FileManagement.Domain;
using GHM.FileManagement.Domain.IRepositories;
using GHM.FileManagement.Domain.IServices;
using GHM.FileManagement.Domain.ModelMetas;
using GHM.FileManagement.Domain.Models;
using GHM.FileManagement.Domain.Resources;
using GHM.FileManagement.Domain.ViewModels;
using GHM.Infrastructure.Extensions;
using GHM.Infrastructure.IServices;
using GHM.Infrastructure.Models;
using GHM.Infrastructure.Resources;
using GHM.Infrastructure.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using File = GHM.FileManagement.Domain.Models.File;

namespace GHM.FileManagement.Infrastructure.Services
{
    public class FileService : IFileService
    {
        private readonly IFileRepository _fileRepository;
        private readonly IFolderRepository _folderRepository;

        private readonly IResourceService<SharedResource> _sharedResourceService;
        private readonly IResourceService<GhmFileManagementResource> _resourceService;

        public FileService(IFileRepository fileRepository,
            IResourceService<SharedResource> sharedResourceService, IResourceService<GhmFileManagementResource> resourceService,
            IFolderRepository folderRepository)
        {
            _fileRepository = fileRepository;
            _sharedResourceService = sharedResourceService;
            _resourceService = resourceService;
            _folderRepository = folderRepository;
        }

        public async Task<ActionResultResponse> Delete(string tenantId, string userId, string fileId)
        {
            var result = await _fileRepository.Delete(tenantId, userId, fileId);
            return new ActionResultResponse(result,
                  result == -1 ? _resourceService.GetString("File does not exists.")
                  : result <= 0 ? _sharedResourceService.GetString("Something went wrong. Please contact with administrator.")
                  : _resourceService.GetString("Delete file success"));
        }

        public async Task<ActionResultResponse<List<FileViewModel>>> UploadFiles(string tenantId, string creatorId, string creatorFullName, string creatorAvatar,
            int? folderId, IFormFileCollection formFileCollection)
        {
            List<File> listFiles = new List<File>();
            Folder folderInfo = null;
            if (folderId.HasValue)
            {
                folderInfo = await _folderRepository.GetInfo(tenantId, creatorId, folderId.Value, true);
                if (folderInfo == null)
                    return new ActionResultResponse<List<FileViewModel>>(-1,
                        _resourceService.GetString("Folder does not exists. You can not update file to this folder."));
            }

            foreach (IFormFile formFile in formFileCollection)
            {
                var concurrencyStamp = Guid.NewGuid().ToString();
                string uploadPath = $"{CreateFolder()}{concurrencyStamp}.{formFile.GetExtensionFile()}";
                //await _fileRepository.UploadFile(formFile, file.Url);
                // Upload file to server.
                var resultCopyFile = await CopyFileToServer(formFile, uploadPath);
                if (resultCopyFile == -1)
                    continue;

                var file = new File
                {
                    ConcurrencyStamp = concurrencyStamp,
                    TenantId = tenantId,
                    Name = formFile.FileName,
                    UnsignName = formFile.FileName.Trim().StripVietnameseChars().ToUpper(),
                    Type = formFile.GetTypeFile(),
                    Size = formFile.GetFileSize(),
                    Url = uploadPath,
                    CreatorId = creatorId,
                    CreatorFullName = creatorFullName,
                    CreatorAvatar = creatorAvatar,
                    Extension = formFile.GetExtensionFile(),
                    FolderId = folderInfo?.Id,
                };

                // Add file info to list for insert into database.
                listFiles.Add(file);
            }

            var result = await _fileRepository.Insert(listFiles);
            if (result <= 0)
                return new ActionResultResponse<List<FileViewModel>>(result,
                    _sharedResourceService.GetString("Something went wrong. Please contact with administrator."));

            return new ActionResultResponse<List<FileViewModel>>
            {
                Code = 1,
                Message = _resourceService.GetString("Upload file successful"),
                Data = listFiles.Select(x => new FileViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    CreatorId = x.CreatorId,
                    CreatorAvatar = x.CreatorAvatar,
                    FolderId = x.FolderId,
                    CreatorFullName = x.CreatorFullName,
                    Url = x.Url,
                    ConcurrencyStamp = x.ConcurrencyStamp,
                    CreateTime = x.CreateTime,
                    Extension = x.Extension,
                    Size = x.Size,
                    Type = x.Type
                }).ToList()
            };

            string CreateFolder()
            {
                IHostingEnvironment hostingEnvironment = new HostingEnvironment();
                var mapPath = hostingEnvironment.WebRootPath + string.Format("uploads/" + tenantId + "/{0:yyyy/MM/dd}/", DateTime.Now);
                if (!Directory.Exists(mapPath))
                    Directory.CreateDirectory(mapPath);

                return mapPath;
            }

            async Task<int> CopyFileToServer(IFormFile file, string uploadPath)
            {
                if (System.IO.File.Exists(uploadPath))
                    return -1;

                using (var stream = new FileStream(uploadPath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                return 1;
            }
        }

        public async Task<ActionResultResponse> Update(string tenantId, string userId, string fileId, FileMeta fileMeta)
        {
            var fileInfo = await _fileRepository.GetInfo(tenantId, userId, fileId);
            if (fileInfo == null)
                return new ActionResultResponse(-2, _resourceService.GetString("File does not exists."));

            if (fileInfo.ConcurrencyStamp != fileMeta.ConcurrencyStamp)
                return new ActionResultResponse(-3,
                    _resourceService.GetString("The File already updated by other people. You can not update this PatientSubject."));

            fileInfo.LastUpdate = DateTime.Now;
            fileInfo.Name = fileMeta.Name;
            fileInfo.UnsignName = fileMeta.Name.Trim().StripVietnameseChars().ToUpper();

            await _fileRepository.Update(fileInfo);

            return new ActionResultResponse(1, _resourceService.GetString("Update File successful."));

        }

        public async Task<File> GetInfo(string tenantId, string userId, string fileId, bool isReadOnly = false)
        {
            return await _fileRepository.GetInfo(tenantId, userId, fileId, isReadOnly);
        }

        public async Task<List<FileViewModel>> GetsAll(string tenantId, string userId, int? folderId)
        {
            return await _fileRepository.GetAll(tenantId, userId, folderId);
        }

        public async Task<SearchResult<FileViewModel>> Search(string tenantId, string userId, string keyword, int page, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
