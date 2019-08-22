﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarUsuario.aspx.cs" Inherits="Web.Presentacion.Usuario.WebForm1" %>

<!DOCTYPE html>
<html lang="en">

<head>
    <!-- Required meta tags-->
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="au theme template">
    <meta name="author" content="Hau Nguyen">
    <meta name="keywords" content="au theme template">

    <!-- Title Page-->
    <title>Registrar Usuario</title>

    <!-- Fontfaces CSS-->
    <link href="../../css/font-face.css" rel="stylesheet" media="all">
    <link href="../../vendor/font-awesome-4.7/css/font-awesome.min.css" rel="stylesheet" media="all">
    <link href="../../vendor/font-awesome-5/css/fontawesome-all.min.css" rel="stylesheet" media="all">
    <link href="../../vendor/mdi-font/css/material-design-iconic-font.min.css" rel="stylesheet" media="all">

    <!-- Bootstrap CSS-->
    <link href="../../vendor/bootstrap-4.1/bootstrap.min.css" rel="stylesheet" media="all">

    <!-- Vendor CSS-->
    <link href="../../vendor/animsition/animsition.min.css" rel="stylesheet" media="all">
    <link href="../../vendor/bootstrap-progressbar/bootstrap-progressbar-3.3.4.min.css" rel="stylesheet" media="all">
    <link href="../../vendor/wow/animate.css" rel="stylesheet" media="all">
    <link href="../../vendor/css-hamburgers/hamburgers.min.css" rel="stylesheet" media="all">
    <link href="../../vendor/slick/slick.css" rel="stylesheet" media="all">
    <link href="../../vendor/select2/select2.min.css" rel="stylesheet" media="all">
    <link href="../../vendor/perfect-scrollbar/perfect-scrollbar.css" rel="stylesheet" media="all">

    <!-- Main CSS-->
    <link href="../../css/theme.css" rel="stylesheet" media="all">
</head>

<body class="animsition">
    <div class="page-wrapper">
        <div class="page-content--bgf7">
            <div class="container">
                <div class="login-wrap">
                    <div class="login-content">
                        <div class="login-logo">
                            <a href="#">
                                <img src="../../images/icon/logo1.jpg" width="179" height="52" alt="CoolAdmin">
                            </a>
                            <div>
                                <h3>REGISTRAR USUARIO</h3>
                            </div>
                        </div>
                        <div class="login-form">
                            <form id="form1" runat="server">
                                <div class="form-group">
                                    <input class="au-input au-input--full" type="number" id="Documento" name="Documento" placeholder="Documento" required>
                                </div>
                                <div class="form-group">
                                    <input class="au-input au-input--full" type="text" id="Nombre" name="Nombre" placeholder="Nombre" required>
                                </div>
                                <div class="form-group">
                                    <input class="au-input au-input--full" type="text" id="Apellido" name="Apellido" placeholder="Apellido" required>
                                </div>
                                <div class="form-group">
                                    <input class="au-input au-input--full" type="email" id="Correo" name="Correo" placeholder="Correo" required>
                                </div>
                                <div class="form-group">
                                    <input class="au-input au-input--full" type="password" id="Clave" name="Clave" placeholder="Clave" required>
                                </div>
                                <div class="form-group">
                                    <input class="au-input au-input--full" type="number" id="telefono" name="Telefono" placeholder="Telefono" required>
                                </div>
                                <div class="form-group">
                                    <asp:DropDownList class="au-input au-input--full" ID="hola" Font-Names="hola" runat="server" Height="45px" Width="482px">
                                    </asp:DropDownList>
                                </div>
                                <button class="au-btn au-btn--block au-btn--green m-b-20" id="Enviar" runat="server" onserverclick="btnRegistrar" name="Enviar" type="button">Registrar</button>
                            </form>
                            <div class="register-link">
                                <p>
                                    Ya tienes Cuenta?
                                    <a href="../Login/Login.aspx">Ingresa Aqui</a>
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Jquery JS-->
    <script src="../../vendor/jquery-3.2.1.min.js"></script>
    <!-- Bootstrap JS-->
    <script src="../../vendor/bootstrap-4.1/popper.min.js"></script>
    <script src="../../vendor/bootstrap-4.1/bootstrap.min.js"></script>
    <!-- Vendor JS       -->
    <script src="../../vendor/slick/slick.min.js">
    </script>
    <script src="../../vendor/wow/wow.min.js"></script>
    <script src="../../vendor/animsition/animsition.min.js"></script>
    <script src="../../vendor/bootstrap-progressbar/bootstrap-progressbar.min.js">
    </script>
    <script src="../../vendor/counter-up/jquery.waypoints.min.js"></script>
    <script src="../../vendor/counter-up/jquery.counterup.min.js">
    </script>
    <script src="../../vendor/circle-progress/circle-progress.min.js"></script>
    <script src="../../vendor/perfect-scrollbar/perfect-scrollbar.js"></script>
    <script src="../../vendor/chartjs/Chart.bundle.min.js"></script>
    <script src="../../vendor/select2/select2.min.js">
    </script>

    <!-- Main JS-->
    <script src="../../js/main.js"></script>

</body>

</html>
<!-- end document-->
