using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        public object Picture { get; set; }

        [Required]
        public string Intro { get; set; }

        [Required]
        public IEnumerable<SocialMedia> SocialMedia { get; set; }
    }
}
