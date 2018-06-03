using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TestRest.model;

namespace TestRest
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RecipeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RecipeService.svc or RecipeService.svc.cs at the Solution Explorer and start debugging.
    public class RecipeService : IRecipeService
    {
        Connection con = new Connection();
        SqlConnection sqlCon;
        public List<MRecipe> GetRecipe(string idRecipe)
        {
            List<MRecipe> recipeList = new List<MRecipe>();
            {
                sqlCon = con.openConnection();
                SqlCommand cmd = new SqlCommand("select a.Id_Recipe, c.DrugName, b.Qty, b.Subtotal from Recipe.Recipe a join Recipe.RecipeDetail b on a.Id_Recipe = b.Id_Recipe join Recipe.Drug c on b.Id_Drug = c.Id_Drug where a.Id_Recipe = '" + idRecipe + "'", sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        MRecipe recipeData = new MRecipe();
                        recipeData.IdDrug = dt.Rows[i]["Id_Recipe"].ToString();
                        recipeData.NamaObat = dt.Rows[i]["DrugName"].ToString();
                        recipeData.Qty = dt.Rows[i]["Qty"].ToString();
                        recipeData.Fare = dt.Rows[i]["Subtotal"].ToString();
                        recipeList.Add(recipeData);
                    }
                }
                sqlCon.Close();
            }
            return recipeList;
        }
    }
}
