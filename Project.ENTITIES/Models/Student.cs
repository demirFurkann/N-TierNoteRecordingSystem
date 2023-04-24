using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Student:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Number { get; set; }
        public int Test1 { get; set; }
        public int Test2 { get; set; }
        public int Test3 { get; set; }
        public bool Case { get; set; }

        public int Average { get; set; }

        public int? AppUserID { get; set; }

        //Relational Properties



        public virtual AppUser AppUser { get; set; }

    


    }
}
