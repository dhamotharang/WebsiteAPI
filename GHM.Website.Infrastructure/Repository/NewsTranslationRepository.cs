﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GHM.Website.Domain.IRepository;
using GHM.Website.Domain.Models;
using GHM.Website.Domain.ViewModels;
using GHM.Infrastructure.SqlServer;
namespace GHM.Website.Infrastructure.Repository
{
    public class NewsTranslationRepository : RepositoryBase, INewsTranslationRepository
    {
        private readonly IRepository<NewsTranslation> _newsTranslationRepository;
        public NewsTranslationRepository(IDbContext context) : base(context)
        {
            _newsTranslationRepository = Context.GetRepository<NewsTranslation>();
        }

        public async Task<int> Insert(NewsTranslation newsTranslation)
        {
            _newsTranslationRepository.Create(newsTranslation);
            return await Context.SaveChangesAsync();
        }

        public async Task<int> Update(NewsTranslation newsTranslation)
        {
            return await Context.SaveChangesAsync();
        }

        public async Task<int> Inserts(List<NewsTranslation> newsTranslations)
        {
            _newsTranslationRepository.Creates(newsTranslations);
            return await Context.SaveChangesAsync();
        }

        public async Task<int> Delete(string newsId)
        {
            var info = await _newsTranslationRepository.GetsAsync(false, x => x.NewsId == newsId);
            if (info == null || !info.Any())
                return -1;
            foreach (var newsTranslation in info)
            {
                newsTranslation.IsDelete = true;
            }
            return await Context.SaveChangesAsync();
        }

        public async Task<int> ForceDelete(string newsId)
        {
            var info = await _newsTranslationRepository.GetsAsync(false, x => x.NewsId == newsId);
            if (info == null || !info.Any())
                return -1;

            _newsTranslationRepository.Deletes(info);
            return await Context.SaveChangesAsync();
        }

        public async Task<NewsTranslation> GetInfo(string newsId, string languageId, bool isReadOnly = false)
        {
            return await _newsTranslationRepository.GetAsync(isReadOnly, x => x.NewsId == newsId && x.LanguageId == languageId && !x.IsDelete);
        }

        public async Task<string> GetNewsIdName(string newsId, string languageId)
        {
            return await _newsTranslationRepository.GetAsAsync(x => x.Title,
                x => x.LanguageId == languageId && x.NewsId == newsId);
        }

        public async Task<List<NewsTranslationViewModel>> GetByNewsId(string newsId, bool isReadOnly = false)
        {
            return await _newsTranslationRepository.GetsAsAsync(x => new NewsTranslationViewModel
            {
                LanguageId = x.LanguageId,
                Title = x.Title,
                MetaTitle = x.MetaTitle,
                UnsignName = x.UnsignName,
                Description = x.Description,
                MetaDescription = x.MetaDescription,
                MetaKeyword = x.MetaKeyword,
                SeoLink = x.SeoLink,
                Content = x.Content
            }, x => x.NewsId == newsId);
        }

        public async Task<bool> CheckExists(string tenantId, string newsId, string languageId, string title)
        {
            title = title.Trim();
            return await _newsTranslationRepository.ExistAsync(x =>
                x.TenantId == tenantId && x.NewsId != newsId && x.LanguageId == languageId && x.Title == title && !x.IsDelete);
        }

        public async Task<bool> CheckSeoLinkExists(string tenantId, string newsId, string languageId, string seolink)
        {
            seolink = seolink.Trim();
            return await _newsTranslationRepository.ExistAsync(x =>
                x.TenantId == tenantId && x.NewsId != newsId && x.LanguageId == languageId && x.SeoLink == seolink && !x.IsDelete);
        }

        public async Task<string> GetNewsIdBySeoLink(string tenantId, string languageId, string seoLink)
        {
            return await _newsTranslationRepository.GetAsAsync(x => x.NewsId,
                x => x.TenantId == tenantId && x.LanguageId == languageId && x.SeoLink == seoLink && !x.IsDelete);
        }
    }
}
