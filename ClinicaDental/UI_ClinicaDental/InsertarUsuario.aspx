<%@ Page Title="" Language="C#" MasterPageFile="~/Dentista.Master" AutoEventWireup="true" CodeBehind="InsertarUsuario.aspx.cs" Inherits="UI_ClinicaDental.InsertarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="alert alert-success" visible="false" id="mensaje" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <strong id="textoMensaje" runat="server"></strong>
    </div>
    <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
        <strong id="textoMensajeError" runat="server"></strong>
    </div>
    <div  align="center">
    <div class="form-group" align="center" >
        <br />
        <h2>Nuevo Usuario
            <img src="" style="max-height:70px; max-width:70px">
        </h2>
        <br />

        <asp:TextBox ID="txtIdUsuario" name="txtIdUsuario" runat="server" CssClass="form-control" placeholder="ID Usuario:" ></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server"
                                ControlToValidate="txtIdUsuario"
                                ErrorMessage="El ID es requerido."
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>

        <br />
        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Nombre:"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                                ControlToValidate="txtNombre"
                                ErrorMessage="El nombre es requerido."
                                ForeColor="Red">
                            </asp:RequiredFieldValidator> 
        <br />
        <asp:TextBox ID="txtApellido1" runat="server" CssClass="form-control" placeholder="Primer Apellido:"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                                ControlToValidate="txtApellido1"
                                ErrorMessage="El primer apellido es requerido."
                                ForeColor="Red">
                            </asp:RequiredFieldValidator> 
        <br />
  
    
          <asp:TextBox ID="txtApellido2" runat="server" CssClass="form-control" placeholder="Segundo Apellido:"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                                ControlToValidate="txtApellido2"
                                ErrorMessage="El segundo apellido es requerido."
                                ForeColor="Red">
                            </asp:RequiredFieldValidator> 
        <br />
        <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" placeholder="Direccion: "></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                                ControlToValidate="txtDireccion"
                                ErrorMessage="La direccion es requerido."
                                ForeColor="Red">
                            </asp:RequiredFieldValidator> 
        <br />
        <asp:TextBox ID="txtRol" runat="server" CssClass="form-control" placeholder="ID Rol:" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server"
                                ControlToValidate="txtRol"
                                ErrorMessage="El numero de rol es requerido."
                                ForeColor="Red">
                            </asp:RequiredFieldValidator> 
        <br />
        <asp:TextBox ID="txtClave" runat="server" CssClass="form-control" placeholder="Clave:" textMode="password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server"
                                ControlToValidate="txtClave"
                                ErrorMessage="La clave es requerida."
                                ForeColor="Red">
                            </asp:RequiredFieldValidator> 
           <br />
        <asp:TextBox ID="txtValidarClave" runat="server" CssClass="form-control" placeholder="Clave:" textMode="password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                                ControlToValidate="txtValidarClave"
                                ErrorMessage="La validacion de clave es requerida."
                                ForeColor="Red">
                            </asp:RequiredFieldValidator> 
        <br />
        &nbsp;<asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" CssClass="btn btn-warning" OnClick="btnLimpiar_Click" Width="120px" BorderStyle="Dashed" BorderColor="LightYellow" BorderWidth="1px" />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="btnInsertarUsuario" runat="server" Text="Registrar" CssClass="btn btn-success" OnClick="btnInsertarUsuario_Click" Width="120px" BorderStyle="Dashed" BorderColor="LightYellow" BorderWidth="1px"/>
        
        <br />
        <br />
      
        </div>
    </div>
</asp:Content>
