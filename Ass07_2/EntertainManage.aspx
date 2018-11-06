<%@ Page Title="Welcome to Social Networks Entertainment" Language="C#" MasterPageFile="~/Entertainment.Master" AutoEventWireup="true" CodeBehind="EntertainManage.aspx.cs" Inherits="Ass07_2.EntertainManage" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="EntertainmentContent" runat="server">
    <h2> Welcome to Social Networks Entertainment <%: Context.User.Identity.GetUserName()  %> !!!</h2>
</asp:Content>
