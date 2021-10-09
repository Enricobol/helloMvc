using EFSchoolPersistence.EF;
using SchoolModel.Entities;
using SchoolModel.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSchoolPersistence.Repository
{
    public class EFCourseRepository : EFCrudRepository<Course, long>, ICourseRepository
    {
        public EFCourseRepository(SchoolContext ctx) : base(ctx)
        {

        }
    }
}
