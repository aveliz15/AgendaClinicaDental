<%@ Page Title="" Language="C#" MasterPageFile="~/Secretaria.Master" AutoEventWireup="true" CodeBehind="IndexSecretaria.aspx.cs" Inherits="UI_ClinicaDental.IndexSecretaria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
<div style="margin-left:25px; color:red">
<asp:Label ID="LBUsuariotext" runat="server" Text="Conectado como: ">
</asp:Label><asp:Label ID="LblUsuario" runat="server" Text=""></asp:Label>
</div>
    <link href="Content/Botones.css" rel="stylesheet" type="text/css" />

   
<div class="container-fluid" style="margin-top:100px">

    <div class="col-sm-4 " > <a href="/CitassS.aspx" class="myButton"><img src="Iconos/cita.png" alt="Los Tejos" /><br />Citas </a> </div>
    <div class="col-sm-4"> <a href="/IndexPacientesS.aspx" class="myButton"><img src="Iconos/paciente.png" alt="" /><br />Pacientes </a></div>
    <div class="col-sm-4"> <a href="/DiagnosticoS.aspx" class="myButton"><img src="Iconos/diagnostico.png" alt="" /><br />Diagnostico</a></div>
   

</div>
  



</asp:Content>

