<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="zmena.aspx.cs" Inherits="ReservationSystemForBloodDonation.zmena" %>

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
        <div>
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
          <a class="nav-link" href="o_projektu.aspx">O projektu</a>
        </li>
       <li class="nav-item">
          <a class="nav-link" href="kontakt.aspx">Kontakt</a>
        </li>
      </ul>
    </div>
  </div>
</nav>
                        <div class="form-outline">
  <input type="password"  style="border:solid 1px black;" id="typeEmail" name="heslo1" class="form-control" />
  <label class="form-label" for="typeEmail"></label>
          <asp:Label ID="Label1" runat="server" style="padding-left:50px;">Zadejte heslo</asp:Label>
</div>
            
            <div class="form-outline">
  <input type="password"  style="border:solid 1px black;" id="typeEmail" name="heslo2" class="form-control" />
  <label class="form-label" for="typeEmail"></label>
              <asp:Label ID="Label2" runat="server" style="padding-left:50px;">Zadejte znovu heslo</asp:Label>
</div>

         <div style="padding-left:50px"> <input type="Submit" class="btn btn-success" value="Aktualizovat heslo" /></div><br/>



        </div>
    </form>
</body>
</html>
