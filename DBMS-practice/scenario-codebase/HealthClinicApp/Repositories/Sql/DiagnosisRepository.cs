using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

using HealthClinicApp.DataAccess;
using HealthClinicApp.Models.Diagnosis;

namespace HealthClinicApp.Repositories.Sql
{
    public class DiagnosisRepository
    {
        public List<DiagnosisModel> GetBySpecialty(int specialtyId)
        {
            var diagnoses = new List<DiagnosisModel>();

            var table = SqlExecutor.ExecuteQuery(
                "sp_GetDiagnosesBySpecialty",
                new SqlParameter("@SpecialtyId", specialtyId)
            );

            foreach (DataRow row in table.Rows)
            {
                diagnoses.Add(new DiagnosisModel
                {
                    DiagnosisId = Convert.ToInt32(row["diagnosis_id"]),
                    DiagnosisName = row["diagnosis_name"].ToString(),
                    SpecialtyId = specialtyId
                });
            }

            return diagnoses;
        }
    }
}
