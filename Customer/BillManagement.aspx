<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage/Home.master" AutoEventWireup="true" CodeFile="BillManagement.aspx.cs" Inherits="Customer_BillManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPH" Runat="Server">
    <h1>BillManagement:</h1>
    <h1>
        <asp:TextBox ID="txtInvoice" runat="server"></asp:TextBox>
    </h1>
    <h1>
        <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
    </h1>
    <h1>
        <asp:Button ID="btnAdd" runat="server" Text="Add" onclick="btnAdd_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnUpdate" runat="server" Text="Update" 
            onclick="btnUpdate_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" Text="Delete" Height="27px" 
            onclick="btnDelete_Click" Width="56px" />
    </h1>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true">
    </asp:GridView>
</asp:Content>

