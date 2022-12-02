using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModuleCalculatorWeb.Models
{
    public class Module
    {
        //Variables of the Class
        [Key]
        public int moduleID { get; set; }
        public string ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public int Credits { get; set; }
        public int HoursPerWeek { get; set; }
        public int SelfStudy { get; set; }
        public int Weeks_in_Semester { get; set; }
        public int HoursStudyFor { get; set; }
        public System.DateTime StudyDate { get; set; }
        public int ReaminingHoursLeft { get; set; }

    }
}
