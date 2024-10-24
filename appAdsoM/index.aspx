<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="appAdsoM.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Adso Mañana</title>
    <link href="vista/css/estiloLogin.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server" class="card-body cardbody-color p-lg-5">
        <div style="height: 122px">

            <div class="container">
                <div class="row">
                    <div class="col-md-6 offset-md-3">
                        <h2 class="text-center text-dark mt-5">Login Form</h2>
                        <div class="text-center mb-5 text-dark">Made with bootstrap</div>
                        <div class="card my-5">


                            <div class="text-center">
                                <img src="https://cdn.pixabay.com/photo/2016/03/31/19/56/avatar-1295397__340.png" class="img-fluid profile-image-pic img-thumbnail rounded-circle my-3"
                                    width="200px" alt="profile" />
                            </div>

                            <div class="mb-3">

                                <asp:TextBox ID="txtUsuario" runat="server" class="form-control" aria-describedby="emailHelp" 
                                    placeholder="User Name" TextMode="Email"></asp:TextBox>
                            </div>
                            <div class="mb-3">
                                <asp:TextBox ID="txtPassword" runat="server" class="form-control" placeholder="password" TextMode="Password"> </asp:TextBox>


                            </div>
                            <div class="text-center">
                                <asp:Button ID="btnIngresar" class="btn btn-color px-5 mb-5 w-100" runat="server" Text="Ingresar enviando parametros" OnClick="btnIngresar_Click"/>
                                <asp:Button ID="btnIngreso" class="btn btn-color px-5 mb-5 w-100" runat="server" Text="Ingresar enviando objeto" OnClick="btnIngreso_Click"/>
                                <asp:Button ID="btnIngresoSP" class="btn btn-color px-5 mb-5 w-100" runat="server" Text="Ingresar con Storage Procedure" OnClick="btnIngresoSP_Click"/>
                           
                                </div>

                            <div id="emailHelp" class="form-text text-center mb-5 text-dark">
                                Not
              Registered? <a href="#" class="text-dark fw-bold">Create an
                Account</a>
                            </div>
                            <div class="text-center">
                            <asp:Label ID="lblVer" runat="server" Text="" ></asp:Label>

                            </div>

                        </div>

                    </div>
                </div>
            </div>


        </div>
        <asp:Label ID="lblMessage" runat="server"></asp:Label>


    </form>

</body>
</html>
