using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Mission4.Models
{
    public class GradeCalcModel
    {
        [Required]
        [Range(0, 100, ErrorMessage = "Please enter valid number between 0 and 100")]
        public decimal Assignments { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Please enter valid number between 0 and 100")]
        public decimal groupProject { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Please enter valid number between 0 and 100")]
        public decimal Quizzes { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Please enter valid number between 0 and 100")]
        public decimal Midterm { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Please enter valid number between 0 and 100")]
        public decimal Final { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Please enter valid number between 0 and 100")]
        public decimal Intex { get; set; }
    }
}
