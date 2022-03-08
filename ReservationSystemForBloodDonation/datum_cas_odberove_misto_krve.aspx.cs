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
    public partial class datum_cas_odberove_misto_krve : System.Web.UI.Page
    {
     
        protected void Page_Load(object sender, EventArgs e)
        {
     
              uziv.Text = Session["uzivatel"].ToString();
            nemocniceLbl.Text = Session["nemocnice"].ToString();


        }

        protected void logOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
            Session["uzivatel"] = null;
        }

        protected void cas8_Click(object sender, EventArgs e)
        {
            int pocet = Convert.ToInt32(Session["8"].ToString());
            int kapacita = Convert.ToInt32(Session["kapa"]);
            string datum = Session["datum"].ToString();
            string mistoKrveId = Session["mistoKrve"].ToString();
            string cisloDarce = Session["uzivatel"].ToString();
            int volneMista = kapacita - pocet;
            if (volneMista > 0)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["darcostvi"].ConnectionString);
                con.Open();
                 string mistoID =  Session["mistoKrve"].ToString();
                Random rnd = new Random();
                int idRezervace = rnd.Next(30000);

             
               
      
           
           SqlCommand sqlRezervovatTermin8 = new SqlCommand("insert into Rezervace(Id,datum_odberu,misto_odberu_krve_id,cas_odberu,cislo_darce) values(@Id,@datum_odberu,@misto_odberu_krve_id,@cas_odberu,@cislo_darce)", con);

                sqlRezervovatTermin8.Parameters.AddWithValue("@Id",idRezervace);
                sqlRezervovatTermin8.Parameters.AddWithValue("@datum_odberu",datum);
                sqlRezervovatTermin8.Parameters.AddWithValue("@misto_odberu_krve_id", mistoKrveId);
                sqlRezervovatTermin8.Parameters.AddWithValue("@cas_odberu", "8:00");
                sqlRezervovatTermin8.Parameters.AddWithValue("@cislo_darce", cisloDarce);

                sqlRezervovatTermin8.ExecuteNonQuery();
                Response.Redirect("datum_cas_odberove_misto_krve.aspx");
            }
            if (volneMista <= 0)
            {
                Response.Write("<script>alert('Pro tento termín již není volné místo. Vyberte prosím jiný.');</script>");
            }

        }

        protected void cas9_Click(object sender, EventArgs e)
        {
            int pocet = Convert.ToInt32(Session["9"].ToString());
            int kapacita = Convert.ToInt32(Session["kapa"]);
            string datum = Session["datum"].ToString();
            string mistoKrveId = Session["mistoKrve"].ToString();
            string cisloDarce = Session["uzivatel"].ToString();
            int volneMista = kapacita - pocet;
            if (volneMista > 0)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["darcostvi"].ConnectionString);
                con.Open();
                string mistoID = Session["mistoKrve"].ToString();
                Random rnd = new Random();
                int idRezervace = rnd.Next(30000);





                SqlCommand sqlRezervovatTermin8 = new SqlCommand("insert into Rezervace(Id,datum_odberu,misto_odberu_krve_id,cas_odberu,cislo_darce) values(@Id,@datum_odberu,@misto_odberu_krve_id,@cas_odberu,@cislo_darce)", con);

                sqlRezervovatTermin8.Parameters.AddWithValue("@Id", idRezervace);
                sqlRezervovatTermin8.Parameters.AddWithValue("@datum_odberu", datum);
                sqlRezervovatTermin8.Parameters.AddWithValue("@misto_odberu_krve_id", mistoKrveId);
                sqlRezervovatTermin8.Parameters.AddWithValue("@cas_odberu", "9:00");
                sqlRezervovatTermin8.Parameters.AddWithValue("@cislo_darce", cisloDarce);

                sqlRezervovatTermin8.ExecuteNonQuery();

            }

            if (volneMista <= 0)
            {
                Response.Write("<script>alert('Pro tento termín již není volné místo. Vyberte prosím jiný.');</script>");
            }
        }

        protected void cas10_Click(object sender, EventArgs e)
        {
            int pocet = Convert.ToInt32(Session["10"].ToString());
            int kapacita = Convert.ToInt32(Session["kapa"]);
            string datum = Session["datum"].ToString();
            string mistoKrveId = Session["mistoKrve"].ToString();
            string cisloDarce = Session["uzivatel"].ToString();
            int volneMista = kapacita - pocet;
            if (volneMista > 0)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["darcostvi"].ConnectionString);
                con.Open();
                string mistoID = Session["mistoKrve"].ToString();
                Random rnd = new Random();
                int idRezervace = rnd.Next(30000);





                SqlCommand sqlRezervovatTermin8 = new SqlCommand("insert into Rezervace(Id,datum_odberu,misto_odberu_krve_id,cas_odberu,cislo_darce) values(@Id,@datum_odberu,@misto_odberu_krve_id,@cas_odberu,@cislo_darce)", con);

                sqlRezervovatTermin8.Parameters.AddWithValue("@Id", idRezervace);
                sqlRezervovatTermin8.Parameters.AddWithValue("@datum_odberu", datum);
                sqlRezervovatTermin8.Parameters.AddWithValue("@misto_odberu_krve_id", mistoKrveId);
                sqlRezervovatTermin8.Parameters.AddWithValue("@cas_odberu", "10:00");
                sqlRezervovatTermin8.Parameters.AddWithValue("@cislo_darce", cisloDarce);

                sqlRezervovatTermin8.ExecuteNonQuery();

            }
            if (volneMista <= 0)
            {
                Response.Write("<script>alert('Pro tento termín již není volné místo. Vyberte prosím jiný.');</script>");
            }
        }

        protected void cas11_Click(object sender, EventArgs e)
        {
            int pocet = Convert.ToInt32(Session["11"].ToString());
            int kapacita = Convert.ToInt32(Session["kapa"]);
            string datum = Session["datum"].ToString();
            string mistoKrveId = Session["mistoKrve"].ToString();
            string cisloDarce = Session["uzivatel"].ToString();
            int volneMista = kapacita - pocet;
            if (volneMista > 0)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["darcostvi"].ConnectionString);
                con.Open();
                string mistoID = Session["mistoKrve"].ToString();
                Random rnd = new Random();
                int idRezervace = rnd.Next(30000);





                SqlCommand sqlRezervovatTermin8 = new SqlCommand("insert into Rezervace(Id,datum_odberu,misto_odberu_krve_id,cas_odberu,cislo_darce) values(@Id,@datum_odberu,@misto_odberu_krve_id,@cas_odberu,@cislo_darce)", con);

                sqlRezervovatTermin8.Parameters.AddWithValue("@Id", idRezervace);
                sqlRezervovatTermin8.Parameters.AddWithValue("@datum_odberu", datum);
                sqlRezervovatTermin8.Parameters.AddWithValue("@misto_odberu_krve_id", mistoKrveId);
                sqlRezervovatTermin8.Parameters.AddWithValue("@cas_odberu", "11:00");
                sqlRezervovatTermin8.Parameters.AddWithValue("@cislo_darce", cisloDarce);

                sqlRezervovatTermin8.ExecuteNonQuery();

            }
            if (volneMista <= 0)
            {
                Response.Write("<script>alert('Pro tento termín již není volné místo. Vyberte prosím jiný.');</script>");
            }

        }

        protected void cas12_Click(object sender, EventArgs e)
        {
            int pocet = Convert.ToInt32(Session["12"].ToString());
            int kapacita = Convert.ToInt32(Session["kapa"]);
            string datum = Session["datum"].ToString();
            string mistoKrveId = Session["mistoKrve"].ToString();
            string cisloDarce = Session["uzivatel"].ToString();
            int volneMista = kapacita - pocet;
            if (volneMista > 0)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["darcostvi"].ConnectionString);
                con.Open();
                string mistoID = Session["mistoKrve"].ToString();
                Random rnd = new Random();
                int idRezervace = rnd.Next(30000);





                SqlCommand sqlRezervovatTermin8 = new SqlCommand("insert into Rezervace(Id,datum_odberu,misto_odberu_krve_id,cas_odberu,cislo_darce) values(@Id,@datum_odberu,@misto_odberu_krve_id,@cas_odberu,@cislo_darce)", con);

                sqlRezervovatTermin8.Parameters.AddWithValue("@Id", idRezervace);
                sqlRezervovatTermin8.Parameters.AddWithValue("@datum_odberu", datum);
                sqlRezervovatTermin8.Parameters.AddWithValue("@misto_odberu_krve_id", mistoKrveId);
                sqlRezervovatTermin8.Parameters.AddWithValue("@cas_odberu", "12:00");
                sqlRezervovatTermin8.Parameters.AddWithValue("@cislo_darce", cisloDarce);

                sqlRezervovatTermin8.ExecuteNonQuery();

            }
            if (volneMista <= 0)
            {
                Response.Write("<script>alert('Pro tento termín již není volné místo. Vyberte prosím jiný.');</script>");
            }
        }

        protected void cas13_Click(object sender, EventArgs e)
        {
            int pocet = Convert.ToInt32(Session["13"].ToString());
            int kapacita = Convert.ToInt32(Session["kapa"]);
            string datum = Session["datum"].ToString();
            string mistoKrveId = Session["mistoKrve"].ToString();
            string cisloDarce = Session["uzivatel"].ToString();
            int volneMista = kapacita - pocet;
            if (volneMista > 0)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["darcostvi"].ConnectionString);
                con.Open();
                string mistoID = Session["mistoKrve"].ToString();
                Random rnd = new Random();
                int idRezervace = rnd.Next(30000);





                SqlCommand sqlRezervovatTermin8 = new SqlCommand("insert into Rezervace(Id,datum_odberu,misto_odberu_krve_id,cas_odberu,cislo_darce) values(@Id,@datum_odberu,@misto_odberu_krve_id,@cas_odberu,@cislo_darce)", con);

                sqlRezervovatTermin8.Parameters.AddWithValue("@Id", idRezervace);
                sqlRezervovatTermin8.Parameters.AddWithValue("@datum_odberu", datum);
                sqlRezervovatTermin8.Parameters.AddWithValue("@misto_odberu_krve_id", mistoKrveId);
                sqlRezervovatTermin8.Parameters.AddWithValue("@cas_odberu", "13:00");
                sqlRezervovatTermin8.Parameters.AddWithValue("@cislo_darce", cisloDarce);

                sqlRezervovatTermin8.ExecuteNonQuery();

            }
            if (volneMista <= 0)
            {
                Response.Write("<script>alert('Pro tento termín již není volné místo. Vyberte prosím jiný.');</script>");
            }

        }

        protected void cas14_Click(object sender, EventArgs e)
        {
            int pocet = Convert.ToInt32(Session["14"].ToString());
            int kapacita = Convert.ToInt32(Session["kapa"]);
            string datum = Session["datum"].ToString();
            string mistoKrveId = Session["mistoKrve"].ToString();
            string cisloDarce = Session["uzivatel"].ToString();
            int volneMista = kapacita - pocet;
            if (volneMista > 0)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["darcostvi"].ConnectionString);
                con.Open();
                string mistoID = Session["mistoKrve"].ToString();
                Random rnd = new Random();
                int idRezervace = rnd.Next(30000);





                SqlCommand sqlRezervovatTermin8 = new SqlCommand("insert into Rezervace(Id,datum_odberu,misto_odberu_krve_id,cas_odberu,cislo_darce) values(@Id,@datum_odberu,@misto_odberu_krve_id,@cas_odberu,@cislo_darce)", con);

                sqlRezervovatTermin8.Parameters.AddWithValue("@Id", idRezervace);
                sqlRezervovatTermin8.Parameters.AddWithValue("@datum_odberu", datum);
                sqlRezervovatTermin8.Parameters.AddWithValue("@misto_odberu_krve_id", mistoKrveId);
                sqlRezervovatTermin8.Parameters.AddWithValue("@cas_odberu", "14:00");
                sqlRezervovatTermin8.Parameters.AddWithValue("@cislo_darce", cisloDarce);

                sqlRezervovatTermin8.ExecuteNonQuery();

            }
            if (volneMista <= 0)
            {
                Response.Write("<script>alert('Pro tento termín již není volné místo. Vyberte prosím jiný.');</script>");
            }

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
       
            string datum = Calendar1.SelectedDate.ToString();
    
            Session["datum"] = datum;
      
            string mistoId = Session["mistoKrve"].ToString();
            int misto = Convert.ToInt32(mistoId);
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["darcostvi"].ConnectionString);
             con.Open();
            string kapacitaSql = "select kapacita from OdberoveMistoKrve where Id=@Id";
            SqlCommand cmdKapacita = new SqlCommand(kapacitaSql, con);
            cmdKapacita.Parameters.AddWithValue("@Id", misto);
            int kapacita = Convert.ToInt32(cmdKapacita.ExecuteScalar());
            Session["kapa"] = kapacita.ToString();
            Response.Write(kapacita);
            string cas = "8:00";
            string sqldaVolnost8hodin = "select COUNT(Id) from Rezervace where datum_odberu=@datum and cas_odberu=@cas and misto_odberu_krve_id=@misto";
            SqlCommand cmd = new SqlCommand(sqldaVolnost8hodin, con);

            cmd.Parameters.AddWithValue("@datum", datum);
            cmd.Parameters.AddWithValue("@cas",cas);
            cmd.Parameters.AddWithValue("@misto", mistoId);


           int pocet = Convert.ToInt32(cmd.ExecuteScalar());
            Session["8"] = pocet.ToString();
            Response.Write(pocet);
           kapacita8.Text = (kapacita - pocet).ToString() + " volných z " + kapacita;


            string cas9 = "9:00";
            string sqldaVolnost9hodin = "select COUNT(Id) from Rezervace where datum_odberu=@datum and cas_odberu=@cas and misto_odberu_krve_id=@misto";
            SqlCommand cmd9 = new SqlCommand(sqldaVolnost9hodin, con);

            cmd9.Parameters.AddWithValue("@datum", datum);
            cmd9.Parameters.AddWithValue("@cas", cas9);
            cmd9.Parameters.AddWithValue("@misto", mistoId);
     

            int pocet9 = Convert.ToInt32(cmd9.ExecuteScalar());
            Session["9"] = pocet9.ToString();
            Response.Write(pocet9);
            kapacita9.Text = (kapacita - pocet9).ToString() + " volných z " + kapacita;


            string cas10 = "10:00";
            string sqldaVolnost10hodin = "select COUNT(Id) from Rezervace where datum_odberu=@datum and cas_odberu=@cas and misto_odberu_krve_id=@misto";
            SqlCommand cmd10 = new SqlCommand(sqldaVolnost10hodin, con);

            cmd10.Parameters.AddWithValue("@datum", datum);
            cmd10.Parameters.AddWithValue("@cas", cas10);
            cmd10.Parameters.AddWithValue("@misto", mistoId);
  
   
            int pocet10 = Convert.ToInt32(cmd10.ExecuteScalar());
            Session["10"] = pocet10.ToString();
            Response.Write(pocet10);
            kapacita10.Text = (kapacita - pocet10).ToString() + " volných z " + kapacita;



            string cas11 = "11:00";
            string sqldaVolnost11hodin = "select COUNT(Id) from Rezervace where datum_odberu=@datum and cas_odberu=@cas and misto_odberu_krve_id=@misto";
            SqlCommand cmd11 = new SqlCommand(sqldaVolnost11hodin, con);

            cmd11.Parameters.AddWithValue("@datum", datum);
            cmd11.Parameters.AddWithValue("@cas", cas11);
            cmd11.Parameters.AddWithValue("@misto", mistoId);


            int pocet11 = Convert.ToInt32(cmd11.ExecuteScalar());
            Response.Write(pocet11);
            Session["11"] = pocet11.ToString();
            kapacita11.Text = (kapacita - pocet11).ToString() + " volných z " + kapacita;


            string cas12 = "12:00";
            string sqldaVolnost12hodin = "select COUNT(Id) from Rezervace where datum_odberu=@datum and cas_odberu=@cas and misto_odberu_krve_id=@misto";
            SqlCommand cmd12 = new SqlCommand(sqldaVolnost12hodin, con);

            cmd12.Parameters.AddWithValue("@datum", datum);
            cmd12.Parameters.AddWithValue("@cas", cas12);
            cmd12.Parameters.AddWithValue("@misto", mistoId);
 

            int pocet12 = Convert.ToInt32(cmd12.ExecuteScalar());
            Session["12"] = pocet12.ToString();
            Response.Write(pocet12);
            kapacita12.Text = (kapacita - pocet12).ToString() + " volných z " + kapacita;


            string cas13 = "13:00";
            string sqldaVolnost13hodin = "select COUNT(Id) from Rezervace where datum_odberu=@datum and cas_odberu=@cas and misto_odberu_krve_id=@misto";
            SqlCommand cmd13 = new SqlCommand(sqldaVolnost13hodin, con);

            cmd13.Parameters.AddWithValue("@datum", datum);
            cmd13.Parameters.AddWithValue("@cas", cas13);
            cmd13.Parameters.AddWithValue("@misto", mistoId);
     

            int pocet13 = Convert.ToInt32(cmd13.ExecuteScalar());
            Response.Write(pocet13);


            kapacita13.Text = (kapacita - pocet13).ToString() + " volných z " + kapacita;
            Session["13"] = pocet12.ToString();

            string cas14 = "14:00";
            string sqldaVolnost14hodin = "select COUNT(Id) from Rezervace where datum_odberu=@datum and cas_odberu=@cas and misto_odberu_krve_id=@misto";
            SqlCommand cmd14 = new SqlCommand(sqldaVolnost14hodin, con);

            cmd14.Parameters.AddWithValue("@datum", datum);
            cmd14.Parameters.AddWithValue("@cas", cas14);
            cmd14.Parameters.AddWithValue("@misto", mistoId);
     

            int pocet14 = Convert.ToInt32(cmd14.ExecuteScalar());
            Session["14"] = pocet14.ToString();
            Response.Write(pocet14);
            kapacita14.Text = (kapacita - pocet14).ToString() + " volných z "+ kapacita;

           


        }

        protected void zpetVyber_Click(object sender, EventArgs e)
        {
            Response.Redirect("rezervace.aspx");
        }
    }
}