<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Ass07_2.Home" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div id="myCarousel" class="carousel slide" data-ride="carousel">
      <!-- Indicators -->
      <ol class="carousel-indicators">
        <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
        <li data-target="#myCarousel" data-slide-to="1"></li>
        <li data-target="#myCarousel" data-slide-to="2"></li>
      </ol>

      <!-- Wrapper for slides -->
      <div class="carousel-inner">
        <div class="item active">
            <div class ="homelogo">
                <a href="https://www.facebook.com/" target="_blank" >
                <img src="images/facebook.jpg" alt="Facebook" class="imgHomeLogo"/>
                </a>
            </div>
        </div>

        <div class="item">
            <div class ="homelogo">
             <a href="https://www.instagram.com/" target="_blank">
                <img src="images/instagram.png" alt="Instagram" class="imgHomeLogo"/>
              </a>
            </div>
        </div>

        <div class="item">
            <div class ="homelogo">
              <a href="https://twitter.com/" target="_blank">
                <img src="images/twitter.png" alt="Twitter" class="imgHomeLogo"/>
              </a>
            </div>
        </div>
      </div>

      <!-- Left and right controls -->
      <a class="left carousel-control" href="#myCarousel" data-slide="prev">
        <span class="glyphicon glyphicon-chevron-left"></span>
        <span class="sr-only">Previous</span>
      </a>
      <a class="right carousel-control" href="#myCarousel" data-slide="next">
        <span class="glyphicon glyphicon-chevron-right"></span>
        <span class="sr-only">Next</span>
      </a>
    </div>
</asp:Content>
