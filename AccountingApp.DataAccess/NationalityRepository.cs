using AccountingApp.Core;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace AccountingApp.DataAccess
{
    public class NationalityRepository : BaseRepository, INationalityRepository
    {
        public NationalityRepository(string connectionString) : base(connectionString) { }

        public IEnumerable<Nationality> GetAll()
        {
            var nationalities = new List<Nationality>();
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT id, nationality FROM Countries", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nationalities.Add(new Nationality
                        {
                            Id = (int)reader["id"],
                            Name = (string)reader["nationality"]
                        });
                    }
                }
            }
            return nationalities;
        }
    }
}
