<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="datum_cas_odberove_misto_krve.aspx.cs" Inherits="ReservationSystemForBloodDonation.datum_cas_odberove_misto_krve" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

            <link
  href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css"
  rel="stylesheet"
/>
<!-- Google Fonts -->
<link
  href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700&display=swap"
  rel="stylesheet"
/>
<!-- MDB -->
<link
  href="https://cdnjs.cloudflare.com/ajax/libs/mdb-ui-kit/3.10.2/mdb.min.css"
  rel="stylesheet"
/>
</head>
      


<body>
    <form id="form1" runat="server">
                <nav  class="navbar navbar-expand-lg navbar-light bg-light" >
  <div class="container-fluid">
    <a class="navbar-brand" href="Index.aspx">Domů</a>
    <button
      class="navbar-toggler"
      type="button"
      data-mdb-toggle="collapse"
      data-mdb-target="#navbarNav"
      aria-controls="navbarNav"
      aria-expanded="false"
      aria-label="Toggle navigation"
    >
      <i class="fas fa-bars"></i>
    </button>
    <div class="collapse navbar-collapse" id="navbarNav">
      <ul class="navbar-nav">
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="registracni_formular.aspx">Registrovat se</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="rezervace.aspx">Výběr místa darování krve</a>
        </li>
            <li class="nav-item">
          <a class="nav-link" href="moje_rezervace.aspx">Zobrazit moje rezervace</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="o_projektu.aspx">O projektu</a>
        </li>
       <li class="nav-item">
          <a class="nav-link" href="kontakt.aspx">Kontakt</a>
        </li>
      </ul>
    </div>
  </div>
</nav>

        <div>
                Uživatel: <asp:Label ID="uziv" runat="server"></asp:Label><br/>
            <asp:Button ID="logOut" runat="server" class="btn btn-danger" Text="Odhlásit se" OnClick="logOut_Click"/><br/>
           Rezervujete termín pro odběrové místo:<asp:Label ID="nemocniceLbl" runat="server"></asp:Label><br/>

     <div style="width:50%; align-content:center; margin: 0 auto;">
             <asp:Calendar  ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged">
              </asp:Calendar></div>
            <br/>

                 <asp:Button  ID="cas8"  runat="server" Text="8:00-9:00" class="btn btn-primary btn-lg btn-block" OnClick="cas8_Click"/><div><asp:Label style="padding-left:30px" ID="kapacita8" class="text-success" runat="server"></asp:Label></div>  <br/>       
                 <asp:Button ID="cas9" runat="server" Text="9:00-10:00" class="btn btn-primary btn-lg btn-block" OnClick="cas9_Click"/><div  ><asp:Label  style="padding-left:30px" ID="kapacita9"  class="text-success" runat="server"></asp:Label></div>  <br/>     
                 <asp:Button ID="cas10" runat="server" Text="10:00-11:00" class="btn btn-primary btn-lg btn-block" OnClick="cas10_Click"/><div><asp:Label style="padding-left:30px"  ID="kapacita10"  class="text-success" runat="server"></asp:Label>  <br/>  </div>   
                 <asp:Button ID="cas11" runat="server" Text="11:00-12:00" class="btn btn-primary btn-lg btn-block" OnClick="cas11_Click"/><div ><asp:Label style="padding-left:30px"  ID="kapacita11"  class="text-success" runat="server"></asp:Label>  <br/>   </div>  
                 <asp:Button ID="cas12" runat="server" Text="12:00-13:00" class="btn btn-primary btn-lg btn-block" OnClick="cas12_Click"/><div ><asp:Label style="padding-left:30px"  ID="kapacita12" class="text-success" runat="server"></asp:Label>  <br/>  </div>   
                 <asp:Button ID="cas13" runat="server" Text="13:00-14:00" class="btn btn-primary btn-lg btn-block" OnClick="cas13_Click"/><div  ><asp:Label style="padding-left:30px"  ID="kapacita13"  class="text-success" runat="server"></asp:Label>  <br/> </div>    
                <asp:Button ID="cas14" runat="server" Text="14:00-15:00" class="btn btn-primary btn-lg btn-block" OnClick="cas14_Click"/><div ><asp:Label style="padding-left:30px"  ID="kapacita14"  class="text-success" runat="server"></asp:Label>  <br/> </div>
            
             <asp:Button id="zpetVyber" runat="server" class="btn btn-secondary btn-lg" Text="Zpět na výber odběrového místa" OnClick="zpetVyber_Click" /><br/>
           
        </div>

       
    </form>

     <script
  type="text/javascript"
  src="https://cdnjs.cloudflare.com/ajax/libs/mdb-ui-kit/3.10.2/mdb.min.js"
></script>
</body>
</html>
