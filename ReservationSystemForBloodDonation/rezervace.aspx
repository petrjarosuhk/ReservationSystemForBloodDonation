<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rezervace.aspx.cs" Inherits="ReservationSystemForBloodDonation.rezervace" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
          <link href="style.css" rel="stylesheet" type="text/css" />
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
    <form id="form1" method="get" runat="server">
           
  
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
          <a class="nav-link" href="moje_rezervace.aspx">Moje rezervace</a>
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
  
                    <asp:DropDownList ID="odberovaMista" runat="server" Font-Size="Larger" Height="169px" style="margin-left: 470px; margin-top: 94px" Width="353px">  
                        <asp:ListItem Text="Nemocnice Pelhřimov" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Nemocnice Jihlava" Value="2"></asp:ListItem>
                        <asp:ListItem Text="Nemocnice Třebíč" Value="3"></asp:ListItem>
                    </asp:DropDownList> <br/>

           <asp:Button ID="cas" runat="server" class="btn btn-secondary btn-lg btn-block" Text="Přejí pro výběr datumu a času" OnClick="cas_Click"/><br/>
            <asp:Button ID="mojeRezervace" class="btn btn-secondary btn-lg btn-block" runat="server" Text="Moje rezervace" OnClick="mojeRezervace_Click"/>
        </div>

    </form>
</body>
</html>
