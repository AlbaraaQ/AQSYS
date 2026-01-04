using AccountingApp.Core;
using Microsoft.Data.SqlClient;

namespace AccountingApp.DataAccess
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly string _connectionString;

        public AuthenticationService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public User Authenticate(string username, string password)
        {
            // CRITICAL: This is a temporary authentication mechanism for development purposes only.
            // Passwords should NEVER be stored as plaintext. Before any production deployment,
            // this must be replaced with a secure password hashing and verification mechanism
            // (e.g., PBKDF2, BCrypt, or Argon2).
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Users WHERE username = @username AND pwd = @password", connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            Id = (int)reader["id"],
                            Username = (string)reader["username"],
                            EmployeeId = (int)reader["emp"],
                            BranchId = 0 // The branch is selected in the UI, so we'll need to handle this separately.
                        };
                    }
                }
            }
            return null;
        }
    }
}
