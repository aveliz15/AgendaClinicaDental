<%@ Page Title="" Language="C#" MasterPageFile="~/Dentista.Master" AutoEventWireup="true" CodeBehind="Diagnostico.aspx.cs" Inherits="UI_ClinicaDental.Diagnostico" %>

   

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <div class="alert alert-success" visible="false" id="mensaje" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
        <strong id="textoMensaje" runat="server"></strong>
    </div>

    <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
        <strong id="textoMensajeError" runat="server"></strong>
    </div>
      
    <div id="buscador" runat="server">
    <h2 style="color: black">Ver diagnostico del paciente</h2>
    <div id="buscar" class="form-inline" runat="server">
      <asp:TextBox ID="ttIdPaciente" runat="server"  Width="300px" TextMode="Number" Placeholder="ID del paciente:" CssClass="form-control" ></asp:TextBox>
         <asp:Button Text="Buscar" runat="server" ID="btnBuscar" CssClass="btn btn-success" OnClick="btnBuscar_Click" />
        </div>
    </div>
<div  id="divOdontogramaNiño" runat="server" style="float:left">    
     <h2 id="tituloPaciente" runat="server">Paciente: </h2>
    
    
    <div id="arriba" style=" background-color:pink; width:260px">

        <div  style="margin-left:83px">
             <asp:Button ID="d5" runat="server" Width="44px" Text="5" CssClass="btn btn-success"  onClick="d5_Click" ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        
       <asp:Button ID="d6" runat="server" Width="44px" Text="6" CssClass="btn btn-success" OnClick="d6_Click"  ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/> 
            </div>
        <div  style="margin-left:53px" > <asp:Button ID="d4" runat="server" Width="44px" Text="4" OnClick="d4_Click" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
            
      &nbsp;  &nbsp;   &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:Button ID="d7" runat="server" Width="44px" OnClick="d7_Click" Text="7" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
            
            </div>

        <div  style="margin-left:30px"><asp:Button ID="d3" runat="server" OnClick="d3_Click" Width="44px" Text="3" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
             &nbsp;  &nbsp; &nbsp;    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;  <asp:Button ID="d8" OnClick="d8_Click" runat="server" Width="44px" Text="8" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
            </div>
        <div  style="margin-left:20px"> <asp:Button ID="d2" runat="server" Width="44px" Text="2"  CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" OnClick="d2_Click" BorderWidth="1px"/>
            &nbsp;  &nbsp;   &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="d9" OnClick="d9_Click" runat="server" Width="44px" Text="9" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
            </div>
        <div style="margin-left:10px; margin-bottom:0px">
         <asp:Button ID="d1" runat="server" Width="44px"  Text="1" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" OnClick="d1_Click"/>
          &nbsp;   &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;<asp:Button onclick="d10_Click" ID="d10" runat="server" Width="44px" Text="10" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
            </div>
            
            
        
         
        
    
       
        
      
        
   
       
   
        
      </div>
        <br />
    <div id="abajo" style="background-color:pink; width:260px">
  
     <div style="margin-left:10px"> <asp:Button ID="d11" runat="server" Width="44px" Text="11" OnClick="d11_Click" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        &nbsp;   &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;<asp:Button ID="d20" runat="server" Width="44px" OnClick="d20_Click" Text="20" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>    
     </div>
    <div  style="margin-left:20px">  <asp:Button ID="d12" OnClick="d12_Click" runat="server" Width="44px" Text="12" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
     &nbsp;  &nbsp;   &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;  <asp:Button ID="d19" OnClick="d19_Click" runat="server" Width="44px" Text="19" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
       
    </div>
    <div  style="margin-left:30px"> <asp:Button ID="d13" OnClick="d13_Click" runat="server" Width="44px" Text="13" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        &nbsp;  &nbsp; &nbsp;    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp; <asp:Button ID="d18" runat="server" OnClick="d18_Click" Width="44px" Text="18" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        
    </div>
    <div  style="margin-left:53px" >  <asp:Button ID="d14" runat="server" Width="44px" Text="14" CssClass="btn btn-success" OnClick="d14_Click"  ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
         &nbsp;  &nbsp;   &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; <asp:Button ID="d17" runat="server" Width="44px" Text="17" OnClick="d17_Click" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
       
        
          <div  style="margin-left:30px">  <asp:Button ID="d15" runat="server" Width="44px" Text="15" CssClass="btn btn-success" OnClick="d15_Click"  ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        <asp:Button ID="d16" runat="server" Width="44px" Text="16" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  OnClick="d16_Click" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
    
        </div>
    
        </div>
         
       </div>
    
     
       
     <br />
  <asp:Button Text="Volver" runat="server" ID="Volver" CssClass="btn btn-warning" OnClick="Volver_Click" />
        </div>
   
    <br />
    <br />
    
    <div id="MostrarDiagnostico"  runat="server"  style="width:450px;float:right;margin-right:100px;">
        <h2>Historial de diagnosticos:</h2>
         <asp:ListView ID="LVDiagnosticos" runat="server" ItemType="DATOS_ClinicaDental.Modelos.Diagnostico">
              
              <ItemTemplate>
                   <div style="width: 445px; float: left ; border-style:outset ; border-color:darkgray; " >
               
                <strong>
                    <p style="color:black">
                    ID Paciente: <%#Item.IdPaciente %>
                    <br />
                  # Diente:       <%#Item.IdDiente %>
                    <br />
                 Detalle: <%# Item.Detalle %>
                    <br />
                 Fecha: <%# Item.Fecha %>
                   <p/> 
       <strong/>
                       </div>
          </ItemTemplate>
    
       
             </asp:ListView>
        <br />
        <br />
        <br />
          <asp:DataPager runat="server" ID="DPDiagnosticos" PagedControlID="LVDiagnosticos" PageSize="3" class="btn-group">
        <Fields>
            <asp:NextPreviousPagerField ButtonType="Link"
                ShowFirstPageButton="true" ShowPreviousPageButton="true" ShowNextPageButton="false" ShowLastPageButton="false"
                FirstPageText="«" PreviousPageText="<"
                ButtonCssClass="btn btn-default" />
            <asp:NumericPagerField ButtonCount="2" ButtonType="Link"
                CurrentPageLabelCssClass="btn btn-default active" NumericButtonCssClass="btn btn-default" />
            <asp:NextPreviousPagerField ButtonType="Link"
                ShowFirstPageButton="false" ShowPreviousPageButton="false" ShowNextPageButton="true" ShowLastPageButton="true"
                NextPageText=">" LastPageText="»"
                ButtonCssClass="btn btn-default" />
        </Fields>
    </asp:DataPager>
        
        <asp:Button Text="Agregar Diagnostico" Style="float:right" runat="server" ID="btnAgregar" CssClass="btn btn-success" OnClick="btnAgregar_Click" />
            </div>

    
    <div id="divMantenimientoDiag" runat="server" style="width:450px;float:right;margin-right:100px;">
         <br />
        <h2> Agregar Diagnostico
            <img src="" style="max-height:70px; max-width:70px">
        </h2>
        
        <br />
        <asp:Label ID="LBDetalle" ForeColor="black" runat="server" Width="300px" Text="Detalle: "></asp:Label>
        <asp:TextBox ID="txtDetalle" runat="server" CssClass="form-control" ></asp:TextBox>
         <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                                ControlToValidate="txtDetalle"
                                ErrorMessage="El detalle es requerido."
                                ForeColor="Red">
                            </asp:RequiredFieldValidator> --%>
        <br />
        
        &nbsp;<asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" CssClass="btn btn-warning" OnClick="btnLimpiar_Click" Width="120px" BorderStyle="Dashed" BorderColor="LightYellow" BorderWidth="1px" />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="btnAgregarDiagnostico" runat="server" Text="Agregar" CssClass="btn btn-success" OnClick="btnAgregarDiagnostico_Click" Width="120px" BorderStyle="Dashed" BorderColor="LightYellow" BorderWidth="1px"/>
    </div>
            
      
   

    <div  id="divOdontogramaAdulto" runat="server"> 
       <h3>Adulto</h3>
    <div class="container-fluid">
  <div class="row ">
     <div class="col-sm-1 "> <asp:Button ID="d21" runat="server" Width="44px"  Text="21" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d22" runat="server" Width="44px" Text="22"  CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d23" runat="server" Width="44px" Text="23" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1" > <asp:Button ID="d24" runat="server" Width="44px" Text="24" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
          <div class="col-sm-1 "> <asp:Button ID="d25" runat="server" Width="44px" Text="25" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>


    <div class="col-sm-1"> <asp:Button ID="d26" runat="server" Width="44px" Text="26" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d27" runat="server" Width="44px" Text="27" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1" > <asp:Button ID="d28" runat="server" Width="44px" Text="28" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
          <div class="col-sm-1 "> <asp:Button ID="d29" runat="server" Width="44px" Text="29" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d30" runat="server" Width="44px" Text="30" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
     </div>
         </div>

    <div class="container-fluid">
  <div class="row ">
     <div class="col-sm-1 "> <asp:Button ID="d31" runat="server" Width="44px"  Text="31" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d32" runat="server" Width="44px" Text="32"  CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d33" runat="server" Width="44px" Text="33" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1" > <asp:Button ID="d34" runat="server" Width="44px" Text="34" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
          <div class="col-sm-1 "> <asp:Button ID="d35" runat="server" Width="44px" Text="35" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>


    <div class="col-sm-1"> <asp:Button ID="d36" runat="server" Width="44px" Text="36" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d37" runat="server" Width="44px" Text="37" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1" > <asp:Button ID="d38" runat="server" Width="44px" Text="38" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
          <div class="col-sm-1 "> <asp:Button ID="d39" runat="server" Width="44px" Text="39" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d40" runat="server" Width="44px" Text="40" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
     </div>
         </div>

    <div class="container-fluid">
  <div class="row ">
     <div class="col-sm-1 "> <asp:Button ID="d41" runat="server" Width="44px"  Text="41" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d42" runat="server" Width="44px" Text="42"  CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d43" runat="server" Width="44px" Text="43" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1" > <asp:Button ID="d44" runat="server" Width="44px" Text="44" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
          <div class="col-sm-1 "> <asp:Button ID="d45" runat="server" Width="44px" Text="45" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>


    <div class="col-sm-1"> <asp:Button ID="d46" runat="server" Width="44px" Text="46" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d47" runat="server" Width="44px" Text="47" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1" > <asp:Button ID="d48" runat="server" Width="44px" Text="48" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
          <div class="col-sm-1 "> <asp:Button ID="d49" runat="server" Width="44px" Text="49" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d50" runat="server" Width="44px" Text="50" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
     </div>
         </div>

    <div class="container-fluid ">
  <div class="row  ">
     <div class="col-sm-1 "> <asp:Button ID="d51" runat="server" Width="44px"  Text="51" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
    <div class="col-sm-1"> <asp:Button ID="d52" runat="server" Width="44px" Text="52"  CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        </div>
   
      
     </div>
         </div>
        <br />
        <asp:Button Text="Volver" runat="server" ID="Volver2" CssClass="btn btn-warning" OnClick="Volver2_Click" />
    </div>
                    <!-- Final divOdontograma -->
</asp:Content>
