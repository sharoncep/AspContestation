<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="tblFreedomCensus.aspx.cs" Inherits="Contestation.Freedom.tblFreedomCensus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../Scripts/Freedom/tblFreedomCensus.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="pageheader">
        Freedom<span>- Census</span>
        <div class="dv_fl_right">
            <a href="Javascript:searchDiv();" id="aSearch" class="aSearch">Search</a>
            <a id="aAdd" class="aAdd" href="tblFreedomCensusAdd.aspx">Add</a>
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
        <asp:GridView ID="GridViewFreedomCensus" EmptyDataText="No records Found" runat="server" AutoGenerateColumns="False" BorderWidth="0" CssClass="mGrid"
            AllowPaging="true" ShowFooter="false" PageSize="15" Width="100%" OnPageIndexChanging="GridViewFreedomCensus_PageIndexChanging"
            OnRowCancelingEdit="GridViewFreedomCensus_RowCancelingEdit" OnRowEditing="GridViewFreedomCensus_RowEditing"
            OnRowUpdating="GridViewFreedomCensus_RowUpdating"
            OnRowDeleting="GridViewFreedomCensus_RowDeleting" OnRowCommand="GridViewFreedomCensus_RowCommand">
            <AlternatingRowStyle CssClass="alt" />
            <PagerStyle CssClass="pgr" />
            <Columns>
                <asp:TemplateField HeaderText="ID" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="lblID" runat="server" Text='<%#Eval("ID") %>'></asp:Label>
                    </ItemTemplate>

                </asp:TemplateField>

                <asp:TemplateField HeaderText="PCP Name">
                    <ItemTemplate>
                        <asp:Label ID="lblPCP_Name" runat="server" Text='<%#Eval("PCP_Name") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtPCP_Name" runat="server" Text='<%#Eval("PCP_Name") %>'></asp:TextBox>
                    </EditItemTemplate>

                    <HeaderStyle Width="15%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Member Name">
                    <ItemTemplate>
                        <asp:Label ID="lblMember_Name" runat="server" Text='<%#Eval("Member_Name") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtMember_Name" runat="server" Text='<%#Eval("Member_Name") %>'></asp:TextBox>
                    </EditItemTemplate>

                    <HeaderStyle Width="15%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Member ID">
                    <ItemTemplate>
                        <asp:Label ID="lblMember_ID" runat="server" Text='<%#Eval("Member_ID") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtMember_ID" runat="server" Text='<%#Eval("Member_ID") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtMember_ID" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="8%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Admit Date">
                    <ItemTemplate>
                        <asp:Label ID="lblAdmit_Date" runat="server" Text='<%#Eval("Admit_Date") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox CssClass="myCalCss" ID="txtAdmit_Date" runat="server" Text='<%#Eval("Admit_Date") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtAdmit_Date" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtAdmit_Date" ErrorMessage="Invalid date" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="8%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Discharge Date">
                    <ItemTemplate>
                        <asp:Label ID="lblDischarge_Date" runat="server" Text='<%#Eval("Discharge_Date") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox CssClass="myCalCss" ID="txtDischarge_Date" runat="server" Text='<%#Eval("Discharge_Date") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtDischarge_Date" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtDischarge_Date" ErrorMessage="Invalid date" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="8%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Admit Diagnosis">
                    <ItemTemplate>
                        <asp:Label ID="lblAdmit_Diagnosis" runat="server" Text='<%#Eval("Admit_Diagnosis") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtAdmit_Diagnosis" runat="server" Text='<%#Eval("Admit_Diagnosis") %>'></asp:TextBox>
                    </EditItemTemplate>

                    <HeaderStyle Width="24%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Facility Name">
                    <ItemTemplate>
                        <asp:Label ID="lblFacility_Name" runat="server" Text='<%#Eval("Facility_Name") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtFacility_Name" runat="server" Text='<%#Eval("Facility_Name") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtFacility_Name" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="17%"></HeaderStyle>
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
