using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Runtime.Serialization;

namespace TestRest
{
    [DataContract]
    public class MDoctor
    {
        String idDoctor = string.Empty;
        String idSpecialist = string.Empty;
        String doctorName = string.Empty;
        String gender = string.Empty;
        String dob = string.Empty;
        String phone = string.Empty;
        String fare = string.Empty;
        String idSchedule = string.Empty;

        [DataMember]
        public string IdDoctor
        {
            get { return idDoctor; }
            set { idDoctor = value; }
        }

        [DataMember]
        public string IdSpecialist
        {
            get { return idSpecialist; }
            set { idSpecialist = value; }
        }

        [DataMember]
        public string DoctorName
        {
            get { return doctorName; }
            set { doctorName = value; }
        }

        [DataMember]
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        [DataMember]
        public string DOB
        {
            get { return dob; }
            set { dob = value; }
        }

        [DataMember]
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        [DataMember]
        public string Fare
        {
            get { return fare; }
            set { fare = value; }
        }

        [DataMember]
        public string IdSchedule
        {
            get { return idSchedule; }
            set { idSchedule = value; }
        }
    }
}