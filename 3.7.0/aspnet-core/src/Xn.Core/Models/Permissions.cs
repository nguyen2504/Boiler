using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.Domain.Entities;
using BaseEntity;

namespace Xn.Models
{
   public class Permissions:Entity<int>
    {
        [Required]
        public string KeyUser { get; set; }
        public string Gender { get; set; }//loại 0 1 2 3 4
        public bool InOut { get; set; }
        public bool Report { get; set; }
        public bool CreUpDe { get; set; }
        public bool View1 { get; set; }
        public bool View2 { get; set; }
        public bool View3 { get; set; }
       
        public string Code { get; set; }
        public string NvGhi { get; set; }
        public DateTime NgayGhi { get; set; }
        public int IdCty { get; set; }
    }
}
