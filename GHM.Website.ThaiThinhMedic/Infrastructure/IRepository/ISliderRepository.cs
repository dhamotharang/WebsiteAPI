﻿using System.Collections.Generic;
using System.Threading.Tasks;
using GHM.Infrastructure.Models;
using GHM.Website.ThaiThinhMedic.Infrastructure.Models;
using GHM.Website.ThaiThinhMedic.Infrastructure.ViewModels;

namespace GHM.Website.ThaiThinhMedic.Infrastructure.IRepository
{
    public  interface ISliderRepository
    {

        Task<Slider> GetInfo(int id);

        Task<bool> CheckNameExists(int id, string name);

        Task<int> UpdateActiveStatus(int id, bool isActive);        

        Task<int> UpdateItemActiveStatus(int id, bool isActive);

        Task<int> DeleteItem(int id);

        Task<SliderItem> GetItemInfo(int id);

        Task<List<SliderSearchViewModel>> Search(string keyword, byte? type, bool? isActive, int page, int pageSize, out int totalRows);

        Task<List<SliderSearchViewModel>> GetSliderInfoByType(byte type);
    }
}
