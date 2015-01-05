﻿<%@ Page Language="C#" CodeBehind="~/Home.aspx.cs" AutoEventWireup="true" Inherits="Contestation.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link rel="stylesheet" href="Content/themes/base/jquery-ui.css" />
    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
    <script src="//ajax.googleapis.com/ajax/libs/jqueryui/1.10.4/jquery-ui.min.js"></script>

    <%--<link rel="stylesheet" href="//code.jquery.com/ui/1.10.4/themes/smoothness/jquery-ui.css" />--%>

    <%--<script src="Scripts/jquery-1.7.1.js"></script>
    <script src="Scripts/jquery.colorbox.js"></script>
    <script src="Scripts/jquery-ui-1.8.20.js"></script>--%>

    <link href="Css/main.css" rel="stylesheet" />
    <link href="Css/menu.css" rel="stylesheet" />
    <link rel="stylesheet" href="CSS/colorbox.css" />

    <%--    <script src="//ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>--%>

    <link href='http://fonts.googleapis.com/css?family=Gafata' rel='stylesheet' type='text/css' />

</head>
<body>
    <form id="form1" runat="server">
        <div class="wrapper-home">
            <div class="top-bar-wrapper">
                <div class="sitelogo"></div>
                <div class="menu">
                    <ul>
                        <li><a id="tab1" href="/Home.aspx"><span>Home</span></a></li>
                        <li><a id="tab2" href="/Optimum/Optimum.aspx"><span>Optimum</span></a></li>
                        <li><a id="tab3" href="/Freedom/Freedom.aspx"><span>Freedom</span></a></li>
                    </ul>
                </div>
            </div>
            <div class="top-bar-login-details">
                <ul class="ul-login-details">
                    <%
                        string uname = "";
                        try
                        {
                            uname = Session["username"].ToString();
                        }
                        catch (NullReferenceException)
                        {
                            logoutAll();
                        }
                    %>
                    <li><span>Welcome, </span><% Response.Write(uname);%> </li>
                </ul>
                <span>
                    <input type="hidden" id="menu1" value="" />
                </span>
                <div class="submenu" id='cssmenu'>
                    <ul>
                        <li>
                            <asp:LinkButton ID="btnLogout" runat="server" OnClick="btnLogout_Click1">Logout</asp:LinkButton></li>
                    </ul>
                </div>

            </div>
            <div class="dv_cont_wrap">
                <div class="pageheader">&nbsp;</div>

            </div>
        </div>
        <div class="dv_footer">&copy;2014 Contestation </div>
        <div id="loading-image" class="div_transparent-loading" style="display: none;">
            <div class="div_loading_inner">
                <!-- <img src="/Contestation/images/pageload.gif" alt="Loading..." />-->
            </div>
        </div>


    </form>
</body>
</html>

