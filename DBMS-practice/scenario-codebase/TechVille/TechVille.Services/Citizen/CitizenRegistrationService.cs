using TechVille.DataAccess;
using TechVille.Exceptions;

namespace TechVille.Services.Citizen
{
    public static class CitizenRegistrationService
    {
        public static void Register(
            string code,
            string name,
            int age,
            decimal income,
            int residencyYears,
            string zone)
        {
            if (age < 18)
                throw new UnderageException("Citizen must be 18 or older.");

            CitizenRepository.InsertCitizen(
                code,
                name,
                age,
                income,
                residencyYears,
                zone
            );
        }
    }
}
