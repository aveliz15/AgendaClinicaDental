<%@ Page Title="" Language="C#" MasterPageFile="~/Dentista.Master" AutoEventWireup="true" CodeBehind="Diagnostico.aspx.cs" Inherits="UI_ClinicaDental.Diagnostico" %>

   

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="alert alert-success" visible="false" id="mensaje" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
        <strong id="textoMensaje" runat="server"></strong>
    </div>

    <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
        <strong id="textoMensajeError" runat="server"></strong>
    </div>
      
    <h2 style="color: black">Ver diagnostico del paciente</h2>
    <div id="buscar" class="form-inline" runat="server">
      <asp:TextBox ID="ttIdPaciente" runat="server"  Width="300px" TextMode="Number" CssClass="form-control" ></asp:TextBox>
         <asp:Button Text="Buscar" runat="server" ID="btnBuscar" CssClass="btn btn-success" OnClick="btnBuscar_Click" />
        </div>

<div  id="divOdontograma" runat="server">    
     <h2 id="tituloPaciente" runat="server">Paciente: </h2>
    <h3>Niños</h3>
    <div class="container-fluid">
  <div class="row ">
     <div class="col-sm-1 "> <asp:Button ID="d1" runat="server" Width="44px"  Text="1" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d2" runat="server" Width="44px" Text="2"  CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d3" runat="server" Width="44px" Text="3" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1" > <asp:Button ID="d4" runat="server" Width="44px" Text="4" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
          <div class="col-sm-1 "> <asp:Button ID="d5" runat="server" Width="44px" Text="5" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>


    <div class="col-sm-1"> <asp:Button ID="d6" runat="server" Width="44px" Text="6" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d7" runat="server" Width="44px" Text="7" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1" > <asp:Button ID="d8" runat="server" Width="44px" Text="8" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
          <div class="col-sm-1 "> <asp:Button ID="d9" runat="server" Width="44px" Text="9" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d10" runat="server" Width="44px" Text="10" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
     </div>
         </div>

    <div class="container-fluid">
        <div class="row ">

      <div class="col-sm-1"> <asp:Button ID="d11" runat="server" Width="44px" Text="11" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1" > <asp:Button ID="d12" runat="server" Width="44px" Text="12" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
      <div class="col-sm-1"> <asp:Button ID="d13" runat="server" Width="44px" Text="13" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d14" runat="server" Width="44px" Text="14" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1" > <asp:Button ID="d15" runat="server" Width="44px" Text="15" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
     
      <div class="col-sm-1"> <asp:Button ID="d16" runat="server" Width="44px" Text="16" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d17" runat="server" Width="44px" Text="17" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1" > <asp:Button ID="d18" runat="server" Width="44px" Text="18" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
      <div class="col-sm-1"> <asp:Button ID="d19" runat="server" Width="44px" Text="19" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d20" runat="server" Width="44px" Text="20" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    
  </div>
        </div>

       <h3>Adulto</h3>
    <div class="container-fluid">
  <div class="row ">
     <div class="col-sm-1 "> <asp:Button ID="d21" runat="server" Width="44px"  Text="1" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d22" runat="server" Width="44px" Text="2"  CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d23" runat="server" Width="44px" Text="3" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1" > <asp:Button ID="d24" runat="server" Width="44px" Text="4" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
          <div class="col-sm-1 "> <asp:Button ID="d25" runat="server" Width="44px" Text="5" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>


    <div class="col-sm-1"> <asp:Button ID="d26" runat="server" Width="44px" Text="6" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d27" runat="server" Width="44px" Text="7" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1" > <asp:Button ID="d28" runat="server" Width="44px" Text="8" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
          <div class="col-sm-1 "> <asp:Button ID="d29" runat="server" Width="44px" Text="9" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d30" runat="server" Width="44px" Text="10" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
     </div>
         </div>

    <div class="container-fluid">
  <div class="row ">
     <div class="col-sm-1 "> <asp:Button ID="d31" runat="server" Width="44px"  Text="1" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d32" runat="server" Width="44px" Text="2"  CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d33" runat="server" Width="44px" Text="3" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1" > <asp:Button ID="d34" runat="server" Width="44px" Text="4" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
          <div class="col-sm-1 "> <asp:Button ID="d35" runat="server" Width="44px" Text="5" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>


    <div class="col-sm-1"> <asp:Button ID="d36" runat="server" Width="44px" Text="6" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d37" runat="server" Width="44px" Text="7" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1" > <asp:Button ID="d38" runat="server" Width="44px" Text="8" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
          <div class="col-sm-1 "> <asp:Button ID="d39" runat="server" Width="44px" Text="9" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d40" runat="server" Width="44px" Text="10" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
     </div>
         </div>

    <div class="container-fluid">
  <div class="row ">
     <div class="col-sm-1 "> <asp:Button ID="d41" runat="server" Width="44px"  Text="1" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d42" runat="server" Width="44px" Text="2"  CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d43" runat="server" Width="44px" Text="3" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1" > <asp:Button ID="d44" runat="server" Width="44px" Text="4" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
          <div class="col-sm-1 "> <asp:Button ID="d45" runat="server" Width="44px" Text="5" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>


    <div class="col-sm-1"> <asp:Button ID="d46" runat="server" Width="44px" Text="6" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d47" runat="server" Width="44px" Text="7" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1" > <asp:Button ID="d48" runat="server" Width="44px" Text="8" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
          <div class="col-sm-1 "> <asp:Button ID="d49" runat="server" Width="44px" Text="9" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d50" runat="server" Width="44px" Text="10" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
     </div>
         </div>

    <div class="container-fluid ">
  <div class="row  ">
     <div class="col-sm-1 "> <asp:Button ID="d51" runat="server" Width="44px"  Text="1" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d52" runat="server" Width="44px" Text="2"  CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d53" runat="server" Width="44px" Text="3" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1" > <asp:Button ID="d54" runat="server" Width="44px" Text="4" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
          <div class="col-sm-1 "> <asp:Button ID="d55" runat="server" Width="44px" Text="5" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>


    <div class="col-sm-1"> <asp:Button ID="d56" runat="server" Width="44px" Text="6" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d57" runat="server" Width="44px" Text="7" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1" > <asp:Button ID="d58" runat="server" Width="44px" Text="8" CssClass="btn btn-success" ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
      
     </div>
         </div>
    </div><!-- Final divOdontograma -->
</asp:Content>
