using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModuleCalculatorWeb.Models
{
    public class Semester
    {
        //Variables of the Class
        [Key]
        public int SemId { get; set; }
        public string semesterName { get; set; }
        public System.DateTime startDate { get; set; }
        public int Weeks { get; set; }
    }
}
