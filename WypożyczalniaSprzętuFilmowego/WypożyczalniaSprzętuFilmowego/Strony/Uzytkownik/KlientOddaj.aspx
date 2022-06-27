<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KlientOddaj.aspx.cs" Inherits="WypożyczalniaSprzętuFilmowego.Strony.Uzytkownik.KlientOddaj" %>

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
       <a class="navbar-brand" href="<%=Page.ResolveUrl("~/Strony/Uzytkownik/KlientGlowna.aspx")%>">Strona główna</a>
      <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarsExample07" aria-controls="navbarsExample07" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>

      <div class="collapse navbar-collapse" id="navbarsExample07">
        <ul class="navbar-nav me-auto mb-2 mb-xl-0">
          <li class="nav-item active">
            <!-- poszczególne nazwy .zakladek-->
          <a class="nav-link" href="<%=Page.ResolveUrl("~/Strony/Uzytkownik/KlientAktualne.aspx")%>">Twoje wypożyczenia</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="<%=Page.ResolveUrl("~/Strony/Uzytkownik/KlientDostepne.aspx")%>">Dostępne produkty</a>
        </li>       
          <li class="nav-item">
          <a class="nav-link" href="<%=Page.ResolveUrl("~/Strony/Uzytkownik/KlientOpinia.aspx")%>">Dodaj opinie</a>
        </li>   
           <li class="nav-item">
          <a class="nav-link" href="<%=Page.ResolveUrl("~/Strony/Uzytkownik/KlientWypo.aspx")%>">Wypożycz</a>
        </li>
          <li class="nav-item">
          <a class="nav-link" href="<%=Page.ResolveUrl("~/Strony/Uzytkownik/KlientOddaj.aspx")%>">Zwróć</a>
        </li>
        </ul>
        <form class="">
          <a class="nav-link"  href="<%=Page.ResolveUrl("~/Strony/Logowanie/LogowanieKlient.aspx")%>">Wyloguj</a>
        </form>
      </div>
    </div>
  </nav>
        </div>
    
<section style="color:white; font-family:sans-serif" class="py-5">
    <form runat="server">
      <div class="container">
          <!--rozpiska dostepnych produktów-->
         <h2 style="text-align:center;">Zwróć wypożyczony Sprzęt</h2>
          <br />
          <asp:GridView style="color:white; font-family:sans-serif" cssClass="table" ID="gvSprzet" runat="server"></asp:GridView>
      </div>
    </section>
    <section class="py-5">   
            <div>
        <div class="container">
            <label Style="color:white;">Podaj Id Sprzętu:
            </label>
            <br />
        <asp:TextBox ID="TxtId" runat="server"   Width="4%"></asp:TextBox><br />
            <br />
            <div>
          <asp:button ID="OddajS" runat="server" class="btn btn-dark btn-lg btn-block" Text="Zwróć Sprzęt!" OnClick="wypozyczbt_Click"  />
            </div>
        </div>
        </div>
    </form>
    
</section>
    
</body>
</html>
