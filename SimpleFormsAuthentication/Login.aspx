﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SimpleFormsAuthentication.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1> Welcome to forms authentication Demo</h1>
        <%--<asp:Login ID="Login1" runat="server" onauthenticate="Login1_Authenticate" 
           >
        </asp:Login>--%>
       

       

    </div>
    <p>
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
    </p>

     <p>
        <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
    </p>
    <asp:Button ID="btnLogin" runat="server" Text="Login" />
    </form>
</body>
</html>
