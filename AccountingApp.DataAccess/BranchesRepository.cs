using AccountingApp.Core;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace AccountingApp.DataAccess
{
    public class BranchesRepository : BaseRepository, IBranchesRepository
    {
        public BranchesRepository(string connectionString) : base(connectionString) { }

        public IEnumerable<Branch> GetAll()
        {
            var branches = new List<Branch>();
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Branches", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        branches.Add(new Branch
                        {
                            Id = (int)reader["id"],
                            Name = (string)reader["name"]
                        });
                    }
                }
            }
            return branches;
        }
    }
}
