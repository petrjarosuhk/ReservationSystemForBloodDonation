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
    public partial class moje_rezervace : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            uziv.Text = Session["uzivatel"].ToString();
            string cisloDarce = Session["uzivatel"].ToString();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["darcostvi"].ConnectionString);
            con.Open();
            SqlCommand sqlda = new SqlCommand("select Id, datum_odberu, misto_odberu_krve_id, cas_odberu from Rezervace where cislo_darce=@darce", con);
            sqlda.Parameters.AddWithValue("@darce", cisloDarce);
            var rdr = sqlda.ExecuteReader();
            mojeR.DataSource = rdr;
            mojeR.DataBind();
            con.Close();

        }

        protected void logOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
            Session["uzivatel"] = null;
        }

    
    }
}