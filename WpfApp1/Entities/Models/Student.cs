using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WpfApp1.Entities.Models;

namespace WpfApp1
{
    public class Student
    {
        [Required]
        public int StudentId { get; set; }
        [Required]
        [MaxLength(10)]
        [MinLength(10)]
        public int NationalCode { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public  ICollection<StudentCourse> StudentCourse { get; set; }
        public float CalcAvg()
        {
            return 0;
        }
    }
}
