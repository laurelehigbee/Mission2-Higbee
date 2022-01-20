using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission3_Higbee.Models
{
    public class GradeCalculator //contains information for the grade calculator responses
    {
        [Required] //establishes the variable as required
        [Range(0, 100)]  //establishes that the variable must be between 0 and 100
        public byte Assignments { get; set; } //assignments response type and get/set
        [Required]
        [Range(0, 100)] 
        public byte Group { get; set; } //assignments response type and get/set
        [Required]
        [Range(0, 100)]  
        public byte Quizzes { get; set; } //assignments response type and get/set
        [Required]
        [Range(0, 100)]  
        public byte Exams { get; set; } //assignments response type and get/set
        [Required]
        [Range(0, 100)]  
        public byte Intex { get; set; }//assignments response type and get/set
    }
}
