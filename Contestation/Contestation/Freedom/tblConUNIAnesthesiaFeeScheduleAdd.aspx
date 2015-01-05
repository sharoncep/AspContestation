<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Freedom/AddMaster.Master" CodeBehind="tblConUNIAnesthesiaFeeScheduleAdd.aspx.cs" Inherits="Contestation.Freedom.tblConUNIAnesthesiaFeeScheduleAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        $(function ($) {

            $("#ContentPlaceHolder1_txtFromDate").datepicker({
                changeMonth: true,
                changeYear: true
            });

            $("#ContentPlaceHolder1_txtToDate").datepicker({
                changeMonth: true,
                changeYear: true
            });

        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="pageheader-pop">Anesthesia Fee Schedule</div>
        <div>
            <table class="table-list-pop" style="width: 100%">
                <tr>
                    <td>From Date</td>
                    <td>
                        <asp:TextBox ID="txtFromDate" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFromDate" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtFromDate" ErrorMessage="Invalid date" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
                    </td>

                    <td>To Date</td>
                    <td>
                        <asp:TextBox ID="txtToDate" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtToDate" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtToDate" ErrorMessage="Invalid date" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>Procedure Code</td>
                    <td>
                        <asp:TextBox ID="txtProcCode" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtProcCode" ErrorMessage="*"></asp:RequiredFieldValidator>

                    </td>

                    <td>Unit</td>
                    <td>
                        <asp:TextBox ID="txtUnit" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtUnit" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtUnit" ErrorMessage="Units should be numeric (max 5 digits)" ValidationExpression="[0-9]{1,5}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Par Allow</td>
                    <td>
                        <asp:TextBox ID="txtParAllow" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtParAllow" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtParAllow" ErrorMessage="Enter only numeric data" ValidationExpression="^\d*\.?\d*$"></asp:RegularExpressionValidator>
                    </td>

                    <td>Locality</td>
                    <td>
                        <asp:TextBox ID="txtLocality" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtLocality" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtLocality" ErrorMessage="Locality should be numeric (max 5 digits)" ValidationExpression="[0-9]{1,5}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>IPA Name</td>
                    <td>
                        <asp:TextBox ID="txtIpaName" runat="server"></asp:TextBox>
                    </td>

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
