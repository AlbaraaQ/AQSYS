using AccountingApp.Core;
using Microsoft.Data.SqlClient;

namespace AccountingApp.DataAccess
{
    public class FoundationRepository : BaseRepository, IFoundationRepository
    {
        public FoundationRepository(string connectionString) : base(connectionString) { }

        public Foundation Get()
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT TOP 1 * FROM Foundation", connection);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Foundation
                        {
                            NameA = reader["nameA"] as string,
                            Address = reader["Address"] as string,
                            Tel = reader["Tel"] as string,
                            Mobile = reader["Mobile"] as string,
                            Fax = reader["Fax"] as string
                        };
                    }
                }
            }
            return null;
        }
    }
}
