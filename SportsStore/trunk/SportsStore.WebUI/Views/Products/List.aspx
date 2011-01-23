<%@ Import Namespace="SportsStore.Domain.Entities" %>	


<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.master" 
	Inherits="System.Web.Mvc.ViewPage<IEnumerable<Product>>" %>
	

<asp:Content ID="headContent" ContentPlaceHolderID="TitleContent" runat="server">
	Products
</asp:Content>

<asp:Content ID="MainContentContent" ContentPlaceHolderID="MainContent" runat="server">
	<% foreach(var product in Model) { %>
	<div class="item">
		<h3><%= Html.Encode( product.Name ) %></h3>
		<%= Html.Encode( product.Description ) %>
		<h4><%= Html.Encode( product.Price.ToString("c") ) %></h4>
	</div>
	<% } %>
</asp:Content>
