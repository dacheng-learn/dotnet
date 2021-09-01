using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMigration.Models
{
    [Table("member")]
    public class Member
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        [Comment("名字")]
        public string Name { get; set; }
        
        public DateTime CreateTime { get; set; }
        
        public DateTime? UpdateTime { get; set; }
    }
}