using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Xn.Models
{
  public  class DoiTac:BaseEntity.BaseEntity
    {
        [Required]
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        public int IdCty { get; set; }
    }
}
