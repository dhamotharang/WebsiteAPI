﻿using GHM.Infrastructure.Models;
using GHM.WebsiteClient.Api.Domain.ModelMetas;
using GHM.WebsiteClient.Api.Domain.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GHM.WebsiteClient.Api.Domain.IServices
{
    public interface IAgencyInfoService
    {
        Task<List<AgencyInfoViewModel>> AgencyInfoGetClient(string tenantId, string languageId, string provinceId , string districtId);

        Task<int> Insert(AgencyInfoMeta agencyInfoMeta);
    }
}
