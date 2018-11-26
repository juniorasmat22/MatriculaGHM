<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Fondo.Master" CodeBehind="Frm_AsignarCurso.aspx.vb" Inherits="SISTEMA_MATRICULA.Frm_AsignarCurso"  ClientIDMode="Static"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
      <div class="row">
      <div class="col s4">
          <div class="row">
              <div class="col s12">
                  <div class="card">
                      <div class="card-content ">
                          <span class="card-title">Seleccione Curso</span>
                          <div class="input-field ">
                               <asp:DropDownList ID="DropDownList2" CssClass="select" runat="server" AppendDataBoundItems="true">
                                   <asp:ListItem Value="0" disabled selected >Seleccione un Curso</asp:ListItem>
                               </asp:DropDownList>

                              <label>Cursos</label>
                          </div>
                      </div>
                      
                  </div>
              </div>
          </div>
      </div>

      <div class="col s4">
           <div class="row">
              <div class="col s12">
                  <div class="card">
                      <div class="card-content ">
                          <span class="card-title">Seleccione Seccion</span>
                          <div class="input-field ">
                              <asp:DropDownList ID="DropDownList1" CssClass="select " runat="server" AppendDataBoundItems="true">
                                  <asp:ListItem Value="0" disabled selected >Seleccione Seccion </asp:ListItem>
                              </asp:DropDownList>
                                  <label>Secciones</label> 
                          </div>
                      </div>
                      
                  </div>
                 
              </div>
          </div>
      </div>
      <div class="col s4">
           <div class="row">
              <div class="col s12">
                  <div class="card">
                      <div class="card-content ">
                          <span class="card-title">Seleccione Profesor</span>
                          <div class="input-field ">
                              <asp:DropDownList ID="DropDownList3" CssClass="select " runat="server" AppendDataBoundItems="true">
                                    <asp:ListItem Value="0"  >Seleccione un Profesor </asp:ListItem>
                              </asp:DropDownList>
                                  
                                  <label>Profesores</label> 
                          </div>
                      </div>
                      
                  </div>
              </div>
          </div>
      </div>
       <a class="btn-floating btn-large waves-effect waves-light red" id="btn_asignar_Curso"><i class="material-icons">add</i></a>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="footer" runat="server">
    <script>
          $(document).ready(function(){
    $('select').formSelect();
  });
    
    </script>
    <script src="js/asignar_curso.js"></script>
</asp:Content>
