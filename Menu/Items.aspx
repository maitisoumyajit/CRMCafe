<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage/Home.master" AutoEventWireup="true" CodeFile="Items.aspx.cs" Inherits="Menu_Items" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPH" Runat="Server">
    <h1>Menu Items:</h1>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</asp:Content>

