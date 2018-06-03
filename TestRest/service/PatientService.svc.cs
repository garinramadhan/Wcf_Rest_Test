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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PatientService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PatientService.svc or PatientService.svc.cs at the Solution Explorer and start debugging.
    public class PatientService : IPatientService
    {
        Connection con = new Connection();
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataAdapter sqlDa;

        public void AddPatient(string patientname, string dob, string address, string gender)
        {
            throw new NotImplementedException();
        }

        public void DeletePatient(string id)
        {
            throw new NotImplementedException();
        }

        public MPatient GetPatientId(string id)
        {
            throw new NotImplementedException();
        }

        public List<MPatient> GetPatientList()
        {
            sqlCon = con.openConnection();
            List<MPatient> patientList = new List<MPatient>();
            {
                con.openConnection();
                sqlCom = new SqlCommand("select * from Patient.Patient", sqlCon);
                sqlDa = new SqlDataAdapter(sqlCom);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        MPatient patientData = new MPatient();
                        patientData.IdPatient = dt.Rows[i]["Id_Patient"].ToString();
                        patientData.PatientName = dt.Rows[i]["Patient_Name"].ToString();
                        patientData.DOB = dt.Rows[i]["DateOfBirth"].ToString();
                        patientData.Address = dt.Rows[i]["Address"].ToString();
                        patientData.Gender = dt.Rows[i]["GenderPatient"].ToString();
                        patientList.Add(patientData);
                    }
                }
                sqlCon.Close();
            }
            return patientList;
        }

        public List<string> GetPatientNames()
        {
            throw new NotImplementedException();
        }

        public void UpdatePatient(string id, string name)
        {
            throw new NotImplementedException();
        }

        public MPatient doLogin(string username, string password)
        {
            MPatient mpat = new MPatient();
            sqlCon = con.openConnection();
            sqlCom = new SqlCommand("select * from Patient.Patient where Id_Patient = @username and DateOfBirth = @password", sqlCon);
            sqlCom.Parameters.AddWithValue("@username", username);
            sqlCom.Parameters.AddWithValue("@password", password);
            sqlDa = new SqlDataAdapter(sqlCom);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                mpat.IdPatient = dt.Rows[0]["Id_Patient"].ToString();
                mpat.PatientName = dt.Rows[0]["Patient_Name"].ToString();
                mpat.DOB = dt.Rows[0]["DateOfBirth"].ToString();
                mpat.Address = dt.Rows[0]["Address"].ToString();
                mpat.Gender = dt.Rows[0]["GenderPatient"].ToString();
            }
            else
            {
                mpat.IdPatient = "404";
            }
            sqlCon.Close();
            return mpat;
        }
    }
}
