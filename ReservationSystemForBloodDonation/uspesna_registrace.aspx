<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="uspesna_registrace.aspx.cs" Inherits="ReservationSystemForBloodDonation.uspesna_registrace" %>

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
          <a class="nav-link" href="login.aspx">Přihlásit se</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="o_projektu.aspx">Informace o darování krve</a>
        </li>
       <li class="nav-item">
          <a class="nav-link" href="kontakt.aspx">Kontakt</a>
        </li>
      </ul>
    </div>
  </div>
</nav>

        <div>
            <h1>Vaše registrace proběhla v pořádku.</h1><br/>
            <h3>Nyní se můžete přihlásit na konrkétní termín pomocí čísla dárce a hesla, které je Vaše rodné číslo. Heslo doporučujeme změnit. Přihlašovací údaje byly uaslány na Váš email.</h3> <br/>


            Login:<asp:Label ID="loginLb" runat="server"></asp:Label><br/>
            Heslo:<asp:Label ID="hesloLbl" runat="server"></asp:Label><br/>

            <asp:Button ID="prihlasitSe" runat="server" Text="Přihlásit se" OnClick="prihlasitSe_Click"/><br/>


        </div>
    </form>
</body>
</html>
