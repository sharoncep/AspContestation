<%@ Page Title="" Language="C#" MasterPageFile="~/OptimumMaster.Master" AutoEventWireup="true" CodeBehind="tblMVA-FRH.aspx.cs" Inherits="Contestation.Optimum.tblMVA_FRH" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../Scripts/Optimum/tblMVA-FRH.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="pageheader">
        Optimum<span>- MVA-FRH</span>
        <div class="dv_fl_right">
            <a href="Javascript:searchDiv();" id="aSearch" class="aSearch">Search</a>
            <a id="aAdd" class="aAdd" href="tblMVA-FRHAdd.aspx">Add</a>
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

        <asp:GridView ID="GridViewTblMVA_FRH" EmptyDataText="No records Found" runat="server" AutoGenerateColumns="False" BorderWidth="0" CssClass="mGrid"
            AllowPaging="true" ShowFooter="false" PageSize="15" Width="100%" OnPageIndexChanging="GridViewTblMVA_FRH_PageIndexChanging"
            OnRowCancelingEdit="GridViewTblMVA_FRH_RowCancelingEdit" OnRowEditing="GridViewTblMVA_FRH_RowEditing"
            OnRowUpdating="GridViewTblMVA_FRH_RowUpdating"
            OnRowDeleting="GridViewTblMVA_FRH_RowDeleting" OnRowCommand="GridViewTblMVA_FRH_RowCommand">
            <AlternatingRowStyle CssClass="alt" />
            <PagerStyle CssClass="pgr" />
            <Columns>
                <asp:TemplateField HeaderText="ID" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="lblID" runat="server" Text='<%#Eval("ID") %>'></asp:Label>
                    </ItemTemplate>

                </asp:TemplateField>

                <asp:TemplateField HeaderText="PCP NAME" HeaderStyle-Width="10%">
                    <ItemTemplate>
                        <asp:Label ID="lblPCP_NAME" runat="server" Text='<%#Eval("PCP_NAME") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtPCP_NAME" runat="server" Text='<%#Eval("PCP_NAME") %>'></asp:TextBox>
                    </EditItemTemplate>

                    <HeaderStyle Width="35%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="PCP ID">
                    <ItemTemplate>
                        <asp:Label ID="lblPCP_ID" runat="server" Text='<%#Eval("PCP_ID") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtPCP_ID" runat="server" Text='<%#Eval("PCP_ID") %>'></asp:TextBox>
                    </EditItemTemplate>

                    <HeaderStyle Width="10%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="SUBSCRIBER ID">
                    <ItemTemplate>
                        <asp:Label ID="lblSUBSCRIBER_ID" runat="server" Text='<%#Eval("SUBSCRIBER_ID") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtSUBSCRIBER_ID" runat="server" Text='<%#Eval("SUBSCRIBER_ID") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtSUBSCRIBER_ID" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="10%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="MEMBER NAME">
                    <ItemTemplate>
                        <asp:Label ID="lblMEMBER_NAME" runat="server" Text='<%#Eval("MEMBER_NAME") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtMEMBER_NAME" runat="server" Text='<%#Eval("MEMBER_NAME") %>'></asp:TextBox>
                    </EditItemTemplate>

                    <HeaderStyle Width="30%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="DOS">
                    <ItemTemplate>
                        <asp:Label ID="lblDOS" runat="server" Text='<%#Eval("DOS") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox CssClass="myCalCss" ID="txtDOS" runat="server" Text='<%#Eval("DOS") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtDOS" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtDOS" ErrorMessage="Invalid Date" ValidationExpression="^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"></asp:RegularExpressionValidator>
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
