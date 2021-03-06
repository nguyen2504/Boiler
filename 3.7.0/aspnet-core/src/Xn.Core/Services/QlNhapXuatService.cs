﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Xn.Models;

namespace Xn.Services
{
   public class QlNhapXuatService:DomainService,IQlNhapXuatService
    {
       private IRepository<QlXuatNhap> _repository;

        public QlNhapXuatService(IRepository<QlXuatNhap> repository)
        {
            _repository = repository;
        }
        public IEnumerable<QlXuatNhap> GetAll(int idcty)
        {
            return _repository.GetAllList(j=>j.IdCty==idcty).OrderByDescending(j=>j.Id);
        }

        public IEnumerable<QlXuatNhap> GetAllList()
        {
            return _repository.GetAllList();
        }

        public IEnumerable<QlXuatNhap> GetAllListGetIdcty_madh(int idcty, string madh)
        {
            var l = _repository.GetAllList().FindAll(j => j.MaDonHang.Equals(madh) && j.IdCty.Equals(idcty));
            return l;
        }

        public  QlXuatNhap GetById(int id)
        {
            return _repository.FirstOrDefault(j => j.Id.Equals(id));
        }

        public void Create(QlXuatNhap entity)
        {
            _repository.Insert(entity);
        }

        public void Update(QlXuatNhap entity)
        {
            _repository.Update(entity);
        }

        public void Delete(int id)
        {
           _repository.Delete(id);
        }

        public void DeleteIsActive(QlXuatNhap entity)
        {
            entity.IsActive = false;
            _repository.Update(entity);
        }

        public QlXuatNhap GetNhap(int idcty, string madh)
        {
            var l = _repository.GetAllList().Find(j => j.MaDonHang.Equals(madh) && j.IdCty.Equals(idcty));
            return l;
        }

       
    }
}
