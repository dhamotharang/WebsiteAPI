﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using GHM.Infrastructure.Extensions;
using GHM.Website.Nelly.ViewModels;
using GHM.WebsiteClient.Api.Domain.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GHM.WebSite.Nelly.Controllers
{
    public class JsonController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IProductService _productService;

        public JsonController(IConfiguration configuration,
            IProductService productService)
        {
            _configuration = configuration;
            _productService = productService;
        }

        // GET: /<controller>/
        public async Task<IActionResult> GetProductByCategory(string seoLink)
        {
            var apiService = _configuration.GetApiServiceInfo();
            var listProduct = await _productService.ProductSearch(apiService.TenantId, CultureInfo.CurrentCulture.Name, seoLink, null, null, 20);

            var listProductData = JsonConvert.DeserializeObject<List<ProductSearchViewModel>>(JsonConvert.SerializeObject(listProduct));
            return Ok(listProductData);
        }
    }
}