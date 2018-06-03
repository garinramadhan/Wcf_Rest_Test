using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TestRest.model;

namespace TestRest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRecipeService" in both code and config file together.
    [ServiceContract]
    public interface IRecipeService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "Recipe/{idRecipe}")]
        List<MRecipe> GetRecipe(string idRecipe);
    }
}
