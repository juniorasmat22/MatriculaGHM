<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Fondo.Master" CodeBehind="Frm_Grado.aspx.vb" Inherits="SISTEMA_MATRICULA.Frm_Grado"  ClientIDMode="Static" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="row">
      
        <div class="col s6">

            <div class="card">
                <div class="card-content">
                    <span class="card-title">Nuevo Grado</span>
                    <div class="row">
                        <div class="col s12 ">
                     
                                <div class="input-field ">
                                    <label for="txtGrado"><i class="zmdi zmdi-account"></i>&nbsp; Grado</label>
                                    <input id="txtGrado" type="number" class="validate">
                                </div>
                                <div class="input-field ">
                                    <label for="txtSeccion"><i class="zmdi zmdi-lock"></i>&nbsp;Seccion </label>
                                    <input id="txtSeccion" type="text" class="validate">
                                   
                                </div>
                            
                                <div class="input-field ">
                                    <select id="nivel">
                                        <option value="" disabled selected>Selecione Nivel</option>
                                        <option value="1">Primaria</option>
                                        <option value="2">Secundaria</option>
                                   
                                    </select>
                                    <label>Nivel</label>
                                </div>
                                 <%--<label>Materialize Select</label>
                                <select>
                                    <option value=""  disabled selected>Selecione Nivel</option>
                                    <option value="1">Primaria</option>
                                    <option value="2">Secundaria</option>
                                    <%--<option value="3"> Secundaria</option>--%>
                                <%--</select>--%>
   
                                 <%--<asp:DropDownList ID="dlSexo" runat="server">
                                     <asp:ListItem Value="0" Selected="True" >Seleccione el Nivel</asp:ListItem>
                                     <asp:ListItem Value="1">Primaria</asp:ListItem>
                                     <asp:ListItem Value="2">Secundaria</asp:ListItem>
                                </asp:DropDownList>--%>
                            <div>
                                <div class="col s6">
                                    <button class="btn waves-effect waves-light btn_add_Grado">
                                    Aceptar
                                      <i class="material-icons right">send</i>
                                </button>
                                </div>
                                <div class="col s6">
                                    <button class="btn waves-effect waves-light">
                                    Cancelar
                                      <i class="material-icons right">send</i>
                                </button>
                                </div>
                               
                            </div>
                       
                            
                        </div>
                    </div>
                </div>
               
            </div>

        </div>

      <div class="col s6">
          
            <div class="card">
                <div class="card-content">
                    <span class="card-title">Lista de Grados</span>
                     <table class="highlight  centered responsive-table" id="tbl_Grado">
              <thead>
                  <tr>
                      <th>Codigo</th>
                      <th>Grado</th>
                      <th>Seccion</th>
                      <th>Nivel</th>
          
                      <th>Opciones</th>

                  </tr>
              </thead>

              <tbody id="tbl_body_grado">
                  <%-- dat --%>
              </tbody>
          </table>
        
                </div>
               
            </div>
         
      </div>

    </div>
     <div id="modalEditGrado" class="modal">
        <div class="modal-content ">
            <div class="row ">
                <div class="col s12 ">

                    <div class="card-content  ">
                        <span class="card-title  blue-text text-darken-2">
                            <h4>Editar Datos</h4>
                        </span>
                        <div class="row">
                          
                                <div class="col s6">
                                    <label for="txtCodigoGrado"><i class="zmdi zmdi-account"></i>&nbsp; Grado</label>
                                    <input id="modaltxtCodigo" disabled type="text" class="validate">
                                </div>



                            <div class="col s6">
                                <label for="txtGrado"><i class="zmdi zmdi-account"></i>&nbsp; Grado</label>
                                <input id="modaltxtGrado" type="number" class="validate">
                            </div>

                            <div class="  col s6">

                                <label for="txtSeccion"><i class="zmdi zmdi-lock"></i>&nbsp;Seccion </label>
                                <input id="modaltxtSeccion" type="text" class="validate">
                            </div>
                            <div class=" input-field col s6">

                                <select id="modalnivel">
                                    <option value="0" disabled selected>Selecione Nivel</option>
                                    <option value="1">Primaria</option>
                                    <option value="2">Secundaria</option>

                                </select>
                                <label>Nivel</label>

                            </div>

                        </div>
                            
                        </div>
                    </div>


                </div>

            </div>
         <div class="modal-footer">
            <button id="btn_Update_Grado" class="btn waves-effect waves-light modal-close" >Editar</button>
            <button id="btn_Delete_Grado" class="btn waves-effect waves-light modal-close" >Cancelar</button>
        </div>
        </div>
        
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
        <script>   
        $(document).ready(function () {
            //$('.sidenav').sidenav();
            $('select').formSelect();

            //$('.datepicker').datepicker({
            //    autoClose: true,
            //    format: 'yyyy-mm-dd'
            //});
        });
    </script>
    <script src="js/Grado.js"></script>   
     <script>
        $(document).ready(function () {
            /*iniciali¿zando el modal*/
            $('.modal').modal();
            M.updateTextFields();

        });
    </script>
</asp:Content>
