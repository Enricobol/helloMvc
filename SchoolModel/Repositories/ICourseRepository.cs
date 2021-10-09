using SchoolModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolModel.Repositories
{
    public interface ICourseRepository : ICrudRepository<Course, long>
    {
    }
}
