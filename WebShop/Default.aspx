<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebShop._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <head>

        <link href="Content/slider.css" rel="stylesheet" />

    </head>
    <%--  <h2><%: Title %>.</h2>
    <h3>Webshop we can help you find the perfect gift.</h3>
    <p class="lead">
        WE ARE WEBSHOP,
            SHOP THE FRESHEST FASHION FROM 500+ OF THE WORLD'S BEST BRANDS.
            ALWAYS OPEN, ALWAYS NEW.--%>
    <%--</p>--%>

    <div id="slider">
        <figure>
            
            <img class="mySlides" src="Images/guess.jpg">
          
               <img class="mySlides" src="Images/stranger-things-nike-wallpaper-hd.jpg">
            <img class="mySlides" src="Images/thumb-1920-599094.png">
             <img class="mySlides" src="Images/le-coq-sportif-omega-leather-black.jpg">
        </figure>
    </div>

</asp:Content>
