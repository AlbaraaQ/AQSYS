using AccountingApp.Core;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AccountingApp.DataAccess
{
    public class LookupRepository<T> : BaseRepository, ILookupRepository<T> where T : LookupItem, new()
    {
        private readonly string _tableName;

        public LookupRepository(string connectionString, string tableName) : base(connectionString)
        {
            // WARNING: This repository uses string interpolation to build the SQL query.
            // This is generally a security risk and should be avoided. In this specific case,
            // the table name is validated with a regex to ensure it only contains alphanumeric
            // characters and underscores, which mitigates the risk of SQL injection.
            // However, this pattern should not be replicated in other parts of the application.
            if (!Regex.IsMatch(tableName, @"^[a-zA-Z_]+$"))
            {
                throw new System.ArgumentException("Invalid table name.", nameof(tableName));
            }
            _tableName = tableName;
        }

        public IEnumerable<T> GetAll()
        {
            var items = new List<T>();
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand($"SELECT * FROM {_tableName}", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        items.Add(new T
                        {
                            Id = (int)reader["id"],
                            Name = (string)reader["name"]
                        });
                    }
                }
            }
            return items;
        }
    }
}
