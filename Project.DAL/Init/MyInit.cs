using Project.DAL.Context;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Init
{
    public class MyInit:CreateDatabaseIfNotExists<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            #region Öğretmen
            AppUser au = new AppUser();
            au.UserName = "irfan";
            au.Password = "4321";
            au.Role = ENTITIES.Enums.UserRole.Teacher;
            context.AppUsers.Add(au);
            context.SaveChanges();
            #endregion



            #region Öğrenci

            Student  s = new Student();
            s.Number = "1234";
            s.FirstName = "Furkan";
            s.LastName = "Demir";
            context.Students.Add(s);
            context.SaveChanges();

            #endregion


        }
    }
}
