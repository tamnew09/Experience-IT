using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MidtermVersion.Models
{
    public class Students
    {
        [Required]
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int CourseId { get; set; }
        public DateTime CourseEnrolledDate { get; set; }
        public int CourseStatus { get; set; }
        [Required]
        [Range(1,10)]
        public string Grade { get; set; }
    }
}