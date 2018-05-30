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
            List<MPatient> patientList = new List<MPatient>();
            {
                con.openConnection();
                SqlCommand cmd = new SqlCommand("select * from Patient.Patient", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
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
    }
}
