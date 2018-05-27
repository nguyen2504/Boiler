using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Xn.Models
{
   public class Qlnv:BaseEntity.BaseEntity
    {
        [Required]
        public string Ten { get; set; }
        public double LuongCb { get; set; }
        public double ChietKhau { get; set; }
        public double ChienKhau1 { get; set; }
        [Required]
        public string Loai { get; set; }// ngay thang nam
        public double Thuong { get; set; }
        public double Phat { get; set; }
        public double Khac { get; set; }
        public string GhiChu { get; set; }
        [Required]
        public DateTime NgayGhi { get; set; }
        public string KeyUser { get; set; }
        public string Code { get; set; }
        public string TenNvGhi { get; set; }
        public int IdCty { get; set; }

    }
}
