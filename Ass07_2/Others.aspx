<%@ Page Title="Other Social Networks" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Others.aspx.cs" Inherits="Ass07_2.Others" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>

    <ol id="OthersSelectable">
        <li class="ui-widget-content">Youtube</li>
        <li class="ui-widget-content">Linkedln</li>
        <li class="ui-widget-content">Quora</li>
        <li class="ui-widget-content">Pinterest </li>
        <li class="ui-widget-content">Snapchat</li>
    </ol>

    <br /> <br />
    <h3><a runat="server" href="DatabasesHome">View Databases</a></h3>
    <h3><a runat="server" href="EntertainmentHome">Entertainment</a></h3>

</asp:Content>
