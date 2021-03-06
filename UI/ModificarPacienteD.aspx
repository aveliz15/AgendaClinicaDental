﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Dentista.Master" AutoEventWireup="true" CodeBehind="ModificarPacienteD.aspx.cs" Inherits="UI_ClinicaDental.ModificarPacienteD" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.10.19/css/jquery.dataTables.css"> 
<script type="text/javascript" charset="utf8" src="https://cdn.datatables.net/1.10.19/js/jquery.dataTables.js"></script>
    <script>
    $(function () {
    $(".gvv").prepend( $("<thead></thead>").append( $(this).find("tr:first") ) ).dataTable();
});
</script>

    <script>
         
        $(document).ready(function () {
    $('#GV1').DataTable();
        });
       </script>
     <link rel="stylesheet" href="estilos3.css">
    
    <br />
    <div class="alert alert-success" visible="false" id="mensaje" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
        <strong id="textoMensaje" runat="server"></strong>
    </div>

    <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
        <strong id="textoMensajeError" runat="server"></strong>
    </div>

    <h2 style="color: black">Busqueda de pacientes</h2>
    <br />
    <div id="buscar" class="form-inline" runat="server">
      <asp:TextBox ID="ttIdPaciente" runat="server"  Width="300px" TextMode="Number" CssClass="form-control" PlaceHolder="Ingrese ID del paciente:"></asp:TextBox>
         <asp:Button Text="Buscar" runat="server" ID="btnBuscar" CssClass="btn btn-success" OnClick="btnBuscar_Click" />
        </div>
    <br />
          <div id="gridview" runat="server">
    <asp:GridView ID="GV1"  runat="server" CssClass="gvv" >
     
       
    </asp:GridView>
        </div>

    <div align="center">
    
    <div class="form-line" id="divMantenimiento" runat="server">
     <h2 style="color: black">Modificar datos del paciente</h2>
        <br />
    <div class="form-group">
      <asp:Label ID="lbIdPaciente" ForeColor="black" runat="server" Text="ID Paciente: "></asp:Label>
        <asp:TextBox ID="txtIdPaciente" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
            ControlToValidate="txtIdPaciente"
            ErrorMessage="El ID es requerido."
            ForeColor="Red">
        </asp:RequiredFieldValidator>
     </div>

        <div class="form-group">
            <asp:Label ID="lbNombre" ForeColor="black" runat="server" Text="Nombre: "></asp:Label>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                ControlToValidate="txtNombre"
                ErrorMessage="El nombre es requerido."
                ForeColor="Red">
            </asp:RequiredFieldValidator>
        </div>
        <div class="form-group">

            <asp:Label ID="lbApellido1" ForeColor="black" runat="server" Text="Primer Apellido: "></asp:Label>
            <asp:TextBox ID="txtApellido1" runat="server" CssClass="form-control"> </asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                ControlToValidate="txtApellido1"
                ErrorMessage="El primer apellido es requerido."
                ForeColor="Red">
            </asp:RequiredFieldValidator>
        </div>

        <div class="form-group">
            <asp:Label ID="lbApellido2" ForeColor="black" runat="server" Text="Segundo Apellido: "></asp:Label>
            <asp:TextBox ID="txtApellido2" runat="server" CssClass="form-control" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                ControlToValidate="txtApellido2"
                ErrorMessage="El segundo apellido es requerido."
                ForeColor="Red">
            </asp:RequiredFieldValidator>
        </div>

        <div class="form-group">
            <asp:Label ID="lbTelefono" ForeColor="black" runat="server" Text="Telefono: "></asp:Label>
            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                ControlToValidate="txtTelefono"
                ErrorMessage="El Telefono es requerido."
                ForeColor="Red">
            </asp:RequiredFieldValidator>
        </div>
       
             <div class="form-group">
            <asp:Label ID="lbCorreo" ForeColor="black" runat="server" Text="Correo: "></asp:Label>
            <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server"
                ControlToValidate="txtCorreo"
                ErrorMessage="El correo es requerido."
                ForeColor="Red">
            </asp:RequiredFieldValidator>
        </div>

        <br />
         <asp:Label ID="LbFecha" ForeColor="black" runat="server" Text="Fecha nacimiento: "></asp:Label>
        <asp:TextBox ID="txtFecha" runat="server" Width="280px" CssClass="form-control" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server"
                                ControlToValidate="txtFecha"
                                ErrorMessage="La fecha es requerida."
                                ForeColor="Red">
                            </asp:RequiredFieldValidator> 
           <br />
        <div class="form-group">
        <asp:Label ID="lbTipoOntograma" ForeColor="black" runat="server" Text="Tipo de ontograma: "></asp:Label>
       <asp:DropDownList ID="DDLTipoOntograma" CssClass="form-control" Width="280px" runat="server"></asp:DropDownList>
             
        </div>
         <div class="form-horizontal">
           
            
            &nbsp; &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;  <asp:Button Text="Modificar" runat="server" ID="btnModificar" CssClass="btn btn-success" OnClick="btnModificar_Click" />
       
            </div>
        </div>
        </div>
        <br />
       
    
</asp:Content>
