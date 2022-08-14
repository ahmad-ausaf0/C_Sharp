using System;
using System.Data.SqlClient;
using System.Data;

namespace SqlDataAdapExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConString = "Server=DESKTOP-5IOLHIF\\SQLEXPRESS;Database=Student; Trusted_Connection=True";
            using (SqlConnection sqlConnection = new SqlConnection(ConString))
            {
                
                //-------------------Inserting Data For StudentsData Table---------------------------------
                // SqlDataAdapter da = new SqlDataAdapter("INSERT INTO StudentsData VALUES (1, 'Rohan', 21, 'Comp Sci', 1)", sqlConnection);
                // SqlDataAdapter da = new SqlDataAdapter("INSERT INTO StudentsData VALUES (2, 'Vishal', 23, 'Electronics', 2)", sqlConnection);
                //  SqlDataAdapter da = new SqlDataAdapter("INSERT INTO StudentsData VALUES (3, 'Ankur', 24, 'Mech', 2)", sqlConnection);
                //  SqlDataAdapter da = new SqlDataAdapter("INSERT INTO StudentsData VALUES (4, 'Ravi', 22, 'Civil', 1)", sqlConnection);

                //-------------------Inserting Data For College Table-------------------------------------------
                // SqlDataAdapter da = new SqlDataAdapter("INSERT INTO College VALUES (1, 'DTU', 'New Delhi')", sqlConnection);
                // SqlDataAdapter da = new SqlDataAdapter("INSERT INTO College VALUES (2, 'IPU', 'New Delhi')", sqlConnection);

                //----------------------List all data of Table StudentsData-------------------------------------
                SqlDataAdapter da1 = new SqlDataAdapter("select * from StudentsData", sqlConnection);
                DataTable dt = new DataTable();
                da1.Fill(dt);
                Console.WriteLine("Using Data Table");
                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine(row["Student_Id"] +".  " + row["Name"] + "  " + row["Age"] + "  " + row["Branch"] + "  " + row["College_Id"]);

                    // Console.WriteLine(row["College_Id"] +".  " + row["College_Name"] + "  " + row["Location"]);

                    // Console.WriteLine(row["College_Name"] + "  " +row["Name"] +"  " + row["Branch"]);
                }
                Console.WriteLine("---------------");
                 
                //------------------------List all data of Table College----------------------------------------
                SqlDataAdapter da2 = new SqlDataAdapter("select * from College", sqlConnection);
                da2.Fill(dt);
                Console.WriteLine("Using Data Table");
                foreach (DataRow row in dt.Rows)
                {
                    // Console.WriteLine(row["Student_Id"] +".  " + row["Name"] + "  " + row["Age"] + "  " + row["Branch"] + "  " + row["College_Id"]);

                    Console.WriteLine(row["College_Name"] + "  " + row["Location"]);

                    // Console.WriteLine(row["College_Name"] + "  " +row["Name"] +"  " + row["Branch"]);
                }
                Console.WriteLine("---------------");

                //----------------List all data where StudentsData.College_Id = College.College_Id -------------
                // SqlDataAdapter da = new SqlDataAdapter("select College_Name, Name, Branch from StudentsData, College where StudentsData.College_Id = College.College_Id;", sqlConnection);
                
                //Using Data Table
                

                
            }
        }
    }
}
