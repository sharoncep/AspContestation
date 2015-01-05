<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="tblFlatRateAdd.aspx.cs" Inherits="Contestation.Optimum.tblFlatRateAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="~/Css/pop.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="pageheader-pop">Flat Rate</div>
            <div>
                <table class="table-list-pop" style="width: 100%">
                    <tr>
                        <td>Service Code</td>
                        <td>
                            <asp:TextBox ID="txtServiceCode" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtServiceCode" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                        <td>Rate</td>
                        <td>
                            <asp:TextBox ID="txtRate" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtRate" ErrorMessage="*"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtRate" ErrorMessage="Enter only numeric data" ValidationExpression="^\d*\.?\d*$"></asp:RegularExpressionValidator>
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
