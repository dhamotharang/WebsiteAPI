﻿using GHM.WebsiteClient.Api.Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GHM.WebsiteClient.Api.Domain.ViewModels
{
    public class MenuDetailViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public EffectType EffectType { get; set; }
        public int Order { get; set; }
        public bool IsActive { get; set; }
        public Position Position { get; set; }
        public string ConcurrencyStamp { get; set; }
        public List<MenuItemSearchViewModel> MenuItems { get; set; }
    }
}
