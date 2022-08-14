using System;
using DbEntityFramework.Model;

namespace DbEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //CREATE OBJECT
            var dbContext = new StudentContext();

             //INSERT 2 RECORD in Student
            dbContext.StudentData.Add(new StudentData { Id = 3 , Name = "Ankur", Dept = "Mech" });
            dbContext.StudentData.Add(new StudentData { Id = 4, Name = "Varun", Dept = "Civil" });

            //SAVING these record in DATABASE
            dbContext.SaveChanges();

            //READ STUDENT RECROD
            foreach (var item in dbContext.StudentData)
            {
                Console.Write(" " + item.Id);
                Console.Write(item.Name + " ");
                Console.Write(item.Dept);
            }
        }
    }
}
