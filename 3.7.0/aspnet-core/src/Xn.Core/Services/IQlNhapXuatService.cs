using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Xn.Models;

namespace Xn.Services
{
   public interface IQlNhapXuatService:IDomainService
   {
       //IRepository<QlXuatNhap> _repository;
       IEnumerable<QlXuatNhap> GetAll(int idcty);
       IEnumerable<QlXuatNhap> GetAllList();
       IEnumerable<QlXuatNhap> GetAllListGetIdcty_madh(int idcty,string madh);
       QlXuatNhap GetById(int id);
       void Create(QlXuatNhap entity);
       void Update(QlXuatNhap entity);
       void Delete(int id);
       void DeleteIsActive(QlXuatNhap entity);
       QlXuatNhap GetNhap(int idcty, string madh);
     
   }
}
