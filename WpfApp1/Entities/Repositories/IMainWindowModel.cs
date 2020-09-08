using System;
using System.Collections.Generic;
using System.Text;
using WpfApp1.Entities.Models;

namespace WpfApp1
{
    public interface IMainWindowModel
    {
        public List<Student> GetStudentData();
        public List<Course> GetCourseData();
        public Student AddStudent(Student st);
        public Course AddCourse(Course st);

        public Student EditStudent(Student st);
        public Course EditCourse(Course st);
        public Student DeleteStudent(Student st);
        public Course DeleteCourse(Course st);

        public StudentCourse AddStudentsCourse(int StudentId, int CourseId);


        public void Save();



    }
}
