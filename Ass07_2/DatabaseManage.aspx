<%@ Page Title="Welcome to Social Networks Databases" Language="C#" MasterPageFile="~/Databases.Master" AutoEventWireup="true" CodeBehind="DatabaseManage.aspx.cs" Inherits="Ass07_2.DatabaseManage" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="DatabaseContent" runat="server">
    <h2> Welcome to Social Networks Databases <%: Context.User.Identity.GetUserName()  %> !!!</h2>
</asp:Content>
