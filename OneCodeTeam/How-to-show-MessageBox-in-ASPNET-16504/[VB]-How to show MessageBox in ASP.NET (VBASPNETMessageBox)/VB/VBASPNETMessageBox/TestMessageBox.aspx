﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TestMessageBox.aspx.vb" Inherits="VBASPNETMessageBox.TestMessageBox" %>

<%@ Register src="MessageBoxUserControl.ascx" tagname="MessageBoxUserControl" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:MessageBoxUserControl ID="MessageBoxUserControl1" runat="server" />
        <asp:Button ID="btnInvokeMessageBox" runat="server" Text="Display messages" 
            onclick="btnInvokeMessageBox_Click" />
        
        <br />
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    </div>
    </form>
</body>
</html>
