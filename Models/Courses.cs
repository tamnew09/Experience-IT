using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MidtermVersion.Models;
using System.ComponentModel.DataAnnotations;

namespace MidtermVersion.Models
{
    public class Courses
    {
        [Required]
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string TutorName { get; set; }
        [Required]
        [Range(1, 10)]
        public int CourseRating { get; set; }
    }
}