<%@ Page Title="" Language="C#" MasterPageFile="~/Dentista.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI_ClinicaDental.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Estilos.css" rel="stylesheet" />

     <div class="container">
       <div style="max-width:550px" align="center">
           <br />
         <h4 style="color:black">Solo personal autorizado</h4>
         </div>
        <div id="loginbox" style="margin-top:50px"  >
            <div class="panel panel-success" style="max-width:550px">
                <div class="panel-heading">
                    <div class="panel-title" align="center">Inicio de Sesión | Administracion </div>
                </div>
                <div style="padding-top: 30px" class="panel-body">
                    <div class="form-horizontal">
                        
                        <div style="margin-bottom:25px" class="input-group">
                            <span class="input-group-addon"> <i class="glyphicon glyphicon-user"></i> </span>
                            <asp:TextBox ID="txtIdUsuario" runat="server" CssClass="form-control" placeholder="ID Usuario:" TextMode="Number" Width="280px"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                                ControlToValidate="txtIdUsuario"
                                ErrorMessage="El usuario es requerido."
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
                        </div>
						
                         <div style="margin-bottom:25px" class="input-group">
                            <span class="input-group-addon"> <i class="glyphicon glyphicon-lock"></i> </span>
                            <asp:TextBox ID="txtContra" runat="server" CssClass="form-control" TextMode="Password" placeholder="Contraseña" Width="447px"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                                ControlToValidate="txtContra"
                                ErrorMessage="La contraseña es requerida."
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
                        </div>
                        <div style="margin-top:10px" class="form-group">
                            <div class="col-sm-12">
                                <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" OnClick="btnLimpiar_Click" CssClass="btn btn-warning"  BorderStyle="Dashed" BorderColor="LightYellow" BorderWidth="1px" Width="120px"/>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="btnLogin" runat="server" Text="Ingresar" CssClass="btn btn-success" OnClick="btnLogin_Click"  BorderStyle="Dashed" BorderColor="LightGreen" BorderWidth="1px" Width="120px"/>
                                
                            </div>
                            <br />
                                <div class="alert alert-success" visible="false" id="mensaje" style="max-width:350px; margin-left:18px"  runat="server">
                       &nbsp;&nbsp;  <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                         <strong id="textoMensaje" runat="server"></strong>
                         </div>
                       <div class="alert alert-danger" visible="false" id="mensajeError" style="max-width:350px; margin-left:18px" runat="server">
                        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                        <strong id="textoMensajeError" runat="server"></strong>
                         </div>
                            
                        </div>
                         
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
