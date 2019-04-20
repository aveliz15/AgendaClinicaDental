<%@ Page Title="" Language="C#" MasterPageFile="~/Dentista.Master" AutoEventWireup="true" CodeBehind="IndexAdminUsuarios.aspx.cs" Inherits="UI_ClinicaDental.IndexAdminUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="Content/Botones.css" rel="stylesheet" type="text/css" />

   <h2>Administración de Usuarios del Sistema</h2>
<div class="container-fluid" style="margin-top:100px">

    <div class="col-sm-4 " > <a href="/InsertarUsuario.aspx" class="myButton"><img src="Iconos/agregarPersona.png" alt="Los Tejos" /><br />Insertar</a> </div>
    <div class="col-sm-4"> <a href="/BuscarUsuario.aspx" class="myButton"><img src="Iconos/editarPersona.png" alt="Los Tejos" /><br />Modificar</a></div>
   <div class="col-sm-4"> <a href="/ModificarUsuario.aspx" class="myButton"><img src="Iconos/perfil.png" alt="Los Tejos" /><br />Mi Perfil</a></div>
   
   

</div>

</asp:Content>
