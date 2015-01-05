<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="tblFRQuestCarveOutAdd.aspx.cs" Inherits="Contestation.Optimum.tblFRQuestCarveOutAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>

    <link href="~/Css/pop.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="pageheader-pop">Quest Carve Out</div>
            <div>
                <table class="table-list-pop">
                    <tr>
                        <td>CPT CODE</td>
                        <td>
                            <asp:TextBox ID="txtCptCode" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCptCode" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                        <td>REIM AMOUNT</td>
                        <td>
                            <asp:TextBox ID="txtReimAmt" runat="server"></asp:TextBox>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtReimAmt" ErrorMessage="Enter only numeric data" ValidationExpression="^\d*\.?\d*$"></asp:RegularExpressionValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtReimAmt" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>EFF YEAR</td>
                        <td>
                            <asp:TextBox ID="txtEffYear" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEffYear" ErrorMessage="*"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEffYear" ErrorMessage="Units should be numeric (max 5 digits)" ValidationExpression="[0-9]{1,5}"></asp:RegularExpressionValidator>
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
