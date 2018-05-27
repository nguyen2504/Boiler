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
    public class NccService : DomainService, INccService
    {
        private readonly IRepository<Ncc> _repository;

        public NccService(IRepository<Ncc> repository)
        {
            _repository = repository;
        }
        public Task<Ncc> Create(Ncc entity)
        {
            return _repository.InsertAsync(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<Ncc> GetAll(string code)
        {
            return _repository.GetAll().Where(j => j.Code.Equals(code)).ToList();
        }

        public IEnumerable<Ncc> GetAllbtIdCty(int idcty)
        {
            return _repository.GetAll().Where(j => j.IdCty.Equals(idcty)).OrderByDescending(j=>j.Id).ToList();
        }

        public Ncc GetFist(string code)
        {
           return _repository.FirstOrDefault(j => j.Code.Equals(code));
        }

        public Task<Ncc> GetById(long? id)
        {
            return _repository.FirstOrDefaultAsync(x=>x.Id==id);
        }

        public void Update(Ncc entity)
        {
            _repository.UpdateAsync(entity);
        }
    }
}
