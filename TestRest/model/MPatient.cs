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
    public class MPatient
    {
        String idPatient = string.Empty;
        String patientName = string.Empty;
        String dob = string.Empty;
        String address = string.Empty;
        String gender = string.Empty;


        [DataMember]
        public string IdPatient
        {
            get { return idPatient; }
            set { idPatient = value; }
        }

        [DataMember]
        public string PatientName
        {
            get { return patientName; }
            set { patientName = value; }
        }

        [DataMember]
        public string DOB
        {
            get { return dob; }
            set { dob = value; }
        }

        [DataMember]
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        [DataMember]
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
    }
}