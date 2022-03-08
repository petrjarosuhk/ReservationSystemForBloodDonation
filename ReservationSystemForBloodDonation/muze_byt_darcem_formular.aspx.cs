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
    public partial class muze_byt_darcem_formular : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             var vek =  Request.QueryString["vek"];
            var vaha = Request.QueryString["vaha"];
            var mira = Request.QueryString["mira"];
            var ab = Request.QueryString["ab"];
            var al = Request.QueryString["al"];
            var ku = Request.QueryString["ku"];
            var pr = Request.QueryString["pr"];
            var hiv = Request.QueryString["hiv"];
            var zl = Request.QueryString["zl"];
            var ml = Request.QueryString["ml"];
            var dr = Request.QueryString["dr"];
            var mi = Request.QueryString["mi"];


            Response.Write(vek);


            if (((Convert.ToInt32(vek) > 18) && (Convert.ToInt32(vek) < 65)) && (Convert.ToInt32(vaha) > 50) && (zl.ToString() == "Ne") && (ku.ToString() == "Ne") && (al.ToString()== "Ne") && (dr.ToString() == "Ne")

              && (hiv.ToString()  == "Ne") && (ml.ToString() == "Ne") && (mi.ToString() == "Ne"))

              
            {

                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["darcostvi"].ConnectionString);
                con.Open();


                SqlCommand sqlMuzeBytDarcem = new SqlCommand("insert into MuzeBytDarcem(Id, mira,vaha,vek,kurak,alkoholik,abstinent,psychyatricke_chronicke_onemocneni, HIV, malarie, riz" +
                    "" +
                    "ikova_skupina,uk_fr_1980_96_vice_12_mesicu_UK,zloutenka, cislo_darce, rodne_cislo)" +
                    "" +
                    "" +
                    "" +
                    "" +
                    " values(@Id,@mira,@vaha,@vek,@kurak,@alkoholik,@abstinent,@psychyatricke_chronicke_onemocneni,@HIV,@malarie,@riz" +
                    "" +
                    "ikova_skupina,@uk_fr_1980_96_vice_12_mesicu_UK,@zloutenka,@cislo_darce, @rC)", con);

                Random rnd = new Random();
                int cislo_darce = rnd.Next(30000);

                Session["cisloDarce"] = cislo_darce.ToString();

                Random rnd2 = new Random();
                int cislo_darceID = rnd2.Next(10000);

                string rodneC = Session["rodneCislo"].ToString();


                sqlMuzeBytDarcem.Parameters.AddWithValue("@Id", cislo_darceID);
                sqlMuzeBytDarcem.Parameters.AddWithValue("@mira", mira);
                sqlMuzeBytDarcem.Parameters.AddWithValue("@vaha", vaha);
                sqlMuzeBytDarcem.Parameters.AddWithValue("@vek", vek);
                sqlMuzeBytDarcem.Parameters.AddWithValue("@kurak", ku);
                sqlMuzeBytDarcem.Parameters.AddWithValue("@alkoholik", al);
                sqlMuzeBytDarcem.Parameters.AddWithValue("@abstinent", ab);
                sqlMuzeBytDarcem.Parameters.AddWithValue("@psychyatricke_chronicke_onemocneni",pr);
                sqlMuzeBytDarcem.Parameters.AddWithValue("@HIV",hiv);
                sqlMuzeBytDarcem.Parameters.AddWithValue("@malarie",ml);
                sqlMuzeBytDarcem.Parameters.AddWithValue("@rizikova_skupina", dr);
                sqlMuzeBytDarcem.Parameters.AddWithValue("@uk_fr_1980_96_vice_12_mesicu_UK",mi);
                sqlMuzeBytDarcem.Parameters.AddWithValue("@zloutenka", zl);
                sqlMuzeBytDarcem.Parameters.AddWithValue("@cislo_darce", cislo_darce);
                sqlMuzeBytDarcem.Parameters.AddWithValue("@rC", rodneC.ToString());

                sqlMuzeBytDarcem.ExecuteNonQuery();



                SqlCommand sqlCisloDarceMuze = new SqlCommand("insert into CisloDarceMuzeBytDarcem(Id, cislo_darce, muze_byt_darcem) values(@Id,@cislo_darce,@muze_byt_darcem)", con);
                sqlCisloDarceMuze.Parameters.AddWithValue("@Id", cislo_darceID);
                sqlCisloDarceMuze.Parameters.AddWithValue("@cislo_darce", cislo_darce);
                sqlCisloDarceMuze.Parameters.AddWithValue("@muze_byt_darcem", 1);

                sqlCisloDarceMuze.ExecuteNonQuery();

                Response.Redirect("uspesna_registrace.aspx");
            }

       

        }
    }
}