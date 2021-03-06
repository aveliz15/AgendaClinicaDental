﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Dentista.Master" AutoEventWireup="true" CodeBehind="ModificarUsuario.aspx.cs" Inherits="UI_ClinicaDental.ModificarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link rel="stylesheet" href="estilos3.css">

    <h2 style="color: black">Modificar datos del usuario</h2>
    
    <div class="alert alert-success" visible="false" id="mensaje" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
        <strong id="textoMensaje" runat="server"></strong>
    </div>

    <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
        <strong id="textoMensajeError" runat="server"></strong>
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

            <asp:Label ID="lbRol" ForeColor="black" runat="server" Text="Rol: "></asp:Label>
            <asp:TextBox ID="txtRol" runat="server" CssClass="form-control"  ></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"
                ControlToValidate="txtRol"
                ErrorMessage="El rol es requerido."
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
        </div>
        <br />
        <div class="form-horizontal">
            <asp:Button Text="Modificar" runat="server" ID="btnModificar" CssClass="btn btn-success" OnClick="btnModificar_Click" />
            
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;  <asp:Button Text="Cambiar clave" OnClick="btnCambiarClave_Click" runat="server" ID="btnCambiarClave" CssClass="btn btn-primary" />
       
            </div>
    
          
           
             
    
      


</asp:Content>
