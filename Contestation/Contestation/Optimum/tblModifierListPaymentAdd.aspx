<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="tblModifierListPaymentAdd.aspx.cs" Inherits="Contestation.Optimum.tblModifierListPaymentAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="~/Css/pop.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="pageheader-pop">Modifier List Payment</div>
            <div>
                <table class="table-list-pop" style="width: 100%">
                    <tr>
                        <td>Modifier</td>
                        <td>
                            <asp:TextBox ID="txtModifier" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtModifier" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                        <td>Allowance</td>
                        <td>
                            <asp:TextBox ID="txtAllowance" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAllowance" ErrorMessage="*"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtAllowance" ErrorMessage="Enter only numbers (max 5 digits)" ValidationExpression="[0-9]{1,5}"></asp:RegularExpressionValidator>
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

