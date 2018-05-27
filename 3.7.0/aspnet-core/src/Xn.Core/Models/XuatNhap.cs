using System;
using System.Collections.Generic;
using System.Text;
using BaseEntity;

namespace Xn.Models
{
   public class XuatNhap:BaseXnt
    {
        public DateTime NgayghiSo { get; set; }
        public DateTime NgayChungTu { get; set; }
        public string SoChungTu { get; set; }
        public string Tenhang { get; set; }
        public string MaVt { get; set; }
        public string Loai { get; set; }// xuat, nhap
        public string KhNcc { get; set; }//
        public string KhLeCty { get; set; }// khach hang le hay cty
        public int SoLuong { get; set; }
        public double DonGiaNhap { get; set; }
        public double DonGiaXuat { get; set; }
        public string Dvt { get; set; }
        public string TenKhNcc { get; set; }
        public string IdKhNcc { get; set; }
        public string MaDonHang { get; set; }
        public string GhiChu { get; set; }
        public int IdCty { get; set; }
    }
}
