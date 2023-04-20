using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Exam:BaseEntity
    {
        public double Test1 { get; set; }
        public double Test2 { get; set; }
        public double Test3 { get; set; }

        public double Avarege => (Test1 + Test2 + Test3) / 3;




        //Relational Properties

        public virtual List<StudentExam> StudentExams { get; set; }
    }
}
