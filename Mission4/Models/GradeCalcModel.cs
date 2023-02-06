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
        [MaxLength(100)]
        [MinLength(0)]
        public decimal Assignments { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(0)]
        public decimal groupProject { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(0)]
        public decimal Quizzes { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(0)]
        public decimal Midterm { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(0)]
        public decimal Final { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(0)]
        public decimal Intex { get; set; }
    }
}
