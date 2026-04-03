namespace HealthClinicApp.Core.Session
{
    /// <summary>
    /// Defines the exact lifecycle of a patient in the clinic.
    /// State transitions are STRICT and sequential.
    /// </summary>
    public enum PatientState
    {
        NEW,
        REGISTERED,
        APPOINTMENT_REQUESTED,
        APPOINTMENT_CONFIRMED,
        VISIT_COMPLETED,
        BILLED,
        PAID
    }
}
