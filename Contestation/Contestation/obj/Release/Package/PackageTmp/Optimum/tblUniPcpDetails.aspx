<%@ Page Title="" Language="C#" MasterPageFile="~/OptimumMaster.Master" AutoEventWireup="true" CodeBehind="tblUniPcpDetails.aspx.cs" Inherits="Contestation.Optimum.tblUniPcpDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../Scripts/Optimum/tblUniPcpDetails.js">  </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="pageheader">
        Optimum<span>- PCP Details</span>
        <div class="dv_fl_right">
            <a href="Javascript:searchDiv();" id="aSearch" class="aSearch">Search</a>
            <a id="aAdd" class="aAdd" href="tblUniPcpDetailsAdd.aspx">Add</a>
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

        <asp:GridView ID="GridViewUniPcpDetails" EmptyDataText="No records Found" runat="server" AutoGenerateColumns="False" BorderWidth="0" CssClass="mGrid"
            AllowPaging="true" ShowFooter="false" PageSize="15" Width="100%" OnPageIndexChanging="GridViewUniPcpDetails_PageIndexChanging"
            OnRowCancelingEdit="GridViewUniPcpDetails_RowCancelingEdit" OnRowEditing="GridViewUniPcpDetails_RowEditing"
            OnRowUpdating="GridViewUniPcpDetails_RowUpdating"
            OnRowDeleting="GridViewUniPcpDetails_RowDeleting" OnRowCommand="GridViewUniPcpDetails_RowCommand">
            <AlternatingRowStyle CssClass="alt" />
            <PagerStyle CssClass="pgr" />
            <Columns>
                <asp:TemplateField HeaderText="ID" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="lblID" runat="server" Text='<%#Eval("ID") %>'></asp:Label>
                    </ItemTemplate>

                </asp:TemplateField>

                <asp:TemplateField HeaderText="PCP ID">
                    <ItemTemplate>
                        <asp:Label ID="lblPCPID" runat="server" Text='<%#Eval("PCPID") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtPCPID" runat="server" Width="50px" Text='<%#Eval("PCPID") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtPCPID" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="5%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="PCP Name">
                    <ItemTemplate>
                        <asp:Label ID="lblPCPName" runat="server" Text='<%#Eval("PCPName") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtPCPName" runat="server" Text='<%#Eval("PCPName") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtPCPName" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="20%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="County">
                    <ItemTemplate>
                        <asp:Label ID="lblCounty" runat="server" Text='<%#Eval("County") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtCounty" runat="server" Text='<%#Eval("County") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtCounty" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="7%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Effective Date">
                    <ItemTemplate>
                        <asp:Label ID="lblEffectiveDate" runat="server" Text='<%#Eval("EffectiveDate") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox CssClass="myCalCss" ID="txtEffectiveDate" runat="server" Text='<%#Eval("EffectiveDate") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtEffectiveDate" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtEffectiveDate" ErrorMessage="Invalid date" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="8%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Terminated Date">
                    <ItemTemplate>
                        <asp:Label ID="lblTerminatedDate" runat="server" Text='<%#Eval("TerminatedDate") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox CssClass="myCalCss" ID="txtTerminatedDate" runat="server" Text='<%#Eval("TerminatedDate") %>'></asp:TextBox>
                        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtTerminatedDate" ErrorMessage="Invalid date" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="10%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Status">
                    <ItemTemplate>
                        <asp:Label ID="lblStatus" runat="server" Text='<%#Eval("Status") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtStatus" runat="server" Text='<%#Eval("Status") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="txtStatus" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="5%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="LOC">
                    <ItemTemplate>
                        <asp:Label ID="lblFeeScheduleLOC" runat="server" Text='<%#Eval("FeeScheduleLOC") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtFeeScheduleLOC" runat="server" Text='<%#Eval("FeeScheduleLOC") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="txtFeeScheduleLOC" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtFeeScheduleLOC" ErrorMessage="Enter only numeric data" ValidationExpression="^\d*\.?\d*$"></asp:RegularExpressionValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="5%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="IPA Name">
                    <ItemTemplate>
                        <asp:Label ID="lblIPAName" runat="server" Text='<%#Eval("IPAName") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtIPAName" runat="server" Text='<%#Eval("IPAName") %>'></asp:TextBox>
                    </EditItemTemplate>

                    <HeaderStyle Width="20%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Plan Name">
                    <ItemTemplate>
                        <asp:Label ID="lblPlanName" runat="server" Text='<%#Eval("PlanName") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtPlanName" runat="server" Text='<%#Eval("PlanName") %>'></asp:TextBox>
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
