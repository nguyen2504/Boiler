using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Services;
using Xn.Models;

namespace Xn.Services
{
  public  interface INhanVienService:IDomainService
  {
      IEnumerable<NhanVien> GetAllNv(string code);
      NhanVien GetById(int id, string code);
      Task<NhanVien> Create(NhanVien entity);
      void Update(NhanVien entity);
      void Detele(int id);
  }
}
