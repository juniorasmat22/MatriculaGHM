<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Fondo.Master" CodeBehind="Frm_Alumnos.aspx.vb" Inherits="SISTEMA_MATRICULA.Frm_Alumnos"  ClientIDMode="Static"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="row">
        <div class="col s12">
            <div class="card">
                <div class="card-content z-depth-3">
                    <span class="card-title">Alumnos</span>
                    <div class="row">
                        <div class="col s12 ">
                             <a href="Reg_Alumno.aspx" class="waves-effect waves-light btn-large  blue darken-1"><i class="material-icons left">person_add</i>Nuevo Alumno</a>
                             
                            <table class="blue-grey lighten-5 display cell-border  centered responsive-table" id="tbl_Alumnos" >
                                <thead>
                                    <tr>
                                        <th>Dni</th>
                                        <th>Nombre</th>
                                        <th>Apellidos</th>
                                        <th>Correo</th>
                                        <th>Direccion</th>
                                       <%-- <th>sexo</th>
                                         <th>Nacimiento</th>--%>
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
               <%-- <div class="card-action">
                    <a href="#">This is a link</a>
                    <a href="#">This is a link</a>
                </div>--%>
            </div>
        </div>
    </div>
    <!-- Modal Structure -->
    <div id="modalEditAlumno" class="modal">
        <div class="modal-content ">
            <div class="row ">
                <div class="col s12 ">

                    <div class="card-content  ">
                        <span class="card-title  blue-text text-darken-2">
                            <h4>Editar Datos</h4>
                        </span>
                        <div class="row">

                            <div class="row">
                                <div class="col s6">
                                    <i class="material-icons prefix">confirmation_number</i>
                                    <label for="dni">DNI</label>
                                    <asp:TextBox ID="txtDni" type="number" CssClass="validate" runat="server" Enabled="False"></asp:TextBox>

                                </div>

                            </div>
                            <div class="row">
                                <div class=" col s6">
                                    <i class="material-icons prefix">account_circle</i>
                                    <label for="Nombre">Nombres</label>
                                    <asp:TextBox ID="txtNombre" type="text" CssClass="validate" runat="server"></asp:TextBox>
                                </div>
                                <div class="col s6">
                                    <i class="material-icons prefix">account_circle</i>
                                    <label for="Paterno">Apellido Paterno</label>
                                    <asp:TextBox ID="txtApellido" type="text" CssClass="validate" runat="server"></asp:TextBox>

                                </div>

                            </div>
                            <div class="row">

                                <div class="col s12">
                                    <i class="material-icons prefix">location_on</i>
                                    <label for="direccion">Direccion</label>
                                    <asp:TextBox ID="txtDireccion" type="text" CssClass="validate" runat="server"></asp:TextBox>
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
                                    <asp:TextBox ID="txtCorreo" type="email" CssClass="validate" runat="server"></asp:TextBox>
                                </div>

                            </div>
                        </div>
                    </div>



                </div>


            </div>
        </div>
        <div class="modal-footer">
            <button id="btn_Update_Alumno" class="btn waves-effect waves-light modal-close" >Editar</button>
            <button id="btn_Delete_Alumno" class="btn waves-effect waves-light modal-close" >Cancelar</button>
        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
    <script src="js/jquery.dataTables.min.js"></script>
<script>
    $(document).ready(function () {
    $('.sidenav').sidenav();
    $('#tbl_Alumnos').DataTable({
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
         
    
            /*iniciali¿zando el modal*/
            $('.modal').modal();
      

        });
    </script>
    <script src="js/Alumno.js"></script>


</asp:Content>