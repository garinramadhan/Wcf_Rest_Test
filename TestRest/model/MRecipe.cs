using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace TestRest.model
{
    [DataContract]
    public class MRecipe
    {
        String idDrug = string.Empty;
        String namaObat = string.Empty;
        String qty = string.Empty;
        String fare = string.Empty;

        [DataMember]
        public String IdDrug
        {
            get { return idDrug; }
            set { idDrug = value; }
        }

        [DataMember]
        public String NamaObat
        {
            get { return namaObat; }
            set { namaObat = value; }
        }

        [DataMember]
        public String Qty
        {
            get { return qty; }
            set { qty = value; }
        }

        [DataMember]
        public String Fare
        {
            get { return fare; }
            set { fare = value; }
        }
    }
}