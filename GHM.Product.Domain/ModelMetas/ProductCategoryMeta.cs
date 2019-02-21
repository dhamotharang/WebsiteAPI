﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GHM.Product.Domain.ModelMetas
{
    public class ProductCategoryMeta
    {
        public int Order { get; set; }

        public int? ParentId { get; set; }

        public bool IsActive { get; set; }

        public string ConcurrencyStamp { get; set; }

        public List<ProductCategoryTranslationMeta> Translations { get; set; }

        public List<ProductCategoriesAttribute> ProductCategoryAttributes { get; set; }
    }
}
