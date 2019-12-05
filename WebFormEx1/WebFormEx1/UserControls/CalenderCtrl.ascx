<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CalenderCtrl.ascx.cs" Inherits="WebFormEx1.CalenderCtrl" %>
<asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
        
        <asp:ImageButton ID="ImageButton1" runat="server" Height="27px" ImageUrl="~/Images/img.jpg" OnClick="ImageButton1_Click" Width="33px" />
        
        <br />
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>