namespace HealthClinicApp.Utilities.IdGeneration
{
    /// <summary>
    /// Generates incremental IDs for non-DB entities.
    /// DB entities use IDENTITY.
    /// </summary>
    public static class IdGenerator
    {
        private static int _patientCounter = 0;

        public static int GeneratePatientId()
        {
            _patientCounter++;
            return _patientCounter;
        }
    }
}
