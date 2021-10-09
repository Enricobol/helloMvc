using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolModel.Entities
{
    public class CourseEdition
    {
        public long Id { get; set; }
        public decimal FinalPrice { get; set; }
        public int MinNumStudents { get; set; }
        public int MaxNumStudents { get; set; }

        //PROPRIETA' DI TIPO ASSOCIAZIONE
        public long CourseId { get; set; }
        public Course Course { get; set; }

        //PROPRIETA' DI TIPO CONTENITORE
        public virtual List<Subscription> Subscriptions { get; set; } = new List<Subscription>();
    }
}
