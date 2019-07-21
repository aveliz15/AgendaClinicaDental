<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Dentista.Master" CodeBehind="Diagnostico.aspx.cs" Inherits="UI.Diagnostico" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />

    
     <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.10.19/css/jquery.dataTables.css"> 
<script type="text/javascript" charset="utf8" src="https://cdn.datatables.net/1.10.19/js/jquery.dataTables.js"></script>
    <script>
    $(function () {
    $(".gvv").prepend( $("<thead></thead>").append( $(this).find("tr:first") ) ).dataTable();
});
</script>

    <script>
         
        $(document).ready(function () {
    $('#GV1').DataTable();
        });
       </script>

    <div class="alert alert-success" visible="false" id="mensaje" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
        <strong id="textoMensaje" runat="server"></strong>
    </div>

    <div class="alert alert-danger" visible="false" id="mensajeError" runat="server">
        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times</a>
        <strong id="textoMensajeError" runat="server"></strong>
    </div>

    <div id="buscador" runat="server">
        <h2 style="color: black">Buscar odontograma:</h2>
        <div id="buscar" class="form-inline" runat="server">
            <asp:TextBox ID="ttIdPaciente" runat="server" Width="300px" TextMode="Number" Placeholder="ID del paciente:" CssClass="form-control"></asp:TextBox>
            <asp:Button Text="Buscar" runat="server" ID="btnBuscar" CssClass="btn btn-success" OnClick="btnBuscar_Click" />
        </div>
    </div>
    <br />
        <div id="gridview" runat="server">
    <asp:GridView ID="GV1"  runat="server" CssClass="gvv" >
     
       
    </asp:GridView>
        </div>

    <div id="divOdontogramaNiño"  runat="server" style="float: left">
        <h2 id="tituloPaciente" runat="server">Paciente: </h2>

         <div id="arribayabajo1" style="width:270px;
 border-top: 4px solid #B00E0E;
 border-bottom: 4px solid #B00E0E;
 border-radius: 40px;
 box-shadow: 0px 10px 13px -7px #000000, 0px 5px 15px 5px rgba(0,0,0,0);
  ">
        <div id="arriba" style="width: 260px">
            <br />
            <div style="margin-left: 83px">
                <asp:Button ID="d5" runat="server" Width="44px" Text="5" CssClass="btn btn-success" OnClick="d5_Click" ForeColor="Black" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />

                <asp:Button ID="d6" runat="server" Width="44px" Text="6" CssClass="btn btn-success" OnClick="d6_Click" ForeColor="Black" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />
            </div>
            <div style="margin-left: 53px">
                <asp:Button ID="d4" runat="server" Width="44px" Text="4" OnClick="d4_Click" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />

                &nbsp;  &nbsp;   &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:Button ID="d7" runat="server" Width="44px" OnClick="d7_Click" Text="7" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />

            </div>

            <div style="margin-left: 30px">
                <asp:Button ID="d3" runat="server" OnClick="d3_Click" Width="44px" Text="3" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />
                &nbsp;  &nbsp; &nbsp;    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp; 
                <asp:Button ID="d8" OnClick="d8_Click" runat="server" Width="44px" Text="8" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />
            </div>
            <div style="margin-left: 20px">
                <asp:Button ID="d2" runat="server" Width="44px" Text="2" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" BorderStyle="Solid" OnClick="d2_Click" BorderWidth="1px" />
                &nbsp;  &nbsp;   &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="d9" OnClick="d9_Click" runat="server" Width="44px" Text="9" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />
            </div>
            <div style="margin-left: 10px; margin-bottom: 0px">
                <asp:Button ID="d1" runat="server" Width="44px" Text="1" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" OnClick="d1_Click" />
                &nbsp;   &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;<asp:Button OnClick="d10_Click" ID="d10" runat="server" Width="44px" Text="10" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />
                
                 </div>


        </div>
        <br />
       
        <div  class="abajo" id="abajo" style="width: 260px ">

            <div style="margin-left: 10px">
                <asp:Button ID="d11" runat="server" Width="44px" Text="11" OnClick="d11_Click" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />
                &nbsp;   &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;<asp:Button ID="d20" runat="server" Width="44px" OnClick="d20_Click" Text="20" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />
            </div>
            <div style="margin-left: 20px">
                <asp:Button ID="d12" OnClick="d12_Click" runat="server" Width="44px" Text="12" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />
                &nbsp;  &nbsp;   &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; 
                <asp:Button ID="d19" OnClick="d19_Click" runat="server" Width="44px" Text="19" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />

            </div>
            <div style="margin-left: 30px">
                <asp:Button ID="d13" OnClick="d13_Click" runat="server" Width="44px" Text="13" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />
                &nbsp;  &nbsp; &nbsp;    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;
                <asp:Button ID="d18" runat="server" OnClick="d18_Click" Width="44px" Text="18" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />

            </div>
            <div style="margin-left: 53px">
                <asp:Button ID="d14" runat="server" Width="44px" Text="14" CssClass="btn btn-success" OnClick="d14_Click" ForeColor="Black" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />
                &nbsp;  &nbsp;   &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                <asp:Button ID="d17" runat="server" Width="44px" Text="17" OnClick="d17_Click" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />


                <div style="margin-left: 30px">
                    <asp:Button ID="d15" runat="server" Width="44px" Text="15" CssClass="btn btn-success" OnClick="d15_Click" ForeColor="Black" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />
                    <asp:Button ID="d16" runat="server" Width="44px" Text="16" CssClass="btn btn-success" ForeColor="Black" BackColor="White" OnClick="d16_Click" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />

                </div>

            </div>
            <br />
        </div>
            </div>


        <br />
        <asp:Button Text="Volver" runat="server" ID="Volver" CssClass="btn btn-warning" OnClick="Volver_Click" />
    </div>

    <br />
    <br />

    <div id="MostrarDiagnostico" runat="server" style="width: 450px; float: right; margin-right: 100px;">
        <h2>Historial de diagnósticos:</h2>
        <asp:ListView ID="LVDiagnosticos" runat="server" ItemType="DATOS_ClinicaDental.Modelos.Diagnostico">

            <ItemTemplate>
                <div style="width: 445px; float: left; border-style: outset; border-color: darkgray;">

                    
                        
                        <p style="color: black;font-family:Arial;font-style:italic">
                        <strong>   ID Paciente: </strong> <%#Item.IdPaciente %> 
                        <br />
                      <strong>    Diente: </strong>         <%#Item.IdDiente %>
                        <br />
                      <strong>    Detalle: </strong>   <%# Item.Detalle %>
                        <br />
                       <strong>    Fecha: </strong>   <%# Item.Fecha.ToShortDateString() %>
                    <p />
                    
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

        <asp:Button Text="Agregar diagnóstico" Style="float: right" runat="server" ID="btnAgregar" CssClass="btn btn-success" OnClick="btnAgregar_Click" />
    </div>
    


    <div id="divOdontogramaAdulto" runat="server" style="float: left">
        <h2 id="tituloPaciente2" runat="server">Paciente: </h2>
        
        <div id="arribayabajo2" style="width:380px;
 border-top: 4px solid #B00E0E;
 border-bottom: 4px solid #B00E0E;
 border-radius: 40px;
 box-shadow: 0px 10px 13px -7px #000000, 0px 5px 15px 5px rgba(0,0,0,0);
  ">
        <div id="arriba2" style="width: 380px">
            <br />

            <center>
            <asp:Button ID="d27" runat="server" Width="40px" Text="27" CssClass="btn btn-success"   ForeColor="Black" BackColor="White" OnClick="d27_Click" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
            <asp:Button ID="d28" runat="server" Width="40px" Text="28" CssClass="btn btn-success"   ForeColor="Black" BackColor="White" OnClick="d28_Click" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
      
            <asp:Button ID="d29" runat="server" Width="40px" Text="29" CssClass="btn btn-success"   ForeColor="Black" BackColor="White" OnClick="d29_Click" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
        
            <asp:Button ID="d30" runat="server" Width="40px" Text="30" CssClass="btn btn-success"   ForeColor="Black" BackColor="White" OnClick="d30_Click" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"/>
         </center>

            <div style="margin-left: 75px">
                <asp:Button ID="d26" runat="server" Width="40px" Text="26" CssClass="btn btn-success" ForeColor="Black" BackColor="White" OnClick="d26_Click" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />
                &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;  &nbsp;  &nbsp;    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                <asp:Button ID="d31" runat="server" Width="40px" Text="31" CssClass="btn btn-success" ForeColor="Black" BackColor="White" OnClick="d31_Click" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />
            </div>
            <div style="margin-left: 55px">
                <asp:Button ID="d25" runat="server" Width="40px" Text="25" CssClass="btn btn-success" ForeColor="Black" BackColor="White" OnClick="d25_Click" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px" />
                &nbsp;  &nbsp; &nbsp;   &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="d32" runat="server" Width="40px" Text="32" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" OnClick="d32_Click" BorderStyle="Solid" BorderWidth="1px" />
            </div>
            <div style="margin-left: 45px">
                <asp:Button ID="d24" runat="server" Width="40px" Text="24" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" OnClick="d24_Click" BorderStyle="Solid" BorderWidth="1px" />
                &nbsp;  &nbsp;  &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="d33" runat="server" Width="40px" Text="33" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" OnClick="d33_Click" BorderStyle="Solid" BorderWidth="1px" />
            </div>
            <div style="margin-left: 35px">
                <asp:Button ID="d23" runat="server" Width="40px" Text="23" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" OnClick="d23_Click" BorderStyle="Solid" BorderWidth="1px" />
                &nbsp;  &nbsp;  &nbsp;  &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp;  &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="d34" runat="server" Width="40px" Text="34" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" OnClick="d34_Click" BorderStyle="Solid" BorderWidth="1px" />
            </div>
            <div style="margin-left: 30px">
                <asp:Button ID="d22" runat="server" Width="40px" Text="22" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" OnClick="d22_Click" BorderStyle="Solid" BorderWidth="1px" />
                &nbsp;  &nbsp;  &nbsp;  &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp;  &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="d35" runat="server" Width="40px" Text="35" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" OnClick="d35_Click" BorderStyle="Solid" BorderWidth="1px" />
            </div>
            <div style="margin-left: 25px">
                <asp:Button ID="d21" runat="server" Width="40px" Text="21" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" OnClick="d21_Click" BorderStyle="Solid" BorderWidth="1px" />
                &nbsp;  &nbsp;  &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;  &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="d36" runat="server" Width="40px" Text="36" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" OnClick="d36_Click" BorderStyle="Solid" BorderWidth="1px" />
            </div>
        </div>
        <br />

        <div id="abajo2" style="width: 380px">


            <div style="margin-left: 25px">
                <asp:Button ID="d52" runat="server" Width="40px" Text="52" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" OnClick="d52_Click" BorderStyle="Solid" BorderWidth="1px" />
                &nbsp;  &nbsp;  &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;  &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="d37" runat="server" Width="40px" Text="37" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" OnClick="d37_Click" BorderStyle="Solid" BorderWidth="1px" />
            </div>
            <div style="margin-left: 30px">
                <asp:Button ID="d51" runat="server" Width="40px" Text="51" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" OnClick="d51_Click" BorderStyle="Solid" BorderWidth="1px" />
                &nbsp;  &nbsp;  &nbsp;  &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp;  &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:Button ID="d38" runat="server" Width="40px" Text="38" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" OnClick="d38_Click" BorderStyle="Solid" BorderWidth="1px" />
            </div>
            <div style="margin-left: 35px">
                <asp:Button ID="d50" runat="server" Width="40px" Text="50" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" OnClick="d50_Click" BorderStyle="Solid" BorderWidth="1px" />
                &nbsp;  &nbsp;  &nbsp;  &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp;  &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="d39" runat="server" Width="40px" Text="39" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" OnClick="d39_Click" BorderStyle="Solid" BorderWidth="1px" />
            </div>
            <div style="margin-left: 45px">
                <asp:Button ID="d49" runat="server" Width="40px" Text="49" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" OnClick="d49_Click" BorderStyle="Solid" BorderWidth="1px" />
                &nbsp;  &nbsp;  &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp;  &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Button ID="d40" runat="server" Width="40px" Text="40" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" OnClick="d40_Click" BorderStyle="Solid" BorderWidth="1px" />
            </div>
            <div style="margin-left: 55px">
                <asp:Button ID="d48" runat="server" Width="40px" Text="48" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" OnClick="d48_Click" BorderStyle="Solid" BorderWidth="1px" />
                &nbsp;  &nbsp; &nbsp;   &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="d41" runat="server" Width="40px" Text="41" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" OnClick="d41_Click" BorderStyle="Solid" BorderWidth="1px" />
            </div>
            <div style="margin-left: 75px">
                <asp:Button ID="d47" runat="server" Width="40px" Text="47" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" OnClick="d47_Click" BorderStyle="Solid" BorderWidth="1px" />
                &nbsp;  &nbsp; &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;  &nbsp;  &nbsp;    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                <asp:Button ID="d42" runat="server" Width="40px" Text="42" CssClass="btn btn-success" ForeColor="Black" BackColor="White" BorderColor="Black" OnClick="d42_Click" BorderStyle="Solid" BorderWidth="1px" />
            </div>
            <center>
                 <asp:Button ID="d46" runat="server" Width="40px" Text="46" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" OnClick="d46_Click" BorderStyle="Solid" BorderWidth="1px"/>
                <asp:Button ID="d45" runat="server" Width="40px" Text="45" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" BorderStyle="Solid" OnClick="d45_Click" BorderWidth="1px"/>
                <asp:Button ID="d44" runat="server" Width="40px" Text="44" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" OnClick="d44_Click" BorderStyle="Solid" BorderWidth="1px"/>
                <asp:Button ID="d43" runat="server" Width="40px" Text="43" CssClass="btn btn-success"   ForeColor="Black" BackColor="White"  BorderColor="Black" OnClick="d43_Click" BorderStyle="Solid" BorderWidth="1px"/>
     </center>
            <br />
        </div>
            </div>

        <br />
        <asp:Button Text="Volver" runat="server" ID="Volver2" CssClass="btn btn-warning" OnClick="Volver2_Click" />
    </div>

    <div id="divMantenimientoDiag" runat="server" style="width: 450px; float: right; margin-right: 100px;">
        <br />
        <h2>Agregar diagnóstico
            <img src="Iconos/add.png" style="max-height: 40px; max-width: 40px">
        </h2>

        <br />
        <asp:Label ID="LBDetalle" ForeColor="black" runat="server" Width="300px" Text="Detalle: "></asp:Label>
        <asp:TextBox ID="txtDetalle" runat="server" CssClass="form-control"></asp:TextBox>

        <br />

        &nbsp;<asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" CssClass="btn btn-warning" OnClick="btnLimpiar_Click" Width="120px" BorderStyle="Dashed" BorderColor="LightYellow" BorderWidth="1px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="btnAgregarDiagnostico" runat="server" Text="Agregar" CssClass="btn btn-success" OnClick="btnAgregarDiagnostico_Click" Width="120px" BorderStyle="Dashed" BorderColor="LightYellow" BorderWidth="1px" />
    </div>




</asp:Content>
