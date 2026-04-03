namespace TechVille.Models.Citizen
{
    public class CitizenProfile
    {
        public Citizen Citizen { get; set; }
        public Address Address { get; set; }

        public CitizenProfile(Citizen citizen, Address address)
        {
            Citizen = citizen;
            Address = address;
        }
    }
}
