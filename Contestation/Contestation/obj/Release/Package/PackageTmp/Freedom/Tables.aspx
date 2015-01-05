<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tables.aspx.cs" Inherits="Contestation.Freedom.Tables" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Menu ID="Menu1" runat="server">
        <Items>
            <asp:MenuItem NavigateUrl="~/Freedom/tblFlatRate.aspx" Text="FlatRate " Value="FlatRate "></asp:MenuItem>
            <asp:MenuItem NavigateUrl="~/Freedom/tblFRHProfRate.aspx" Text="FRHProfRate " Value="FRHProfRate "></asp:MenuItem>
            <asp:MenuItem NavigateUrl="~/Freedom/tblInjuryCodes.aspx" Text="InjuryCodes " Value="InjuryCodes "></asp:MenuItem>
            <asp:MenuItem NavigateUrl="~/Freedom/tblMVA-FRH.aspx" Text="MVA-FRH " Value="MVA-FRH "></asp:MenuItem>
            <asp:MenuItem NavigateUrl="~/Freedom/tblMVAAccidentCodes.aspx" Text="MVAAccidentCodes " Value="MVAAccidentCodes "></asp:MenuItem>
            <asp:MenuItem NavigateUrl="~/Freedom/tblUniPcpDetails.aspx" Text="UniPcpDetails " Value="UniPcpDetails "></asp:MenuItem>
            <asp:MenuItem NavigateUrl="~/Freedom/tblUniProfClaimFeeSchedule.aspx" Text="UniProfClaimFeeSchedule " Value="UniProfClaimFeeSchedule "></asp:MenuItem>
        </Items>
    </asp:Menu>
</asp:Content>


