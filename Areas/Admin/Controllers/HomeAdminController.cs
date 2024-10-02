﻿using Microsoft.AspNetCore.Mvc;
using WebBanVali.Models;

namespace WebBanVali.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    [Route("admin/homeadmin")]
    public class HomeAdminController : Controller
    {
        QlbanVaLiContext db = new QlbanVaLiContext();
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("danhmucsanpham")]
        public IActionResult DanhMucSanPham()
        {
            var lstSanPham = db.TDanhMucSps.ToList();
            return View(lstSanPham);    

        }
    }
}
