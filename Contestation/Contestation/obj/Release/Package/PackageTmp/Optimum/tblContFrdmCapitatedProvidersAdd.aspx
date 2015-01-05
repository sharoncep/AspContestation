<%@ Page Title="" Language="C#" MasterPageFile="~/Optimum/AddMaster.Master" AutoEventWireup="true" CodeBehind="tblContFrdmCapitatedProvidersAdd.aspx.cs" Inherits="Contestation.Optimum.tblContFrdmCapitatedProvidersAdd" %>

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
        <div class="pageheader-pop">Capitated Providers</div>
        <div>
            <table class="table-list-pop" style="width: 100%">
                <tr>
                    <td>Capitated Providers</td>
                    <td>
                        <asp:TextBox ID="txtCapProv" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCapProv" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>

                    <td>Provider ID</td>
                    <td>
                        <asp:TextBox ID="txtProviderID" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Plan Number</td>
                    <td>
                        <asp:TextBox ID="txtPlanNo" runat="server"></asp:TextBox>
                    </td>

                    <td>IPA Name</td>
                    <td>
                        <asp:TextBox ID="txtIPAName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Plan Name</td>
                    <td>
                        <asp:TextBox ID="txtPlanName" runat="server"></asp:TextBox>
                    </td>

                    <td>From Date</td>
                    <td>
                        <asp:TextBox ID="txtFromDate" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtFromDate" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtFromDate" ErrorMessage="Invalid date" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td>To Date</td>
                    <td>
                        <asp:TextBox ID="txtToDate" runat="server" Width="128px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtToDate" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtToDate" ErrorMessage="Invalid date" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
                    </td>

                    <td>Speciality Name</td>
                    <td>
                        <asp:TextBox ID="txtSpecName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Speciality Fund</td>
                    <td>
                        <asp:TextBox ID="txtSpecFund" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <div class="dv-controls-pop">
            <asp:Button ID="btnAdd" runat="server" Text="Save" CssClass="btnsave-pop" OnClick="btnAdd_Click" />
        </div>
    </div>
</asp:Content>

