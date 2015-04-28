<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonalDetails.aspx.cs" Inherits="SimpleFormsAuthentication.PersonalDetails" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Reached the Persoanl details page after successfully passing forms authentication 
        
        </h1>
    </div>
        <br />
       
        <br />
       
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/LogOut.jfif" OnClick="ImageButton1_Click" />
    </form>
</body>
</html>
