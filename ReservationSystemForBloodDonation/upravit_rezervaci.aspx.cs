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
    public partial class upravit_rezervaci : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["login"] != null)
            {
                login.Text = Session["login"].ToString();
                string cisloDarce = Session["cislo"].ToString();
                Response.Write(cisloDarce);

                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["darcostvi"].ConnectionString);
                con.Open();

                string datum = "select [datum_odberu] from [Rezervace] where [Id]=@darceT";
                string misto = "select [misto_odberu_krve_id] from [Rezervace] where [Id]=@darceT";
                string cas = "select [cas_odberu] from [Rezervace] where [Id]=@darceT";
                SqlCommand cmdDatum = new SqlCommand(datum, con);
                SqlCommand cmdMisto = new SqlCommand(misto, con);
                SqlCommand cmdCas = new SqlCommand(cas, con);



                cmdDatum.Parameters.AddWithValue("@darceT", cisloDarce);
                cmdMisto.Parameters.AddWithValue("@darceT", cisloDarce);
                cmdCas.Parameters.AddWithValue("@darceT", cisloDarce);

                if (cmdDatum.ExecuteScalar() != null) {
                    string d = cmdDatum.ExecuteScalar().ToString();
                    string m = cmdMisto.ExecuteScalar().ToString();
                    string c = cmdCas.ExecuteScalar().ToString();
                    casL.Text = d;
                    mistoL.Text = m;
                    datumL.Text = c;
                } else
                {

                    ClientScript.RegisterStartupScript(Page.GetType(), "alert", "javascript:alert('Rezervace pod daným číslem neexistuje.');", true);
                }
               
            }

        }

        protected void vymazat_rezervaci_Click(object sender, EventArgs e)
        {
            if (Session["login"] != null)
            {
                string cisloDarce = Session["cislo"].ToString();
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["darcostvi"].ConnectionString);
                con.Open();
                SqlCommand sqlVym = new SqlCommand("delete from Rezervace where Id=@cisloT", con);
                sqlVym.Parameters.AddWithValue("@cisloT", cisloDarce);
                sqlVym.ExecuteNonQuery();
                Response.Write("Rezervace úspěšně smazána.");
            }


        }

        protected void zpet_Click(object sender, EventArgs e)
        {
            Response.Redirect("uprava_mista.aspx");
        }
    }
}