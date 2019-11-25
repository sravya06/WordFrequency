<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CountWord.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:Panel ID="Panel1" runat="server">
        <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Label ID="Label13" runat="server" Text="Key Word"></asp:Label>
          <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Upload" runat="server" Text="Upload" OnClick="Upload_Click" />
        <br />
          
        <br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
