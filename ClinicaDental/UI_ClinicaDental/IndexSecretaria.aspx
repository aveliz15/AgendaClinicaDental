﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Secretaria.Master" AutoEventWireup="true" CodeBehind="IndexSecretaria.aspx.cs" Inherits="UI_ClinicaDental.IndexSecretaria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <link href="Content/Botones.css" rel="stylesheet" type="text/css" />

   
<div class="container-fluid" style="margin-top:100px">

    <div class="col-sm-4 " > <a href="#" class="myButton"><img src="Iconos/cita.png" alt="Los Tejos" /><br />Citas </a> </div>
    <div class="col-sm-4"> <a href="/IndexPacientesS.aspx" class="myButton"><img src="Iconos/paciente.png" alt="Los Tejos" /><br />Pacientes </a></div>
    <div class="col-sm-4"> <a href="/Diagnostico.aspx" class="myButton"><img src="Iconos/diagnostico.png" alt="Los Tejos" /><br />Diagnostico</a></div>
   

</div>
  



</asp:Content>

