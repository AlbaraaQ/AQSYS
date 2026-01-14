using AccountingApp.Core;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace AccountingApp.DataAccess
{
    public class EmployeesRepository : BaseRepository, IEmployeesRepository
    {
        public EmployeesRepository(string connectionString) : base(connectionString) { }

        public IEnumerable<Employee> GetAll()
        {
            var employees = new List<Employee>();
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Employees WHERE IS_Deleted = 0", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employees.Add(MapToEmployee(reader));
                    }
                }
            }
            return employees;
        }

        public Employee GetById(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Employees WHERE id = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return MapToEmployee(reader);
                    }
                }
            }
            return null;
        }

        public void Add(Employee employee, IEnumerable<int> branchIds)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    var command = new SqlCommand(
                        "INSERT INTO Employees (name, manag, dep, state, job, birth_date, insurance_no, work_date, marital_state, nationality, sex, tel, mobile, email, address, notes, image, salary_basic, house, travel, food, medical, salary_add, salary_other, IS_Deleted) " +
                        "VALUES (@name, @manag, @dep, @state, @job, @birth_date, @insurance_no, @work_date, @marital_state, @nationality, @sex, @tel, @mobile, @email, @address, @notes, @image, @salary_basic, @house, @travel, @food, @medical, @salary_add, @salary_other, 0); SELECT SCOPE_IDENTITY();",
                        connection, transaction);
                    MapToParameters(command, employee);
                    var newId = Convert.ToInt32(command.ExecuteScalar());
                    UpdateEmployeeBranches(newId, branchIds, connection, transaction);
                    transaction.Commit();
                }
            }
        }

        public void Update(Employee employee, IEnumerable<int> branchIds)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    var command = new SqlCommand(
                        "UPDATE Employees SET name = @name, manag = @manag, dep = @dep, state = @state, job = @job, birth_date = @birth_date, insurance_no = @insurance_no, work_date = @work_date, marital_state = @marital_state, nationality = @nationality, sex = @sex, tel = @tel, mobile = @mobile, email = @email, address = @address, notes = @notes, image = @image, salary_basic = @salary_basic, house = @house, travel = @travel, food = @food, medical = @medical, salary_add = @salary_add, salary_other = @salary_other " +
                        "WHERE id = @id",
                        connection, transaction);
                    MapToParameters(command, employee);
                    command.Parameters.AddWithValue("@id", employee.Id);
                    command.ExecuteNonQuery();
                    UpdateEmployeeBranches(employee.Id, branchIds, connection, transaction);
                    transaction.Commit();
                }
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("UPDATE Employees SET IS_Deleted = 1 WHERE id = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Branch> GetEmployeeBranches(int employeeId)
        {
            var branches = new List<Branch>();
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT b.id, b.name FROM Branches b JOIN EmpBranches eb ON b.id = eb.branch WHERE eb.emp = @employeeId", connection);
                command.Parameters.AddWithValue("@employeeId", employeeId);
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

        private void UpdateEmployeeBranches(int employeeId, IEnumerable<int> branchIds, SqlConnection connection, SqlTransaction transaction)
        {
            var command = new SqlCommand("DELETE FROM EmpBranches WHERE emp = @employeeId", connection, transaction);
            command.Parameters.AddWithValue("@employeeId", employeeId);
            command.ExecuteNonQuery();

            foreach (var branchId in branchIds)
            {
                command = new SqlCommand("INSERT INTO EmpBranches (emp, branch) VALUES (@employeeId, @branchId)", connection, transaction);
                command.Parameters.AddWithValue("@employeeId", employeeId);
                command.Parameters.AddWithValue("@branchId", branchId);
                command.ExecuteNonQuery();
            }
        }

        private Employee MapToEmployee(SqlDataReader reader)
        {
            return new Employee
            {
                Id = (int)reader["id"],
                Name = (string)reader["name"],
                ManagementId = (int)reader["manag"],
                DepartmentId = (int)reader["dep"],
                StateId = (int)reader["state"],
                JobId = (int)reader["job"],
                BirthDate = (System.DateTime)reader["birth_date"],
                InsuranceNo = reader["insurance_no"] as string,
                WorkDate = (System.DateTime)reader["work_date"],
                MaritalStatusId = (int)reader["marital_state"],
                NationalityId = (int)reader["nationality"],
                Sex = reader["sex"] as string,
                Telephone = reader["tel"] as string,
                Mobile = reader["mobile"] as string,
                Email = reader["email"] as string,
                Address = reader["address"] as string,
                Notes = reader["notes"] as string,
                Image = reader["image"] as byte[],
                BasicSalary = (double)reader["salary_basic"],
                HouseAllowance = (double)reader["house"],
                TravelAllowance = (double)reader["travel"],
                FoodAllowance = (double)reader["food"],
                MedicalAllowance = (double)reader["medical"],
                AdditionalSalary = (double)reader["salary_add"],
                OtherSalary = (double)reader["salary_other"]
            };
        }

        private void MapToParameters(SqlCommand command, Employee employee)
        {
            command.Parameters.AddWithValue("@name", employee.Name);
            command.Parameters.AddWithValue("@manag", employee.ManagementId);
            command.Parameters.AddWithValue("@dep", employee.DepartmentId);
            command.Parameters.AddWithValue("@state", employee.StateId);
            command.Parameters.AddWithValue("@job", employee.JobId);
            command.Parameters.AddWithValue("@birth_date", employee.BirthDate);
            command.Parameters.AddWithValue("@insurance_no", employee.InsuranceNo);
            command.Parameters.AddWithValue("@work_date", employee.WorkDate);
            command.Parameters.AddWithValue("@marital_state", employee.MaritalStatusId);
            command.Parameters.AddWithValue("@nationality", employee.NationalityId);
            command.Parameters.AddWithValue("@sex", employee.Sex);
            command.Parameters.AddWithValue("@tel", employee.Telephone);
            command.Parameters.AddWithValue("@mobile", employee.Mobile);
            command.Parameters.AddWithValue("@email", employee.Email);
            command.Parameters.AddWithValue("@address", employee.Address);
            command.Parameters.AddWithValue("@notes", employee.Notes);
            command.Parameters.AddWithValue("@image", employee.Image ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@salary_basic", employee.BasicSalary);
            command.Parameters.AddWithValue("@house", employee.HouseAllowance);
            command.Parameters.AddWithValue("@travel", employee.TravelAllowance);
            command.Parameters.AddWithValue("@food", employee.FoodAllowance);
            command.Parameters.AddWithValue("@medical", employee.MedicalAllowance);
            command.Parameters.AddWithValue("@salary_add", employee.AdditionalSalary);
            command.Parameters.AddWithValue("@salary_other", employee.OtherSalary);
        }
    }
}
