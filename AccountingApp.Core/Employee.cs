using System;

namespace AccountingApp.Core
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ManagementId { get; set; }
        public int DepartmentId { get; set; }
        public int StateId { get; set; }
        public int JobId { get; set; }
        public DateTime BirthDate { get; set; }
        public string InsuranceNo { get; set; }
        public DateTime WorkDate { get; set; }
        public int MaritalStatusId { get; set; }
        public int NationalityId { get; set; }
        public string Sex { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
        public byte[] Image { get; set; }
        public double BasicSalary { get; set; }
        public double HouseAllowance { get; set; }
        public double TravelAllowance { get; set; }
        public double FoodAllowance { get; set; }
        public double MedicalAllowance { get; set; }
        public double AdditionalSalary { get; set; }
        public double OtherSalary { get; set; }
    }
}
