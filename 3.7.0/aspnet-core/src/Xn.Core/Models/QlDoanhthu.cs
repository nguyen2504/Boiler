using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Xn.Models
{
   public class QlDoanhthu:BaseEntity.BaseEntity
    {
 
        public string Code { get; set; }
        public string Ten { get; set; }
        public double GopVon { get; set; }
        public double ChietKhau { get; set; }
        [Required]
        public DateTime NgayGop { get; set; }
        public string Loai { get; set; }
        public double LoiNhuan { get; set; }
        public bool IsChiPhi { get; set; }
        public string TenNvGhi { get; set; }
        [Required]
        public string KeyUser { get; set; }
        public int IdCty { get; set; }

    }
}
