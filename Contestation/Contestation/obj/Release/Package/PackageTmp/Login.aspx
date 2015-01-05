<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Contestation.Login" %>

<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Contestation : Login</title>
<link href="css/login.css" rel="stylesheet" type="text/css">
</head>
<body>
    <form id="form1" runat="server">
       
        <div class="wrapper">
			<div class="top-bar-wrapper">
				<div class="sitelogo"></div>
				<%--<div class="menu">
					<ul>
						<li><a href="#" class="active"><span>Home</span></a></li>
						<li><a href="#"><span>About</span></a></li>
						<li><a href="#"><span>Services</span></a></li>
						<li><a href="#"><span>Contact us</span></a></li>
					</ul>
				</div>--%>
			</div>
			<div class="div-login">
				<asp:Login OnAuthenticate="Login1_Authenticate" ID="Login1" runat="server" FailureText="Login Failed. Please try again." >
                <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                <LayoutTemplate>
                    <ul>
					<li class="li_head_login"></li>
					<li><asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Username:</asp:Label></li>
					<li> <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="*" ToolTip="User Name is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator></li>
					<li><asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label></li>
					<li> <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator></li>
					<li>
					
					<asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
					<asp:Button ID="LoginButton" runat="server" CommandName="Login" CssClass="buttons" Text="Log In" ValidationGroup="Login1" OnClick="LoginButton_Click1" />
					
					</li>
				</ul>
                </LayoutTemplate>
                
            </asp:Login>
			</div>
		</div>
		<div class="dv_footer">&copy; 2014 Contestation .</div>
    </form>
</body>
</html>
