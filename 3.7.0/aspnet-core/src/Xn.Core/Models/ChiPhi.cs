using System;
using System.Collections.Generic;
using System.Text;
using BaseEntity;

namespace Xn.Models
{
   public class ChiPhi:BaseXnt
    {
        public string TenCp { get; set; }
        public double SoTien { get; set; }
        public DateTime NgayGhi { get; set; }
        public string TenNvGhi { get; set; }
        public string GhiChu { get; set; }
        public string NoiDung { get; set; }
        public int IdCty { get; set; }
    }
}
