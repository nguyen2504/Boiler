using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Xn.Company.Dto
{
   public class CompanyDto
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Tên Công Ty")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Mã Số Thuế")]
        public string Code { get; set; }
        [Required]
        [Display(Name = "Địa chỉ công ty")]
        public string Address { get; set; }
        [Display(Name = "Số Điện Thoại")]
        public string Phone { get; set; }
        public string Fax { get; set; }
        public DateTime StartFounding { get; set; }
    }
}
