﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUploadPage.aspx.cs" Inherits="ServeFilesFromBlobStorageWebRole.FileUploadPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    This page will help you to upload some files to your blob storage.
    After the files have been uploaded, the sample will show how to protect your files.

    <br />
    
    <asp:Button ID="btnUpload" runat="server" Text="Click to upload the default resources" onclick="btnUpload_Click" />
    <br />
    <asp:Label ID="lbContent" runat="server" ForeColor="Red" ></asp:Label>
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Go back to Default page.</asp:LinkButton>
        <br />

    </div>
    </form>
</body>
</html>