using System;
using System.Globalization;
using Abp.AutoMapper;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Xn.Controllers;
using Xn.Models;
using Xn.Services;
using Xn.Users;
using Xn.Web.Models;
using Xn.Web.Models.NccEntity;


namespace Xn.Web.Controllers
{
    public class NccController : XnControllerBase
    {
        private INccService _nccService;
        private ICompanyService _companyService;
        private UserAppService _appService;
        private int _idCty;

        public NccController(INccService nccService, ICompanyService companyService, UserAppService appService)
        {
            //_idCty = int.Parse(Request.Cookies["id"].ToString());
            _nccService = nccService;
            _companyService = companyService;
            _appService = appService;
        }
        public IActionResult Index()
        {
            _idCty = int.Parse(Request.Cookies["id"].ToString());
            return View();
        }

        private int IdCty()
        {
            var ncc = Request.Cookies["id"];
            _idCty = int.Parse(ncc);
            return _idCty;
        }
        [HttpPost]
        public IActionResult GetAll()
        {
          
            var dt = _nccService.GetAllbtIdCty(IdCty());
            return Json(dt);
        }

        public IActionResult GetId()
        {
            return Json(IdCty());
        }
        [HttpPost]
        public IActionResult CreateOrEdit([FromBody]NccEntity entity)
        {
            var tt = "";
            var com = _companyService.GetByCreatorUserId(IdCty());
            if (com!=null)
            {
                if (entity.Id == 0)
                {
                    DateTime day;
                    try
                    {
                        day= DateTime.ParseExact(entity.NgayGhi, "yyyy-MM-dd'T'HH:mm:ss.fff'Z'", CultureInfo.InvariantCulture);
                    }
                    catch (Exception e)
                    {
                       day = DateTime.Parse(entity.NgayGhi);
                    }
                    // insert
                    var ouput = entity.MapTo<Ncc>();
                    ouput.NgayGhi = day;
                    ouput.IsActive = true;
                    ouput.Code = com.Code;
                    ouput.KeyUser = _appService.AbpSession.UserId.ToString();
                    ouput.NgaySinh = DateTime.Today;
                    ouput.IdCty = IdCty();
                    if (ModelState.IsValid)
                    {
                        _nccService.Create(ouput);
                    }

                    tt = "Tạo mới thành công";
                }
                else
                {
                    // update 
                    var ouput = entity.MapTo<Ncc>();
                    ouput.NgayGhi = DateTime.ParseExact(entity.NgayGhi, "yyyy-MM-dd'T'HH:mm:ss.fff'Z'", CultureInfo.InvariantCulture);
                    ouput.Code = com.Code;
                    ouput.KeyUser = _appService.AbpSession.UserId.ToString();
                    ouput.NgaySinh = DateTime.Today;
                    ouput.IdCty = IdCty();
                    if (ModelState.IsValid)
                    {
                        _nccService.Update(ouput);
                    }

                    tt = "Cập Nhật Thành Công";
                }
                
            }
           
            return Json(tt);
        }

        [HttpPost]
        public IActionResult Edit(int id)
        {
            var t = _nccService.GetById(id);
            
            return t != null ? Json(t.Result.MapTo<NccEntity>()) : Json("0");
        }

        public IActionResult Delete(int id)
        {
            _nccService.Delete(id);
            return Json("Đã Xóa Xong Dữ Liệu");

        }

        public IActionResult CreateEdit()
        {
            return View();
        }
    }
}