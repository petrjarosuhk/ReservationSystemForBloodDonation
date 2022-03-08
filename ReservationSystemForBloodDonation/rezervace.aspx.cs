using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReservationSystemForBloodDonation
{
    public partial class rezervace : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           uziv.Text = Session["uzivatel"].ToString();

        }

        protected void logOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
            Session["uzivatel"] = null;
        }

        protected void cas_Click(object sender, EventArgs e)
        {
            string idMisto = odberovaMista.SelectedValue;

            Session["mistoKrve"] = idMisto;
            Session["nemocnice"]=odberovaMista.SelectedItem.Text;
            Response.Redirect("datum_cas_odberove_misto_krve.aspx");
        }

        protected void mojeRezervace_Click(object sender, EventArgs e)
        {
            Response.Redirect("moje_rezervace.aspx");
        }
    }
}