using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmployeeScheduler.Models
{
    public class Shifts
    {
        public int ShiftsID { get; set; }

        [Required]
        [Range(0, 23)]
        public int StartingHour { get; set; }

        [Required]
        [Range(0, 23)]
        public int EndingHour { get; set; }
        public int UserLogonId { get; set; }
        public UserLogon User { get; set;}
        public int DaysId { get; set; }
        public Days Days { get; set; }
        
       
        
    }
}
