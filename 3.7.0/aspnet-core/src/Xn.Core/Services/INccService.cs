using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Services;
using Xn.Models;

namespace Xn.Services
{
   public interface INccService:IDomainService
   {
       IEnumerable<Ncc> GetAll(string code);
       IEnumerable<Ncc> GetAllbtIdCty(int idcty);
        Models.Ncc GetFist(string code);
       Task<Ncc> GetById(long? id);
       Task<Ncc> Create(Ncc entity);
       void Update(Ncc entity);
       void Delete(int id);
   }
}
