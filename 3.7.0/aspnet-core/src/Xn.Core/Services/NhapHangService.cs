using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Xn.Models;

namespace Xn.Services
{
   public class NhapHangService:DomainService,INhapHangService
   {
       private readonly IRepository<QlNcc> _repository;

       public NhapHangService(IRepository<QlNcc> repository)
       {
           _repository = repository;
       }
        public IEnumerable<QlNcc> GetAll()
        {
            return _repository.GetAll();
        }

        public IEnumerable<QlNcc> GetAll(int idcty)
        {
            return _repository.GetAll().Where(j => j.IdCty.Equals(idcty)).OrderByDescending(j => j.Id).ToList();
        }

       public QlNcc GetById(int id)
       {
           return _repository.FirstOrDefault(id);
       }

       public async Task<QlNcc> Create(QlNcc entity)
       {
           var check =await _repository.InsertAsync(entity);
           return check;
       }

        public async void Creates(IList<QlNcc> entitys)
        {
            foreach (var w in entitys)
            {
                await _repository.InsertAsync(w);
            }
          
        }

       public void Update(IList<QlNcc> entitys)
       {
           foreach (var w in entitys)
           {
               _repository.Update(w);
           }
       }

       public void UpdateId(QlNcc entity)
       {
           _repository.Update(entity);
        }

       public void Update(QlNcc entity)
        {
            _repository.Update(entity);
        }

      

       public void Delete(int idcty)
        {
           _repository.Delete(idcty);
        }

       public void DeleteMaDh(IList<QlNcc> entitys)
       {
           foreach (var w in entitys)
           {
              _repository.Delete(w.Id);
           }
       }


       public IEnumerable<QlNcc> Search(string ncc, DateTime begin, DateTime end)
       {
           return _repository.GetAllList()
               .FindAll(j => j.TenNcc.Contains(ncc) && j.NgayGhi >= begin && j.NgayGhi <= end);
       }

       public IEnumerable<string> TenHangs(int idcty)
       {
            return _repository.GetAllList().ToList().Select(j => j.TenHang).Distinct();
       }

       public IEnumerable<string> TenNccs(int idcty)
       {
            return _repository.GetAllList().ToList().Select(j => j.TenNcc).Distinct();
        }
   }
}
