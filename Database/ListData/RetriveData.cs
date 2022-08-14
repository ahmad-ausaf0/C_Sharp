using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ListData
{
    public class RetriveData
    {
        public static void College_1() {

            using(SqlConnection connection = new SqlConnection("Server = DESKTOP-5IOLHIF\\SQLEXPRESS; Database = Student; Trusted_Connection = True;"))
            {
                connection.Open();

                // Selecting College
                string query1 = "select College_Name from College where College.College_Id = 1";
                using(SqlCommand command1 = new SqlCommand(query1, connection))
                {
                    using (SqlDataReader reader1 = command1.ExecuteReader())
                    {
                        while (reader1.Read())
                        {
                            
                            Console.WriteLine(reader1[0]);
                        }      
                    }
                }


                //Selecting students from that college in a list
                List<String> columnData = new List<String>();
                string query = "select Name, Branch from StudentsData where StudentsData.College_Id = 1";
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            columnData.Add(reader.GetString(0));
                            columnData.Add(reader.GetString(1));
                            //Console.WriteLine(reader[0]);
                        }  
                        // foreach(var i in columnData)
                        // {
                        //     Console.WriteLine(", ", columnData[i]);
                        // }
                        //Console.Write(string.Join(System.Environment.NewLine, columnData));
                        Console.WriteLine(string.Join(", ", columnData));
                        //Console.WriteLine(string.Join(", ", columnData[1]));        
                    }
                }
            }
        
        }
        
        public static void College_2() {
            
            using(SqlConnection connection = new SqlConnection("Server = DESKTOP-5IOLHIF\\SQLEXPRESS; Database = Student; Trusted_Connection = True;"))
            {
                connection.Open();
            
                // Selecting College
                    string query1 = "select College_Name from College where College.College_Id = 2";
                    using(SqlCommand command1 = new SqlCommand(query1, connection))
                    {
                        using (SqlDataReader reader1 = command1.ExecuteReader())
                        {
                            while (reader1.Read())
                            {
                                
                                Console.WriteLine(reader1[0]);
                            }      
                        }
                    }

                //Selecting students from that college in a list    
                var columnData = new List<String>();
                string query = "select Name, Branch from StudentsData where StudentsData.College_Id = 2";
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            columnData.Add(reader.GetString(0));
                            columnData.Add(reader.GetString(1));
                            //Console.WriteLine(reader[0]);
                        }  
                        // foreach(var i in columnData)
                        // {
                        //     Console.WriteLine(", ", columnData[i]);
                        // }
                        //Console.Write(string.Join(System.Environment.NewLine, columnData));
                        Console.WriteLine(string.Join(", ", columnData));
                        //Console.WriteLine(string.Join(", ", columnData[1]));        
                    }
                }

            }
        }
    }
}






        /////////////Testing///////


        // public static void College_test() {

        //     using(SqlConnection connection = new SqlConnection("Server = DESKTOP-5IOLHIF\\SQLEXPRESS; Database = Student; Trusted_Connection = True;"))
        //     {
        //         connection.Open();

        //         // Selecting College
        //         string query1 = "select College_Name from College where College.College_Id = 1";
        //         using(SqlCommand command1 = new SqlCommand(query1, connection))
        //         {
        //             using (SqlDataReader reader1 = command1.ExecuteReader())
        //             {
        //                 while (reader1.Read())
        //                 {
                            
        //                     Console.WriteLine(reader1[0]);
        //                 }      
        //             }
        //         }


        //         //Selecting students from that college in a list
        //         List<String> namesData = new List<String>();
        //         string query = "select Name from StudentsData where StudentsData.College_Id = 1";
        //         using(SqlCommand command = new SqlCommand(query, connection))
        //         {
        //             using (SqlDataReader reader = command.ExecuteReader())
        //             {
        //                 while (reader.Read())
        //                 {
        //                     namesData.Add(reader.GetString(0));
        //                     //Console.WriteLine(reader[0]);
        //                 }  
        //                 // foreach(var i in columnData)
        //                 // {
        //                 //     Console.WriteLine(", ", columnData[i]);
        //                 // }
        //                 //Console.Write(string.Join(System.Environment.NewLine, columnData));
        //                 Console.WriteLine(string.Join(", ", namesData));    
        //             }
        //         }

        //         List<String> branchData = new List<String>();
        //         string query2 = "select Branch from StudentsData where StudentsData.College_Id = 1";
        //         using(SqlCommand command = new SqlCommand(query2, connection))
        //         {
        //             using (SqlDataReader reader = command.ExecuteReader())
        //             {
        //                 while (reader.Read())
        //                 {
                            
        //                     branchData.Add(reader.GetString(0));
        //                     //Console.WriteLine(reader[0]);
        //                 }  
        //                 // foreach(var i in columnData)
        //                 // {
        //                 //     Console.WriteLine(", ", columnData[i]);
        //                 // }
        //                 //Console.Write(string.Join(System.Environment.NewLine, columnData));
                        
        //                 Console.WriteLine(string.Join(", ", branchData));        
        //             }
        //         }
        //     }
        
        // }



/*

*/