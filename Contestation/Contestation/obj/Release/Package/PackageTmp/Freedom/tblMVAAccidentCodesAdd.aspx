<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tblMVAAccidentCodesAdd.aspx.cs" Inherits="Contestation.Freedom.tblMVAAccidentCodesAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/Css/pop.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="pageheader-pop">MVA Accident Codes</div>
            <div>
                <table class="table-list-pop" style="width: 100%">
                    <tr>
                        <td>ICD Codes</td>
                        <td>
                            <asp:TextBox ID="txtIcdCodes" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtIcdCodes" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                        <td>Long Desc</td>
                        <td>
                            <asp:TextBox ID="txtLongDesc" runat="server"></asp:TextBox>
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
                <asp:Button ID="btnAdd" runat="server" Text="Save" CssClass="btnsave-pop" OnClick="btnAdd_Click" />
            </div>
        </div>
    </form>
</body>
</html>
