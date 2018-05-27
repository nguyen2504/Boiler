using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Services;
using Xn.Models;

namespace Xn.Services
{
   public interface INhapService:IDomainService
   {
       IEnumerable<QlNcc> GetAll();
       IEnumerable<QlNcc> GetAll(string ncc, DateTime begin, DateTime end);
       QlNcc GetByMaDh(string madonhang);
       void Create(QlNcc entity);
       void Update(QlNcc entity);
       void Delete(int id);
       void DeleteMaDh(string madh);
   }
}
