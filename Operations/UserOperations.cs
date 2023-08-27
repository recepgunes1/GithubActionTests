using Microsoft.Data.SqlClient;

namespace Operations;

public class UserOperations
{
    public bool IsUserAuthenticated(string username, string password)
    {
        using SqlConnection connection = new SqlConnection("YourConnectionStringHere");
        connection.Open();
                
        // Vulnerable SQL Query
        var command = new SqlCommand($"SELECT * FROM Users WHERE Username='{username}' AND Password='{password}'", connection);
                
        var reader = command.ExecuteReader();

        return reader.HasRows;
    }
}