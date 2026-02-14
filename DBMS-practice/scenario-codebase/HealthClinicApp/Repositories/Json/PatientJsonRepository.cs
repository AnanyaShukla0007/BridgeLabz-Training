using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using HealthClinicApp.Models.Patient;

namespace HealthClinicApp.Repositories.Json
{
    public class PatientJsonRepository
    {
        private const string FilePath = "patients.json";

        /* =========================
           READ
           ========================= */

        public List<PatientModel> GetAll()
        {
            if (!File.Exists(FilePath))
            {
                File.WriteAllText(FilePath, "[]");
                return new List<PatientModel>();
            }

            var json = File.ReadAllText(FilePath);

            if (string.IsNullOrWhiteSpace(json))
                return new List<PatientModel>();

            return JsonSerializer.Deserialize<List<PatientModel>>(json)
                   ?? new List<PatientModel>();
        }

        public PatientModel FindByNameAndDob(string name, DateTime dob)
        {
            var patients = GetAll();

            return patients.FirstOrDefault(p =>
                p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)
                && p.DateOfBirth.Date == dob.Date
            );
        }

        /* =========================
           WRITE (WITH ID GENERATION)
           ========================= */

        public PatientModel Add(PatientModel patient)
        {
            var patients = GetAll();

            // 🔥 CRITICAL FIX: Generate next ID
            patient.PatientId = GetNextPatientId(patients);
            patient.RegisteredAt = DateTime.Now;

            patients.Add(patient);
            SaveAll(patients);

            return patient;
        }

        private int GetNextPatientId(List<PatientModel> patients)
        {
            if (patients == null || patients.Count == 0)
                return 1;

            return patients.Max(p => p.PatientId) + 1;
        }

        private void SaveAll(List<PatientModel> patients)
        {
            var json = JsonSerializer.Serialize(
                patients,
                new JsonSerializerOptions { WriteIndented = true }
            );

            File.WriteAllText(FilePath, json);
        }
    }
}
