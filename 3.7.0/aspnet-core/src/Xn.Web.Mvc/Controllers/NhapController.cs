using System;
using System.Collections.Generic;
using System.Linq;
using Abp.AutoMapper;
using Castle.Components.DictionaryAdapter;
using Microsoft.AspNetCore.Mvc;
using Xn.Authorization.Users;
using Xn.Controllers;
using Xn.Models;
using Xn.Services;
using Xn.Web.Models;
namespace Xn.Web.Controllers
{
    public class NhapController : XnControllerBase
    {
        private readonly INhapHangService _nhap;
        private readonly IQlNhapXuatService _qlNx;
        private readonly UserManager _user;
        private readonly INccService _ncc;
        public NhapController(INhapHangService nhap, IQlNhapXuatService qlNx, UserManager user, INccService ncc)
        {
            _nhap = nhap;
            _qlNx = qlNx;
            _user = user;
            _ncc = ncc;
        }
        public int IdCty()
        {

            var ncc = Request.Cookies["id"];

            return int.Parse(ncc);
        }
        public IActionResult Index()
        {
          //var t =  _nhap.GetAll(IdCty());
            return View();
        }

        public IActionResult Creates()
        {
           return View();
        }

        public IActionResult GetMaDh()
        {
            var id = _user.AbpSession.UserId;
            var name = _user.Users.FirstOrDefault(j => j.Id.Equals(id));
            var date = DateTime.Today;
            var madh = "";
            var moth = "";
            if (date.Month < 10)
            {
                moth = "0" + date.Month;}
            else
            {
                moth =  date.Month.ToString();
            }
            
            var t = _nhap.GetAll(IdCty()).ToList()
                .Where(j => j.NgayGhi.Month.Equals(date.Month) && j.NgayGhi.Year.Equals(date.Year)).ToList();
            if (t.Count() < 10)
            {
                madh += "0" + (t.Count());}
            else
            {
                madh +=(t.Count());
            }
            ;
            if (name != null)
            {
                madh += name.Name[0];
            }
          

            return  Json(madh+moth + date.Year.ToString()[2] + date.Year.ToString()[3]);
        }
        [HttpPost]
        public IActionResult CreateOrEdit([FromBody] List<NhapHangEntity> entity  )
        {
            var id = _user.AbpSession.UserId;
            var name = _user.Users.FirstOrDefault(j => j.Id.Equals(id))?.Name;
            int dem = 0;
            foreach (var w in entity)
            {
                if (dem++ < entity.Count - 1)
                {
                    w.IdCty = IdCty();
                    w.IdNv = (int)id;
                    w.TenNv = name;
                    w.NgayGhi = DateTime.Now.ToString();
                    w.TenNcc = entity[entity.Count - 1].TenNcc;
                    var ouput = w.MapTo<QlNcc>();
                    ouput.NgayGhi = DateTime.Now;
                    _nhap.Create(ouput);
                }
            }
            var qlnx= new QlXuatNhap()
            {
                MaDonHang = entity[0].MaDonHang,
                IsActive = true,
                IdCty = IdCty(),
                Loai = "Nhap",
                ThanhTien = entity[entity.Count - 1].SoLuong,
                ThanhToan = entity[entity.Count - 1].DonGiaMua,
                Conlai = entity[entity.Count - 1].SoLuong - entity[entity.Count - 1].DonGiaMua,
                NgayGhi = DateTime.Now
            };
            _qlNx.Create(qlnx);
            return Content("thanh cong");
        }
        //---------------------------------------------//
        public JsonResult GetNxs()
        {
            return Json(_qlNx.GetAll(IdCty()));
        }
        public JsonResult GetAll(string ncc, string start, string end)
        {
            return Json(_nhap.GetAll(IdCty()));
        }

        public JsonResult GetTenNcc()
        {
            return Json(_nhap.TenNccs(IdCty()));
        }
        public JsonResult GetTenHang()
        {
            return Json(_nhap.TenHangs(IdCty()));
        }
    }
}