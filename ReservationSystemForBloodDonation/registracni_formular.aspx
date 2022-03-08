<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registracni_formular.aspx.cs" Inherits="ReservationSystemForBloodDonation.registracni_formular" %>

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
    <form id="registracni_formular"  class="mx-1 mx-md-4" method="get" runat="server">

           


        <div>
             <h1>Registrační fomurlář prvně vyplňtě základní údaje a poté klikněte na registraci</h1>
        
<section class="vh-100" style="background-color: #eee;">
  <div class="container h-100">
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col-lg-12 col-xl-11">
        <div class="card text-black" style="border-radius: 25px;">
          <div class="card-body p-md-5">
            <div class="row justify-content-center">
              <div class="col-md-10 col-lg-6 col-xl-5 order-2 order-lg-1">

                <p class="text-center h1 fw-bold mb-5 mx-1 mx-md-4 mt-4">Registrovat se</p>

                   <div class="d-flex flex-row align-items-center mb-4">
                    <i class="fas fa-user fa-lg me-3 fa-fw"></i>
                    <div class="form-outline flex-fill mb-0">
                      
                      <input type="text" id="form3Example1c0" name="jmeno" style="border:solid 1px black;"  class ="form-control" />
                  <label class="form-label" for="form3Example1c"></label>
                    Jméno
                    
                    </div>
                  </div>
                      <div class="d-flex flex-row align-items-center mb-4">
                    <i class="fas fa-user fa-lg me-3 fa-fw"></i>
                    <div class="form-outline flex-fill mb-0" >
                      <input type="text" id="form3Example110c" name="prijmeni" style="border:solid 1px black;" class="form-control" />
                      <label class="form-label" for="form3Example1c" ></label>
                        Příjmení
                    </div>
                  </div>
                      <div class="d-flex flex-row align-items-center mb-4">
                    <i class="fas fa-user fa-lg me-3 fa-fw"></i>
                    <div class="form-outline flex-fill mb-0">
                      <input type="text" id="form3Exampl010e1c"name="rodnecislo" style="border:solid 1px black;" class="form-control" />
                      <label class="form-label" for="form3Example1c"></label>
                        Rodné číslo bez lomítka
                    </div>
                  </div>
                      <div class="d-flex flex-row align-items-center mb-4">
                    <i class="fas fa-user fa-lg me-3 fa-fw"></i>
                    <div class="form-outline flex-fill mb-0">
                      <input type="text" id="form3Ex010ample1c"name="ulice" style="border:solid 1px black;" class="form-control" />
                      <label class="form-label" for="form3Example1c" ></label>
                        Ulice včetně čísla popisného
                    </div>
                  </div>
                      <div class="d-flex flex-row align-items-center mb-4">
                    <i class="fas fa-user fa-lg me-3 fa-fw"></i>
                    <div class="form-outline flex-fill mb-0">
                      <input type="text" id="form300101Example1c"name="psc" style="border:solid 1px black;"  class="form-control" />
                      <label class="form-label" for="form3Example1c"></label>
                        PSČ
                    </div>
                  </div>

                            <div class="d-flex flex-row align-items-center mb-4">
                    <i class="fas fa-user fa-lg me-3 fa-fw"></i>
                    <div class="form-outline flex-fill mb-0">
                      <input type="text" id="form300101Example1c"name="mesto" style="border:solid 1px black;"  class="form-control" />
                      <label class="form-label" for="form3Example1c"></label>
                       Město
                    </div>
                  </div>


                  <div class="d-flex flex-row align-items-center mb-4">
                    <i class="fas fa-user fa-lg me-3 fa-fw"></i>
                    <div class="form-outline flex-fill mb-0">
                      <input type="text" id="form0103Example1c" name="telefon" style="border:solid 1px black;" class="form-control" />
                      <label class="form-label" for="form3Example1c"></label>
                        Telefon
                    </div>
                  </div>

                   <div class="d-flex flex-row align-items-center mb-4">
                    <i class="fas fa-user fa-lg me-3 fa-fw"></i>
                    <div class="form-outline flex-fill mb-0">
                      <input type="email" id="form0103Example1c" name="email" style="border:solid 1px black;" class="form-control" />
                      <label class="form-label" for="form3Example1c"></label>
                       Email
                    </div>
                  </div>

  

                  <div class="form-check d-flex justify-content-center mb-5">
                    <input
                      class="form-check-input me-2"
                      type="checkbox"
                      value=""
                      id="form2Example3c"
                    />
                    <label class="form-check-label" for="form2Example3">
                     Souhlasím se zpracování osobních údajů.
                    </label>
                  </div>

                  <div class="d-flex justify-content-center mx-4 mb-3 mb-lg-4">
                   <input type="Submit" value="Registrovat se" /><br/>
                  </div>

               

              </div>
              <div class="col-md-10 col-lg-6 col-xl-7 d-flex align-items-center order-1 order-lg-2">

                <img src="https://i.imgur.com/EO9bwFi.jpg" style="border:3px solid black;" class="img-fluid" alt="Sample image">

              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</section>
        
      
        </form>

</body>
</html>
