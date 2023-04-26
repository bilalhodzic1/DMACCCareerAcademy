using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmployeeScheduler.Models
{
    public class UserLogon
    {
        public int UserLogonId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public ICollection<Shifts> Shifts { get; set; }
        public string Fullname => $"{FirstName} {LastName}";
    }
}
