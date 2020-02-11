using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tutorial.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public DepEnum Department { get; set; }

        public string PhotoPatch { get; set; }


    }
}
