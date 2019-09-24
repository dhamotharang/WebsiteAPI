﻿using System.Collections.Generic;

namespace GHM.Website.Domain.ModelMetas
{
    public class FaqGroupMeta
    {
        public bool IsActive { get; set; }
        public string ConcurrencyStamp { get; set; }
        public List<FaqGroupTranslationMeta> FaqGroupTranslations { get; set; }
    }
}