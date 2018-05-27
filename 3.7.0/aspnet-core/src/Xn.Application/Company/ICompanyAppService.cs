using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Domain.Services;
using Xn.Company.Dto;

namespace Xn.Company
{
   public interface ICompanyAppService:IApplicationService
   {
       IEnumerable<GetCompanyOutput> GetCompanies();
       Task Create(CreateCompanyInput input);
       void Update(UpdateCompanyInput input);
       void Delete(DeleteCompanyInput input);
       GetCompanyOutput GetById(GetCompanyInput input);
       CompanyDto GetByIDtos(long?id);
   }
}
