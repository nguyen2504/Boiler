using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Xn.Web.Models
{
    public class NhapHangEntity
    {
        public long Id { get; set; }
        public string TenNcc { get; set; }
        public int IdNcc { get; set; }
        public string TenHang { get; set; }
        public string MaVt { get; set; }
        public int SoLuong { get; set; }
        public double DonGiaMua { get; set; }
        public string Dvt { get; set; }
        public string NgayGhi { get; set; }
        public int IdCty { get; set; }
        public string MaDonHang { get; set; }
        public bool IsActive { get; set; }
        public int IdNv { get; set; }
        public string TenNv { get; set; }
    }
}
