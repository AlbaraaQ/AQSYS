namespace AccountingApp.Core
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameEN { get; set; }
        public int CustomerType { get; set; } // 1 = Permanent, 2 = Cash
        public int Type { get; set; } // 1 = Customer, 2 = Supplier
        public int CustomerNo { get; set; }
        public string NationalId { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
        public string TaxNo { get; set; }
        public double CreditLimit { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public int AreaId { get; set; }
        public int ActId { get; set; }
        public string Street { get; set; }
        public string Gov { get; set; }
        public string CityName { get; set; }
        public string AreaName { get; set; }
        public string StreetEN { get; set; }
        public string GovEN { get; set; }
        public string CityEN { get; set; }
        public string AreaEN { get; set; }
        public string BuildNo { get; set; }
        public string PostCode { get; set; }
        public string AddNo { get; set; }
        public string CRN { get; set; }
        public string CR { get; set; }
    }
}
