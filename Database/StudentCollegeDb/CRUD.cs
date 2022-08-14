using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentCollegeDb
{
    public class CRUD
    {
        //Reading records from Student_Data Table in Student Database
        public static void ReadAllRecord()
        {
            using (SqlConnection sqlconnection = new SqlConnection("Server = DESKTOP-5IOLHIF\\SQLEXPRESS; Database = Student; Trusted_Connection = True;"))
            {
                sqlconnection.Open();
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = sqlconnection;
                        // cmd.CommandText = "SELECT * FROM StudentsData";
                        cmd.CommandText = "select College_Name, Name, Branch from StudentsData, College where StudentsData.College_Id = College.College_Id";
                        using (SqlDataReader SqlDataReader = cmd.ExecuteReader())
                        {
                            while(SqlDataReader.Read())
                            {
                                //Console.WriteLine(SqlDataReader[0])
                                Console.WriteLine(SqlDataReader[0] + " " + SqlDataReader[1] + " " + SqlDataReader[2]);
                                // Console.Write(SqlDataReader[1] );
                                // Console.WriteLine(SqlDataReader[2]);
                            }
                        }
                    }
                }
            }
        }
    }
}