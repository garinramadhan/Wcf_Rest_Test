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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DoctorService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DoctorService.svc or DoctorService.svc.cs at the Solution Explorer and start debugging.
    public class DoctorService : IDoctorService
    {
        //SqlConnection con = new SqlConnection("Data Source=DESKTOP-MEO5I55\\DHADOTID; Initial Catalog=YR; User Id=sa; Password=qwerty");
        Connection con = new Connection();

        public void AddDoctor(string idspecialist, string doctorname, string gender, string dob, string phone)
        {
            throw new NotImplementedException();
        }

        public void DeleteDoctor(string id)
        {
            throw new NotImplementedException();
        }

        public MDoctor GetDoctorId(string id)
        {
            throw new NotImplementedException();
        }

        public List<MDoctor> GetDoctorList()
        {
            List<MDoctor> doctorList = new List<MDoctor>();
            {
                con.openConnection();
                SqlCommand cmd = new SqlCommand("select a.Id_Doctor, b.Specialist, a.DoctorName, a.DoctorGender, a.DateOfBirth, a.Phone, b.Fare from Doctor.Doctor a join Doctor.Specialist b on a.Id_Specialist = b.Id_Specialist", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        MDoctor doctorData = new MDoctor();
                        doctorData.IdDoctor = dt.Rows[i]["Id_Doctor"].ToString();
                        doctorData.IdSpecialist = dt.Rows[i]["Specialist"].ToString();
                        doctorData.DoctorName = dt.Rows[i]["DoctorName"].ToString();
                        doctorData.Gender = dt.Rows[i]["DoctorGender"].ToString();
                        doctorData.DOB = dt.Rows[i]["DateOfBirth"].ToString();
                        doctorData.Phone = dt.Rows[i]["Phone"].ToString();
                        doctorData.IdSpecialist = dt.Rows[i]["Fare"].ToString();
                        doctorList.Add(doctorData);
                    }
                }
                
            }
            return doctorList;

        }

        public List<string> GetDoctorNames()
        {
            throw new NotImplementedException();
        }

        public void UpdateDoctor(string id, string name)
        {
            throw new NotImplementedException();
        }
    }
}
