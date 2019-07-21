<%@ Page Title="" Language="C#" MasterPageFile="~/Secretaria.Master" AutoEventWireup="true" CodeBehind="InsertarPacienteS.aspx.cs" Inherits="UI_ClinicaDental.InsertarPacienteS" %>
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
        <h2>Nuevo paciente
            <img src="Iconos/add.png" style="max-height:60px; max-width:60px">
        </h2>
        <br />
        <asp:Label ID="LBID" ForeColor="black" runat="server" Text="ID de paciente: "></asp:Label>
        <asp:TextBox ID="txtIdPaciente" name="txtIdPaciente" Width="300px" TextMode="Number" runat="server" CssClass="form-control" ></asp:TextBox>
          <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server"
                                ControlToValidate="txtIdPaciente"
                                ErrorMessage="El ID es requerido."
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>

        <br />
        <asp:Label ID="LBNombre" ForeColor="black" runat="server" Text="Nombre de paciente: "></asp:Label>
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
         <asp:Label ID="LBtelefono" ForeColor="black" runat="server"  Text="Télefono: "></asp:Label>
        <asp:TextBox ID="txtTelefono" runat="server" Width="280px" CssClass="form-control" TextMode="Number" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server"
                                ControlToValidate="txtTelefono"
                                ErrorMessage="El télefono es requerido."
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="LbCorreo" ForeColor="black" runat="server" Text="Correo: "></asp:Label>
        <asp:TextBox ID="txtCorreo" runat="server" Width="280px" CssClass="form-control" TextMode="Email" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                                ControlToValidate="txtCorreo"
                                ErrorMessage="El correo es requerido."
                                ForeColor="Red">
                            </asp:RequiredFieldValidator> 
        <br />
        
        
        <asp:Label ID="LbFecha" ForeColor="black" runat="server" Text="Fecha nacimiento: "></asp:Label>
        <asp:TextBox ID="txtFecha" runat="server" Width="280px" CssClass="form-control"  textMode="date"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server"
                                ControlToValidate="txtFecha"
                                ErrorMessage="La fecha es requerida."
                                ForeColor="Red">
                            </asp:RequiredFieldValidator> 
           <br />
        <div class="form-group">
        <asp:Label ID="lbTipoOntograma" ForeColor="black" runat="server" Text="Tipo de odontograma: "></asp:Label>
       <asp:DropDownList ID="DDLTipoOntograma" CssClass="form-control" Width="280px" runat="server"></asp:DropDownList>
             
        </div>

        <br />
        &nbsp;<asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" CssClass="btn btn-warning" OnClick="btnLimpiar_Click" Width="120px" BorderStyle="Dashed" BorderColor="LightYellow" BorderWidth="1px" />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="btnInsertarPaciente" runat="server" Text="Registrar" CssClass="btn btn-success" OnClick="btnInsertarPaciente_Click" Width="120px" BorderStyle="Dashed" BorderColor="LightYellow" BorderWidth="1px"/>
        
        <br />
      
      
        </div>
    </div>
</asp:Content>
