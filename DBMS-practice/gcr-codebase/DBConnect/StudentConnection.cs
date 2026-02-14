using Microsoft.Data.SqlClient;
class StudentConnection
{
    public static void Main(String[] args)
    {
        string query="SELECT * FROM Students";
        string connectionString="Server=Ananya\\SQLEXPRESS;Database=StudentDB;Trusted_Connection=true;TrustServerCertificate=true;";
        using SqlConnection connection= new SqlConnection(connectionString);
        connection.Open(); //open is a non static method present inside sqlconnection
        System.Console.WriteLine("Connection Estabilished");
        SqlCommand command=new SqlCommand(query,connection); //executequery, executescaler , executereader,  executenonquery
        SqlDataReader reader=command.ExecuteReader();
        while (reader.Read())
        {
            System.Console.WriteLine(reader["StudentID"]+" "+reader["FullName"]+" "+reader["Email"]+" "+reader["CreatedAt"]+" "+reader["Course"]);
        }
        reader.Close();
        connection.Close();
    }
}

