using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Services;
using Xn.Models;

namespace Xn.Services
{
   public interface INhapHangService:IDomainService
   {
       IEnumerable<QlNcc> GetAll();
       IEnumerable<QlNcc> GetAll(int idcty);
       QlNcc GetById(int id);
       Task<QlNcc> Create(QlNcc entity);
       void Creates(IList<QlNcc> entitys);
       void Update(IList<QlNcc> entitys);
       void UpdateId(QlNcc entity);

        void Delete(int idcty);
       void DeleteMaDh(IList<QlNcc> entitys);
        IEnumerable<QlNcc> Search(string ncc, DateTime begin, DateTime end);
       IEnumerable<string> TenHangs(int idcty);
       IEnumerable<string> TenNccs(int idcty);
    }
}
