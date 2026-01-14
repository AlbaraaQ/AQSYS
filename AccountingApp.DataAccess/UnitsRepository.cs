using AccountingApp.Core;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace AccountingApp.DataAccess
{
    public class UnitsRepository : BaseRepository, IUnitsRepository
    {
        public UnitsRepository(string connectionString) : base(connectionString) { }

        public IEnumerable<Unit> GetAll()
        {
            var units = new List<Unit>();
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM units", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        units.Add(new Unit
                        {
                            Id = (int)reader["id"],
                            Name = (string)reader["name"]
                        });
                    }
                }
            }
            return units;
        }

        public void Add(Unit unit)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("INSERT INTO units (name) VALUES (@name)", connection);
                command.Parameters.AddWithValue("@name", unit.Name);
                command.ExecuteNonQuery();
            }
        }

        public void Update(Unit unit)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("UPDATE units SET name = @name WHERE id = @id", connection);
                command.Parameters.AddWithValue("@name", unit.Name);
                command.Parameters.AddWithValue("@id", unit.Id);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("DELETE FROM units WHERE id = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
