<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage/Home.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Menu_Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPH" Runat="Server">
<div>
    <h4>
        Espresso
        <asp:TextBox ID="txtQty" runat="server" Width="34px" />
        <asp:Button ID="btnATC" runat="server" Text="AToC" />
    </h4>
    <h4>
        Americano
        <asp:TextBox ID="txtQty1" runat="server" Width="34px" />
        <asp:Button ID="btnATC1" runat="server" Text="AToC" />
    </h4>
    <h4>
        Latte
        <asp:TextBox ID="txtQty2" runat="server" Width="34px" />
        <asp:Button ID="btnATC2" runat="server" Text="AToC" />
    </h4>
    <h4>
        Cappuccino
        <asp:TextBox ID="txtQty3" runat="server" Width="34px" />
        <asp:Button ID="btnATC3" runat="server" Text="AToC" />
    </h4>
    <h4>
        Mocha
        <asp:TextBox ID="txtQty4" runat="server" Width="34px" />
        <asp:Button ID="btnQty5" runat="server" Text="AToC" />
    </h4>
    <h3>Total:</h3>
</div>
</asp:Content>

