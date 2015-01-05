<%@ Page Title="" Language="C#" MasterPageFile="~/OptimumMaster.Master" AutoEventWireup="true" CodeBehind="tblUniProfClaimFee.aspx.cs" Inherits="Contestation.Optimum.tblUniProfClaimFee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../Scripts/Optimum/tblUniProfClaimFeeSchedule.js"> </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="pageheader">
        Optimum<span>- Professional Claim Fee</span>
        <div class="dv_fl_right">
            <a href="Javascript:searchDiv();" id="aSearch" class="aSearch">Search</a>
            <a id="aAdd" class="aAdd" href="tblUniProfClaimFeeAdd.aspx">Add</a>
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
        <asp:GridView ID="GridViewUniProfClaimFee" EmptyDataText="No records Found" runat="server" AutoGenerateColumns="False" BorderWidth="0" CssClass="mGrid"
            AllowPaging="true" ShowFooter="false" PageSize="15" Width="100%" OnPageIndexChanging="GridViewUniProfClaimFee_PageIndexChanging"
            OnRowCancelingEdit="GridViewUniProfClaimFee_RowCancelingEdit" OnRowEditing="GridViewUniProfClaimFee_RowEditing"  ShowHeaderWhenEmpty="true"
            OnRowUpdating="GridViewUniProfClaimFee_RowUpdating"
            OnRowDeleting="GridViewUniProfClaimFee_RowDeleting" OnRowCommand="GridViewUniProfClaimFee_RowCommand">
            <AlternatingRowStyle CssClass="alt" />
            <PagerStyle CssClass="pgr" />
            <EmptyDataRowStyle CssClass="norec" />
            <Columns>
                <asp:TemplateField HeaderText="ID" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="lblID" runat="server" Text='<%#Eval("ID") %>'></asp:Label>
                    </ItemTemplate>

                </asp:TemplateField>

                <asp:TemplateField HeaderText="Period From">
                    <ItemTemplate>
                        <asp:Label ID="lblPeriodFrom" runat="server" Text='<%#Eval("PeriodFrom") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox CssClass="myCalCss" ID="txtPeriodFrom" runat="server" Text='<%#Eval("PeriodFrom") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtPeriodFrom" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtPeriodFrom" ErrorMessage="Invalid date" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>

                    </EditItemTemplate>

                    <HeaderStyle Width="15%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Period To">
                    <ItemTemplate>
                        <asp:Label ID="lblPeriodTo" runat="server" Text='<%#Eval("PeriodTo") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox CssClass="myCalCss" ID="txtPeriodTo" runat="server" Text='<%#Eval("PeriodTo") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtPeriodTo" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtPeriodTo" ErrorMessage="Invalid date" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="15%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Procedure">
                    <ItemTemplate>
                        <asp:Label ID="lblprocedure" runat="server" Text='<%#Eval("procedure") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtprocedure" runat="server" Text='<%#Eval("procedure") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtprocedure" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <HeaderStyle Width="15%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Modifier">
                    <ItemTemplate>
                        <asp:Label ID="lblmodifier" runat="server" Text='<%#Eval("modifier") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtmodifier" runat="server" Text='<%#Eval("modifier") %>'></asp:TextBox>
                    </EditItemTemplate>

                    <HeaderStyle Width="15%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Par Allow">
                    <ItemTemplate>
                        <asp:Label ID="lblParAllow" runat="server" Text='<%#Eval("ParAllow") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtParAllow" runat="server" Text='<%#Eval("ParAllow") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtParAllow" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtParAllow" ErrorMessage="Enter only numeric data" ValidationExpression="^\d*\.?\d*$"></asp:RegularExpressionValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="15%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Locality">
                    <ItemTemplate>
                        <asp:Label ID="lblLocality" runat="server" Text='<%#Eval("Locality") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtLocality" runat="server" Text='<%#Eval("Locality") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="txtLocality" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtLocality" ErrorMessage="Enter only numeric data" ValidationExpression="^\d*\.?\d*$"></asp:RegularExpressionValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="20%"></HeaderStyle>
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