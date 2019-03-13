<%@ Page Title="" Language="C#" MasterPageFile="~/Dentista.Master" AutoEventWireup="true" CodeBehind="BuscarUsuario.aspx.cs" Inherits="UI_ClinicaDental.BuscarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
     <h2 style="color:black">Busqueda de usuarios</h2>
    <div class="alert alert-success" visible="false" id="mensaje" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
        <strong id="textoMensaje" runat="server"></strong>
    </div>
    <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
        <strong id="textoMensajeError" runat="server"></strong>
    </div>
    <div id="buscar" class="form-inline" runat="server">
      <asp:TextBox ID="txtIdCliente" runat="server"  Width="300px" TextMode="Number" CssClass="form-control" ></asp:TextBox>
         <asp:Button Text="Buscar" runat="server" ID="btnBuscar" CssClass="btn btn-success" OnClick="btnBuscar_Click" />
        </div>
    <br />
    <br />
    <div id="gridview" runat="server">
    <asp:GridView ID="GV1"  runat="server" 
        UseAccessibleHeader="true" 
        RowStyle-BackColor="LightGray" 
        Font-Size="Small"
        HeaderStyle-Font-Bold="true" 
        HeaderStyle-BackColor="LightSkyBlue"
        CssClass="table table-responsive" 
        BorderColor="white">
       
    </asp:GridView>
        </div>
    <div class="form-line" id="divMantenimiento" runat="server">

    <div class="form-group">
       
      <asp:Label ID="lbIdUsuario" ForeColor="black" runat="server" Text="ID Usuario: "></asp:Label>
        <asp:TextBox ID="txtIdUsuario" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
            ControlToValidate="txtIdUsuario"
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
            <asp:Label ID="lbDireccion" ForeColor="black" runat="server" Text="Direccion: "></asp:Label>
            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                ControlToValidate="txtDireccion"
                ErrorMessage="La dirección es requerida."
                ForeColor="Red">
            </asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
        <asp:Label ID="lbRol" ForeColor="black" runat="server" Text="Tipo de usuario: "></asp:Label>
       <asp:DropDownList ID="DDLRol" CssClass="form-control" Width="280px" runat="server"></asp:DropDownList>
            <br />
        &nbsp;<asp:Button ID="Volver" runat="server" Text="Volver" CssClass="btn btn-warning" OnClick="Volver_Click" Width="120px" BorderStyle="Dashed" BorderColor="LightYellow" BorderWidth="1px" />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="Confirmar" runat="server" Text="Confirmar" CssClass="btn btn-success" OnClick="Confirmar_Click" Width="120px" BorderStyle="Dashed" BorderColor="LightYellow" BorderWidth="1px"/>
        </div>
        </div>
    
</asp:Content>
