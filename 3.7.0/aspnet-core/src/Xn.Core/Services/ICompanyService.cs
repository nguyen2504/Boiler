using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;
using Xn.Models.Company;

namespace Xn.Services
{
   public interface ICompanyService:IDomainService
   {
       IEnumerable<Company> GetAll();
       Company GetById(string code);
       Company GetByIds(long ?id);
        Company GetByCreatorUserId(long? creatorUserId);
       //Company GetByCreatorUserId(long? creatorUserId,string email);
        //void Create(Company entity);
        Task<Company> Create(Company entity);
       void Update(Company entity);
       void Delete(string code);
       void Delete(int id);
       Company GetByIdCty(int idcty);
   }
}
