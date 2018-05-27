using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Xn.Models
{
  public  class ChiPhiTx
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string KeyUser { get; set; }
        [Required]
        public string NgayGhi { get; set; }
        public string TenCp { get; set; }
        public double Sotien { get; set; }
        public string GhiChu { get; set; }
        public string NoiDung { get; set; }
        public string Logfile { get; set; }
        public string TenNvghi { get; set; }
        public string IdUser { get; set; }
        public int IdCty { get; set; }
    }
}
