using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission2_Higbee.Models
{
    public class GradeCalculator
    {
        [Required]
        public byte Assignments { get; set; }
        [Required]
        public byte Group { get; set; }
        [Required]
        public byte Quizzes { get; set; }
        [Required]
        public byte Exams { get; set; }
        [Required]
        public byte Intex { get; set; }
    }
}
