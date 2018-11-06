<%@ Page Title="Headquarters" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Headquarters.aspx.cs" Inherits="Ass07_2.Headquarters" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>

    <div id="HeadquartersAccordion">
		<h3>Facebook Headquarter</h3>
		<div>
            <strong>Facebook Inc.</strong>
            1 Facebook Way <br />
            Menlo Park <br />
            CA 94025, USA <br />
            +1 650-543-4800
		</div>
		<h3>Instagram Headquarter</h3>
		<div>
            <strong>Instagram Inc.</strong>
			1 Hacker Way <br />
            Menlo Park <br /> 
            CA 94025, USA <br />
		</div>

		<h3>Twitter Headquarter</h3>
		<div>
            <strong>Twiter Inc.</strong>
            1355 Market St #900 <br />
            San Francisco <br /> 
            CA 94103, USA <br />
            +1 415-222-9670
		</div>
	</div>
</asp:Content>
