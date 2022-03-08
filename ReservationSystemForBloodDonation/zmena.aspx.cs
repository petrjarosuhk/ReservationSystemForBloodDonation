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
    public partial class zmena : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string cisloDarce = Session["darec"].ToString();
            string heslo1 = Request.QueryString["heslo1"];
            string heslo2 = Request.QueryString["heslo2"];

            if ((heslo1 != null) && (heslo2 != null))
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["darcostvi"].ConnectionString);
                con.Open();


                if (heslo1 == heslo2)
                {
                    SqlCommand sqldaZmena = new SqlCommand("update Prihlaseni Set heslo=@hesloT where login=" + cisloDarce, con);

                    string md5 = CreateMD5(heslo1);

                    sqldaZmena.Parameters.AddWithValue("@hesloT", md5);
                    sqldaZmena.ExecuteNonQuery();
                    ClientScript.RegisterStartupScript(Page.GetType(), "alert", "javascript:alert('Heslo bylo změněco úspěšně.');", true);
                    Response.Redirect("login.aspx");

                }
                else
                {
                    ClientScript.RegisterStartupScript(Page.GetType(), "alert", "javascript:alert('Hesla nejsou stejná.');", true);
                }

            }

        }

        public static string CreateMD5(string heslo1)
        {

            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(heslo1);
                byte[] hashBytes = md5.ComputeHash(inputBytes);


                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

    }


}