using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TestRest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPatientService" in both code and config file together.
    [ServiceContract]
    public interface IPatientService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        List<MPatient> GetPatientList();

        [OperationContract]
        [WebGet(UriTemplate = "Patient/{id}")]
        MPatient GetPatientId(string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "AddPatient/{patientname}/{dob}/{address}/{gender}")]
        void AddPatient(string patientname, string dob, string address, string gender);

        [OperationContract]
        [WebInvoke(UriTemplate = "UpdatePatient/{id}/{name}")]
        void UpdatePatient(string id, string name);

        [OperationContract]
        [WebInvoke(UriTemplate = "DeletePatient/{id}")]
        void DeletePatient(string id);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        List<string> GetPatientNames();

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "Login/{username}/{password}",
            BodyStyle = WebMessageBodyStyle.Bare)]
        MPatient doLogin(string username, string password);
    }
}
