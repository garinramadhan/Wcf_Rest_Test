using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;
using TestRest.model;

namespace TestRest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDoctorService" in both code and config file together.
    [ServiceContract]
    public interface IDoctorService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        List<MDoctor> GetDoctorList();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "Schedule/{idSchedule}")]
        List<MSchedule> GetSchedule(string idSchedule);

        [OperationContract]
        [WebGet(UriTemplate = "Doctor/{id}")]
        MDoctor GetDoctorId(string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "AddDoctor/{idspecialist}/{doctorname}/{gender}/{dob}/{phone}")]
        void AddDoctor(string idspecialist, string doctorname, string gender, string dob, string phone);

        [OperationContract]
        [WebInvoke(UriTemplate = "UpdateDoctor/{id}/{name}")]
        void UpdateDoctor(string id, string name);

        [OperationContract]
        [WebInvoke(UriTemplate = "DeleteDoctor/{id}")]
        void DeleteDoctor(string id);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        List<string> GetDoctorNames();
    }
}
