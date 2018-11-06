<%@ Page Title="Create Boxes Like Snake" Language="C#" MasterPageFile="~/Entertainment.Master" AutoEventWireup="true" CodeBehind="Snake.aspx.cs" Inherits="Ass07_2.Snake" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="EntertainmentContent" runat="server">
    <h2><%: Title %>.</h2>

    <label for="spinner">Select a number of boxes:</label>
    <input id="spinner" name="value" class="ui-spinner-input" autocomplete="off" role="spinbutton">

    <br /><br />
    <input id="createBoxesButton" type="button" value="Create Boxes" class="UIButton"/>
    <input id="createSnakeButton" type="button" value="Moving Boxes Like a Snake" class="UIButton"/>
    <input id="setValuesTo300" type="button" value="Set Value To 300" class="UIButton"/>

    <br /><br /><br /><br /><br /><br />
    <div id="snakeDiv">
    </div>
</asp:Content>
