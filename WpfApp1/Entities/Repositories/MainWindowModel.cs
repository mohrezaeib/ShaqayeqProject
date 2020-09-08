using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WpfApp1.Entities.Models;

namespace WpfApp1
{
    public class MainWindowModel:IMainWindowModel
    {
        private List<Student> students;
        private SchoolContext _context;
        public MainWindowModel(SchoolContext context) 
        {
            _context = context;
        }

        public Course AddCourse(Course st)
        {
            throw new NotImplementedException();
        }

        public Student AddStudent(Student st)
        {
            throw new NotImplementedException();
        }

        public StudentCourse AddStudentsCourse(int StudentId, int CourseId)
        {
            throw new NotImplementedException();
        }

        public Course DeleteCourse(Course st)
        {
            throw new NotImplementedException();
        }

        public Student DeleteStudent(Student st)
        {
            throw new NotImplementedException();
        }

        public Course EditCourse(Course st)
        {
            throw new NotImplementedException();
        }

        public Student EditStudent(Student st)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetCourseData()
        {
            throw new NotImplementedException();
        }



        public List<Student> GetStudentData()
        {
            students = _context.Students.ToList();
            return students;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
