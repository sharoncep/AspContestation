<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Freedom.aspx.cs" Inherits="Contestation.Freedom.Freedom" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


    <link rel="stylesheet" type="text/css" href="../Css/tooltipster.css" />

    <script src="../Scripts/Freedom/Freedom.js"></script>

    <script type="text/javascript" src="../Scripts/tooltipster/jquery.tooltipster.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="pageheader">Contestation Freedom</div>

    <div class="dv_main_search">
        <ul class="ul_searchform">
            <li style="width: 200px"><span>Claim Type</span>
                <asp:RadioButtonList ID="rbtnlstClaimType" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem>INST </asp:ListItem>
                    <asp:ListItem Selected="True">PROF</asp:ListItem>
                </asp:RadioButtonList>
            </li>
            <li>
                <asp:TextBox ID="txtFrom" runat="server" CssClass="textbox_dos" placeholder="From Date"></asp:TextBox></li>
            <li>
                <asp:TextBox ID="txtTo" runat="server" CssClass="textbox_dos" placeholder="To Date"></asp:TextBox></li>
            <li style="width: 200px"><span>Pcp County</span>
                <asp:DropDownList ID="drpPcpCounty" CssClass="ddl" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drpPcpCounty_SelectedIndexChanged">
                </asp:DropDownList>

            </li>
            <li><span>
                <asp:Label ID="lblPcpName" runat="server" Text="Select Pcp Name"></asp:Label></span>
                <asp:DropDownList ID="drpPcpName" runat="server" CssClass="ddl">
                </asp:DropDownList>
            </li>
        </ul>
    </div>
    <div class="clear"></div>
    <div id="divLoading" style="display: none">
        <img src="../Images/ajax-loader.gif" />
    </div>
    <div id="divList" class="divList">
        <ul class="ul-cases">
            <li>
                <div id="divID1" class="tooltip1" title="<b class='bold'>FILING LIMIT</b>Hospital must claim for their service within 12 months of date of service.  If a claim is filing 12 months after the date of service, we deny such claims.">
                    <asp:LinkButton ID="lnkBtnCase1" runat="server" PostBackUrl="~/Freedom/Freedom.aspx?id=1" OnClientClick="return ValidateEntry()" OnClick="lnkBtnCase1_Click">Case1 </asp:LinkButton>
                </div>
            </li>
            <li>
                <div id="div1" class="tooltip1" title="<b class='bold'>ELIGIBILITY</b>Member’s eligibility is checked to confirm whether the member is eligible for the service date and to know about the copay (For copay, refer Freedom site) details for different service.">
                    <asp:LinkButton ID="lnkBtnCase2" runat="server" PostBackUrl="~/Freedom/Freedom.aspx?id=2" OnClientClick="return ValidateEntry()" OnClick="lnkBtnCase1_Click">Case2</asp:LinkButton>
                </div>
            </li>
            <li>
                <div id="div2" class="tooltip1" title="<b class='bold'>DUPLICATE</b>If a claim is paid previously, we can deny the duplicate claim after verifying the whole fund expense for that claim. ">
                    <asp:LinkButton ID="lnkBtnCase3" runat="server" PostBackUrl="~/Freedom/Freedom.aspx?id=3" OnClientClick="return ValidateEntry()" OnClick="lnkBtnCase1_Click">Case3</asp:LinkButton>
                </div>
            </li>
            <li>
                <div id="div3" class="tooltip1" title="<b class='bold'>SAME PCP</b>The PCP must not claim for his own service or in other words a member must not be referred to another PCP in the same IPA.  So the claim is to be checked whether the service is done at the office of referring PCP or any other PCP in the same IPA. We can deny such claims.">
                    <asp:LinkButton ID="lnkBtnCase4" runat="server" PostBackUrl="~/Freedom/Freedom.aspx?id=4" OnClientClick="return ValidateEntry()" OnClick="lnkBtnCase1_Click">Case4</asp:LinkButton>
                </div>
            </li>
            <li>
                <div id="div4" class="tooltip1" title="<b class='bold'>MVA/INJURY</b>The claim has to be denied, if the patient is a victim of Motor Vehicle Accident (MVA).  This is confirmed through mail or often directly verified through the Code Manager application, when injury/fracture diagnosis is reported in claim.">
                    <asp:LinkButton ID="lnkBtnCase5" runat="server" PostBackUrl="~/Freedom/Freedom.aspx?id=5" OnClientClick="return ValidateEntry()" OnClick="lnkBtnCase1_Click">Case5</asp:LinkButton>
                </div>
            </li>
            <li>
                <div id="div5" class="tooltip1" title="<b class='bold'>PCP EFFECTIVE </b>Check whether the pcp is effective  in our IPA. ">
                    <asp:LinkButton ID="lnkBtnCase6" runat="server" PostBackUrl="~/Freedom/Freedom.aspx?id=6" OnClientClick="return ValidateEntry()" OnClick="lnkBtnCase1_Click">Case6</asp:LinkButton>
                </div>
            </li>
            <li>
                <div id="div6" class="tooltip1" title="<b class='bold'>HOSPICE</b>Check the ‘Demographic file’ in service fund to confirm the patient’s HCFA (Health care Financial Administration) status such as Hospice.">
                    <asp:LinkButton ID="lnkBtnCase7" runat="server" PostBackUrl="~/Freedom/Freedom.aspx?id=7" OnClientClick="return ValidateEntry()" OnClick="lnkBtnCase1_Click">Case7</asp:LinkButton>
                </div>
            </li>
            <li>
                <div id="div7" class="tooltip1" title="<b class='bold'>CAPITATION</b>Some capitated providers are contracted with Insurance Company.  It may be a specialist or a group of specialists or a particular center.  The service done by these Capitated providers should not be paid by PCP.">
                    <asp:LinkButton ID="lnkBtnCase8" runat="server" PostBackUrl="~/Freedom/Freedom.aspx?id=8" OnClientClick="return ValidateEntry()" OnClick="lnkBtnCase1_Click">Case8</asp:LinkButton>
                </div>
            </li>
            <li>
                <div id="div8" class="tooltip1" title="<b class='bold'>COST REALLOCATION</b>Check the filing limitation of transfer out members.">
                    <asp:LinkButton ID="lnkBtnCase9" runat="server" PostBackUrl="~/Freedom/Freedom.aspx?id=9" OnClientClick="return ValidateEntry()" OnClick="lnkBtnCase1_Click">Case9</asp:LinkButton>
                </div>
            </li>
            <li>
                <div id="div9" class="tooltip1" title="<b class='bold'>REFERRAL/AUTHORIZATION</b>Some services need referral from PCP.  It is usually mentioned in claims; otherwise we can find it out from the Freedom web portal.">
                    <asp:LinkButton ID="lnkBtnCase10" runat="server" PostBackUrl="~/Freedom/Freedom.aspx?id=10" OnClientClick="return ValidateEntry()" OnClick="lnkBtnCase1_Click">Case10</asp:LinkButton>
                </div>
            </li>
            <li>
                <div id="div10" class="tooltip1" title="<b class='bold'>CLAIM OVER PAID</b>The fee issued for the claims are being paid by PCP fund.  Excess fees should be contested. ">
                    <asp:LinkButton ID="lnkBtnCase11" runat="server" PostBackUrl="~/Freedom/Freedom.aspx?id=11" OnClientClick="return ValidateEntry()" OnClick="lnkBtnCase1_Click">Case11</asp:LinkButton>
                </div>
            </li>
        </ul>

        <div class="dv-btns">
            <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" OnClientClick="return ValidateRecords()" Text="Save" CssClass="btnsave" />
        </div>
    </div>

    <div class="clear">
    </div>
    <div id="tabs-1" class="demo_container1">
        <asp:Label ID="lblMsg" runat="server" Visible="false" CssClass="span_error"></asp:Label>
        <asp:Repeater ID="rptrDataList" runat="server">
            <HeaderTemplate>
                <table class="table-grid">
                    <tr>
                        <%--<th>SN</th>--%>
                        <th>Pcp Id</th>
                        <th>Pcp name</th>
                        <th>Member id</th>
                        <th>Member Name</th>
                        <th>Claim type</th>
                        <th>Claim Id</th>
                        <%--<th>Billtype pos</th>--%>
                        <th>Service code</th>
                        <th>From date</th>
                        <%--<th>To date</th>--%>
                        <th>Modifiers</th>
                        <%--<th>Line No</th>--%>
                        <th>Check date</th>
                        <th>Reason</th>
                        <th colspan="2" style="text-align: right"><%--Select All--%>
                            <input id="chkAll" title="Check All"
                                runat="server" type="checkbox" />
                        </th>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <%--<td><%#Container.ItemIndex+1 %></td>--%>
                    <td>
                        <asp:Label ID="pcpID" runat="server" Text='<%#Eval("pcpID") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="pcpName" runat="server" Text='<%#Eval("pcpName") %>'></asp:Label></td>
                    <td>
                        <asp:Label ID="subscriberID" runat="server" Text='<%#Eval("subscriberID") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="memberName" runat="server" Text='<%#Eval("memberName") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="claimType" runat="server" Text='<%#Eval("claimType") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="claimID" runat="server" Text='<%#Eval("claimID") %>'></asp:Label>
                    </td>
                    <%--<td>--%>
                    <asp:Label Visible="false" ID="billTypePos" runat="server" Text='<%#Eval("billTypePos") %>'></asp:Label>
                    <%--</td>--%>
                    <td>
                        <asp:Label ID="serviceCode" runat="server" Text='<%#Eval("serviceCode") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="serviceBegin" runat="server" Text='<%#Eval("serviceBegin") %>'></asp:Label>
                    </td>
                    <%--<td>--%>
                    <asp:Label Visible="false" ID="serviceEnd" runat="server" Text='<%#Eval("serviceEnd") %>'></asp:Label>
                    <%--</td>--%>
                    <td>
                        <asp:Label ID="serviceCodeModi" runat="server" Text='<%#Eval("serviceCodeModi") %>'></asp:Label>
                    </td>
                    <%--  <td>--%>
                    <asp:Label Visible="false" ID="lineNo" runat="server" Text='<%#Eval("lineNo") %>'></asp:Label>

                    <%--                    </td>--%>
                    <td>
                        <asp:Label ID="checkDate" runat="server" Text='<%#Eval("checkDate") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="reason" runat="server" Text='<%#Eval("reason") %>'></asp:Label>
                    </td>

                    <asp:Label Visible="false" ID="units" runat="server" Text='<%#Eval("units") %>'></asp:Label>


                    <asp:Label Visible="false" ID="drgCode" runat="server" Text='<%#Eval("drgCode") %>'></asp:Label>


                    <asp:Label Visible="false" ID="providerID" runat="server" Text='<%#Eval("providerID") %>'></asp:Label>


                    <asp:Label Visible="false" ID="providerName" runat="server" Text='<%#Eval("providerName") %>'></asp:Label>


                    <asp:Label Visible="false" ID="billedAmount" runat="server" Text='<%#Eval("billedAmount") %>'></asp:Label>


                    <asp:Label Visible="false" ID="paidAmount" runat="server" Text='<%#Eval("paidAmount") %>'></asp:Label>

                    <td>
                        <a href="javascript:void(0)" class="aDetails" title="Click to see more details" onclick="ShowDetails(
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
                                        );">Details</a>

                        <%--<div id="dv-blanket" style="display: none">
                            <div id='dialog-form_<%#Eval("ID") %>' title="Details">
                            </div>
                        </div>--%>

                    </td>
                    <td style="text-align: right;">
                        <asp:CheckBox ID="chkSelect" runat="server" /></td>
                </tr>

            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
    </div>

</asp:Content>
