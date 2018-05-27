using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Xn.Models
{
   public class DoanhThuTx:BaseEntity.BaseEntity
    {
       
        [Required]
        public string Code { get; set; }
        [Required]
        public string KeyUser { get; set; }
        public string NgayGhi { get; set; }
        public string Img { get; set; }
        public string Dvt { get; set; }// chuyen, ca,tan,m3
        public double DonGiaMua { get; set; }
        public double DongiaXuat { get; set; }
        public DateTime BatDau { get; set; }
        public DateTime KetThuc { get; set; }
        public string GhiChu { get; set; }
        public double Tile { get; set; }
        public double TienMat { get; set; }
        public string NhanVien { get; set; }
        public string Logfile { get; set; }
        public string TenNvghi { get; set; }
        public string IdUser { get; set; }
        public int IdCty { get; set; }
    }
}

