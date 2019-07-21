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
        <h2>Nuevo usuario
            <img src="Iconos/addUser.png" style="max-height:60px; max-width:60px">
        </h2>
        <br />
        <asp:Label ID="LBID" ForeColor="black" runat="server" Text="ID de usuario: "></asp:Label>
        <asp:TextBox ID="txtIdUsuario" name="txtIdUsuario" runat="server" CssClass="form-control" ></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server"
                                ControlToValidate="txtIdUsuario"
                                ErrorMessage="El ID es requerido."
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>

        <br />
        <asp:Label ID="LBNombre" ForeColor="black" runat="server" Text="Nombre de usuario: "></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" ></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                                ControlToValidate="txtNombre"
                                ErrorMessage="El nombre es requerido."
                                ForeColor="Red">
                            </asp:RequiredFieldValidator> 
        <br />
        <asp:Label ID="LBApellido1" ForeColor="black" runat="server" Text="Primer apellido: "></asp:Label>
        <asp:TextBox ID="txtApellido1" runat="server" CssClass="form-control" ></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                                ControlToValidate="txtApellido1"
                                ErrorMessage="El primer apellido es requerido."
                                ForeColor="Red">
                            </asp:RequiredFieldValidator> 
        <br />
  
    <asp:Label ID="LbApellido2" ForeColor="black" runat="server" Text="Segundo apellido: "></asp:Label>
          <asp:TextBox ID="txtApellido2" runat="server" CssClass="form-control" ></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                                ControlToValidate="txtApellido2"
                                ErrorMessage="El segundo apellido es requerido."
                                ForeColor="Red">
                            </asp:RequiredFieldValidator> 
        <br />
        <asp:Label ID="LbDireccion" ForeColor="black" runat="server" Text="Direccion: "></asp:Label>
        <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"  ></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                                ControlToValidate="txtDireccion"
                                ErrorMessage="La direccion es requerido."
                                ForeColor="Red">
                            </asp:RequiredFieldValidator> 
        <br />
                <asp:Label ID="LbCorreo" ForeColor="black" runat="server" Text="Correo: "></asp:Label>
        <asp:TextBox ID="txtCorreo" runat="server" Width="280px" TextMode="Email" CssClass="form-control"  ></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"
                                ControlToValidate="txtCorreo"
                                ErrorMessage="El correo es requerido."
                                ForeColor="Red">
                            </asp:RequiredFieldValidator> 
        <br />
         <asp:Label ID="lbRol" ForeColor="black" runat="server" Text="Tipo de usuario: "></asp:Label>
       <asp:DropDownList ID="DDLRol" CssClass="form-control" Width="280px" runat="server"></asp:DropDownList>
      
        <br />
        <asp:Label ID="LBclave1" ForeColor="black" runat="server" Text="Clave: "></asp:Label>
        <asp:TextBox ID="txtClave" runat="server" CssClass="form-control"  textMode="password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server"
                                ControlToValidate="txtClave"
                                ErrorMessage="La clave es requerida."
                                ForeColor="Red">
                            </asp:RequiredFieldValidator> 
           <br />
        
        <asp:Label ID="LBclave2" ForeColor="black" runat="server" Text="Confirmar clave: "></asp:Label>
        <asp:TextBox ID="txtValidarClave" runat="server" CssClass="form-control"  textMode="password"></asp:TextBox>
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
