<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="tblInjuryCodesAdd.aspx.cs" Inherits="Contestation.Optimum.tblInjuryCodesAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>

    <link href="~/Css/pop.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="pageheader-pop">Injury Codes</div>
            <div>
                <table class="table-list-pop">
                    <tr>
                        <td>Injury Code</td>
                        <td>
                            <asp:TextBox ID="txtInjuryCode" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtInjuryCode" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                        <td>Desc</td>
                        <td>
                            <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Short Desc</td>
                        <td>
                            <asp:TextBox ID="txtShortDesc" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="dv-controls-pop">
                <asp:Button ID="txtAdd" runat="server" OnClick="txtAdd_Click" CssClass="btnsave-pop" Text="Save" />
            </div>
        </div>
    </form>
</body>
</html>

