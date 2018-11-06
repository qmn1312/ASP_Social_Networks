<%@ Page Title="Companies List" Language="C#" MasterPageFile="~/Databases.Master" AutoEventWireup="true" CodeBehind="Companies.aspx.cs" Inherits="Ass07_2.Companies" %>
<asp:Content ID="DatabaseContent" ContentPlaceHolderID="DatabaseContent" runat="server">
    
    <h2><%: Title %> </h2>


    <asp:Button ID="WholeDatabaseButton" runat="server" OnClick="WholeDatabaseButton_Click" Text="View Whole Companies Database" CssClass="Button" />
    <br />


    <br />Range Query:
        <asp:DropDownList ID="RangeList" runat="server" Height="27px" Width="219px">
            <asp:ListItem>Please Select An Attribute</asp:ListItem>
            <asp:ListItem>Company Order</asp:ListItem>
            <asp:ListItem>Number of users</asp:ListItem>
            <asp:ListItem>Company Value</asp:ListItem>
        </asp:DropDownList>
    From:  <asp:TextBox ID="FromValue" runat="server" Width="87px"></asp:TextBox>
    To:    <asp:TextBox ID="ToValue" runat="server" Width="91px"></asp:TextBox>
    <asp:Button ID="RangeButton" runat="server" Text="Range Filter" OnClick="RangeButton_Click" CssClass="Button" />
    <br />
    <br />
    Keyword query:<asp:TextBox ID="Keyword" runat="server" Width="265px"></asp:TextBox>
    <asp:Button ID="KeywordButton" runat="server" Text="Keyword Filter" OnClick="KeywordButton_Click" CssClass="Button" />
    
    <br />
    <br />
    
    Date query: From:
    <asp:TextBox ID="FromDate" runat="server" CssClass ="Date"></asp:TextBox>
    &nbsp; To:
    <asp:TextBox ID="ToDate" runat="server" CssClass ="Date"></asp:TextBox>
    <asp:Button ID="DateButton" runat="server" Text="Date Filter" CssClass ="Button" OnClick="DateButton_Click"/>
    
    <br />
    <br />
    Top-K query:
    <asp:DropDownList ID="TopKList" runat="server" Height="33px" Width="231px">
        <asp:ListItem>Please Select An Attribute</asp:ListItem>
        <asp:ListItem>Number of users</asp:ListItem>
        <asp:ListItem>Company Value</asp:ListItem>
        <asp:ListItem>Company Order</asp:ListItem>
    </asp:DropDownList>
    <asp:TextBox ID="numberK" runat="server" Width="155px"></asp:TextBox>
    <asp:DropDownList ID="TopKOrder" runat="server" Height="34px" Width="73px">
        <asp:ListItem>ASC</asp:ListItem>
        <asp:ListItem>DESC</asp:ListItem>
    </asp:DropDownList>
    <asp:Button ID="TopKButton" runat="server" OnClick="TopKButton_Click" Text="Top-K Filter" CssClass="Button"/>
    
    <br />
    <br />
    <asp:GridView ID="CompaniesView" runat="server" CssClass="mygrdContent" HeaderStyle-CssClass="header" RowStyle-CssClass="rows" >
    </asp:GridView>
</asp:Content>
