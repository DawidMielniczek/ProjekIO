<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminGlowna.aspx.cs" Inherits="WypożyczalniaSprzętuFilmowego.Strony.Administrator.AdminGlowna" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
</head>

<body style="background-color:black">
    <!--zdjecie w headerze--->
 <header class="masthead">

     <img src="https://vuegraphy.com/wp-content/uploads/2019/12/Cross-Format-Cameras-and-Lenses-VUE.jpg" />
</header>
    <!--pasek nawigacyjny-->
    <div style="font-family:sans-serif">
    <nav class="navbar navbar-expand-lg navbar-dark  fixed-top" style="font-weight:bold; background-color:black"  aria-label="Eighth navbar example">
    <div class="container">
     <a class="navbar-brand" href="<%=Page.ResolveUrl("~/Strony/Administrator/AdminGlowna.aspx")%>">Strona główna</a>
      <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarsExample07" aria-controls="navbarsExample07" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>

      <div class="collapse navbar-collapse" id="navbarsExample07">
        <ul class="navbar-nav me-auto mb-2 mb-xl-0">
          <li class="nav-item active">
            <!-- poszczególne nazwy .zakladek-->
               
          <li class="nav-item">
          <a class="nav-link" href="<%=Page.ResolveUrl("~/Strony/Administrator/AdminDodajGre.aspx")%>">Dodaj gre</a>
        </li>
        <li class="nav-item active">
          <li class="nav-item">
          <a class="nav-link" href="<%=Page.ResolveUrl("~/Strony/Administrator/AdminUsunGre.aspx")%>">Usuń gre</a>
        </li>
         <li class="nav-item active">
          <li class="nav-item">
          <a class="nav-link" href="<%=Page.ResolveUrl("~/Strony/Administrator/AdminOpinie.aspx")%>">Przęglądaj opinie</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="<%=Page.ResolveUrl("~/Strony/Administrator/AdminUsunKlienta.aspx")%>">Usuń użytkownika</a>
        </li>
        </ul>

        <form class="">
          <a class="nav-link"  href="<%=Page.ResolveUrl("~/Strony/Logowanie/LogowanieAdmin.aspx")%>">Wyloguj</a>
        </form>
      </div>
    </div>
  </nav>
        </div>
    
<section style="color:white; font-family:sans-serif" class="py-5">
  <div class="container">
      <!--opis firmy-->
    <h1 style="font-weight:bold" class="fw-light" >PANEL ADMINISTRATORA</h1>
    <p class="lead">Wybierz jedną z funkcjonalności na pasku nawigacyjnym</p>
  </div>
</section>
</body>
</html>