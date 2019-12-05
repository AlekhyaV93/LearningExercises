<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Third.aspx.cs" Inherits="WebFormEx1.Third" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
        
        <asp:ImageButton ID="ImageButton1" runat="server" Height="27px" ImageUrl="~/Images/img.jpg" OnClick="ImageButton1_Click" Width="33px" />
        
        <br />
        <asp:Calendar ID="Calendar1" runat="server" SelectionMode="DayWeekMonth"  OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
    
        <br />
        <asp:Button ID="btnDate" runat="server" Text="Select Date" OnClick="btnDate_Click" />
    
    </div>
    </form>
</body>
</html>
