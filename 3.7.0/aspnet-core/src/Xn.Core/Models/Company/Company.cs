using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Abp.Domain.Entities.Auditing;
using Xn.Authorization.Users;

namespace Xn.Models.Company
{
  public  class Company:FullAuditedEntity
    {
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
        [Display(Name = "Ngày Thành Lập")]
        [DataType(DataType.Date)]
       public  DateTime StartFounding { get; set; }
        [Required]
        public string IdScurity { get; set; }
        public int IdCty { get; set; }
        //public ICollection<User> Users { get; set; }
    }
}
