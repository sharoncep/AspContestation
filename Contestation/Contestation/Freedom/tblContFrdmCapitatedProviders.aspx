<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="tblContFrdmCapitatedProviders.aspx.cs" Inherits="Contestation.Freedom.tblContFrdmCapitatedProviders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../Scripts/Freedom/tblContFrdmCapitatedProviders.js"> </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="pageheader">
       Freedom<span>- Capitated Providers</span> 
        <div class="dv_fl_right">
            <a href="Javascript:searchDiv();" id="aSearch" class="aSearch">Search</a>
            <a id="aAdd" class="aAdd" href="tblContFrdmCapitatedProvidersAdd.aspx">Add</a>
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

        <asp:GridView ID="GridViewContFrdmCapitatedProviders" EmptyDataText="No records Found" runat="server" AutoGenerateColumns="False" BorderWidth="0" CssClass="mGrid"
            AllowPaging="true" ShowFooter="false" PageSize="15" Width="100%" OnPageIndexChanging="GridViewContFrdmCapitatedProviders_PageIndexChanging"
            OnRowCancelingEdit="GridViewContFrdmCapitatedProviders_RowCancelingEdit" OnRowEditing="GridViewContFrdmCapitatedProviders_RowEditing"
            OnRowUpdating="GridViewContFrdmCapitatedProviders_RowUpdating"
            OnRowDeleting="GridViewContFrdmCapitatedProviders_RowDeleting" OnRowCommand="GridViewContFrdmCapitatedProviders_RowCommand">
            <AlternatingRowStyle CssClass="alt" />
            <PagerStyle CssClass="pgr" />
            <Columns>
                <asp:TemplateField HeaderText="ID" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="lblID" runat="server" Text='<%#Eval("ID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Capitated Providers">
                    <ItemTemplate>
                        <asp:Label ID="lblCapitatedProviders" runat="server" Text='<%#Eval("CapitatedProviders") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtCapitatedProviders" runat="server" Text='<%#Eval("CapitatedProviders") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtCapitatedProviders" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <HeaderStyle Width="16%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Provider ID">
                    <ItemTemplate>
                        <asp:Label ID="lblProviderID" runat="server" Text='<%#Eval("ProviderID") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtProviderID" runat="server" Text='<%#Eval("ProviderID") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <HeaderStyle Width="6%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Plan#">
                    <ItemTemplate>
                        <asp:Label ID="lblPlanNumber" runat="server" Text='<%#Eval("PlanNumber") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtPlanNumber" runat="server" Text='<%#Eval("PlanNumber") %>'></asp:TextBox>
                    </EditItemTemplate>

                    <HeaderStyle Width="5%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="IPA">
                    <ItemTemplate>
                        <asp:Label ID="lblIPAName" runat="server" Text='<%#Eval("IPAName") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtIPAName" runat="server" Text='<%#Eval("IPAName") %>'></asp:TextBox>
                    </EditItemTemplate>

                    <HeaderStyle Width="14%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Plan Name">
                    <ItemTemplate>
                        <asp:Label ID="lblPlanName" runat="server" Text='<%#Eval("PlanName") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtPlanName" runat="server" Text='<%#Eval("PlanName") %>'></asp:TextBox>
                    </EditItemTemplate>

                    <HeaderStyle Width="14%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="From Date">
                    <ItemTemplate>
                        <asp:Label ID="lblFrom_Date" runat="server" Text='<%#Eval("From_Date") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox CssClass="myCalCss" ID="txtFrom_Date" runat="server" Text='<%#Eval("From_Date") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtFrom_Date" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="8%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="To Date">
                    <ItemTemplate>
                        <asp:Label ID="lblTo_Date" runat="server" Text='<%#Eval("To_Date") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox CssClass="myCalCss" ID="txtTo_Date" runat="server" Text='<%#Eval("To_Date") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtTo_Date" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="7%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Speciality name">
                    <ItemTemplate>
                        <asp:Label ID="lblSpeciality_name" runat="server" Text='<%#Eval("Speciality_name") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtSpeciality_name" runat="server" Text='<%#Eval("Speciality_name") %>'></asp:TextBox>
                    </EditItemTemplate>

                    <HeaderStyle Width="10%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Speciality fund">
                    <ItemTemplate>
                        <asp:Label ID="lblSpeciality_fund" runat="server" Text='<%#Eval("Speciality_fund") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtSpeciality_fund" runat="server" Text='<%#Eval("Speciality_fund") %>'></asp:TextBox>
                    </EditItemTemplate>

                    <HeaderStyle Width="15%"></HeaderStyle>
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
