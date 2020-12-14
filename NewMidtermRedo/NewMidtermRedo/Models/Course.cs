using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewMidtermRedo.Models
{
    public class Course
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        [StringLength (75)]

        public string CourseName { get; set; }

        [Required]
        [StringLength(200)]
        public string CourseDescription { get; set; }

        [Required]
        [StringLength(30)]
        public string TutorName { get; set; }

        [Required]
        [Range(1,10)]
        public int CourseRating { get; set; }
    }
}