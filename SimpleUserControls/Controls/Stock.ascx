<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Stock.ascx.cs" Inherits="SimpleUserControls.Controls.Stock" %>
<div>StockName : <% =this.Name %></div>
<br />
<div>Stock Category: <%=this.Category %></div>
<br />
<div>Stock CMP : <%=this.CurrentPrice  %></div>