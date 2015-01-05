<%@ Page Title="" Language="C#" MasterPageFile="~/OptimumMaster.Master" AutoEventWireup="true" CodeBehind="tblModifierListPayment.aspx.cs" Inherits="Contestation.Optimum.tblModifierListPayment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../Scripts/Optimum/tblModifierListPayment.js"> </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="pageheader">
        Optimum<span>- Modifier List Payment</span>
        <div class="dv_fl_right">
            <a href="Javascript:searchDiv();" id="aSearch" class="aSearch">Search</a>
            <a id="aAdd" class="aAdd" href="tblModifierListPaymentAdd.aspx">Add</a>
        </div>
    </div>
    <div id="searchDiv" style="display: none;" class="dv_search">
        <ul class="ul_searchform">
            <li>
                <asp:TextBox ID="txtSearchName" runat="server" placeholder="Keyword"></asp:TextBox></li>
            <li>
                <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btnseacrh" OnClick="btnSearch_Click" /></li>
        </ul>
    </div>

    <div class="clear"></div>
    <div class="demo_container">

        <asp:GridView ID="GridViewModifierListPayment" EmptyDataText="No records Found" runat="server" AutoGenerateColumns="False" BorderWidth="0" CssClass="mGrid"
            AllowPaging="true" ShowFooter="false" PageSize="15" Width="100%" OnPageIndexChanging="GridViewModifierListPayment_PageIndexChanging"
            OnRowCancelingEdit="GridViewModifierListPayment_RowCancelingEdit" OnRowEditing="GridViewModifierListPayment_RowEditing"
            OnRowUpdating="GridViewModifierListPayment_RowUpdating"
            OnRowDeleting="GridViewModifierListPayment_RowDeleting" OnRowCommand="GridViewModifierListPayment_RowCommand">
            <AlternatingRowStyle CssClass="alt" />
            <PagerStyle CssClass="pgr" />
            <Columns>
                <asp:TemplateField HeaderText="ID" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="lblID" runat="server" Text='<%#Eval("ID") %>'></asp:Label>
                    </ItemTemplate>

                </asp:TemplateField>

                <asp:TemplateField HeaderText="Modifier">
                    <ItemTemplate>
                        <asp:Label ID="lblModifier" runat="server" Text='<%#Eval("Modifier") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtModifier" runat="server" Text='<%#Eval("Modifier") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtModifier" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="15%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Allowance">
                    <ItemTemplate>
                        <asp:Label ID="lblAllowance" runat="server" Text='<%#Eval("Allowance") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtAllowance" runat="server" Text='<%#Eval("Allowance") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtAllowance" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtAllowance" ErrorMessage="Enter only numbers (max 5 digits)" ValidationExpression="[0-9]{1,5}"></asp:RegularExpressionValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="80%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField>
                    <ItemTemplate>
                        <span onclick="return confirm('Are you sure want to delete?')">
                            <asp:LinkButton CssClass="aDelete" ID="btnDelete" Text="Delete" runat="server" ToolTip="Delete" CommandName="Delete" />
                        </span>
                        <asp:LinkButton ID="btnEdit" Text="Edit" runat="server" CommandName="Edit" ToolTip="Edit" CssClass="aEdit" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:LinkButton ID="btnCancel" Text="Cancel" runat="server" CommandName="Cancel" ToolTip="Cancel" CssClass="aCancel" />
                        <asp:LinkButton ID="btnUpdate" Text="Update" runat="server" CommandName="Update" ToolTip="Update" CssClass="aUpdate" />
                    </EditItemTemplate>
                    <HeaderStyle Width="5%"></HeaderStyle>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
