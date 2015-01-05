<%@ Page Language="C#" MasterPageFile="~/Freedom/AddMaster.Master" AutoEventWireup="true" CodeBehind="tblUniProfClaimFeeAdd.aspx.cs" Inherits="Contestation.Freedom.tblUniProfClaimFeeAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="~/Css/pop.css" rel="stylesheet" />
    <script>
        $(function ($) {
            $("#ContentPlaceHolder1_txtPeriodFrom").datepicker({
                changeMonth: true,
                changeYear: true
            });

            $("#ContentPlaceHolder1_txtPeriodTo").datepicker({
                changeMonth: true,
                changeYear: true
            });
        });

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="pageheader-pop">Prof Claim Fee</div>
        <div>
            <table class="table-list-pop">
                <tr>
                    <td>Period From</td>
                    <td>
                        <asp:TextBox ID="txtPeriodFrom" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPeriodFrom" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtPeriodFrom" ErrorMessage="Invalid date" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
                    </td>
                    <td>Period To</td>
                    <td>
                        <asp:TextBox ID="txtPeriodTo" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPeriodTo" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtPeriodTo" ErrorMessage="Invalid date" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>Procedure</td>
                    <td>
                        <asp:TextBox ID="txtProcedure" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtProcedure" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </td>
                    <td>Modifier</td>
                    <td>
                        <asp:TextBox ID="txtModifier" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Par Allow</td>
                    <td>
                        <asp:TextBox ID="txtParAllow" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtParAllow" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtParAllow" ErrorMessage="Enter only numeric data" ValidationExpression="^\d*\.?\d*$"></asp:RegularExpressionValidator>
                    </td>
                    <td>Locality</td>
                    <td>
                        <asp:TextBox ID="txtLocality" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtLocality" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtLocality" ErrorMessage="Enter only numeric data" ValidationExpression="^\d*\.?\d*$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
            </table>
        </div>

        <div class="dv-controls-pop">
            <asp:Button ID="btnAdd" runat="server" Text="Save" CssClass="btnsave-pop" OnClick="btnAdd_Click" />
        </div>
    </div>
</asp:Content>

