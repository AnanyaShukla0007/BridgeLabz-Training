using System.Data;
using Microsoft.Data.SqlClient;

using HealthClinicApp.DataAccess;
using HealthClinicApp.Models.Medicine;

namespace HealthClinicApp.Repositories.Sql
{
    public class MedicineRepository
    {
        public MedicineModel GetByDiagnosis(int diagnosisId)
        {
            var table = SqlExecutor.ExecuteQuery(
                "sp_GetMedicineByDiagnosis",
                new SqlParameter("@DiagnosisId", diagnosisId)
            );

            if (table.Rows.Count == 0)
                return null;

            var row = table.Rows[0];

            return new MedicineModel
            {
                MedicineName = row["medicine_name"].ToString(),
                Dosage = row["dosage"].ToString(),
                Duration = row["duration"].ToString(),
                MedicineFee = (int)row["medicine_fee"]
            };
        }
    }
}
