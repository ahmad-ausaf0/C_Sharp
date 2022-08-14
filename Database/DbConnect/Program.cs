using System;
//using Microsoft.Data.SqlClient;
//using System.Data.SqlClient;
namespace DbConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            // using (var connection = new QC.SqlConnection(  
			// 	"Server=tcp:DESKTOP-5IOLHIF\\SQLEXPRESS.database.windows.net,1433;" +
			// 	"Database=Student;User ID=DESKTOP-5IOLHIF\\HP;" +
			// 	"Password=     ;Encrypt=True;" +
			// 	"TrustServerCertificate=False;Connection Timeout=30;"  
			// 	))  
			// {  
			// 	connection.Open();  
			// 	Console.WriteLine("Connected successfully.");  

			// 	Console.WriteLine("Press any key to finish...");  
			// 	Console.ReadKey(true);  
			// }  
            //Creating connectoin
            using (SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-5IOLHIF\\SQLEXPRESS;Database=Student; Trusted_Connection=True;"))
            {
                //Open connection
                sqlConnection.Open();
 
                //Defining command
                using (SqlCommand cmd = new SqlCommand())
                {
                    //Assigning connection to command
                    cmd.Connection = sqlConnection;
 
                    //---------Defining which command to run----------------------
                    
                    //Inserting record
                    cmd.CommandText = "INSERT INTO Student_Data VALUES (3, 'Rohan', 'History')";
                    cmd.ExecuteNonQuery();
 

                    //Updating Record
                    cmd.CommandText = "UPDATE Student_Data SET Name = \'Rahul\', Dept = \'Mech\' WHERE ID = 3";  
                    cmd.ExecuteNonQuery();

                    //Deleting Record
                    cmd.CommandText = "DELETE from Student_Data where ID = 3"; 
                    cmd.ExecuteNonQuery(); 
                    
                    //Reading Record
                    cmd.CommandText = "SELECT * FROM Student_Data";
                    //Executing command
                    using (SqlDataReader SqlDataReader = cmd.ExecuteReader())
                    {
                        //Reading data till end
                        while (SqlDataReader.Read())
                        {
                            Console.WriteLine(SqlDataReader[0]);
                            Console.WriteLine(SqlDataReader[1]);
                            Console.WriteLine(SqlDataReader[2]);
                        }
                    }

                                  

                }
            }
        }
    }
}
