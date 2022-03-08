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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var login = Request.QueryString["login"];
            var heslo = Request.QueryString["heslo"];
            string lo;
            string he;
            if ((login != null) && (heslo != null))
            {
                lo = login.ToString();
                he = heslo.ToString();


                Response.Write(login);
                if (lo.Contains("admin"))
                {
                    Session["uzivatel"] = lo;
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["darcostvi"].ConnectionString);
                    con.Open();

                    string dotazUziv = "select [login] from [PrihlaseniAdmin] where [login]=@loginT";
                    string dotazHeslo = "select [heslo] from [PrihlaseniAdmin] where [heslo]=@hesloT";

                    SqlCommand cmdLogin = new SqlCommand(dotazUziv, con);
                    SqlCommand cmdHeslo = new SqlCommand(dotazHeslo, con);
                    string l= "",h = "";
                    cmdLogin.Parameters.AddWithValue("@loginT", login);
                    cmdHeslo.Parameters.AddWithValue("@hesloT", he);

                    if ((cmdLogin.ExecuteScalar() != null) && (cmdHeslo.ExecuteScalar() != null))
                    {
                        l = cmdLogin.ExecuteScalar().ToString();
                        h = cmdHeslo.ExecuteScalar().ToString();
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(Page.GetType(), "alert", "javascript:alert('Zadali jste špatné heslo nebo jméne nebo uživatel neexistuje.');", true);
                    }

                    cmdHeslo.Dispose();
                    cmdLogin.Dispose();



                    if (l.Contains(login) && (h.Contains(h)))
                    {
                        Session["login"] = login;
                        Response.Redirect("uprava_mista.aspx");
                    }

                }



                else
                {


                    Session["uzivatel"] = lo;

                    string md5 = CreateMD5(he);

                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["darcostvi"].ConnectionString);
                    con.Open();

                    string dotazUziv = "select [login] from [Prihlaseni] where [login]=@loginT";
                    string dotazHeslo = "select [heslo] from [Prihlaseni] where [heslo]=@hesloT";

                    SqlCommand cmdLogin = new SqlCommand(dotazUziv, con);
                    SqlCommand cmdHeslo = new SqlCommand(dotazHeslo, con);

                    cmdLogin.Parameters.AddWithValue("@loginT", login);
                    cmdHeslo.Parameters.AddWithValue("@hesloT", md5);
                    string l="", h="";
                    if ((cmdLogin.ExecuteScalar() != null) && (cmdHeslo.ExecuteScalar() != null))
                    {

                        l = cmdLogin.ExecuteScalar().ToString();
                        h = cmdHeslo.ExecuteScalar().ToString();
                    }
                    else
                    {

                        ClientScript.RegisterStartupScript(Page.GetType(), "alert", "javascript:alert('Zadali jste špatné heslo nebo jméne nebo uživatel neexistuje.');", true);
                    }
                    cmdHeslo.Dispose();
                    cmdLogin.Dispose();



                    if(h.Contains(md5) && (l.Contains(login)))
                    {

                        Response.Redirect("rezervace.aspx");
                    }
                }

            }


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

    }


    }
