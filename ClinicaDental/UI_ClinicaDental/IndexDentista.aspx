<%@ Page Title="" Language="C#" MasterPageFile="~/Dentista.Master" AutoEventWireup="true" CodeBehind="IndexDentista.aspx.cs" Inherits="UI_ClinicaDental.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />

   
<div style="margin-left:25px; color:red">
<asp:Label ID="LBUsuariotext" runat="server" Text="Conectado como: ">
</asp:Label><asp:Label ID="LblUsuario" runat="server" Text=""></asp:Label>
</div>

 <link href="Content/Botones.css" rel="stylesheet" type="text/css" />

   
<div class="container-fluid" style="margin-top:100px">

    <div class="col-sm-4 " > <a href="/IndexAdminUsuarios.aspx" class="myButton"><img src="Iconos/usuario.png" alt="Los Tejos" /><br />Usuarios </a> </div>
    <div class="col-sm-4"> <a href="/IndexPacientesD.aspx" class="myButton"><img src="Iconos/paciente.png" alt="Los Tejos" /><br />Pacientes </a></div>
    <div class="col-sm-4"> <a href="/Diagnostico.aspx" class="myButton"><img src="Iconos/diagnostico.png" alt="Los Tejos" /><br />Diagnostico</a></div>
   

</div>
    <div style="margin-top:53px" ></div>



 <div class="col-sm-4" style="margin-top:40px; margin-left:200px;"> <a href="#" class="myButton"><img src="Iconos/cita.png" alt="Los Tejos" /><br />Citas</a></div>
    <div class="col-sm-4" style="margin-top:40px"> <a href="#" class="myButton"><img src="Iconos/reporte.png" alt="Los Tejos" /><br />Reportes</a></div>


    
</asp:Content>
<%--  --%><%--  --%>