﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Citass.aspx.cs" Inherits="UI.Citass" %>

<div class="navbar navbar-inverse navbar-fixed-top" >
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" style="color:white" runat="server" href="~/IndexDentista">Logo</a>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav">
                        
                        
                        <li><a runat="server" style="color:white" href="~/IndexAdminUsuarios.aspx">Usuarios</a></li>
                        <li><a runat="server" style="color:white" href="~/IndexPacientesD.aspx">Pacientes</a></li>
                        <li><a runat="server" style="color:white" href="~/Diagnostico.aspx">Diagnosticos</a></li>
                        <li><a runat="server" style="color:white" href="~/Citass.aspx">Citas</a></li>
                        <li><a runat="server" style="color:white" href="~/Reportes.aspx">Reportes</a></li>
                    </ul>
                   
                            <ul class="nav navbar-nav navbar-right">
                               
                               <li><a runat="server" class="btn btn-primary" style="color:white" href="~/Login">Salir</a></li>
                            
                            </ul>
                       
                            <ul class="nav navbar-nav navbar-right">
                                <li></li>
                                <li>
                                   
                                </li>
                            </ul>
                       
                </div>
                 </div>
    </div>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/cupertino/jquery-ui-1.7.3.custom.css" rel="stylesheet" type="text/css" />
    <link href="fullcalendar/fullcalendar.css" rel="stylesheet" type="text/css" />
   
    <script src="jquery/jquery-1.3.2.min.js" type="text/javascript"></script>

    <script src="jquery/jquery-ui-1.7.3.custom.min.js" type="text/javascript"></script>

    <script src="jquery/jquery.qtip-1.0.0-rc3.min.js" type="text/javascript"></script>

    <script src="fullcalendar/fullcalendar.min.js" type="text/javascript"></script>

    <script src="scripts/calendarscript.js" type="text/javascript"></script>
    
    <script src="jquery/jquery-ui-timepicker-addon-0.6.2.min.js" type="text/javascript"></script>

     <link href="css/bootstrap.css" rel="stylesheet" />
     <link href="css/bootstrap.min.css" rel="stylesheet" />
     <link href="css/Botones.css" rel="stylesheet" />
     <link href="css/Estilos.css" rel="stylesheet" />
     <link href="css/Site.css" rel="stylesheet" />


    <style type='text/css'>
           
        body
        {
            margin-top: 40px;
            text-align: center;
            font-size: 14px;
            font-family: "Lucida Grande" ,Helvetica,Arial,Verdana,sans-serif;
        }
        #calendar
        {
            width: 900px;
            margin: 0 auto;
        }
        /* css for timepicker */
        .ui-timepicker-div dl
        {
            text-align: left;
        }
        .ui-timepicker-div dl dt
        {
            height: 25px;
        }
        .ui-timepicker-div dl dd
        {
            margin: -25px 0 10px 65px;
        }
        .style1
        {
            width: 100%;
        }
        
        /* table fields alignment*/
        .alignRight
        {
        	text-align:right;
        	padding-right:10px;
        	padding-bottom:10px;
        }
        .alignLeft
        {
        	text-align:left;
        	padding-bottom:10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true">
    </asp:ScriptManager>
    
    <div id="calendar">
    </div>
    <div id="updatedialog" style="font: 70% 'Trebuchet MS', sans-serif; margin: 50px;"
        title="Update or Delete Event">
        <table cellpadding="0" class="style1">
            <tr>
                <td class="alignRight">
                    Nombre Paciente:</td>
                <td class="alignLeft">
                    <input id="eventName" type="text" /><br /></td>
            </tr>
            <tr>
                <td class="alignRight">
                    Descripcion:</td>
                <td class="alignLeft">
                    <textarea id="eventDesc" cols="30" rows="3" ></textarea></td>
            </tr>
            <tr>
                <td class="alignRight">
                    start:</td>
                <td class="alignLeft">
                    <span id="eventStart"></span></td>
            </tr>
            <tr>
                <td class="alignRight">
                    end: </td>
                <td class="alignLeft">
                    <span id="eventEnd"></span><input type="hidden" id="eventId" /></td>
            </tr>
        </table>
    </div>
    <div id="addDialog" style="font: 70% 'Trebuchet MS', sans-serif; margin: 50px;" title="Add Event">
    <table cellpadding="0" class="style1">
            <tr>
                <td class="alignRight">
                    Nombre Paciente:</td>
                <td class="alignLeft">
                    <input id="addEventName" type="text" size="50" /><br /></td>
            </tr>
            <tr>
                <td class="alignRight">
                    Descripcion:</td>
                <td class="alignLeft">
                    <textarea id="addEventDesc" cols="30" rows="3" ></textarea></td>
            </tr>
            <tr>
                <td class="alignRight">
                    start:</td>
                <td class="alignLeft">
                    <span id="addEventStartDate" ></span></td>
            </tr>
            <tr>
                <td class="alignRight">
                    end:</td>
                <td class="alignLeft">
                    <span id="addEventEndDate" ></span></td>
            </tr>
        </table>
        
    </div>
    <div runat="server" id="jsonDiv" />
    <input type="hidden" id="hdClient" runat="server" />
    </form>
</body>
</html>

