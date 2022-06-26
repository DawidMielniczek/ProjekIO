<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KlientOpinia.aspx.cs" Inherits="WypożyczalniaSprzętuFilmowego.Strony.Uzytkownik.KlientOpinia" %>

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
        </ul>

        <form class="">
          <a class="nav-link"  href="<%=Page.ResolveUrl("~/Strony/Logowanie/LogowanieKlient.aspx")%>">Wyloguj</a>
        </form>
      </div>
    </div>
  </nav>
        </div>

<section style="background-color:black"  class="vh-100 gradient-custom">
  <div class="container py-5 h-100" >
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col-12 col-md-8 col-lg-6 col-xl-5">
          <div class="p-5 text-center">

            <div class="mb-md-5 mt-md-4 pb-5" ">

              <h2 class="fw-bold mb-2 text-uppercase" style="color:white">Dodaj opinie</h2>
              <p class="text-white-50 mb-5"> </p>
              <form runat ="server">
              <div class="form-outline form-white mb-4">
                  <asp:TextBox ID="Opinia" Text="Dodaj opinie" Class="form-control" runat="server" TextMode="MultiLine" Rows="9" Width="100%"></asp:TextBox>
                  <label style="color:white;">
                      </div>
                <div id="form-group">
           <label style="color:white;">Zaznacz Ocenę:</label> 
            <asp:DropDownList ID="ddlOcena" runat="server" CssClass="form-control" Width="10%">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
             </asp:DropDownList>
        </div>
                     <asp:button ID="Btn" runat="server" class="btn btn-dark btn-lg btn-block" Text="Dodaj" OnClick="Btn_Click" />
             </form>
            </div>
              <asp:Label ID="txtwynik" runat="server" Text=""></asp:Label>
              
          </div>
        </div>
      </div>
    </div>
  </div>
</section>
</body>
</html>