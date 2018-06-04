using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.Web;
using System.Runtime.Serialization;

namespace TestRest.model
{
    public class MSchedule
    {
        String idScheduleDetail = string.Empty;
        String idSchedule = string.Empty;
        String day = string.Empty;
        String start = string.Empty;
        String end = string.Empty;

        [DataMember]
        public string IdScheduleDetail
        {
            get { return idScheduleDetail; }
            set { idScheduleDetail = value; }
        }

        [DataMember]
        public string IdSchedule
        {
            get { return idSchedule; }
            set { idSchedule = value; }
        }

        [DataMember]
        public string Day
        {
            get { return day; }
            set { day = value; }
        }

        [DataMember]
        public string Start
        {
            get { return start; }
            set { start = value; }
        }

        [DataMember]
        public string End
        {
            get { return end; }
            set { end = value; }
        }
    }
}