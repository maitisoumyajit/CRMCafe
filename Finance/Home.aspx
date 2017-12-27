<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage/Home.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Finance_Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPH" Runat="Server">
    <br />
    <asp:Button ID="btnGoods" runat="server" Text="Goods" 
        onclick="btnGoods_Click" />
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnBills" runat="server" Text="Bills" 
        onclick="btnBills_Click" />
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnSalary" runat="server" Text="Salary" 
        onclick="btnSalary_Click" />
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnAccounts" runat="server" Text="Accounts" 
        onclick="btnAccounts_Click" />
</asp:Content>

