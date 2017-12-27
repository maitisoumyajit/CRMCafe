<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage/Home.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Assets_Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPH" Runat="Server">
    <br />
    <asp:Button ID="btnElectronics" runat="server" Text="Electronics" 
        onclick="btnElectronics_Click" />
    <br />
    <br />
    <asp:Button ID="btnFurniture" runat="server" Text="Furniture" 
        onclick="btnFurniture_Click" />
    <br />
    <br />
    <asp:Button ID="btnKitchenAppliances" runat="server" Text="KitchenAppliances" 
        onclick="btnKitchenAppliances_Click" />
</asp:Content>

