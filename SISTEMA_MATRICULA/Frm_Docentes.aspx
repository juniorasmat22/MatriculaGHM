<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Fondo.Master" CodeBehind="Frm_Docentes.aspx.vb" Inherits="SISTEMA_MATRICULA.Frm_Docentes" ClientIDMode="Static" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="row">
        <div class="col s12">
            <div class="card">
                <div class="card-content">
                    <span class="card-title">Docentes</span>
                    <div class="row">
                        <div class="col s12">
                            <button class="btn waves-effect waves-light btn_add_Docente">
                                <i class="material-icons left">person_add</i>Agregar Docente
                            </button>
                    
                            <div class="row">
                                <div class="col s12 m6">
                                    <div class="card ">
                                        <div class="card-content">
                                            <span class="card-title">Datos del docente</span>
                                            <div class="input-field ">
                                                <label for="txtDniDocente"><i class="zmdi zmdi-account-box"></i>&nbsp; Dni</label>
                                                <input id="txtDniDocente" type="number" class="validate">
                                            </div>
                                            <div class="input-field ">
                                                <label for="txtNombreDocente"><i class="zmdi zmdi-account-circle"></i>&nbsp;Nombres </label>
                                                <input id="txtNombreDocente" type="text" class="validate">
                                            </div>
                                            <div class="input-field ">
                                                <label for="txtApellidoDocente"><i class="zmdi zmdi-account-circle"></i>&nbsp;Apellido </label>
                                                <input id="txtApellidoDocente" type="text" class="validate">
                                            </div>
                                        </div>
                                        
                                    </div>
                                </div>
                            
                                <div class="col s12 m6">
                                    <div class="card ">
                                        <div class="card-content ">
                                            <span class="card-title">Datos del docente</span>
                                            <div class="input-field ">
                                                <label for="txtDireccionDocente"><i class="zmdi zmdi-gps-dot"></i>&nbsp; Direccion</label>
                                                <input id="txtDireccionDocente" type="text" class="validate">
                                            </div>
                                            <div class="input-field ">
                                                <label for="txtTelefono"><i class="zmdi zmdi-phone"></i>&nbsp;Telefono </label>
                                                <input id="txtTelefonoDocente" type="text" class="validate">
                                            </div>
                                            <div class="input-field ">
                                                <label for="txtCorreoDocente"><i class="zmdi zmdi-outlook"></i>&nbsp;Correo </label>
                                                <input id="txtCorreoDocente" type="text" class="validate">
                                            </div>
                                         
                                        </div>
                                        
                                    </div>
                                </div>
                            </div>
                             <table class="blue-grey lighten-5 display cell-border  centered responsive-table" id="tbl_Profesores" >
                                <thead>
                                    <tr>
                                        <th>Dni</th>
                                        <th>Nombre</th>
                                        <th>Apellidos</th>    
                                        <th>Direccion</th>
                                        <th>Telefono</th>
                                        <th>Correo</th>
                                        <th>Opciones</th>
                                        
                                    </tr>
                                </thead>

                                <tbody id="tbl_body_table">
                                   <%-- dat --%>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
                
            </div>
        </div>
    </div>


       <!-- Modal Structure -->
    <div id="modalEditDocente" class="modal">
        <div class="modal-content ">
            <div class="row ">
                <div class="col s12 ">

                    <div class="card-content  ">
                        <span class="card-title  blue-text text-darken-2">
                            <h4>Editar Datos Docente</h4>
                        </span>
                        <div class="row">

                            <div class="row">
                                <div class="col s6">
                                    <i class="material-icons prefix">confirmation_number</i>
                                    <label for="dni">DNI</label>
                                    <asp:TextBox ID="e_txtDni" type="number" CssClass="validate" runat="server" Enabled="False"></asp:TextBox>

                                </div>

                            </div>
                            <div class="row">
                                <div class=" col s6">
                                    <i class="material-icons prefix">account_circle</i>
                                    <label for="Nombre">Nombres</label>
                                    <asp:TextBox ID="e_txtNombre" type="text" CssClass="validate" runat="server"></asp:TextBox>
                                </div>
                                <div class="col s6">
                                    <i class="material-icons prefix">account_circle</i>
                                    <label for="Paterno">Apellido Paterno</label>
                                    <asp:TextBox ID="e_txtApellido" type="text" CssClass="validate" runat="server"></asp:TextBox>

                                </div>

                            </div>
                            <div class="row">

                                <div class="col s12">
                                    <i class="material-icons prefix">location_on</i>
                                    <label for="direccion">Direccion</label>
                                    <asp:TextBox ID="e_txtDireccion" type="text" CssClass="validate" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>


                </div>


                <div class="col s12 ">

                    <div class="card-content">

                        <div class="row">
                            <%--                                <div class="row">
                                    <div class="input-field col s12">
                                        <i class="material-icons prefix">confirmation_number</i>
                                        <asp:DropDownList ID="dlSexo" runat="server">
                                            <asp:ListItem Value="0">&lt;Seleccione el Sexo&gt;</asp:ListItem>
                                            <asp:ListItem Value="1">Masculino</asp:ListItem>
                                            <asp:ListItem Value="2">Femenino</asp:ListItem>
                                        </asp:DropDownList>



                                          <select>
                                        <option value="" disabled selected>Seleccione Sexo</option>
                                        <option value="1">Masculino</option>
                                        <option value="2">Femenino</option>
                                    </select>
                                        <label>sexo</label>
                                    </div>

                                </div>

                                <div class="row">
                                    <div class="input-field col s12">
                                        <i class="material-icons prefix">phone</i>
                                        <label for="text">F. Nacimiento</label>
                                        <asp:TextBox ID="txtFecha" CssClass="datepicker" runat="server"></asp:TextBox>

                                    </div>

                                </div>--%>
                            <div class="row">
                                <div class=" col s12">
                                    <i class="material-icons prefix">email</i>
                                    <label for="email">Correo</label>
                                    <asp:TextBox ID="e_txtCorreo" type="email" CssClass="validate" runat="server"></asp:TextBox>
                                </div>

                            </div>
                        </div>
                    </div>



                </div>


            </div>
        </div>
        <div class="modal-footer">
            <button id="btn_Update_Docente" class="btn waves-effect waves-light modal-close" >Editar</button>
            <button id="btn_Delete_Alumno" class="btn waves-effect waves-light modal-close" >Cancelar</button>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
