<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TVA4.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <strong>Thao Vo - CSE 598 - Assignment 4 - Part 1</strong><br />
        <br />
        Hello, please enter an URL for an XML file, click on submit and it will display the XML file:<br />
    
    </div>
        <asp:TextBox ID="XMLUrlTextBox" runat="server" Width="348px">http://techvologies.com/ASU/Books.xml</asp:TextBox>
        <strong>
        <asp:Button ID="XMLUrlSubmitButton" runat="server" CssClass="auto-style1" OnClick="XMLUrlSubmitButton_Click" Text="Submit" />
        </strong>
        <p>
            <strong>Result:</strong></p>
        <asp:Label ID="XMLResultLabel" runat="server"></asp:Label>
        <p>
            <asp:Label ID="XMLAttributeLabel" runat="server"></asp:Label>
        </p>
    </form>
    <p>
        &nbsp;</p>
    <p>
        <strong>The files are located at:</strong></p>
    <p>
        <a href="http://techvologies.com/ASU/Books.xml">http://techvologies.com/ASU/Books.xml</a></p>
    <p>
        <a href="http://techvologies.com/ASU/Books.xsl">http://techvologies.com/ASU/Books.xsl</a></p>
    <p>
        <a href="http://techvologies.com/ASU/Books.xsd">http://techvologies.com/ASU/Books.xsd</a></p>
    <p>
        &nbsp;</p>
</body>
</html>
