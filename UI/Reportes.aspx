<%@ Page Title="" Language="C#" MasterPageFile="~/Dentista.Master" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="UI_ClinicaDental.Reportes" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content1"  ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
   
    <br />
     <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="678px">
        <LocalReport Reportpath="Report1.rdlc">
            <DataSources>
                <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="Reporte1" />
            </DataSources>
        </LocalReport>
    </rsweb:ReportViewer>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData" TypeName="UI.BDClinicaDentalDataCitasTableAdapters.eventTableAdapter" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_event_id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="title" Type="String" />
            <asp:Parameter Name="description" Type="String" />
            <asp:Parameter Name="event_start" Type="DateTime" />
            <asp:Parameter Name="event_end" Type="DateTime" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="title" Type="String" />
            <asp:Parameter Name="description" Type="String" />
            <asp:Parameter Name="event_start" Type="DateTime" />
            <asp:Parameter Name="event_end" Type="DateTime" />
            <asp:Parameter Name="Original_event_id" Type="Int32" />
        </UpdateParameters>
    </asp:ObjectDataSource>

    <div id="reporte2" runat="server">
     <div align="center" class="form-vertical">
         <asp:Label ID="LBFechaIni" ForeColor="black" runat="server" Text="Fecha Inicio: "></asp:Label>
         <asp:TextBox ID="txtFechaini" runat="server"  Width="300px" TextMode="Date" CssClass="form-control"></asp:TextBox>
         <br />
          <asp:Label ID="LBFechaFin" ForeColor="black" runat="server" Text="Fecha Fin: "></asp:Label>
         <asp:TextBox ID="txtFechaFin" runat="server"  Width="300px" TextMode="Date" CssClass="form-control"></asp:TextBox>
         <br />
         
         <asp:Button Text="Crear Reporte" runat="server" ID="btnCrearReporte" CssClass="btn btn-success" OnClick="btnCrearReporte_Click" />
            
        </div>   
       
            </div>
</asp:Content>
