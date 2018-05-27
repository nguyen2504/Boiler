using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BaseEntity
{
   public class BaseXnt
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        public string TenNv { get; set; }
        [Required]
        public string KeyUser { get; set; }
    }
}
