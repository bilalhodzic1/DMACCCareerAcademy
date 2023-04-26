using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeScheduler.Models
{
    public class Days
    {
        public int DaysId { get; set; }

        [StringLength(10)]
        [Required]
        public string Name { get; set; }
    }
}
