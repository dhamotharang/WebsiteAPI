﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GHM.Website.ThaiThinhMedic.Controllers
{
    public class ImageHandlerController : Controller
    {
        // GET: /<controller>/
        //public ActionResult Index(string url, int? width, int? height, int? type)
        //{
        //    if (string.IsNullOrEmpty(url))
        //    {
                //                using (var fileStream = new FileStream(Server.MapPath(@"/assets/images/no-image.png"), FileMode.Open, FileAccess.Read))
                //                {
                //                    Image orginImage = Image.FromStream(fileStream);
                //                    int newWidth = width ?? orginImage.Width;
                //                    int newHeight = height ?? orginImage.Height;
                //                    Image image = Common.ResizeImage(newWidth, newHeight, fileStream, type ?? (int)ImageType.Jpg);

                //                    //int newWidth = width ?? fileStream.;
                //                    //int newHeight = height ?? 70;

                //                    //Image image = Common.ResizeImage(newWidth, newHeight, fileStream, type ?? (int)ImageType.Jpg);

                //                    using (var stream = new MemoryStream())
                //                    {
                //                        if (type == (int)ImageType.Png)
                //                            image.Save(stream, ImageFormat.Png);
                //                        else
                //                            image.Save(stream, ImageFormat.Jpeg);

                //                        return File(stream.ToArray(), System.Net.Mime.MediaTypeNames.Application.Octet);
                //                    }
                //                }
                //            }
                //            var adminUrl = ConfigurationManager.AppSettings["adminPath"];
                //            var path = $"{adminUrl}{url}";
                //            try
                //            {
                //                using (var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
                //                {
                //                    Image orginImage = Image.FromStream(fileStream);
                //                    int newWidth = width ?? orginImage.Width;
                //                    int newHeight = height ?? orginImage.Height;
                //                    Image image = Common.ResizeImage(newWidth, newHeight, fileStream, type ?? (int)ImageType.Jpg);

                //                    using (var stream = new MemoryStream())
                //                    {
                //                        if (type == (int)ImageType.Png)
                //                            image.Save(stream, ImageFormat.Png);
                //                        else
                //                            image.Save(stream, ImageFormat.Jpeg);

                //                        return File(stream.ToArray(), System.Net.Mime.MediaTypeNames.Application.Octet);
                //                    }
                //                }
                //            }
                //#pragma warning disable CS0168 // The variable 'ex' is declared but never used
                //            catch (Exception ex)
                //#pragma warning restore CS0168 // The variable 'ex' is declared but never used
                //            {
                //                return null;
                //            }

        //        return View();

        //    }
        //}
    }
}
