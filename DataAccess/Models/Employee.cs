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
        public string Picture { get; set; }

        [Required]
        [MaxLength(666)]
        public string Intro { get; set; }

        [Required]
        public int SocialMediaID { get; set; }
    }
}
