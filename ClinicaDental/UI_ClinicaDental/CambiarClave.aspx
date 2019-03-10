<%@ Page Title="" Language="C#" MasterPageFile="~/Dentista.Master" AutoEventWireup="true" CodeBehind="CambiarClave.aspx.cs" Inherits="UI_ClinicaDental.CambiarClave" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <link rel="stylesheet" href="estilos3.css">

    <h2 style="color: white">Cambio de Contraseña</h2>
    <div class="alert alert-success" visible="false" id="mensaje" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
        <strong id="textoMensaje" runat="server"></strong>
    </div>

    <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
        <strong id="textoMensajeError" runat="server"></strong>
    </div>


    <div class="form-line" id="divMantenimiento" runat="server" visible="false">

    <div class="form-group">
      <asp:Label ID="lbNuevaClave" ForeColor="white" runat="server" Text="Nueva Contraseña: "></asp:Label>
        <asp:TextBox ID="txtNuevaClave" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
            ControlToValidate="txtNuevaClave"
            ErrorMessage="La nueva contraseña es requerida."
            ForeColor="Red">
        </asp:RequiredFieldValidator>
     </div>

        <div class="form-group">
            <asp:Label ID="lbNuevaClave2" ForeColor="white" runat="server" Text="Confirmación: "></asp:Label>
            <asp:TextBox ID="txtNuevaClave2" runat="server" CssClass="form-control" TextMode="Password"> </asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                ControlToValidate="txtNuevaClave2"
                ErrorMessage="La confirmacion es requerida."
                ForeColor="Red">
            </asp:RequiredFieldValidator>
        </div>
        <div class="form-group">

            <asp:Label ID="lbClaveActual" ForeColor="white" runat="server" Text="Contraseña Actual: " TextMode="Password"></asp:Label>
            <asp:TextBox ID="txtClaveActual" runat="server" CssClass="form-control"> </asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                ControlToValidate="txtClaveActual"
                ErrorMessage="La actual contraseña es requerida."
                ForeColor="Red">
            </asp:RequiredFieldValidator>
        </div>

        
       
        </div>
        <br />
        <div class="form-horizontal">
            <asp:Button Text="Modificar" runat="server" ID="btnModificar" CssClass="btn btn-warning" OnClick="btnModificar_Click" />
            

        </div>

</asp:Content>
