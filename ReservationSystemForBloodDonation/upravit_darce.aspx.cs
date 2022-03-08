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
    public partial class upravit_darce : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
    
        }
      
        protected void aktualizovat_Click(object sender, EventArgs e)
        {
            if (Session["login"] != null)
            {
                string rodneCislo = Session["cislodarce"].ToString();
                Response.Write(rodneCislo);
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["darcostvi"].ConnectionString);
                con.Open();
                SqlCommand sqlAktualizace = new SqlCommand("update Darci Set jmeno=@jmenoP, prijmeni=@prijmeniP, ulice=@uliceP, psc=@pscP, mesto=@mestoP, telefon=@telefonP, email=@emailP where rodne_cislo=" + rodneCislo, con);

                sqlAktualizace.Parameters.AddWithValue("@jmenoP", jmenoT.Text); ;
                sqlAktualizace.Parameters.AddWithValue("prijmeniP", prijmeniT.Text);
                sqlAktualizace.Parameters.AddWithValue("@pscP", pscT.Text);
                sqlAktualizace.Parameters.AddWithValue("@mestoP", mestoT.Text);
                sqlAktualizace.Parameters.AddWithValue("@telefonP", telefonT.Text);
                sqlAktualizace.Parameters.AddWithValue("@emailP", emailT.Text);
                sqlAktualizace.Parameters.AddWithValue("@uliceP", uliceT.Text);

                sqlAktualizace.ExecuteNonQuery();
                con.Close();

            }
        }

        protected void zpet_Click(object sender, EventArgs e)
        {
            Response.Redirect("uprava_mista.aspx");
        }

        protected void zobrazit_Click(object sender, EventArgs e)
        {
            if (Session["login"] != null)
            {
                string rodneCislo = Session["cislodarce"].ToString();



                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["darcostvi"].ConnectionString);
                con.Open();

                string jmeno = "select [jmeno] from [Darci] where [rodne_cislo]=@rcT";
                string prijmeni = "select [prijmeni] from [Darci] where [rodne_cislo]=@rcT";
                string ulice = "select [ulice] from [Darci] where [rodne_cislo]=@rcT";
                string psc = "select [psc] from [Darci] where [rodne_cislo]=@rcT";
                string mesto = "select [mesto] from [Darci] where [rodne_cislo]=@rcT";
                string telefon = "select [telefon] from [Darci] where [rodne_cislo]=@rcT";
                string email = "select [email] from [Darci] where [rodne_cislo]=@rcT";
                string rodneCislo3 = "select [rodne_cislo] from [Darci] where [rodne_cislo]=@rcT";
                SqlCommand cmdJmeno = new SqlCommand(jmeno, con);
                SqlCommand cmdPrijmeni = new SqlCommand(prijmeni, con);
                SqlCommand cmdUlice = new SqlCommand(ulice, con);
                SqlCommand cmdPsc = new SqlCommand(psc, con);
                SqlCommand cmdMesto = new SqlCommand(mesto, con);
                SqlCommand cmdTelfon = new SqlCommand(telefon, con);
                SqlCommand cmdEmail = new SqlCommand(email, con);
                SqlCommand cmdRodneCislo = new SqlCommand(rodneCislo3, con);


                cmdJmeno.Parameters.AddWithValue("@rcT", rodneCislo);
                cmdPrijmeni.Parameters.AddWithValue("@rcT", rodneCislo);
                cmdUlice.Parameters.AddWithValue("@rcT", rodneCislo);
                cmdPsc.Parameters.AddWithValue("@rcT", rodneCislo);
                cmdMesto.Parameters.AddWithValue("@rcT", rodneCislo);
                cmdTelfon.Parameters.AddWithValue("@rcT", rodneCislo);
                cmdEmail.Parameters.AddWithValue("@rcT", rodneCislo);
                cmdRodneCislo.Parameters.AddWithValue("@rcT", rodneCislo);

                if(cmdJmeno.ExecuteScalar() != null)
                    {
                    jmenoT.Text = cmdJmeno.ExecuteScalar().ToString();
                    prijmeniT.Text = cmdPrijmeni.ExecuteScalar().ToString();
                    uliceT.Text = cmdUlice.ExecuteScalar().ToString();
                    pscT.Text = cmdPsc.ExecuteScalar().ToString();
                    mestoT.Text = cmdMesto.ExecuteScalar().ToString();
                    telefonT.Text = cmdTelfon.ExecuteScalar().ToString();
                    emailT.Text = cmdEmail.ExecuteScalar().ToString();
                    rcT.Text = cmdRodneCislo.ExecuteScalar().ToString();
                }
                else
                {
                    ClientScript.RegisterStartupScript(Page.GetType(), "alert", "javascript:alert('Uživatel neexistuje pro úpravu.');", true);
                }

                con.Close();
            }
        }
    }
}