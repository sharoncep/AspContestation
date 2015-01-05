<%@ Page Title="" Language="C#" MasterPageFile="~/OptimumMaster.Master" AutoEventWireup="true" CodeBehind="tblConUNIAnesthesiaFeeSchedule.aspx.cs" Inherits="Contestation.Optimum.tblConUNIAnesthesiaFeeSchedule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../Scripts/Optimum/tblConUNIAnesthesiaFeeSchedule.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="pageheader">
        Optimum<span>- Anesthesia Fee Schedule</span>
        <div class="dv_fl_right">
            <a href="Javascript:searchDiv();" id="aSearch" class="aSearch">Search</a>
            <a id="aAdd" class="aAdd" href="tblConUNIAnesthesiaFeeScheduleAdd.aspx">Add</a>
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
        <asp:GridView ID="GridViewConUNIAnesthesiaFeeSchedule" EmptyDataText="No records Found" runat="server" AutoGenerateColumns="False" BorderWidth="0" CssClass="mGrid"
            AllowPaging="true" ShowFooter="false" PageSize="10" Width="100%" OnPageIndexChanging="GridViewConUNIAnesthesiaFeeSchedule_PageIndexChanging"
            OnRowCancelingEdit="GridViewConUNIAnesthesiaFeeSchedule_RowCancelingEdit" OnRowEditing="GridViewConUNIAnesthesiaFeeSchedule_RowEditing"
            OnRowUpdating="GridViewConUNIAnesthesiaFeeSchedule_RowUpdating"
            OnRowDeleting="GridViewConUNIAnesthesiaFeeSchedule_RowDeleting" OnRowCommand="GridViewConUNIAnesthesiaFeeSchedule_RowCommand" HorizontalAlign="Center">
            <AlternatingRowStyle CssClass="alt" />
            <PagerSettings Mode="NumericFirstLast" />
            <PagerStyle CssClass="pgr" />
            <Columns>
                <asp:TemplateField HeaderText="ID" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="lblID" runat="server" Text='<%#Eval("ID") %>'></asp:Label>
                    </ItemTemplate>

                </asp:TemplateField>

                <asp:TemplateField HeaderText="From Date">
                    <ItemTemplate>
                        <asp:Label ID="lblFromDate" runat="server" Text='<%#Eval("FromDate") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox CssClass="myCalCss" ID="txtFromDate" runat="server" Text='<%#Eval("FromDate") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtFromDate" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtFromDate" ErrorMessage="Invalid date" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="8%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="To Date">
                    <ItemTemplate>
                        <asp:Label ID="lblToDate" runat="server" Text='<%#Eval("ToDate") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox CssClass="myCalCss" ID="txtToDate" runat="server" Text='<%#Eval("ToDate") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtToDate" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="txtToDate" ErrorMessage="Invalid date" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="7%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Procedure Code">
                    <ItemTemplate>
                        <asp:Label ID="lblProcedureCode" runat="server" Text='<%#Eval("ProcedureCode") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtProcedureCode" runat="server" Text='<%#Eval("ProcedureCode") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtProcedureCode" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="10%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Unit">
                    <ItemTemplate>
                        <asp:Label ID="lblUnit" runat="server" Text='<%#Eval("Unit") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtUnit" runat="server" Text='<%#Eval("Unit") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="txtUnit" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtUnit" ErrorMessage="Units should be numeric (max 5 digits)" ValidationExpression="[0-9]{1,5}"></asp:RegularExpressionValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="10%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Par Allow">
                    <ItemTemplate>
                        <asp:Label ID="lblParAllow" runat="server" Text='<%#Eval("ParAllow") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtParAllow" runat="server" Text='<%#Eval("ParAllow") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="txtParAllow" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtParAllow" ErrorMessage="Enter only numeric data" ValidationExpression="^\d*\.?\d*$"></asp:RegularExpressionValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="10%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Locality">
                    <ItemTemplate>
                        <asp:Label ID="lblLocality" runat="server" Text='<%#Eval("Locality") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtLocality" runat="server" Text='<%#Eval("Locality") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ControlToValidate="txtLocality" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtLocality" ErrorMessage="Locality should be numeric (max 5 digits)" ValidationExpression="[0-9]{1,5}"></asp:RegularExpressionValidator>
                    </EditItemTemplate>

                    <HeaderStyle Width="10%"></HeaderStyle>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="IPA">
                    <ItemTemplate>
                        <asp:Label ID="lblIPA_NAME" runat="server" Text='<%#Eval("IPA_NAME") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtIPA_NAME" runat="server" Text='<%#Eval("IPA_NAME") %>'></asp:TextBox>
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

            <%--<PagerTemplate>ITemplatefffffffffffffffaaaaaaaaaaaaaaaaaaaaaaaaggggggggggggggggg</PagerTemplate>--%>
        </asp:GridView>
    </div>
</asp:Content>
