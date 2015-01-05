<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Results.aspx.cs" Inherits="Contestation.Freedom.Results" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script src="../Scripts/Freedom/Results.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="pageheader">Freedom<span>- Results</span> </div>
    <div class="dv_main_search">
        <ul class="ul_searchform">
            <li style="width: 180px"><span>Select</span>
                <asp:RadioButtonList ID="rbtnSearch" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True" Value="all">All</asp:ListItem>
                    <asp:ListItem Value="date">Date Wise</asp:ListItem>
                </asp:RadioButtonList>
            </li>
            <li>
                <asp:TextBox ID="txtFrom" runat="server" CssClass="textbox_dos" placeholder="From Date"></asp:TextBox></li>
            <li>
                <asp:TextBox ID="txtTo" runat="server" CssClass="textbox_dos" placeholder="To Date"></asp:TextBox></li>
            <li>
                <asp:Button ID="btnSearch" runat="server" OnClick="btnSearch_Click" OnClientClick="return getData();" CssClass="btnseacrh" Text="Search" /></li>
        </ul>
    </div>
    <div class="clear"></div>
    <div class="dv-btns1">
        <asp:Button ID="btnExcelUpload" runat="server" OnClick="btnExcelUpload_Click" CssClass="btnsave" Text="Export to Excel" />
    </div>
    <div class="demo_container">
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <asp:Repeater ID="rptrDataList" runat="server">
            <HeaderTemplate>
                <table class="table-grid">
                    <tr>
                        <%--<th style="width:3%">SL#</th>--%>
                        <th style="width: 5%">Pcp Id</th>
                        <th style="width: 15%">Pcp name</th>
                        <th style="width: 8%">Member id</th>
                        <th style="width: 11%">Member Name</th>
                        <th style="width: 7%">Claim type</th>
                        <th style="width: 8%">Claim Id</th>
                        <%--<th>Billtype pos</th>--%>
                        <th style="width: 8%">Service code</th>
                        <th style="width: 8%">From date</th>
                        <%--<th>To date</th>
                        <th>Service code modi</th>--%>
                        <%--<th>Line No</th>--%>
                        <th style="width: 7%">Check date</th>
                        <th style="width: 19%">Reason</th>
                        <%--<th style="width:5%">DOE</th>--%>
                        <th style="width: 3%"></th>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>

                <tr>
                    <%--<td><%#Container.ItemIndex+1 %></td>--%>
                    <td><%#Eval("pcpID") %></td>
                    <td><%#Eval("pcpName") %></td>
                    <td><%#Eval("subscriberID") %></td>
                    <td><%#Eval("memberName") %></td>
                    <td><%#Eval("claimType") %></td>
                    <td><%#Eval("claimID") %></td>
                    <%--<td><%#Eval("billTypePos") %></td>--%>
                    <td><%#Eval("serviceCode") %></td>

                    <td><%#Eval("serviceBegin") %></td>
                    <%--<td><%#Eval("serviceEnd") %></td>

                    <td><%#Eval("serviceCodeModi") %></td>--%>
                    <%--<td><%#Eval("lineNo") %></td>--%>
                    <td><%#Eval("checkDate") %></td>


                    <td><%#Eval("reason") %></td>
                    <%--<td><%#Eval("dateOfContest") %></td>--%>

                    <td><a href="javascript:void(0)" class="aDetails" title="Click to see more details"
                        onclick="ShowDetails(
                                         <%#Eval("ID")%>
                                        ,'<%#Eval("pcpID") %>'
                                        ,'<%#Eval("pcpName") %>'
                                        ,'<%#Eval("subscriberID")%>'
                                        ,'<%#Eval("memberName") %>'
                                        ,'<%#Eval("claimType") %>'
                                        ,'<%#Eval("claimID") %>'
                                        ,'<%#Eval("billTypePos") %>'
                                        ,'<%#Eval("serviceCode") %>'
                                        ,'<%#Eval("serviceBegin") %>'
                                        ,'<%#Eval("serviceEnd") %>'
                                        ,'<%#Eval("checkDate") %>'
                                        ,'<%#Eval("serviceCodeModi") %>'
                                        ,'<%#Eval("lineNo") %>'
                                        ,'<%#Eval("units") %>'
                                        ,'<%#Eval("drgCode") %>'
                                        ,'<%#Eval("providerID") %>'
                                        ,'<%#Eval("providerName") %>'
                                        ,'<%#Eval("billedAmount") %>'
                                        ,'<%#Eval("paidAmount") %>'
                                        ,'<%#Eval("reason") %>'
                                        ,'<%#Eval("dateOfContest") %>'
                                        );">Details</a>
                        <div id='dialog-form_<%#Eval("ID") %>' title="Details">
                        </div>
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
    </div>

</asp:Content>
