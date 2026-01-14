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

        public User Authenticate(string username, string password, int branchId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Users WHERE username = @username", connection);
                command.Parameters.AddWithValue("@username", username);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var hashedPassword = reader["pwd"] as string;
                        if (PasswordHasher.Verify(password, hashedPassword))
                        {
                            var userId = (int)reader["id"];
                            var employeeId = (int)reader["emp"];

                            // Check if the user has access to the selected branch
                            command = new SqlCommand("SELECT COUNT(*) FROM EmpBranches WHERE emp = @employeeId AND branch = @branchId", connection);
                            command.Parameters.AddWithValue("@employeeId", employeeId);
                            command.Parameters.AddWithValue("@branchId", branchId);
                            var count = (int)command.ExecuteScalar();

                            if (count > 0)
                            {
                                return new User
                                {
                                    Id = userId,
                                    Username = (string)reader["username"],
                                    EmployeeId = employeeId,
                                    BranchId = branchId
                                };
                            }
                        }
                    }
                }
            }
            return null;
        }
    }
}
