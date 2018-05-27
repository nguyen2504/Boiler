using System;
using System.ComponentModel.DataAnnotations;

namespace Xn.Web.Models.NccEntity
{
    public class NccEntity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string TenNv { get; set; }
        public string KeyUser { get; set; }
        public string DienThoai { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DanhMucHang { get; set; }
        public string DiaChi { get; set; }
        public string NgayGhi { get; set; }
        public string Loai { get; set; }// Ncc Kh
        public int IdCty { get; set; }
        public string TenNcc { get; set; }
        public string MasoThue { get; set; }
        public bool IsActive { get; set; }
    }
}
