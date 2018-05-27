using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;
using BaseEntity;

namespace Xn.Models
{
  public  class Ncc: KhNcc
    {
        public string TenNcc { get; set; }
        public string MasoThue { get; set; }
        public bool IsActive { get; set; }
    }
}
