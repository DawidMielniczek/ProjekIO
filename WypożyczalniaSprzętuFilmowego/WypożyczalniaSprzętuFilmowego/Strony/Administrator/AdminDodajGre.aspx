<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDodajGre.aspx.cs" Inherits="WypożyczalniaSprzętuFilmowego.Strony.Administrator.AdminDodajGre" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
</head>

<body style="background-color:black; color:white; font-family:sans-serif ">
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
    
<section class="py-5">
  <div class="container">
      <h2 style="text-align:center" class="fw-bold mb-2 text-uppercase">Dodaj nowy sprzęt</h2><br />
      
      <form runat ="server">
              <div class="form-outline form-white mb-4">
                  <center>
                       <label style="color:white;"> Nazwa gry</label>&nbsp;
                  <asp:TextBox ID="Txt1" runat="server" class="form-control form-control-lg" Width="500px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                 <br />
                      <label style="color:white;"> Dostępność</label><br />
                  <asp:TextBox ID="Txt2" runat="server" class="form-control form-control-lg" Width="500px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                  
                 
            </center>
                  </div>
         <center>
                     <asp:button ID="Btn" runat="server" class="btn btn-dark btn-lg btn-block" Text="Dodaj" />
          </center>
             </form>
  </div>
      
</section>
</body>
</html>