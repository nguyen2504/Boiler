using System;
using Abp.Authorization;
using Abp.Domain.Uow;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Xn.Company;
using Xn.Company.Dto;
using Xn.Controllers;
using Xn.Services;
using Xn.Models.Company;
namespace Xn.Web.Controllers
{
    public class CompanyController : XnControllerBase
    {
        private readonly ICompanyAppService _companyAppService;
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyAppService companyAppService, ICompanyService companyService)
        {
            _companyAppService = companyAppService;
            _companyService = companyService;
        }

     
        public IActionResult Index()
        {
           
            CompanyDto company = new CompanyDto();
            if (Request.Cookies["id"] != null)
            {
                var hh = Request.Cookies["id"].ToString();
                var id = long.Parse(hh);
                company = _companyAppService.GetByIDtos(id);
                return View(company);
            }
            return View(company);
        }

        public IActionResult Edit()
        {
            Xn.Models.Company.Company company = new Xn.Models.Company.Company();
            if (Request.Cookies["id"] != null)
            {
                var hh = Request.Cookies["id"].ToString();
                var id = long.Parse(hh);
                company = _companyService.GetByCreatorUserId(id);
                return View(company);
            }
            return View(company);
        }
        [HttpPost]
        public IActionResult Edit(Xn.Models.Company.Company companyDto)
        {
            
            //companyDto.DeletionTime = DateTime.Now;
            //companyDto.LastModifierUserId = 1;
            //companyDto.LastModificationTime = DateTime.Now;
            //companyDto.StartFounding = DateTime.Now;
            //companyDto.CreationTime = DateTime.Now;
            //companyDto.IdScurity = "1";
            //var output = Mapper.Map<Xn.Models.Company.Company>(companyDto);
            _companyService.Update(companyDto);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _companyService.Delete(id);
            return Json("success");
        }
        //public IActionResult Edit([FromBody] CompanyDto company)
        //{
        //    return Json("");
        //}

        public IActionResult GetCompany()
        {
            if (TempData["id"] != null)
            {
                var id = long.Parse(TempData["id"].ToString());
                var data = _companyAppService.GetByIDtos(id);
                return Json(data);
            }
            return Json("");
        }

        public IActionResult Create()
        {
            if (Request.Cookies["id"] != null)
            {
                var hh = Request.Cookies["id"].ToString();
                var id = long.Parse(hh);
                var c = new Xn.Models.Company.Company()
                {
                    DeletionTime = DateTime.Now,
                    LastModifierUserId = 1,
                    LastModificationTime = DateTime.Now,
                    StartFounding = DateTime.Now,
                    CreatorUserId = id,
                    CreationTime = DateTime.Now,
                    IdScurity = "1",
                    IdCty = int.Parse(id.ToString()),
                };
                return View(c);
            }
            return View();
        }
        [HttpPost]
        [UnitOfWork]
        public IActionResult Create(Xn.Models.Company.Company company)
        {
            //company.LastModificationTime = DateTime.Today;
            //company.CreationTime = DateTime.Today;
            //company.DeletionTime = DateTime.Today;
            //company.LastModifierUserId = 1;
            var id = int.Parse(Request.Cookies["id"].ToString());
            company.CreatorUserId = id;
            if (ModelState.IsValid)
            {
                _companyService.Create(company);
            }

            return RedirectToAction("Index","Home");
        }
    }
}