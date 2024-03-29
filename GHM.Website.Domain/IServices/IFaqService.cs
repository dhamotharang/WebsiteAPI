﻿using System.Collections.Generic;
using System.Threading.Tasks;
using GHM.Infrastructure.Models;
using GHM.Infrastructure.ViewModels;
using GHM.Website.Domain.Constants;
using GHM.Website.Domain.ModelMetas;
using GHM.Website.Domain.ViewModels;

namespace GHM.Website.Domain.IServices
{
  public  interface IFaqService
    {
        Task<ActionResultResponse<string>> Insert(string tenantId, string creatorId, string creatorFullName, string creatorAvata, FaqMeta faqMeta);

        Task<ActionResultResponse<string>> Update(string tenantId, string lastUpdateUserId, string lastUpdateFullName, string lastUpdateAvata,
            string faqId, bool isQuickUpdate, FaqMeta faqMeta);

        Task<ActionResultResponse> Delete(string tenantId, string faqId);

        Task<ActionResultResponse<FaqDetailViewModel>> GetDetail(string tenantId, string faqId);
    }
}
