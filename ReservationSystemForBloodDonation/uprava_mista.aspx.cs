using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReservationSystemForBloodDonation
{
    public partial class uprava_mista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            login.Text = Session["login"].ToString();

        }

        protected void vyhledat_Click(object sender, EventArgs e)
        {
            Session["cislo"] = darec.Text;
            Response.Redirect("upravit_rezervaci.aspx");
      
        }

        protected void zmenit_udaje_Click(object sender, EventArgs e)
        {
            Session["cislodarce"] = cislodarce2.Text; 
            Response.Redirect("upravit_darce");
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Session["rodnecislo5"] = rodneCislo3.Text;
            Response.Redirect("dulezite_informace.aspx");
        }

        protected void odhlasitSe_Click(object sender, EventArgs e)
        {
            Session["login"] = null;

            Response.Redirect("Index.aspx");

        }
    }
}