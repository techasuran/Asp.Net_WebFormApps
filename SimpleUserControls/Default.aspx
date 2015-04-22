<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleUserControls.Default" %>
<%@ Register TagPrefix="UC" TagName="UserInfoBoxControl" Src="~/UserInfoBoxControl.ascx"  %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <UC:UserInfoBoxControl runat="server" ID="myUserInfoBoxControl" UserName="Nevin" UserAge="31" UserCountry="India" />
    <br />
    <asp:Button ID="aspButton" Text="AspButton"  runat="server"/>

        <br />


        <br />
        <br />

        <h3 style="color:red;font:bold 12px verdana;"> 
            Stock details is showing from the user control stock which is registered in web.config <br /> imp : user contrl registering from webconfig need to be palced in a seperate folder </h3>

        </div>
        <UC:Stock runat="server" ID="myStock" Category="FMCG" CurrentPrice="339" Name="ITC" />
        <div></div>
    </form>
</body>
</html>
