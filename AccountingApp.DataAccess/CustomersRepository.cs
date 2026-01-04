using AccountingApp.Core;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace AccountingApp.DataAccess
{
    public class CustomersRepository : BaseRepository, ICustomersRepository
    {
        public CustomersRepository(string connectionString) : base(connectionString) { }

        public IEnumerable<Customer> GetByType(int type)
        {
            var customers = new List<Customer>();
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Customers WHERE type = @type AND IS_Deleted = 0", connection);
                command.Parameters.AddWithValue("@type", type);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customers.Add(MapToCustomer(reader));
                    }
                }
            }
            return customers;
        }

        public Customer GetById(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Customers WHERE id = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return MapToCustomer(reader);
                    }
                }
            }
            return null;
        }

        public void Add(Customer customer)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand(
                    "INSERT INTO Customers (cust_no, cust_type, name, nameEN, country, city, area, act, national_id, tel, mobile, fax, email, address, notes, type, tax_no, credit_limit, IS_Deleted, street, gov, city_name, area_name, street_EN, gov_EN, city_EN, area_EN, build_no, post_code, add_no, crn_no, cr) " +
                    "VALUES (@cust_no, @cust_type, @name, @nameEN, @country, @city, @area, @act, @national_id, @tel, @mobile, @fax, @email, @address, @notes, @type, @tax_no, @credit_limit, 0, @street, @gov, @city_name, @area_name, @street_EN, @gov_EN, @city_EN, @area_EN, @build_no, @post_code, @add_no, @crn_no, @cr)",
                    connection);
                MapToParameters(command, customer);
                command.ExecuteNonQuery();
            }
        }

        public void Update(Customer customer)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand(
                    "UPDATE Customers SET cust_no = @cust_no, cust_type = @cust_type, name = @name, nameEN = @nameEN, country = @country, city = @city, area = @area, act = @act, national_id = @national_id, tel = @tel, mobile = @mobile, fax = @fax, email = @email, address = @address, notes = @notes, type = @type, tax_no = @tax_no, credit_limit = @credit_limit, street = @street, gov = @gov, city_name = @city_name, area_name = @area_name, street_EN = @street_EN, gov_EN = @gov_EN, city_EN = @city_EN, area_EN = @area_EN, build_no = @build_no, post_code = @post_code, add_no = @add_no, crn_no = @crn_no, cr = @cr " +
                    "WHERE id = @id",
                    connection);
                MapToParameters(command, customer);
                command.Parameters.AddWithValue("@id", customer.Id);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("UPDATE Customers SET IS_Deleted = 1 WHERE id = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

        private Customer MapToCustomer(SqlDataReader reader)
        {
            return new Customer
            {
                Id = (int)reader["id"],
                CustomerNo = (int)reader["cust_no"],
                CustomerType = (int)reader["cust_type"],
                Name = (string)reader["name"],
                NameEN = reader["nameEN"] as string,
                CountryId = (int)reader["country"],
                CityId = (int)reader["city"],
                AreaId = (int)reader["area"],
                ActId = (int)reader["act"],
                NationalId = reader["national_id"] as string,
                Telephone = reader["tel"] as string,
                Mobile = reader["mobile"] as string,
                Fax = reader["fax"] as string,
                Email = reader["email"] as string,
                Address = reader["address"] as string,
                Notes = reader["notes"] as string,
                Type = (int)reader["type"],
                TaxNo = reader["tax_no"] as string,
                CreditLimit = (double)reader["credit_limit"],
                Street = reader["street"] as string,
                Gov = reader["gov"] as string,
                CityName = reader["city_name"] as string,
                AreaName = reader["area_name"] as string,
                StreetEN = reader["street_EN"] as string,
                GovEN = reader["gov_EN"] as string,
                CityEN = reader["city_EN"] as string,
                AreaEN = reader["area_EN"] as string,
                BuildNo = reader["build_no"] as string,
                PostCode = reader["post_code"] as string,
                AddNo = reader["add_no"] as string,
                CRN = reader["crn_no"] as string,
                CR = reader["cr"] as string
            };
        }

        private void MapToParameters(SqlCommand command, Customer customer)
        {
            command.Parameters.AddWithValue("@cust_no", customer.CustomerNo);
            command.Parameters.AddWithValue("@cust_type", customer.CustomerType);
            command.Parameters.AddWithValue("@name", customer.Name);
            command.Parameters.AddWithValue("@nameEN", customer.NameEN);
            command.Parameters.AddWithValue("@country", customer.CountryId);
            command.Parameters.AddWithValue("@city", customer.CityId);
            command.Parameters.AddWithValue("@area", customer.AreaId);
            command.Parameters.AddWithValue("@act", customer.ActId);
            command.Parameters.AddWithValue("@national_id", customer.NationalId);
            command.Parameters.AddWithValue("@tel", customer.Telephone);
            command.Parameters.AddWithValue("@mobile", customer.Mobile);
            command.Parameters.AddWithValue("@fax", customer.Fax);
            command.Parameters.AddWithValue("@email", customer.Email);
            command.Parameters.AddWithValue("@address", customer.Address);
            command.Parameters.AddWithValue("@notes", customer.Notes);
            command.Parameters.AddWithValue("@type", customer.Type);
            command.Parameters.AddWithValue("@tax_no", customer.TaxNo);
            command.Parameters.AddWithValue("@credit_limit", customer.CreditLimit);
            command.Parameters.AddWithValue("@street", customer.Street);
            command.Parameters.AddWithValue("@gov", customer.Gov);
            command.Parameters.AddWithValue("@city_name", customer.CityName);
            command.Parameters.AddWithValue("@area_name", customer.AreaName);
            command.Parameters.AddWithValue("@street_EN", customer.StreetEN);
            command.Parameters.AddWithValue("@gov_EN", customer.GovEN);
            command.Parameters.AddWithValue("@city_EN", customer.CityEN);
            command.Parameters.AddWithValue("@area_EN", customer.AreaEN);
            command.Parameters.AddWithValue("@build_no", customer.BuildNo);
            command.Parameters.AddWithValue("@post_code", customer.PostCode);
            command.Parameters.AddWithValue("@add_no", customer.AddNo);
            command.Parameters.AddWithValue("@crn_no", customer.CRN);
            command.Parameters.AddWithValue("@cr", customer.CR);
        }
    }
}
