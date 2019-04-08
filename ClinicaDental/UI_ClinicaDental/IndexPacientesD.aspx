<%@ Page Title="" Language="C#" MasterPageFile="~/Dentista.Master" AutoEventWireup="true" CodeBehind="IndexPacientesD.aspx.cs" Inherits="UI_ClinicaDental.IndexPacientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <link href="Content/Botones.css" rel="stylesheet" type="text/css" />

   
<div class="container-fluid" style="margin-top:100px">

    <div class="col-sm-5" style="margin-left:140px" > <a href="/InsertarPacienteD.aspx" class="myButton"><img src="Iconos/agregarPersona.png" alt="Los Tejos" /><br />Insertar </a> </div>
    <div class="col-sm-5"> <a href="/ModificarPacienteD" class="myButton"><img src="Iconos/EditarPersona.png" alt="Los Tejos" /><br />Modificar </a></div>
    

</div>
   

</asp:Content>
