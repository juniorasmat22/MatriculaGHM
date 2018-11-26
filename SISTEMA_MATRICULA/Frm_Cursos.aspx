<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Fondo.Master" CodeBehind="Frm_Cursos.aspx.vb" Inherits="SISTEMA_MATRICULA.Frm_Cursos" ClientIDMode="Static" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="row">
        <div class="col s12">
            <div class="card ">
                <div class="card-content ">
                    <span class="card-title">Cursos</span>
                    <div class="row">
                        <div class="col s12">
                           <a class="btn-floating btn-large waves-effect waves-light red btn_add_Curso "><i class="material-icons">add</i></a>NUEVO CURSO
                             <div class="row">
                                <div class="col s12 m6">
                                    <div class="card ">
                                        <div class="card-content">
                                            <span class="card-title">Datos del Curso</span>
                                            <div class="input-field ">
                                                <label for="txtNombreCurso"><i class="zmdi zmdi-account-box"></i>&nbsp; Curso</label>
                                                <input id="txtNombreCurso" type="text" class="validate">
                                            </div>
                                            <div class="input-field ">
                                                <label for="txtHorasCurso"><i class="zmdi zmdi-account-circle"></i>&nbsp;Horas </label>
                                                <input id="txtHorasCurso" type="number" class="validate">
                                            </div>
                                            <div class="input-field ">
                                                <label for="txtDesCurso"><i class="zmdi zmdi-account-circle"></i>&nbsp;Descripcion </label>
                                                <input id="txtDesCurso" type="text" class="validate">
                                            </div>
                                        </div>
                                        
                                    </div>
                                </div>
                            
                                <div class="col s12">
                                    <div class="card ">
                                        <table class="blue-grey lighten-5 display cell-border  centered responsive-table" id="tbl_Curso">
                                            <thead>
                                                <tr>
                                                    <th>Codigo</th>
                                                    <th>Nombre</th>
                                                    <th>Horas</th>
                                                    <th>Descripcion</th>
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
            </div>
        </div>
    </div>

    <!-- Modal Structure -->
  <div id="modalEditCurso" class="modal">
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
                                    <label for="txtCodigo">Codigo del curso</label>
                                    <asp:TextBox ID="txtCodigo" type="text" CssClass="validate" runat="server" Enabled="False"></asp:TextBox>

                                </div>

                            </div>
                            <div class="row">
                                <div class=" col s6">
                                    <i class="material-icons prefix">account_circle</i>
                                    <label for="Nombre">Nombre</label>
                                    <asp:TextBox ID="txtNombre" type="text" CssClass="validate" runat="server"></asp:TextBox>
                                </div>
                                <div class="col s6">
                                    <i class="material-icons prefix">account_circle</i>
                                    <label for="txtHoras">Horas</label>
                                    <asp:TextBox ID="txtHoras" type="number" CssClass="validate" runat="server"></asp:TextBox>

                                </div>

                            </div>
                            <div class="row">

                                <div class="col s12">
                                    <i class="material-icons prefix">location_on</i>
                                    <label for="txtDescripcion">Descripcion</label>
                                    <asp:TextBox ID="txtDescripcion" type="text" CssClass="validate" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                    </div>


                </div>



            </div>
        </div>
        <div class="modal-footer">
            <button id="btn_Update_Curso" class="btn waves-effect waves-light modal-close" >Editar</button>
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
 });
    </script>
    <script src="js/Curso.js"></script>


</asp:Content>

