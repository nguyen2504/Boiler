using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using AutoMapper;
using Xn.Company.Dto;
using Xn.Services;

namespace Xn.Company
{
  public  class CompanyAppService:ApplicationService,ICompanyAppService
  {
      private readonly ICompanyService _companyService;
        public CompanyAppService(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        public IEnumerable<GetCompanyOutput> GetCompanies()
        {
         return (IEnumerable<GetCompanyOutput>) _companyService.GetAll();
        }

        public async Task Create(CreateCompanyInput input)
        {
            Models.Company.Company output = Mapper.Map<CreateCompanyInput, Models.Company.Company>(input);
            await _companyService.Create(output);
        }

        public void Update(UpdateCompanyInput input)
        {
            Models.Company.Company output = Mapper.Map<UpdateCompanyInput, Models.Company.Company>(input);
            _companyService.Update(output);
        }

        public void Delete(DeleteCompanyInput input)
        {
            Models.Company.Company output = Mapper.Map<DeleteCompanyInput, Models.Company.Company>(input);
            _companyService.Delete(output.Id);
        }

      public GetCompanyOutput GetById(GetCompanyInput input)
      {
          var kt = _companyService.GetById(input.Code);
            var output = Mapper.Map< Models.Company.Company, GetCompanyOutput>(kt);
          return  output;
      }

      public CompanyDto GetByIDtos(long? id)
      {
          var kt = _companyService.GetByCreatorUserId(id);
          var output = Mapper.Map<Models.Company.Company, CompanyDto>(kt);
          return output;
      }
  }
}
