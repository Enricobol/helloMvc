using SchoolModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolModel.Services
{
    public interface IDidactisService
    {
        #region STUDENTI
        IEnumerable<Student> GetAllStudents();
        IEnumerable<Student> GetStudentsByLastnameLike(string lastnameLike);
        Student CreateStudent(Student s);
        Student GetStudentById(long id);
        void DeleteStudentById(long id);
        void UpdateStudent(Student s);
        #endregion

        #region CORSI
        IEnumerable<Course> GetAllCourses();
        Course CreateCourse(Course s);
        Course GetCourseById(long id);
        void DeleteCourseById(long id);
        void UpdateCourse(Course s);
        #endregion



    }

}
