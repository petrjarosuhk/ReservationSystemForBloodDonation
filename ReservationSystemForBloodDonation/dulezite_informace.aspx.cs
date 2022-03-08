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
    public partial class dulezite_informace : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void zobrazit_Click(object sender, EventArgs e)
        {
           string rc = Session["rodnecislo5"].ToString();

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["darcostvi"].ConnectionString);
            con.Open();

            string cislo = "select [cislo_darce] from [InformaceDarecKrevPocet] where [rodne_cislo]="+rc;
            string typ = "select [typ_krve] from [InformaceDarecKrevPocet] where [rodne_cislo]="+rc;
            string pocet = "select [pocet_darovani] from [InformaceDarecKrevPocet] where [rodne_cislo]="+rc;
            string rodne_cislo = "select [rodne_cislo] from [InformaceDarecKrevPocet] where [rodne_cislo]="+rc;

            SqlCommand cmdJmeno = new SqlCommand(cislo, con);
            SqlCommand cmdPrijmeni = new SqlCommand(typ, con);
            SqlCommand cmdUlice = new SqlCommand(pocet, con);
            SqlCommand cmdPsc = new SqlCommand(rodne_cislo, con);


                cmdJmeno.Parameters.AddWithValue("@rcT", rc);
                cmdPrijmeni.Parameters.AddWithValue("@rcT", rc);
                cmdUlice.Parameters.AddWithValue("@rcT", rc);




            if (cmdJmeno.ExecuteScalar() != null)
            {

                cisloT.Text = cmdJmeno.ExecuteScalar().ToString();

            }
            else
                cisloT.Text = "Nic";

            if (cmdPrijmeni.ExecuteScalar() != null)
            {
                typT.Text = cmdPrijmeni.ExecuteScalar().ToString();
            }
            else
                typT.Text = "Nic";

            if (cmdUlice.ExecuteScalar() != null)
            {
                pocetT.Text = cmdUlice.ExecuteScalar().ToString();
            }
            else
                pocetT.Text = "Nic";
            if (cmdPsc.ExecuteScalar() != null)
            {
                rodne_cisloT.Text = cmdPsc.ExecuteScalar().ToString();
            }
            else
                rodne_cisloT.Text = "Nic";



            con.Close();

        }

        protected void aktualizovat_Click(object sender, EventArgs e)
        {


            string rc = Session["rodnecislo5"].ToString();
     
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["darcostvi"].ConnectionString);
            con.Open();
            SqlCommand sqlAktualizace = new SqlCommand("update InformaceDarecKrevPocet Set cislo_darce=@cisloP, typ_krve=@typP, pocet_darovani=@pocetP, rodne_cislo=@rodneP where rodne_cislo=" + rc, con);

            sqlAktualizace.Parameters.AddWithValue("@cisloP", cisloT.Text); 
            sqlAktualizace.Parameters.AddWithValue("@typP", typT.Text);
            sqlAktualizace.Parameters.AddWithValue("@pocetP", pocetT.Text);
            sqlAktualizace.Parameters.AddWithValue("@rodneP", rodne_cisloT.Text);
       
            sqlAktualizace.ExecuteNonQuery();
            con.Close();
            Response.Write("Informace v pořádku uloženy");

        }

        protected void zpet_Click(object sender, EventArgs e)
        {
            Response.Redirect("uprava_mista.aspx");
        }
    }
}