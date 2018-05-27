using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Xn.Models
{
   public class CongNo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string KeyUser { get; set; }
        public string Mahang { get; set; }
        public string TenKhNcc { get; set; }
        public string Loai { get; set; }
        public double PhaiTra { get; set; }
        public double PhaiThu { get; set; }
        [Required]
        public DateTime NgayGhi { get; set; }
        public string TenNvGhi { get; set; }
        public int IdUserNvghi { get; set; }
        public string TenNvThuHoi { get; set; }
        public int IdUserNvThuHoi { get; set; }
        public int IdkhNcc { get; set; }
        public string GhiChu { get; set; }
        public int IdCty { get; set; }
    }
}
