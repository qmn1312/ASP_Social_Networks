<%@ Page Title="Welcome to Social Networks Database" Language="C#" MasterPageFile="~/Databases.Master" AutoEventWireup="true" CodeBehind="DatabasesHome.aspx.cs" Inherits="Ass07_2.DatabasesHome" %>
<asp:Content ID="DatabaseContent" ContentPlaceHolderID="DatabaseContent" runat="server">
    
    <div id="databaseDiv">
        <img src="images/database.png" id="databaseLogo" />

        <h2><%: Title %></h2>
    
        <h3><a href="Companies">View Database About Social Networks Companies</a></h3>
        <h3><a href="CEOs">View Database About CEOs of Social Networks Companies </a></h3>
        <h3><a href="Join">Join those two databases</a></h3>

    </div>

</asp:Content>
