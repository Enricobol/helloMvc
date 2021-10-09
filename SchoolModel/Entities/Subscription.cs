using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolModel.Entities
{
    public class Subscription
    {
        public long Id { get; set; }
        public bool Paid { get; set; }
        public long StudentId { get; set; }
        public long CourseEditionId { get; set; }

        //PROPRIETA' DI TIPO ASSOCIAZIONE
        public Student Student { get; set; }
        public CourseEdition CourseEdition { get; set; }

    }
}
