﻿using GHM.Website.Nelly.Constants;
using GHM.Website.Nelly.Models;
using System.Collections.Generic;

namespace GHM.Website.Nelly.ViewModels
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
        public List<MenuItemViewModel> MenuItems { get; set; }
    }
}
