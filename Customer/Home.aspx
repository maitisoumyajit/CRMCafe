<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage/Home.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Customer_Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CPH" Runat="Server">
<div align="center">
    <h3>
        Cafe 'Name'</br>
        Addr:201 Sky Flama A Dosti Flamingos</br>
        Sewri Naka Mumbai-400015</br>
        Mb.No.:9892333058</br>
        www.Cafename.com</br>
        <script>
//            var utc = new Date().toJSON().slice(0,10).replace(/-/g, '/');
//            document.write(utc);
            var d = new Date();
            d.getHours;
            d.getMinutes;
            d.getSeconds;
            document.write(d);
        </script></br>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </h3>
</div>
</asp:Content>

