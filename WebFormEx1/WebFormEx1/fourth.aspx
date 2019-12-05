<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fourth.aspx.cs" Inherits="WebFormEx1.fourth" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <asp:Button ID="btnUpload" Text="Upload" OnClick="btnUpload_Click" runat="server" />
        <br />
        <br />
        <asp:Label ID="lblStatus" Text="" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
