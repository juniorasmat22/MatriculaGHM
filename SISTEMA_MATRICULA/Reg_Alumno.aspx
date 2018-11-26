<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Fondo.Master" CodeBehind="Reg_Alumno.aspx.vb" Inherits="SISTEMA_MATRICULA.Reg_Alumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="row">
    <div class="col s12 m6">
      <div class="card">
        <div class="card-content card-title">
       
                <a href="#!" class="breadcrumb blue-text text-darken-2">Inicio ></a>
                <a href="#!" class="breadcrumb blue-text text-darken-2">Alumnos ></a>
                <a href="#!" class="breadcrumb blue-text text-darken-2">Nuevo </a>

        </div>
      </div>
    </div>
  </div>


    <div class="row">
        <div class="col s12 m6">
            <div class="card">
                <div class="card-content">
                    <span class="card-title  blue-text text-darken-2">Datos del Alumno</span>
                    <div class="row">
                        
                            <div class="row">
                                <div class="input-field col s12">
                                    <i class="material-icons prefix">confirmation_number</i>
                                    <asp:TextBox ID="txtDni" type="number" CssClass="validate" runat="server"></asp:TextBox>
                                    <label for="dni">DNI</label>
                                </div>
                                
                            </div>
                        <div class="row">
                            <div class="input-field col s6">
                                    <i class="material-icons prefix">account_circle</i>
                                    <label for="Nombre">Nombres</label>
                                    <asp:TextBox ID="txtNombre" type="text" CssClass="validate" runat="server"></asp:TextBox>
                                </div>
                                <div class="input-field col s6">
                                    <i class="material-icons prefix">account_circle</i>
                                    <asp:TextBox ID="txtApellidos" type="text" CssClass="validate" runat="server"></asp:TextBox>
                                    <label for="Apellidos">Apellidos</label>
                                </div>
                        </div>
                        <div class="row">
                            
                            <div class="input-field col s12">
                                 <i class="material-icons prefix">location_on</i>
                               <label for="direccion">Direccion</label>
                                 <asp:TextBox ID="txtDireccion" type="text" CssClass="validate" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                
            </div>
        </div>
    

        <div class="col s12 m6">
            <div class="card">
                <div class="card-content">
                    <span class="card-title blue-text text-darken-2">Datos del Alumno</span>
                    <div class="row">
                        <div class="row">
                            <div class="input-field col s12">
                                <i class="material-icons prefix">confirmation_number</i>
                                <asp:DropDownList ID="dlSexo" runat="server">
                                     <asp:ListItem Value="0" Selected="True" >&lt;Seleccione el Sexo&gt;</asp:ListItem>
                                     <asp:ListItem Value="1">Masculino</asp:ListItem>
                                     <asp:ListItem Value="2">Femenino</asp:ListItem>
                                </asp:DropDownList>
                                
                                
                                
                              <%--  <select>
                                        <option value="" disabled selected>Seleccione Sexo</option>
                                        <option value="1">Masculino</option>
                                        <option value="2">Femenino</option>
                                    </select>--%>
                                    <label>sexo</label>
                            </div>
                            
                        </div>
                    
                        <div class="row">
                            <div class="input-field col s12">
                                   <i class="material-icons prefix">phone</i>
                                    <label for="text">F. Nacimiento</label>
                                    <asp:TextBox ID="txtFecha" CssClass="datepicker"  runat="server"></asp:TextBox>

                                </div>
                                
                        </div>
                        <div class="row">
                            <div class="input-field col s12">
                                <i class="material-icons prefix">email</i>
                                    <label for="email">Correo</label>
                                    <asp:TextBox ID="txtCorreo" type="email" CssClass="validate" runat="server"></asp:TextBox>
                            </div>
                           
                        </div>
                    </div>
                </div>
                
            </div>

        </div>
        <div class="row">
            <div class="col s6" style="text-align: right;">
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <asp:LinkButton ID="Btn_Aceptar" CssClass="waves-effect waves-light btn-large" runat="server">Registrar</asp:LinkButton>
               
            </div>
            <div class="col s6" style="text-align: left;">
                
                <asp:LinkButton ID="Btn_Cancelar"  CssClass="waves-effect waves-light btn-large" runat="server">Cancelar</asp:LinkButton>
                
            </div>

        </div>
        
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
    <script src="js/Alumno.js"></script>
    <script>   
        $(document).ready(function () {
            $('.sidenav').sidenav();
            $('select').formSelect();
            $(".dropdown-trigger").dropdown();
            $('.datepicker').datepicker({
                autoClose: true,
                format: 'yyyy-mm-dd'
            });
        });
    </script>
</asp:Content>