<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogowanieAdmin.aspx.cs" Inherits="WypożyczalniaSprzętuFilmowego.Strony.Logowanie.LogowanieAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
</head>
<body class="bg-dark">    
    <section class="vh-100" style="background-color: 	#000000">
  <div class="container py-5 h-100">
      
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col col-xl-10">
        <div class="card" style="border-radius: 1rem;">
          <div class="row g-0">
            <div class="col-md-6 col-lg-5 d-none d-md-block">
              <img src="https://i.pinimg.com/736x/5f/d0/9f/5fd09f2609cb0fa5716ddbe0ecd0d5db--vintage-phone-wallpaper-camera-wallpaper.jpg"
                alt="login form" class="img-fluid" style="border-radius: 1rem 0 0 1rem;" />
            </div>
            <div class="col-md-6 col-lg-7 d-flex align-items-center">
              <div class="card-body p-4 p-lg-5 text-black">

                <form runat="server">
                                    
                  <h5 class="fw-normal mb-3 pb-3" style="letter-spacing: 1px;">PANEL ADMINISTRATORA</h5>

                  <div class="form-outline mb-4">
                    <asp:TextBox runat="server" type="email" id="TxtloginA" class="form-control form-control-lg" />
                    <label class="form-label" for="wpiszloginA">Adres email:</label>
                  </div>

                  <div class="form-outline mb-4">
                    <asp:TextBox runat="server" type="password" id="TxthasloA" class="form-control form-control-lg" />
                    <label class="form-label" for="wpiszhasloA">Hasło:</label>
                  </div>

                  <div class="pt-1 mb-4">
                    <asp:button runat="server" ID="Btn" class="btn btn-dark btn-lg btn-block" Text="Zaloguj"  />
                  </div>

                    <asp:Label ID="txtwynik" runat="server" Text=""></asp:Label>
                  <a class="small text-muted" href="<%=Page.ResolveUrl("~/Strony/Logowanie/LogowanieKlient.aspx")%>">Zabłądziłeś? Jesteś użytkownikiem?</a>
                  
                </form>

              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</section>
</body>
</html>
