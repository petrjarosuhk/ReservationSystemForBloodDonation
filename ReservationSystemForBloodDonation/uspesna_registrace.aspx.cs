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
    public partial class uspesna_registrace : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string login = Session["cisloDarce"].ToString();
        
            string heslo = Session["rodneCislo"].ToString();


            loginLb.Text = login;
            hesloLbl.Text = heslo;


            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["darcostvi"].ConnectionString);
            con.Open();


            SqlCommand sqlPrihlaseni= new SqlCommand("insert into Prihlaseni(Id,login,heslo) values(@IdT,@loginT, @hesloT)", con);

            string md5 = CreateMD5(heslo);
          
           
            Random rnd = new Random();
            int id_darec = rnd.Next(10000);

            sqlPrihlaseni.Parameters.AddWithValue("@IdT", id_darec);
            sqlPrihlaseni.Parameters.AddWithValue("@loginT", login);
            sqlPrihlaseni.Parameters.AddWithValue("@hesloT", md5);

            sqlPrihlaseni.ExecuteNonQuery();


        }

        public static string CreateMD5(string input)
        {
           
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

              
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        protected void prihlasitSe_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");

        }
    }
}