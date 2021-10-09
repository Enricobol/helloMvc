using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolModel.Entities
{
    public class Course
    {
        //PROPRIETA'
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int TotalHours { get; set; }
        public decimal Price { get; set; }

        //PROPRIETA' DI TIPO CONTENITORE dotnet ef 
        public virtual List<CourseEdition> CourseEditions { get; set; } = new List<CourseEdition>(); //Un corso può avere più edizioni corso
    }
}
