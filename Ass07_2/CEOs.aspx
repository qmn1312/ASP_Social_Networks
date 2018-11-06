<%@ Page Title="CEOs List" Language="C#" MasterPageFile="~/Databases.Master" AutoEventWireup="true" CodeBehind="CEOs.aspx.cs" Inherits="Ass07_2.CEOs" %>
<asp:Content ID="DatabaseContent" ContentPlaceHolderID="DatabaseContent" runat="server">

    <h2><%: Title %></h2>


    <asp:Button ID="CEOWholeDatabaseButton" runat="server" OnClick="CEOWholeDatabaseButton_Click" Text="View Whole CEOs Database" CssClass="Button" />


    <br />


    <br />Range Query:
        <asp:DropDownList ID="CEORangeList" runat="server" Height="27px" Width="219px">
            <asp:ListItem>Please Select An Attribute</asp:ListItem>
            <asp:ListItem>Order</asp:ListItem>
            <asp:ListItem>Age</asp:ListItem>
            <asp:ListItem>Asset</asp:ListItem>
        </asp:DropDownList>
    From:  <asp:TextBox ID="CEOFromValue" runat="server" Width="87px"></asp:TextBox>
    To:    <asp:TextBox ID="CEOToValue" runat="server" Width="91px"></asp:TextBox>
    <asp:Button ID="CEORangeButton" runat="server" Text="Range Filter" CssClass="Button" OnClick="CEORangeButton_Click" />
    <br />
    <br />
    Keyword query:<asp:TextBox ID="CEOKeyword" runat="server" Width="265px"></asp:TextBox>
    <asp:Button ID="CEOKeywordButton" runat="server" Text="Keyword Filter" CssClass="Button" OnClick="CEOKeywordButton_Click" />
    
    <br />
    <br />
    
    Date query: From:
    <asp:TextBox ID="CEOFromDate" runat="server" CssClass ="Date"></asp:TextBox>
    &nbsp; To:
    <asp:TextBox ID="CEOToDate" runat="server" CssClass ="Date"></asp:TextBox>
    <asp:Button ID="CEODateButton" runat="server" Text="Date Filter" CssClass ="Button" OnClick="CEODateButton_Click" />
    
    <br />
    <br />
    Top-K query:
    <asp:DropDownList ID="CEOTopKList" runat="server" Height="36px" Width="195px">
        <asp:ListItem>Please Select An Attribute</asp:ListItem>
        <asp:ListItem>Order</asp:ListItem>
        <asp:ListItem>Age</asp:ListItem>
        <asp:ListItem>Asset</asp:ListItem>
    </asp:DropDownList>
    <asp:TextBox ID="CEOnumberK" runat="server" Width="155px"></asp:TextBox>
    <asp:DropDownList ID="CEOTopKOrder" runat="server" Height="34px" Width="73px">
        <asp:ListItem>ASC</asp:ListItem>
        <asp:ListItem>DESC</asp:ListItem>
    </asp:DropDownList>
    <asp:Button ID="CEOTopKButton" runat="server" Text="Top-K Filter" CssClass="Button" OnClick="CEOTopKButton_Click"/>
    
    <br />
    <br />
    <asp:GridView ID="CEOsView" runat="server" CssClass="mygrdContent" HeaderStyle-CssClass="header" RowStyle-CssClass="rows">
    </asp:GridView>


</asp:Content>
