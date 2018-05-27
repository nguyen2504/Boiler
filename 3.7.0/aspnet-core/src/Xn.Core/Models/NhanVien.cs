using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.Domain.Entities;

namespace Xn.Models
{
   public class NhanVien:Entity<int>
   {
       //[Key]
       // public  int Id { get; set; }
        [Required]
        public string Ten { get; set; }
        public string NgaySinh { get; set; }
        public string DienThoai { get; set; }
        public string ChucVu { get; set; }
        [Required]
        public string KeyUser { get; set; }
        [Required]
        public string Code { get; set; }
        public string NgayGhi { get; set; }
        public bool IsActive { get; set; }
        public string SecurityStamp { get; set; }
       public int IdCty { get; set; }
    }
}
