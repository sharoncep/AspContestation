<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tblFRHProfRateAdd.aspx.cs" Inherits="Contestation.Freedom.tblFRHProfRateAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/Css/pop.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="pageheader-pop">Prof Rate</div>
            <div>
                <table class="table-list-pop">
                    <tr>
                        <td>Service Provider Name</td>
                        <td>
                            <asp:TextBox ID="txtServProName" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtServProName" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>

                        <td>Service Provider Id</td>
                        <td>
                            <asp:TextBox ID="txtServProID" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtServProID" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Flat Rate</td>
                        <td>
                            <asp:TextBox ID="txtFlatRate" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtFlatRate" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>

                        <td>Speciality</td>
                        <td>
                            <asp:TextBox ID="txtSpeciality" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Rate</td>
                        <td>
                            <asp:TextBox ID="txtRate" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtRate" ErrorMessage="*"></asp:RequiredFieldValidator>
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
