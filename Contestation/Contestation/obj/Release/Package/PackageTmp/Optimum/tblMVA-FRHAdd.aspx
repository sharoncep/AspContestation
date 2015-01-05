<%@ Page Title="" Language="C#" MasterPageFile="~/Optimum/AddMaster.Master" AutoEventWireup="true" CodeBehind="tblMVA-FRHAdd.aspx.cs" Inherits="Contestation.Optimum.tblMVA_FRHAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="~/Css/pop.css" rel="stylesheet" />
    <script>

        $(function ($) {
            $("#ContentPlaceHolder1_txtDos").datepicker({
                changeMonth: true,
                changeYear: true
            });
        });


    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="pageheader-pop">MVA-FRH</div>
        <div>
            <table class="table-list-pop" style="width: 100%">
                <tr>
                    <td>PCP NAME</td>
                    <td>
                        <asp:TextBox ID="txtPcpName" runat="server"></asp:TextBox>
                    </td>
                    <td>PCP ID</td>
                    <td>
                        <asp:TextBox ID="txtPcpID" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>SUBSCRIBER ID</td>
                    <td>
                        <asp:TextBox ID="txtSubID" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtSubID" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </td>
                    <td>MEMBER NAME</td>
                    <td>
                        <asp:TextBox ID="txtMemberName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>DOS</td>
                    <td>
                        <asp:TextBox ID="txtDos" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtDos" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtDos" ErrorMessage="Invalid Date" ValidationExpression="^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
            </table>
        </div>
        <div class="dv-controls-pop">
            <asp:Button ID="btnAdd" runat="server" Text="Save" CssClass="btnsave-pop" OnClick="btnAdd_Click" />
        </div>
    </div>
</asp:Content>


