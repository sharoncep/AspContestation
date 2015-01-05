<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="tblFlatRate.aspx.cs" Inherits="Contestation.Freedom.tblFlatRate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script src="../Scripts/Freedom/tblFlatRate.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="pageheader">
        Freedom<span>- Flat Rate</span>
        <div class="dv_fl_right">
            <a href="Javascript:searchDiv();" id="aSearch" class="aSearch">Search</a>
            <a id="aAdd" class="aAdd" href="tblFlatRateAdd.aspx">Add</a>
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
        <asp:GridView ID="GridViewFlatRate" EmptyDataText="No Records Found" runat="server" AutoGenerateColumns="False" BorderWidth="0"
            AllowPaging="true" ShowFooter="false" PageSize="15" Width="100%" OnPageIndexChanging="GridViewFlatRate_PageIndexChanging"
            OnRowCancelingEdit="GridViewFlatRate_RowCancelingEdit" OnRowEditing="GridViewFlatRate_RowEditing" CssClass="mGrid"
            OnRowUpdating="GridViewFlatRate_RowUpdating"
            OnRowDeleting="GridViewFlatRate_RowDeleting" OnRowCommand="GridViewFlatRate_RowCommand">
            <AlternatingRowStyle CssClass="alt" />
            <PagerStyle CssClass="pgr" />
            <Columns>
                <asp:TemplateField HeaderText="ID" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="lblID" runat="server" Text='<%#Eval("ID") %>'></asp:Label>
                    </ItemTemplate>

                </asp:TemplateField>
                <asp:TemplateField HeaderText="Service Code">
                    <ItemTemplate>
                        <asp:Label ID="lblServiceCode" runat="server" Text='<%#Eval("ServiceCode") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtServiceCode" runat="server" Text='<%#Eval("ServiceCode") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtServiceCode" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="25%"></HeaderStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Rate">
                    <ItemTemplate>
                        <asp:Label ID="lblRate" runat="server" Text='<%#Eval("Rate") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtRate" runat="server" Text='<%#Eval("Rate") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtRate" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtRate" ErrorMessage="Enter only numeric data" ValidationExpression="^\d*\.?\d*$"></asp:RegularExpressionValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="70%"></HeaderStyle>
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





