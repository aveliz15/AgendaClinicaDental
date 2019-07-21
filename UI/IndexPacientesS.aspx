<%@ Page Title="" Language="C#" MasterPageFile="~/Secretaria.Master" AutoEventWireup="true" CodeBehind="IndexPacientesS.aspx.cs" Inherits="UI_ClinicaDental.IndexPacientesS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


        <link href="Content/Botones.css" rel="stylesheet" type="text/css" />
    <br />
   <h2 align="center">Administración de pacientes </h2>
<div class="container-fluid" style="margin-top:200px">

    <div class="col-sm-5" style="margin-left:140px" > <a href="/InsertarPacienteS.aspx" class="myButton"><img src="Iconos/agregarPersona.png" alt="Los Tejos" /><br />Insertar </a> </div>
    <div class="col-sm-5"> <a href="/ModificarPacienteS.aspx" class="myButton"><img src="Iconos/EditarPersona.png" alt="Los Tejos" /><br />Modificar </a></div>
    

</div>
</asp:Content>
