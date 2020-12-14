using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewMidtermRedo.Models
{
    public class Student
    {
        [Required]
        public int Id { get; set; }
       [Required]
       [StringLength (25)]
        public string FirstName { get; set; }
        [StringLength (35)]
        public string LastName { get; set; }
        [Required]
        public int CourseId { get; set; }
        [Required]
        public DateTime CourseEnrolledDate { get; set; }
        [Required]
        public int CourseStatus { get; set; }
        [Required]
        [StringLength(2)]
        public string Grade { get; set; }
        [Required]
        [Range(18,200)]
        public int StudentAge { get; set; }

    }
}