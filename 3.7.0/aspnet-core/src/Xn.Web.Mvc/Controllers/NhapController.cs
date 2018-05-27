using System.Collections.Generic;
using Abp.AutoMapper;
using Castle.Components.DictionaryAdapter;
using Microsoft.AspNetCore.Mvc;
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
     
        public NhapController(INhapHangService nhap, IQlNhapXuatService qlNx)
        {
            _nhap = nhap;
            _qlNx = qlNx;
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
        [HttpPost]
        public IActionResult CreateOrEdit([FromBody] List<NhapHangEntity> entity  )
        {
            //var ouput = entity.MapTo<QlNcc>();
            //ouput.NgayGhi = Functions.Convert.JsToServer(entity.NgayGhi);
            return Content("");
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