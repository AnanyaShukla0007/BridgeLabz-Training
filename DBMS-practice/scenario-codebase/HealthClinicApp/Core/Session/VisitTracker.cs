using System.Collections.Generic;

namespace HealthClinicApp.Core.Session
{
    /// <summary>
    /// Tracks visit numbers for each patient.
    /// Example: Visit #1, Visit #2, etc.
    /// </summary>
    public class VisitTracker
    {
        private readonly Dictionary<int, int> _visitCounts = new();

        /// <summary>
        /// Increments and returns the next visit number for a patient.
        /// </summary>
        public int GetNextVisitNumber(int patientId)
        {
            if (!_visitCounts.ContainsKey(patientId))
            {
                _visitCounts[patientId] = 0;
            }

            _visitCounts[patientId]++;
            return _visitCounts[patientId];
        }
    }
}
