using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;

namespace ReservationSystemForBloodDonation
{
    public partial class zmena_hesla : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string login = Request.QueryString["cisloD"];
            string rodneCislo = Request.QueryString["rodneCislo"];

            if ((login != null) && (rodneCislo != null))
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["darcostvi"].ConnectionString);
                con.Open();

                string rodne = "select rodne_cislo from Darci where rodne_cislo=@rC";

                SqlCommand cmdRodne = new SqlCommand(rodne, con);
                cmdRodne.Parameters.AddWithValue("@rC", rodneCislo);

                string prihlaseniCislo = "select login from Prihlaseni where login=@lT";

                SqlCommand cmdCislo = new SqlCommand(prihlaseniCislo, con);

                cmdCislo.Parameters.AddWithValue("@lT", login);


                if ((cmdCislo.ExecuteScalar() != null) && (cmdRodne.ExecuteScalar() != null))
                {

                    Session["darec"] = login;
                    Response.Redirect("zmena.aspx");


                }
                else
                {
                    ClientScript.RegisterStartupScript(Page.GetType(), "alert", "javascript:alert('Rodné číslo nebo číslo dárce neexistuje.');", true);
                }
            }
               
        }
    }
}