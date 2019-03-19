﻿namespace GHM.Warehouse.Domain.Models
{
    public class ProductTranslation
    {
        public string ProductId { get; set; }
        public string TenantId { get; set; }
        public string LanguageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string UnsignName { get; set; }
        public bool IsDelete { get; set; }
        public ProductTranslation()
        {
            IsDelete = false;
        }

        public Product Product { get; set; }
    }
}
