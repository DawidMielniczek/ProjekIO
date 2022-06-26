<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rejestracja.aspx.cs" Inherits="WypożyczalniaSprzętuFilmowego.Strony.Logowanie.Rejestracja" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous"/>
</head>

<body class="bg-dark">
    <section class="h-100 bg-dark">
        <form runat="server">
  <div class="container py-5 h-100">
      
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col col-xl-10">
        <div class="card" style="border-radius: 1rem;">
          <div class="row g-0">
            <div class="col-md-6 col-lg-5 d-none d-md-block">
              <img src="https://i.pinimg.com/originals/ad/c5/37/adc53752cd62e2e4d4e9b193a84bf0e1.jpg"
                alt="login form" class="img-fluid" style="border-radius: 1rem 0 0 1rem;" />
            </div>
            <div class="col-xl-6">
              <div class="card-body p-md-5 text-black">
                <h3 class="mb-5 text-uppercase">Rejestracja</h3>

                <div class="row">
                  <div class="col-md-6 mb-4">
                    <div class="form-outline">
                      <asp:TextBox ID="TxtImie" runat="server"  class="form-control form-control-lg" />
                      <label class="form-label" >Imię</label>
                    </div>
                  </div>
                  <div class="col-md-6 mb-4">
                    <div class="form-outline">
                      <asp:TextBox ID="TxtNazwisko" runat="server" class="form-control form-control-lg" />
                      <label class="form-label">Nazwisko</label>
                    </div>
                  </div>
                </div>                               

                <div class="form-outline mb-4">
                  <asp:TextBox ID="TXTEmail" runat="server" class="form-control form-control-lg" />
                  <label class="form-label" >Email</label>
                </div>
                                 
               
                <div class="form-outline mb-4">
                  <asp:TextBox type="password" ID="TxtHaslo" runat="server" class="form-control form-control-lg" />
                  <label class="form-label">Hasło</label>
                </div>

                <div class="form-outline mb-4">
                  <asp:TextBox ID="TxtTelefon" runat="server" class="form-control form-control-lg" />
                  <label class="form-label"  >Telefon</label>
                </div>

                <div class="form-outline mb-4">
                  <asp:TextBox ID="TxtPesel" runat="server" class="form-control form-control-lg" />
                  <label class="form-label"  >Pesel</label>
                </div>                

                <div class="d-flex justify-content-end pt-3">
                  <asp:button ID="Btn_Rejestracja" type="submit" runat="server" class="btn btn-dark btn-lg btn-block" Text="Rejestracja" />
                </div>
                      
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
            </form>
</section>
 
    


</body>
</html>
