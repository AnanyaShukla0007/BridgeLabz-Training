namespace TechVille.Services.Citizen
{
    public static class EligibilityService
    {
        public static bool IsEligible(int age) => age >= 18;
    }
}
