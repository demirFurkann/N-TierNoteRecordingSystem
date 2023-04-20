using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class StudentExam:BaseEntity
    {
        public int ExamID { get; set; }
        public int StudentID { get; set; }


        //Relational Properties

        public virtual Exam Exam { get; set; }

        public virtual Student Student { get; set; }
    }
}
