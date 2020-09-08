using Microsoft.EntityFrameworkCore;
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
            _context.Courses.Add(st);
            
            _context.SaveChanges();
            return st;
        }

        public Student AddStudent(Student st)
        {

            _context.Students.Add(st);
          
            _context.SaveChanges();

          
            return st;
        }

        public StudentCourse AddStudentsCourse(int uniId, int CourseId)
        {
            Student st = _context.Students.Where(b => b.UniId == uniId)
                    .FirstOrDefault();

            var stc = new StudentCourse() { StudentId = st.StudentId, CourseId = CourseId };

            _context.StudentCourses.Add(stc);
            return stc;
        }

        public Course DeleteCourse(Course st)
        {
            _context.Courses.Add(st);
            _context.SaveChanges();
            return st;
        }

        public Student DeleteStudent(Student st)
        {
            //throw new NotImplementedException();
            Console.WriteLine("NotImplemented");
            return st;
        }

        public Course EditCourse(Course st)
        {
            //throw new NotImplementedException();
            Console.WriteLine("NotImplemented");
            return st;
        }

        public Student EditStudent(Student st)
        {
            // throw new NotImplementedException();
            Console.WriteLine("NotImplemented");
            return st;
        }

        public List<Course> GetCourseData()
        {
           return  _context.Courses.ToList();
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
