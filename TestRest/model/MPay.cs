using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TestRest
{
    [DataContract]
    public class MPay
    {
        String idTreatment = string.Empty;
        String idRecipe = string.Empty;
        String patientName = string.Empty;
        String diagnose = string.Empty;
        String doctorName = string.Empty;
        String dateTreatment = string.Empty;
        String paymentDrug = string.Empty;
        String totalPayment = string.Empty;
        String isPay = string.Empty;

        [DataMember]
        public string IdTreatment
        {
            get { return idTreatment; }
            set { idTreatment = value; }
        }

        [DataMember]
        public string IdRecipe
        {
            get { return idRecipe; }
            set { idRecipe = value; }
        }

        [DataMember]
        public string PatientName
        {
            get { return patientName; }
            set { patientName = value; }
        }

        [DataMember]
        public string Diagnose
        {
            get { return diagnose; }
            set { diagnose = value; }
        }

        [DataMember]
        public string DoctorName
        {
            get { return doctorName; }
            set { doctorName = value; }
        }

        [DataMember]
        public string DateTreatment
        {
            get { return dateTreatment; }
            set { dateTreatment = value; }
        }

        [DataMember]
        public string PaymentDrug
        {
            get { return paymentDrug; }
            set { paymentDrug = value; }
        }

        [DataMember]
        public string TotalPayment
        {
            get { return totalPayment; }
            set { totalPayment = value; }
        }

        [DataMember]
        public string IsPay
        {
            get { return isPay; }
            set { isPay = value; }
        }
    }
}