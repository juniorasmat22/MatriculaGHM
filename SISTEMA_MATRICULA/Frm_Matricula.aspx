<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Fondo.Master" CodeBehind="Frm_Matricula.aspx.vb" Inherits="SISTEMA_MATRICULA.Frm_Matricula" ClientIDMode="Static"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

     <div class="row">
      
      <div class="col s6">
          <div class="row">
              <div class="col s12">
                  <div class="card ">
                      <div class="card-content ">
                         
                          <div class="input-field ">
                              <i class="material-icons prefix">format_list_numbered</i>
                              <input id="txtDni"  type="number" class="validate" placeholder="Ingrese dni del estudiante">
                              <label for="txtDni">DNI</label>
                              <a class="btn-floating btn-small waves-effect waves-light red btn_buscar"><i class="material-icons">search</i></a>
                          </div>
                          
                          <div class="divider"></div>
                          <label for="nombres">Nombres</label>
                          <div class="input-field">
                              <i class="material-icons prefix">person_pin</i>
                              <input id="nombre" disabled  type="tel" class="validate">
                              
                          </div>
                          <label for="apellido">Apellidos</label>
                          <div class="input-field">
                              <i class="material-icons prefix">person_pin</i>
                              <input id="apellidos" disabled  type="tel" class="validate">
                              
                          </div>
                          <label for="apellido">Direccion</label>
                          <div class="input-field">
                              <i class="material-icons prefix">person_pin</i>
                              <input id="direccion" disabled  type="tel" class="validate">
                              
                          </div>
                          <label for="apellido">Correo</label>
                          <div class="input-field">
                              <i class="material-icons prefix">person_pin</i>
                              <input id="correo" disabled  type="tel" class="validate">
                              
                          </div>
                           <div class="input-field">
                             <a class="waves-effect waves-light btn-small btn_nueva_busqueda"><i class="material-icons left">create</i>Nueva Busqueda</a>
                              
                          </div>
                      </div>
                     </div> 
                  </div>
              </div>
          </div>
      <div class="col s6">
          <div class="row">
              <div class="col s12">
                  <div class="card ">
                      <div class="card-content ">
                         
                          <div class="input-field ">
                              <asp:DropDownList ID="Secciones" AppendDataBoundItems="true" runat="server">
                                    <asp:ListItem Value="0" disabled selected >Seleccione el grado </asp:ListItem>
                              </asp:DropDownList>
                               <label>Grados</label>
                          </div>
                          
                          <div class="divider"></div>
                          <div class="input-field">
                              <label>Hora</label>
                              <asp:TextBox ID="txtHora" disabled runat="server"></asp:TextBox>
                          </div>
                          <div class="input-field">
                              <label>fecha</label>
                              <asp:TextBox ID="txtFecha" disabled runat="server"></asp:TextBox>
                          </div>
                          <div class="divider"></div>
                           <label>Empleado</label>
                           <div class="input-field ">
                              
                                <asp:TextBox ID="txtEmpleado" disabled runat="server"></asp:TextBox>
                                
                          </div>
                          <label>Codigo Empleado</label>
                           <div class="input-field ">
                              
                                <asp:TextBox ID="codEmpleado" disabled runat="server"></asp:TextBox>
                                
                          </div>
                           <div class="input-field ">
                              
                                <a class="waves-effect waves-light btn-small btn_registra_matricula"><i class="material-icons left">create</i>Registrar Matricula</a>
                                
                          </div>
                      </div>
                     </div> 
                  </div>
              </div>
          </div>
        
      </div>

    <div class="row" style="text-align:center">
       
        <div class="col s12 z-depth-2 ">
            <table class="blue-grey lighten-5 display cell-border  centered responsive-table" id="tbl_Matricula">
             <thead>
                 <tr>
                     <th>Codigo</th>
                     <th>Dni Estudiante</th>
                     <th>Nombres</th>
                     <th>Grado</th>
                     <th>Seccion</th>


                 </tr>
             </thead>

             <tbody id="tbl_body_table">
                 <%-- dat --%>
             </tbody>
         </table>
        </div>
<%--        <div class="col s6">6-columns (one-half)</div>--%>
    </div>
          
    
     
    
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
    <script src="js/Matricula.js"></script>
    <script>
        $(document).ready(function () {
            $('.sidenav').sidenav();
            $('#tbl_Matricula').DataTable({
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
         $(document).ready(function(){
    $('select').formSelect();
  });
    </script>
</asp:Content>
