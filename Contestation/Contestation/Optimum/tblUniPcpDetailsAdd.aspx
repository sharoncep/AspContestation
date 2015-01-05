<%@ Page Title="" Language="C#" MasterPageFile="~/Optimum/AddMaster.Master" AutoEventWireup="true" CodeBehind="tblUniPcpDetailsAdd.aspx.cs" Inherits="Contestation.Optimum.tblUniPcpDetailsAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="~/Css/pop.css" rel="stylesheet" />
    <script>
        $(function ($) {

            $("#ContentPlaceHolder1_txtEffectiveDate").datepicker({
                changeMonth: true,
                changeYear: true
            });

            $("#ContentPlaceHolder1_txtTerminatedDate").datepicker({
                changeMonth: true,
                changeYear: true
            });
        });

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="pageheader-pop">PCP Details</div>
        <div>
            <table class="table-list-pop">
                <tr>
                    <td>PCP ID</td>
                    <td>
                        <asp:TextBox ID="txtPcpID" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPcpID" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </td>
                    <td>PCP Name</td>
                    <td>
                        <asp:TextBox ID="txtPcpName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPcpName" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>County</td>
                    <td>
                        <asp:TextBox ID="txtCounty" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCounty" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </td>
                    <td>Effective Date</td>
                    <td>
                        <asp:TextBox ID="txtEffectiveDate" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtEffectiveDate" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtEffectiveDate" ErrorMessage="Invalid date" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>Terminated Date</td>
                    <td>
                        <asp:TextBox ID="txtTerminatedDate" runat="server"></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtTerminatedDate" ErrorMessage="Invalid date" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
                    </td>
                    <td>Status</td>
                    <td>
                        <asp:TextBox ID="txtStatus" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtStatus" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Fee Schedule LOC</td>
                    <td>
                        <asp:TextBox ID="txtFeeScheduleLoc" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtFeeScheduleLoc" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtFeeScheduleLoc" ErrorMessage="Enter only numeric data" ValidationExpression="^\d*\.?\d*$"></asp:RegularExpressionValidator>
                    </td>
                    <td>IPA Name</td>
                    <td>
                        <asp:TextBox ID="txtIpaName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Plan Name</td>
                    <td>
                        <asp:TextBox ID="txtPlanName" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <div class="dv-controls-pop">
            <asp:Button ID="btnAdd" runat="server" Text="Save" CssClass="btnsave-pop" OnClick="btnAdd_Click" />
        </div>
    </div>
</asp:Content>

