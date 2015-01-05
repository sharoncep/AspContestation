<%@ Page Title="" Language="C#" MasterPageFile="~/OptimumMaster.Master" AutoEventWireup="true" CodeBehind="tblFRHProfRate.aspx.cs" Inherits="Contestation.Optimum.tblFRHProfRate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../Scripts/Optimum/tblFRHProfRate.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="pageheader">
        Optimum<span>- Professional Rate</span>
        <div class="dv_fl_right">
            <a href="Javascript:void(0);" id="aSearch" class="aSearch">Search</a>
            <a class="iframe aAdd" href="tblFRHProfRateAdd.aspx">Add</a>
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
        <asp:GridView ID="GridViewFRHProfRate" EmptyDataText="No records Found" runat="server" AutoGenerateColumns="False" BorderWidth="0" CssClass="mGrid"
            AllowPaging="true" ShowFooter="false" PageSize="15" Width="100%" OnPageIndexChanging="GridViewFRHProfRate_PageIndexChanging"
            OnRowCancelingEdit="GridViewFRHProfRate_RowCancelingEdit" OnRowEditing="GridViewFRHProfRate_RowEditing"
            OnRowUpdating="GridViewFRHProfRate_RowUpdating"
            OnRowDeleting="GridViewFRHProfRate_RowDeleting" OnRowCommand="GridViewFRHProfRate_RowCommand">
            <AlternatingRowStyle CssClass="alt" />
            <PagerStyle CssClass="pgr" />
            <Columns>
                <asp:TemplateField HeaderText="ID" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="lblID" runat="server" Text='<%#Eval("ID") %>'></asp:Label>
                    </ItemTemplate>

                </asp:TemplateField>
                <asp:TemplateField HeaderText="SERVICE PROVIDER NAME" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <asp:Label ID="lblSERVICE_PROVIDER_NAME" runat="server" Text='<%#Eval("SERVICE_PROVIDER_NAME") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtSERVICE_PROVIDER_NAME" runat="server" Text='<%#Eval("SERVICE_PROVIDER_NAME") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtSERVICE_PROVIDER_NAME" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="40%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="SERVICE PROVIDER ID">
                    <ItemTemplate>
                        <asp:Label ID="lblSERVICE_PROVIDER_ID" runat="server" Text='<%#Eval("SERVICE_PROVIDER_ID") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtSERVICE_PROVIDER_ID" runat="server" Text='<%#Eval("SERVICE_PROVIDER_ID") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtSERVICE_PROVIDER_ID" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="15%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="FLAT RATE">
                    <ItemTemplate>
                        <asp:Label ID="lblFLAT_RATE" runat="server" Text='<%#Eval("FLAT_RATE") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtFLAT_RATE" runat="server" Text='<%#Eval("FLAT_RATE") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtFLAT_RATE" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="10%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Speciality">
                    <ItemTemplate>
                        <asp:Label ID="lblSpeciality" runat="server" Text='<%#Eval("Speciality") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtSpeciality" runat="server" Text='<%#Eval("Speciality") %>'></asp:TextBox>
                    </EditItemTemplate>

                    <HeaderStyle Width="20%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="RATE">
                    <ItemTemplate>
                        <asp:Label ID="lblRATE" runat="server" Text='<%#Eval("RATE") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtRATE" runat="server" Text='<%#Eval("RATE") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtRATE" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtRATE" ErrorMessage="Enter only numeric data" ValidationExpression="^\d*\.?\d*$"></asp:RegularExpressionValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="10%"></HeaderStyle>
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