<script>
    $(document).ready(function () {
    $('.sidenav').sidenav();
    $('#tbl_Profesores').DataTable({
        "language": {
            "sProcessing": "Procesando...",
            "sLengthMenu": "Mostrar _MENU_ registros",
            "sZeroRecords": "No se encontraron resultados",
            "sEmptyTable": "Ningún dato disponible en esta tabla",
            "sInfo": "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros",
            "sInfoEmpty": "Mostrando registros del 0 al 0 de un total de 0 registros",
            "sInfoFiltered": "(filtrado de un total de _MAX_ registros)",
            "sInfoPostFix": "",
            "sSearch": "Buscar:",
            "sUrl": "",
            "sInfoThousands": ",",
            "sLoadingRecords": "Cargando...",
            "oPaginate": {
                "sFirst": "Primero",
                "sLast": "Último",
                "sNext": "Siguiente",
                "sPrevious": "Anterior"
            },
            "oAria": {
                "sSortAscending": ": Activar para ordenar la columna de manera ascendente",
                "sSortDescending": ": Activar para ordenar la columna de manera descendente"
            }
        }
        });
  $("select").val('10');
  $('select').addClass("Search");
  $('select').formSelect();

});
</script>
<script>
$(document).ready(function () {
         
 $('.modal').modal();
 M.updateTextFields();

});
</script>

    <script src="js/Profesor.js"></script>
</asp:Content>
