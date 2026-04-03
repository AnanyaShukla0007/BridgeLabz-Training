using Microsoft.Data.SqlClient;

using HealthClinicApp.DataAccess;

namespace HealthClinicApp.Repositories.Sql
{
    public class PaymentRepository
    {
        public void RecordPayment(int billId, string paymentMode)
        {
            SqlExecutor.ExecuteNonQuery(
                "sp_RecordPayment",
                new SqlParameter("@BillId", billId),
                new SqlParameter("@PaymentMode", paymentMode)
            );
        }
    }
}
