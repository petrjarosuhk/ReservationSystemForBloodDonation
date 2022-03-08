using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReservationSystemForBloodDonation
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void registrace_Click(object sender, EventArgs e)
        {
            Response.Redirect("registracni_formular.aspx");
        }
    }
}