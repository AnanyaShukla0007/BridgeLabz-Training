using HealthClinicApp.Core.Exceptions;

namespace HealthClinicApp.Services
{
    public class ReceptionistService
    {
        private const string Password = "admin007";

        public void Authenticate(string inputPassword)
        {
            if (inputPassword != Password)
                throw new AuthorizationException("Invalid receptionist password.");
        }
    }
}
