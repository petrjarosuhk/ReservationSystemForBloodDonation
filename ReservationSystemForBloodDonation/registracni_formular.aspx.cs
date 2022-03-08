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
    public partial class registracni_formular : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var jm1 = Request.QueryString["roky"];

            Response.Write(jm1);  

            var jm = Request.QueryString["jmeno"];
            var pr = Request.QueryString["prijmeni"];
            var rc = Request.QueryString["rodnecislo"];
            var tl = Request.QueryString["telefon"];
            var em = Request.QueryString["email"];
            var ul = Request.QueryString["ulice"];
            var me = Request.QueryString["mesto"];
            var psc = Request.QueryString["psc"];

            if ((jm != null) && (pr != null) && (rc != null) && (tl != null) && (em != null) && (ul != null) && (me != null) && (psc != null))
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["darcostvi"].ConnectionString);
                con.Open();


                SqlCommand sqlDarci = new SqlCommand("insert into Darci(Id, jmeno,prijmeni,ulice,psc,mesto,telefon,email,rodne_cislo) values(@IdT,@jmenoT, @prijmeniT, @uliceT, @pscT, @mestoT, @telefon" +
                    "T, @emailT, @rodneCisloT)", con);


                Random rnd = new Random();
                int id_darec = rnd.Next(10000);

                sqlDarci.Parameters.AddWithValue("@IdT", id_darec);
                sqlDarci.Parameters.AddWithValue("@jmenoT", jm);
                sqlDarci.Parameters.AddWithValue("@prijmeniT", pr);
                sqlDarci.Parameters.AddWithValue("@uliceT", ul); ;
                sqlDarci.Parameters.AddWithValue("@pscT", psc);
                sqlDarci.Parameters.AddWithValue("@mestoT", me);
                sqlDarci.Parameters.AddWithValue("@telefonT", tl);
                sqlDarci.Parameters.AddWithValue("@emailT", em);
                sqlDarci.Parameters.AddWithValue("@rodneCisloT", rc);




                sqlDarci.ExecuteNonQuery();

                Session["rodneCislo"] = rc.ToString();
                Response.Redirect("muze_byt_darcem_formular.aspx");


            }
        }
    

        protected void registrace_darec_Click(object sender, EventArgs e)
        {
         
         
         

           



              
        }

        protected void login_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}