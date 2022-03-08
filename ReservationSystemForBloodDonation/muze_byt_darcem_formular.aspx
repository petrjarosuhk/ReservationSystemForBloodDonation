<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="muze_byt_darcem_formular.aspx.cs" Inherits="ReservationSystemForBloodDonation.muze_byt_darcem_formular" %>

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
    <form id="muze_byt_darcem" method="get"  runat="server">

           
    
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

        <div>
           <h1>Ověření zda osoba je adekvátní pro darování krve</h1>
            <h3>Vyplňujte pouze pravdivé informace. Formulář bude dále přezkoumán posudkovým lékařem.</h3>

          <div class="d-flex flex-row align-items-center mb-4">
                    <i class="fas fa-user fa-lg me-3 fa-fw"></i>
                    <div class="form-outline flex-fill mb-0">
                      <input type="text" id="form300101Example1c"name="vaha" style="border:solid 1px black;"  class="form-control" />
                      <label class="form-label" for="form3Example1c"></label>
                       Jaká je Vaše váha? 
                    </div>
                  </div>

            
          <div class="d-flex flex-row align-items-center mb-4">
                    <i class="fas fa-user fa-lg me-3 fa-fw"></i>
                    <div class="form-outline flex-fill mb-0">
                      <input type="text" id="form300101Example1c"name="mira" style="border:solid 1px black;"  class="form-control" />
                      <label class="form-label" for="form3Example1c"></label>
                       Jaká je Vaše míra v cm?
                    </div>
                  </div>

            
          <div class="d-flex flex-row align-items-center mb-4">
                    <i class="fas fa-user fa-lg me-3 fa-fw"></i>
                    <div class="form-outline flex-fill mb-0">
                      <input type="text" id="form300101Example1c" name="vek" style="border:solid 1px black;"  class="form-control" />
                      <label class="form-label" for="form3Example1c"></label>
                       Jaký je Váš věk?
                    </div>
                  </div>

  <input class="form-check-input" type="radio" value="Ano" name="al" id="flexRadioDefault1"/>
  <label class="form-check-label" for="flexRadioDefault1">Ano</label>
</div>
   

<div class="form-check">
  <input class="form-check-input" type="radio" value="Ne" name="al" id="flexRadioDefault2" checked/>
  <label class="form-check-label" for="flexRadioDefault2">Ne</label>
</div>
         Jste alkoholik?


    
  <input class="form-check-input" type="radio" value="Ano" name="ku" id="flexRadioDefault1"/>
  <label class="form-check-label" for="flexRadioDefault1">Ano</label>
</div>
   

<div class="form-check">
  <input class="form-check-input" type="radio" value="Ne" name="ku" id="flexRadioDefault2" checked/>
  <label class="form-check-label" for="flexRadioDefault2">Ne</label>
</div>
         Jste kuřák?

               <div class="form-check">
  <input class="form-check-input" type="radio" value="Ano" name="ab" id="flexRadioDefault1"/>
  <label class="form-check-label" for="flexRadioDefault1">Ano</label>
</div>
   

<div class="form-check">
  <input class="form-check-input" type="radio" value="Ne" name="ab" id="flexRadioDefault2" checked/>
  <label class="form-check-label" for="flexRadioDefault2">Ne</label>
</div>
         Jste abstinent?


            
            <div class="form-check">
  <input class="form-check-input" type="radio" value="Ano" name="pr" id="flexRadioDefault1"/>
  <label class="form-check-label" for="flexRadioDefault1">Ano</label>
</div>
   

<div class="form-check">
  <input class="form-check-input" type="radio" value="Ne" name="pr" id="flexRadioDefault2" checked/>
  <label class="form-check-label" for="flexRadioDefault2">Ne</label>
</div>
         Trpíte chronickými nebo psychickými problémy?
            <div class="form-check">
  <input class="form-check-input" type="radio" value="Ano" name="hiv" id="flexRadioDefault1"/>
  <label class="form-check-label" for="flexRadioDefault1">Ano</label>
</div>
   

<div class="form-check">
  <input class="form-check-input" type="radio" value="Ne" name="hiv" id="flexRadioDefault2" checked/>
  <label class="form-check-label" for="flexRadioDefault2">Ne</label>
</div>
         Jste HIV pozitivní?

            
             <div class="form-check">
  <input class="form-check-input" type="radio" value="Ano" name="zl" id="flexRadioDefault1"/>
  <label class="form-check-label" for="flexRadioDefault1">Ano</label>
</div>
   

<div class="form-check">
  <input class="form-check-input" type="radio" value="Ne" name="zl" id="flexRadioDefault2" checked/>
  <label class="form-check-label" for="flexRadioDefault2">Ne</label>
</div>
        Prodělal jste žloutenku typu B nebo C?

            
                 <div class="form-check">
  <input class="form-check-input" type="radio" value="Ano" name="ml" id="flexRadioDefault1"/>
  <label class="form-check-label" for="flexRadioDefault1">Ano</label>
</div>
   

<div class="form-check">
  <input class="form-check-input" type="radio" value="Ne" name="ml" id="flexRadioDefault2" checked/>
  <label class="form-check-label" for="flexRadioDefault2">Ne</label>
</div>
         Prodělal jste malárii?

                   <div class="form-check">
  <input class="form-check-input" type="radio" value="Ano" name="dr" id="flexRadioDefault1"/>
  <label class="form-check-label" for="flexRadioDefault1">Ano</label>
</div>
   

<div class="form-check">
  <input class="form-check-input" type="radio" value="Ne" name="dr" id="flexRadioDefault2" checked/>
  <label class="form-check-label" for="flexRadioDefault2">Ne</label>
</div>
         Patříte do rizikové skupiny? (promiskuitní způsob života, uživatel drog)

            
            <div class="form-check">
  <input class="form-check-input" type="radio" value="Ano" name="mi" id="flexRadioDefault1"/>
  <label class="form-check-label" for="flexRadioDefault1">Ano</label>
</div>
   

<div class="form-check">
  <input class="form-check-input" type="radio" value="Ne" name="mi" id="flexRadioDefault2" checked/>
  <label class="form-check-label" for="flexRadioDefault2">Ne</label>
</div>
        Byl jste více, jak 12 měsíců v letech 1980-1996 v Anglii nebo ve Francii?

                 <div class="d-flex justify-content-center mx-4 mb-3 mb-lg-4">
                   <input type="Submit" value="Registrovat se" /><br/>
                  </div>
                </div>
        
    </form>
</body>
</html>
