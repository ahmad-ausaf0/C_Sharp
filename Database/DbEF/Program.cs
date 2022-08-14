using System;
using DbEF.Models;

namespace DbEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

             //CREATE OBJECT
            var dbContext = new StudentContext();

            //  //INSERT 2 RECORD in Student
            // dbContext.StudentData.Add(new StudentData { Id = 3 , Name = "Ankur", Dept = "Mech" });
            // dbContext.StudentData.Add(new StudentData { Id = 4, Name = "Varun", Dept = "Civil" });

            //dbContext.StudentData.Delete(new StudentData { Id = 4, Name = "Varun", Dept = "Civil" });
            //SAVING these record in DATABASE
            // dbContext.SaveChanges();

            //Update record
            // var dept = new StudentData()
            // {
            //     Id = 1,
            //     Name = "Ankush",
            //     Dept = "Designing"
            // };
            // dbContext.Update(dept);
            // dbContext.SaveChanges();

            // Delete a record
            // var Record4 = new StudentData() 
            // {
            //     Id = 4
            // };
            // dbContext.Remove(Record4);
            // dbContext.SaveChanges();

            //READ STUDENT RECROD
            foreach (var item in dbContext.StudentData)
            {
                Console.Write(item.Id + " ");
                Console.Write(item.Name + " ");
                Console.Write(item.Dept);
                Console.WriteLine();
            }
        }
    }
}
