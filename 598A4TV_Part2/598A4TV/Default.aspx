<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_598A4TV.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Thao Vo - CSE 598 - Assignment 4 - Part 2</div>
        <p>
            <strong>1. Get Verification</strong></p>
        <p>
            <strong>XML Url:</strong>
            <asp:TextBox ID="xmlUrlTextBox2" runat="server" Width="244px">http://techvologies.com/ASU/Books.xml</asp:TextBox>
        </p>
        <p>
            <strong>XSD Url: </strong>
            <asp:TextBox ID="XSDTextBox" runat="server" Width="256px">http://techvologies.com/ASU/Books.xsd</asp:TextBox>
        </p>
        <p>
            <asp:Button ID="GetVerificationButton" runat="server" OnClick="GetVerificationButton_Click" Text="Get Verification" />
        </p>
        <p>
            <strong>Result:</strong></p>
        <p>
            <asp:Label ID="VerificationResultLabel" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <strong>2. Get XPath Search</strong></p>
        <p>
            <strong>XML Url:</strong>
            <asp:TextBox ID="XmlTextBox3" runat="server" Width="255px">http://techvologies.com/ASU/Books.xml</asp:TextBox>
        </p>
        <p>
            <strong>Path:</strong>
            <asp:TextBox ID="XPathTextBox" runat="server" Width="255px">.</asp:TextBox>
        </p>
        <p>
            <asp:Button ID="GetXPathButton" runat="server" OnClick="GetXPathButton_Click" Text="Get XPath" />
        </p>
        <p>
            <strong>Result:</strong></p>
        <asp:Label ID="XPathResultLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
