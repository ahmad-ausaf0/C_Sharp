using System;
//using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using DbRecord;

internal class SQLDatabase
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
                        cmd.CommandText = "SELECT * FROM Student_Data";
                        using (SqlDataReader SqlDataReader = cmd.ExecuteReader())
                        {
                            while(SqlDataReader.Read())
                            {
                                Console.WriteLine(SqlDataReader[0] + " " + SqlDataReader[1] + " " + SqlDataReader[2]);
                                // Console.Write(SqlDataReader[1] );
                                // Console.WriteLine(SqlDataReader[2]);
                            }
                        }
                    }
                }
            }
        }

        //Adding a record from Student_Data Table in Student Database
        public static void AddRecord()
        {
            using (SqlConnection sqlconnection = new SqlConnection("Server = DESKTOP-5IOLHIF\\SQLEXPRESS; Database = Student; Trusted_Connection = True;"))
            {
                sqlconnection.Open();
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = sqlconnection;
                        cmd.CommandText = "INSERT into Student_Data values(3,'Rohit2','BCA')";
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        //Updating a record from Student_Data Table in Student Database
        public static void UpdateRecord()
        {
            using (SqlConnection sqlconnection = new SqlConnection("Server = DESKTOP-5IOLHIF\\SQLEXPRESS; Database = Student; Trusted_Connection = True;"))
            {
                sqlconnection.Open();
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = sqlconnection;
                        cmd.CommandText = "UPDATE Student_Data SET Name = 'Rahul', Dept = 'Mech' WHERE ID = 3";  
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        //Deleting a record from Student_Data Table in Student Database
        public static void DeleteRecord()
        {
            using (SqlConnection sqlconnection = new SqlConnection("Server = DESKTOP-5IOLHIF\\SQLEXPRESS; Database = Student; Trusted_Connection = True;"))
            {
                sqlconnection.Open();
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = sqlconnection;
                        cmd.CommandText = "DELETE from Student_Data where ID = 3"; 
                        cmd.ExecuteNonQuery(); 

                    }
                }
            }
        }
    }


    // dotnet ef dbcontext scaffold "Server=DESKTOP-5IOLHIF\SQLEXPRESS;Database=Student;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o Model

    //dotnet EF dbcontext

    //dotnet EF Scaffold-DbContext

    //dotnet ef dbcontext scaffold