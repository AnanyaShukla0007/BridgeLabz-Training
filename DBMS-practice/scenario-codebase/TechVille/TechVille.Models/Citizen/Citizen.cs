namespace TechVille.Models.Citizen
{
    public class Citizen
    {
        public int CitizenId { get; set; }
        public string CitizenCode { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public decimal Income { get; set; }
        public int ResidencyYears { get; set; }
        public string Zone { get; set; }

        public Citizen() { }

        public Citizen(
            string citizenCode,
            string fullName,
            int age,
            decimal income,
            int residencyYears,
            string zone)
        {
            CitizenCode = citizenCode;
            FullName = fullName;
            Age = age;
            Income = income;
            ResidencyYears = residencyYears;
            Zone = zone;
        }
    }
}
