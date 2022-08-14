using EFCoreExample.Model;
using System;

namespace EFCoreExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //CREATE OBJECT
            var dbContext = new DBExamplesContext();

            //INSERT 2 RECORD in COURSE
            dbContext.Course.Add(new Course { Course1 = "Mechanical" });
            dbContext.Course.Add(new Course { Course1 = "IT" });

            //INSERT 2 RECORD in Student
            dbContext.Student.Add(new Student { Branch="MECH", Name="ANKUR", CourseId=1 });
            dbContext.Student.Add(new Student { Branch = "MECH", Name = "WAJAHAT", CourseId = 2 });

            //SAVING these record in DATABASE
            dbContext.SaveChanges();


            //READ STUDENT RECROD
            foreach (var item in dbContext.Student)
            {
                Console.Write(item.Id);
                Console.Write(item.Name);
                Console.Write(item.CourseId);
                Console.WriteLine(item.Branch);
            }

        }
    }
}
