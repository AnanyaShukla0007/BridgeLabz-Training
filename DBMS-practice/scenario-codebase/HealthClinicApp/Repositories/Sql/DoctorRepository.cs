using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

using HealthClinicApp.DataAccess;
using HealthClinicApp.Models.Doctor;

namespace HealthClinicApp.Repositories.Sql
{
    public class DoctorRepository
    {
        public List<DoctorModel> GetAvailableDoctors(
            int specialtyId,
            DateTime date,
            TimeSpan time)
        {
            var doctors = new List<DoctorModel>();

            var table = SqlExecutor.ExecuteQuery(
                "sp_GetAvailableDoctors",
                new SqlParameter("@SpecialtyId", specialtyId),
                new SqlParameter("@AppointmentDate", date.Date),
                new SqlParameter("@AppointmentTime", time)
            );

            foreach (DataRow row in table.Rows)
            {
                doctors.Add(new DoctorModel
                {
                    DoctorId = Convert.ToInt32(row["doctor_id"]),
                    FullName = row["full_name"].ToString(),
                    ConsultationFee = Convert.ToInt32(row["consultation_fee"])
                });
            }

            return doctors;
        }
    }
}
