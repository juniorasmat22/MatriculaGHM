<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="login.aspx.vb" Inherits="SISTEMA_MATRICULA.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="Materialize/css/materialize.css" rel="stylesheet" />
    <link href="css/Login.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/material-design-iconic-font/2.2.0/css/material-design-iconic-font.min.css" />
    <title>Login</title>
</head>
<body class="font-cover" id="login">
    <div class="container-login center-align">
        <div style="margin: 15px 0;">
            <i class="zmdi zmdi-account-circle zmdi-hc-5x"></i>

            <p>Inicia sesión con tu cuenta</p>
        </div>
        <form id="form1" runat="server">
            <div>
                <div class="input-field col s12">
                <label for="email"><i class="zmdi zmdi-account"></i>&nbsp; Usuario</label>
                <asp:TextBox ID="email" type="email" CssClass="validate" runat="server"></asp:TextBox>
                

            </div>
            <div class="input-field col s12">
                <label for="Password"><i class="zmdi zmdi-lock"></i>&nbsp; Contraseña</label>
                <asp:TextBox ID="Password" type="password" CssClass="validate" runat="server"></asp:TextBox>
                

            </div>
            <asp:LinkButton ID="btnIngresar" CssClass="waves-effect waves-teal btn-flat " runat="server">Ingresar &nbsp;<i class="zmdi zmdi-mail-send"></i></asp:LinkButton>
            </div>
        </form>
    </div>
</body>
<script src="Materialize/js/materialize.min.js"></script>
</html>
