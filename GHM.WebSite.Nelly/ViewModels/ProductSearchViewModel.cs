﻿using System;

namespace GHM.Website.Nelly.ViewModels
{
    public class ProductSearchViewModel
    {
        public string Id { get; set; }
        public bool IsActive { get; set; }
        public string Thumbnail { get; set; }
        public string Name { get; set; }
        public bool? IsHot { get; set; }
        public bool? IsHomePage { get; set; }
        public string DefaultUnit { get; set; }
        public decimal? SalePrice { get; set; }
        public string SeoLink { get; set; }
        public string Desciption { get; set; }
        public DateTime? LastUpdateTime { get; set; }
    }
}