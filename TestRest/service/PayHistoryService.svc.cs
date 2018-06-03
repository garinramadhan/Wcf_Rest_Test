using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TestRest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PayHistoryService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PayHistoryService.svc or PayHistoryService.svc.cs at the Solution Explorer and start debugging.
    public class PayHistoryService : IPayHistoryService
    {
        Connection con = new Connection();
        SqlConnection sqlCon;

        public List<MPay> GetPayment(string idPat, string isPayment)
        {
            List<MPay> paymentList = new List<MPay>();
            {
                sqlCon = con.openConnection();
                SqlCommand cmd = new SqlCommand("select treat.Id_Treatment, rec.Id_Recipe, pat.Patient_Name, treat.Diagnose, doc.DoctorName, treat.DateTreatment, pay.PaymentDrug, pay.PaymentDoctor, pay.TotalPayment, pay.isPay from Patient.Treatment treat join Recipe.Recipe rec on treat.Id_Recipe = rec.Id_Recipe join Patient.Patient pat on treat.Id_Patient = pat.Id_Patient join Doctor.Doctor doc on treat.Id_Doctor = doc.Id_Doctor join Patient.Payment pay on pay.Id_Treatment = treat.Id_Treatment where pat.Id_Patient = '" + idPat +"' and pay.isPay = '" + isPayment + "'", sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    for(int i = 0; i < dt.Rows.Count; i++)
                    {
                        MPay paymentData = new MPay();
                        paymentData.IdTreatment = dt.Rows[i]["Id_Treatment"].ToString();
                        paymentData.IdRecipe = dt.Rows[i]["Id_Recipe"].ToString();
                        paymentData.PatientName = dt.Rows[i]["Patient_Name"].ToString();
                        paymentData.Diagnose = dt.Rows[i]["Diagnose"].ToString();
                        paymentData.DoctorName = dt.Rows[i]["DoctorName"].ToString();
                        paymentData.DateTreatment = dt.Rows[i][5].ToString();
                        paymentData.PaymentDrug = dt.Rows[i]["PaymentDrug"].ToString();
                        paymentData.PaymentDoctor = dt.Rows[i]["PaymentDoctor"].ToString();
                        paymentData.TotalPayment = dt.Rows[i]["TotalPayment"].ToString();
                        paymentData.IsPay = dt.Rows[i]["isPay"].ToString();
                        paymentList.Add(paymentData);
                    }
                }
                sqlCon.Close();
            }
            return paymentList;
        }

        public MPay GetPaymentId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
