﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GHM.Website.Pyrexar.Models
{
    public class MenuObject
    {
        public List<MenuItemViewModel> ListMenuItem { get; set; }
        public int? ParentId { get; set; }
    }
}
