<%@ Page Language="C#" MasterPageFile="~/Freedom/AddMaster.Master" AutoEventWireup="true" CodeBehind="tblFreedomCensusAdd.aspx.cs" Inherits="Contestation.Freedom.tblFreedomCensusAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="~/Css/pop.css" rel="stylesheet" />
    <script>
        $(function ($) {

            $("#ContentPlaceHolder1_txtAdmitDate").datepicker({
                changeMonth: true,
                changeYear: true
            });

            $("#ContentPlaceHolder1_txtDischargeDate").datepicker({
                changeMonth: true,
                changeYear: true
            });
        });

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="pageheader-pop">Census</div>
        <div>
            <table class="table-list-pop">
                <tr>
                    <td>PCP Name</td>
                    <td>
                        <asp:TextBox ID="txtPcpName" runat="server"></asp:TextBox>
                    </td>

                    <td>Member Name</td>
                    <td>
                        <asp:TextBox ID="txtMemberName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Member ID</td>
                    <td>
                        <asp:TextBox ID="txtMemberID" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtMemberID" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </td>

                    <td>Admit Date</td>
                    <td>
                        <asp:TextBox ID="txtAdmitDate" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAdmitDate" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtAdmitDate" ErrorMessage="Invalid date" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>Discharge Date</td>
                    <td>
                        <asp:TextBox ID="txtDischargeDate" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDischargeDate" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtDischargeDate" ErrorMessage="Invalid date" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
                    </td>

                    <td>Admit Diagnosis</td>
                    <td>
                        <asp:TextBox ID="txtAdmitDg" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Facility Name</td>
                    <td>
                        <asp:TextBox ID="txtFacilityName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtFacilityName" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
        </div>
        <div class="dv-controls-pop">
            <asp:Button ID="btnAdd" runat="server" Text="Save" CssClass="btnsave-pop" OnClick="btnAdd_Click" />
        </div>
    </div>
</asp:Content>
