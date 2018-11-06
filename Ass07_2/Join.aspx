<%@ Page Title="Join Databases" Language="C#" MasterPageFile="~/Databases.Master" AutoEventWireup="true" CodeBehind="Join.aspx.cs" Inherits="Ass07_2.Join" %>
<asp:Content ID="DatabaseContent" ContentPlaceHolderID="DatabaseContent" runat="server">

    <h2><%: Title %></h2>

    <asp:Button ID="JoinButton" runat="server" Text="Click to join two tables" CssClass="Button" OnClick="JoinButton_Click" />

    <br />

    <br />
    <asp:GridView ID="JoinGridView" runat="server" CssClass="mygrdContent" HeaderStyle-CssClass="header" RowStyle-CssClass="rows">
    </asp:GridView>

</asp:Content>
