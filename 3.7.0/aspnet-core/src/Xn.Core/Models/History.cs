using System;
using System.Collections.Generic;
using System.Text;

namespace Xn.Models
{
  public  class History
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string KeyUser { get; set; }
        public string NgayGhi { get; set; }
        public string GhiChu { get; set; }
        public string NoiDung { get; set; }
        public int IdCty { get; set; }
    }
}
