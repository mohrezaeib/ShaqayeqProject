using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WpfApp1.Entities.Models
{
    public class Course
    {
       
        [Required]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public  ICollection<StudentCourse> StudentCourse { get; set; }
    }
}
