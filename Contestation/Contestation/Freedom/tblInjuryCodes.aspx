<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="tblInjuryCodes.aspx.cs" Inherits="Contestation.Freedom.tblInjuryCodes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../Scripts/Freedom/tblInjuryCodes.js"> </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="pageheader">
        Freedom<span>- Injury Codes</span>
        <div class="dv_fl_right">
            <a href="Javascript:void(0);" id="aSearch" class="aSearch" title="Search">Search</a>
            <a class="iframe aAdd" href="tblInjuryCodesAdd.aspx">Add</a>
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
        <asp:GridView ID="GridViewTblInjuryCodes" EmptyDataText="No records Found" runat="server" AutoGenerateColumns="False" BorderWidth="0" CssClass="mGrid"
            AllowPaging="true" ShowFooter="false" PageSize="15" Width="100%" OnPageIndexChanging="GridViewTblInjuryCodes_PageIndexChanging"
            OnRowCancelingEdit="GridViewTblInjuryCodes_RowCancelingEdit" OnRowEditing="GridViewTblInjuryCodes_RowEditing"
            OnRowUpdating="GridViewTblInjuryCodes_RowUpdating"
            OnRowDeleting="GridViewTblInjuryCodes_RowDeleting" OnRowCommand="GridViewTblInjuryCodes_RowCommand">
            <AlternatingRowStyle CssClass="alt" />
            <PagerStyle CssClass="pgr" />
            <Columns>
                <asp:TemplateField HeaderText="ID" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="lblID" runat="server" Text='<%#Eval("ID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Injury Code">
                    <ItemTemplate>
                        <asp:Label ID="lblInjuryCode" runat="server" Text='<%#Eval("InjuryCode") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtInjuryCode" runat="server" Text='<%#Eval("InjuryCode") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtInjuryCode" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="10%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Description">
                    <ItemTemplate>
                        <asp:Label ID="lblInjuryCodeDesc" runat="server" Text='<%#Eval("InjuryCodeDesc") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtInjuryCodeDesc" runat="server" Text='<%#Eval("InjuryCodeDesc") %>'></asp:TextBox>
                    </EditItemTemplate>

                    <HeaderStyle Width="50%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Short Description">
                    <ItemTemplate>
                        <asp:Label ID="lblInjuryCodeShortDesc" runat="server" Text='<%#Eval("InjuryCodeShortDesc") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtInjuryCodeShortDesc" runat="server" Text='<%#Eval("InjuryCodeShortDesc") %>'></asp:TextBox>
                    </EditItemTemplate>

                    <HeaderStyle Width="35%"></HeaderStyle>
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
