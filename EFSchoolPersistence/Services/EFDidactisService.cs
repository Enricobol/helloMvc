using EFSchoolPersistence.EF;
using SchoolModel.Entities;
using SchoolModel.Repositories;
using SchoolModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSchoolPersistence.Services
{
    public class EFDidactisService : IDidactisService
    {
        private IStudentRepository studentRepo;
        private ICourseRepository courseRepo;
        private SchoolContext ctx;
        public EFDidactisService(IStudentRepository studentRepo, ICourseRepository courseRepo, SchoolContext ctx) 
        {
            this.studentRepo = studentRepo;
            this.courseRepo = courseRepo;
            this.ctx = ctx;
        }

        #region METODI STUDENTI
        public Student CreateStudent(Student s)
        {
            studentRepo.Create(s);
            ctx.SaveChanges(); //Salviamo qui invece che nella repository
            return s;
        }
        public IEnumerable<Student> GetAllStudents()
        {
            return studentRepo.GetAll();
        }

        public IEnumerable<Student> GetStudentsByLastnameLike(string lastnameLike)
        {
            return studentRepo.FindByLastnameLike(lastnameLike).ToList(); //Non più una query, ma una lista vera e propria grazie a .ToList
        }
        public Student GetStudentById(long id) 
        {
            return studentRepo.FindById(id);
        }

        public void DeleteStudentById(long id)
        {
            studentRepo.Delete(id);
            ctx.SaveChanges(); //Salviamo qui invece che nella repository
        }

        public void UpdateStudent(Student s)
        {
            studentRepo.Update(s);
            ctx.SaveChanges(); //Salviamo qui invece che nella repository
        }

        #endregion

        #region METODI CORSI
        public Course CreateCourse(Course s)
        {
            courseRepo.Create(s);
            ctx.SaveChanges(); //Salviamo qui invece che nella repository
            return s;
        }
        public IEnumerable<Course> GetAllCourses()
        {
            return courseRepo.GetAll();
        }

        public Course GetCourseById(long id)
        {
            return courseRepo.FindById(id);
        }

        public void DeleteCourseById(long id)
        {
            courseRepo.Delete(id);
            ctx.SaveChanges(); //Salviamo qui invece che nella repository
        }

        public void UpdateCourse(Course s)
        {
            courseRepo.Update(s);
            ctx.SaveChanges(); //Salviamo qui invece che nella repository
        }

        #endregion

    }
}
