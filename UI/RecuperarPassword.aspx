<%@ Page Title="" Language="C#" MasterPageFile="~/LoginDentista.Master" AutoEventWireup="true" CodeBehind="RecuperarPassword.aspx.cs" Inherits="UI_ClinicaDental.RecuperarPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <link rel="stylesheet" href="estilos3.css">

    <h2 style="color: black">Recuperación de Contraseña</h2>


    <div class="alert alert-success" visible="false" id="mensaje" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
        <strong id="textoMensaje" runat="server"></strong>
    </div>

    <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
        <strong id="textoMensajeError" runat="server"></strong>
    </div>


    

    <div class="form-group">
      <asp:Label ID="lbUsuario" ForeColor="black" runat="server" Text="Usuario: "></asp:Label>
        <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
            ControlToValidate="txtUsuario"
            ErrorMessage="El usuario es requerido."
            ForeColor="Red">
        </asp:RequiredFieldValidator>
     </div>

        
       
        <div class="form-horizontal">
       &nbsp;   &nbsp; &nbsp; &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;   &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;  <asp:Button Text="Recuperar por correo"  runat="server" ID="btnRecuperar" CssClass="btn btn-success" OnClick="btnRecuperar_Click" />
            

        </div>

</asp:Content>
