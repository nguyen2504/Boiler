using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.Domain.Entities;
using BaseEntity;

namespace Xn.Models
{
   public class QlCongNoChiTiet:Entity<int>
    {
        [Required]
        public string TenKhNcc { get; set; }
        public DateTime NgayGhi { get; set; }
        public string MaSoPhieu { get; set; }
        public string NoiDung { get; set; }
        public double PhaiTra { get; set; }
        public double PhaiThu { get; set; }
        public double ConLai { get; set; }
        [Required]
        public string GhiChu { get; set; }
        public string TenNvghi { get; set; }
        public int IdNvGhi { get; set; }
        public int IdCty { get; set; }
    }
}
