using System;
using System.ComponentModel.DataAnnotations;

namespace BaseEntity
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
