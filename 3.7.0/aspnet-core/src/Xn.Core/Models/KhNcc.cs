using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.Domain.Entities;
using BaseEntity;

namespace Xn.Models
{
   public class KhNcc:Entity<int>
    {
        [Required]
        public string Code { get; set; }
        public string TenNv { get; set; }
        [Required]
        public string KeyUser { get; set; }
        public string DienThoai { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DanhMucHang { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgayGhi { get; set; }
        public string Loai { get; set; }// Ncc Kh
        public int IdCty { get; set; }
        //public string MasoThue { get; set; }
    }
}
