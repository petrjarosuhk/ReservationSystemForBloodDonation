<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="o_projektu.aspx.cs" Inherits="ReservationSystemForBloodDonation.o_projektu" %>

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
          <a class="nav-link" href="o_projektu.aspx">Informace o darování krve</a>
        </li>
       <li class="nav-item">
          <a class="nav-link" href="kontakt.aspx">Kontakt</a>
        </li>
      </ul>
    </div>
  </div>
</nav>

            <h1 style="text-align:center">Informace o darování krve</h1>
            <div style="padding-top:30px;">
            <p style="text-align:center">Darovat krev může každý občan, který splní podmínky pro darování krve. Krev či darovaná plazma může zahránit ne jeden život. V České republice je nedodastek dárců krve 
                statistiky uvádějí až 100 000 nedostatků darců krve. Přitom my jako osoby zpotřebujeme za svůj život průměrně 5 krát krevní transfuzi a 14 krát lék vyrobený z krve. 
                Co se týká komplikovanější operace, kde je potřeba i 10 jednotek krve po 300 mililitrů. Díky stále zložitějším operacím spotřeba krve neustále roste, ale pbohužel počet dárce klesá. 

                Lidská krev, patří mezi ty látky, které nedokážeme prozatím uměle vyrobit. 

            </p>
            <h3  style="text-align:center; color:brown;">Staňte se prosím dárcem, jedním darování můžete zachránit až 4 lidské životy. </h3>

            <p style="text-align:center">Srdce je dutý sval vážící přibližně 300 gramů. Úkolem srdce je udržovat svoji rytmickou činností udržovat krev v pohybu. Srdce je zásobováno vlastním cévním systémem
                ,srdečními věnčitými cévavi. Srdce se stáhne až<h3  style="text-align:center; color:brown;"> 70 krát za minutu a pokaždé vtlačí asi 0,075 litrů krve</h3>
                <p  style="text-align:center">Den co den přepravuje srdce  přibližně</p> 
               <h3  style="text-align:center; color:brown;"> 7500 litrů krve.</h3>

            </p><p style="text-align:center">Jak je vidět už jen z málo informací krev je jedna z nejdůležitjěších částí našeho těla, zjednodušeně řečeno všechny naše orgány jsou důležité, krev obzvlášť.
                Pokud se koukneme na poslední statistiky můžeme vidět minulý rok tedy 2021 bylo registrováno těměř 260 tisíc pravidelných dárců krve. A každý rokem přibude zhruba 
                dalších 30 tisíc. Za jeden odběr se odebere zhruba 470 mililitrů krve.  <h3  style="text-align:center; color:forestgreen">Darování krve může zachránit až 4 lidské životy.</h3>


                </p>
                <div class="list-group">
  <a href="#" class="list-group-item list-group-item-action flex-column align-items-start active">
    <div class="d-flex w-100 justify-content-between">
      <h5 class="mb-1">Krevní skupina</h5>
      <small>AB0</small>
    </div>
    <p class="mb-1">Krevní skupina nebo, také někdy přesněji krevní typ, je popis vlastností červených krvinek jedince, respektivě sacharidů a bílkovin. Nejvýznamnější 
        kritérium pro dělení krve do skupin je tzv. sysém AB0. Lidská krev se dělí podle přítomností antigenů A a B, pro každou skupinu je charakteristická určítá kombinace protilátek vůči chybějícím antigenům.
        </small>
  </a>

                      <a href="#" class="list-group-item list-group-item-action flex-column align-items-start">
    <div class="d-flex w-100 justify-content-between">
      <h5 class="mb-1">Dělení</h5>
      <small class="text-muted">AB0</small>
    </div>
  </a>

  <a href="#" class="list-group-item list-group-item-action flex-column align-items-start">
    <div class="d-flex w-100 justify-content-between">
      <h5 class="mb-1">Krev typu A</h5>
      <small class="text-muted">AB0</small>
    </div>
    <p class="mb-1">Krev typu A, která obsahuje antigen B a protilátky anti-B.</p>
  </a>

  <a href="#" class="list-group-item list-group-item-action flex-column align-items-start">
    <div class="d-flex w-100 justify-content-between">
      <h5 class="mb-1">Krev typu B</h5>
      <small class="text-muted">AB0</small>
    </div>
    <p class="mb-1">Krev typu B, která obsahuje antigen B a protilátky anti-A.</p>
  </a>
    
     <a href="#" class="list-group-item list-group-item-action flex-column align-items-start">
    <div class="d-flex w-100 justify-content-between">
      <h5 class="mb-1">Krev typu AB</h5>
      <small class="text-muted">AB0</small>
    </div>
    <p class="mb-1">Krev typu AB, která obsahuje antigeny A i B a neobsahuje protilátky anti-A ani anti-B.</p>
  </a>

<a href="#" class="list-group-item list-group-item-action flex-column align-items-start">
    <div class="d-flex w-100 justify-content-between">
      <h5 class="mb-1">Krev typu 0</h5>
      <small class="text-muted">AB0</small>
    </div>
    <p class="mb-1">Krev typu 0, která neobsahuje antigeny A ani B a obsahuje protilátky anti-A i anti-B.</p>
  </a>
</div>

                    </div>
        </div>
    </form>
</body>
</html>
