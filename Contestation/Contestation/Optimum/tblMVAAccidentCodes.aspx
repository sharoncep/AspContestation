<%@ Page Title="" Language="C#" MasterPageFile="~/OptimumMaster.Master" AutoEventWireup="true" CodeBehind="tblMVAAccidentCodes.aspx.cs" Inherits="Contestation.Optimum.tblMVAAccidentCodes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../Scripts/Optimum/tblMVAAccidentCodes.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="pageheader">
        Optimum<span>- MVA Codes</span>
        <div class="dv_fl_right">
            <a href="Javascript:searchDiv();" id="aSearch" class="aSearch">Search</a>
            <a id="aAdd" class="aAdd" href="tblMVAAccidentCodesAdd.aspx">Add</a>
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
        <asp:GridView ID="GridViewMVAAccidentCodes" EmptyDataText="No records Found" runat="server" AutoGenerateColumns="False" BorderWidth="0" CssClass="mGrid"
            AllowPaging="true" ShowFooter="false" PageSize="15" Width="100%" OnPageIndexChanging="GridViewMVAAccidentCodes_PageIndexChanging"
            OnRowCancelingEdit="GridViewMVAAccidentCodes_RowCancelingEdit" OnRowEditing="GridViewMVAAccidentCodes_RowEditing"
            OnRowUpdating="GridViewMVAAccidentCodes_RowUpdating"
            OnRowDeleting="GridViewMVAAccidentCodes_RowDeleting" OnRowCommand="GridViewMVAAccidentCodes_RowCommand">
            <AlternatingRowStyle CssClass="alt" />
            <PagerStyle CssClass="pgr" />
            <Columns>
                <asp:TemplateField HeaderText="ID" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="lblID" runat="server" Text='<%#Eval("ID") %>'></asp:Label>
                    </ItemTemplate>

                </asp:TemplateField>

                <asp:TemplateField HeaderText="ICD Codes">
                    <ItemTemplate>
                        <asp:Label ID="lblICDCodes" runat="server" Text='<%#Eval("ICDCodes") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtICDCodes" runat="server" Text='<%#Eval("ICDCodes") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtICDCodes" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <HeaderStyle Width="15%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Long Description">
                    <ItemTemplate>
                        <asp:Label ID="lblLongDescription" runat="server" Text='<%#Eval("LongDescription") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtLongDescription" runat="server" Text='<%#Eval("LongDescription") %>'></asp:TextBox>
                    </EditItemTemplate>

                    <HeaderStyle Width="45%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Short Description">
                    <ItemTemplate>
                        <asp:Label ID="lblShortDescription" runat="server" Text='<%#Eval("ShortDescription") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtShortDescription" runat="server" Text='<%#Eval("ShortDescription") %>'></asp:TextBox>
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
