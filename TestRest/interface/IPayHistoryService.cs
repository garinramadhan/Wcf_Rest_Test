using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TestRest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPayHistoryService" in both code and config file together.
    [ServiceContract]
    public interface IPayHistoryService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "Payment/{idPat}/{isPay}")]
        List<MPay> GetPayment(string idPat, string isPay);

        [OperationContract]
        [WebGet(UriTemplate = "PaymentID/{id}", ResponseFormat = WebMessageFormat.Json)]
        MPay GetPaymentId(string id);
    }
}
