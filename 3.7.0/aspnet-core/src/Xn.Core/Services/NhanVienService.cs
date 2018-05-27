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
  public  class NhanVienService:DomainService,INhanVienService
  {
      private readonly IRepository<NhanVien> _repository;

      public NhanVienService(IRepository<NhanVien> repository)
      {
          _repository = repository;
      }
        public IEnumerable<NhanVien> GetAllNv(string code)
        {
            return _repository.GetAll().ToList().Where(j=>j.Code.Equals(code));
        }

        public NhanVien GetById(int id, string code)
        {
            throw new NotImplementedException();
        }

        public Task<NhanVien> Create(NhanVien entity)
        {
            throw new NotImplementedException();
        }

        public void Update(NhanVien entity)
        {
            throw new NotImplementedException();
        }

        public void Detele(int id)
        {
            throw new NotImplementedException();
        }
    }
}
