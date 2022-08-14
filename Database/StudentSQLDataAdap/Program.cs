using System;
// using StudentSQLDataAdap.Model;
using System.Data.SqlClient;
using System.Data;
//using System.Windows.Forms;

namespace StudentSQLDataAdap
{
    class Program
    {
        static void Main(string[] args)
        {
             string ConString = "Server=DESKTOP-5IOLHIF\\SQLEXPRESS;Database=Student; Trusted_Connection=True";
            using (SqlConnection sqlConnection = new SqlConnection(ConString))
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from StudentsData", sqlConnection);
                
                //----------------------List all data of Table StudentsData Using DataSet-----------------------
                DataSet ds = new DataSet();
                da.Fill(ds, "StudentsData");                   
                Console.WriteLine("Using Data Set");
                foreach (DataRow row in ds.Tables["StudentsData"].Rows)
                {
                    Console.WriteLine(row["Student_Id"] +".  " + row["Name"] + "  " + row["Age"] + "  " + row["Branch"] + "  " + row["College_Id"]);
                }   

                //---------------------------List all data of Table College Using DataSet-----------------------
                SqlDataAdapter da1 = new SqlDataAdapter("select * from College", sqlConnection);
                da1.Fill(ds, "College");                   
                Console.WriteLine("Using Data Set");
                foreach (DataRow row in ds.Tables["College"].Rows)
                {
                    Console.WriteLine(row["College_Id"] +".  " + row["College_Name"] + "  " + row["Location"]);
                }

            }
        }
    }
}
