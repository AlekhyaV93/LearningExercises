<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fifth.aspx.cs" Inherits="WebFormEx1.fifth" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server">
                This panel shows the dynamic generation of controls
            <br />
                <br />
            </asp:Panel>
            
            <table>
                <tr>
                    <td>Number of Labels:</td>
                    <td>
                        <asp:DropDownList ID="ddlLabels" runat="server">
                            <asp:ListItem>0</asp:ListItem>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                        </asp:DropDownList>
                    </td>

                </tr>
                <tr>
                    <td>Number of textboxes:</td>
                    <td>
                        <asp:DropDownList ID="ddltxtboxes" runat="server">
                            <asp:ListItem>0</asp:ListItem>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                        </asp:DropDownList>
                    </td>

                </tr>
                <tr>
                    <td>
                        <asp:CheckBox ID="chkvisible" runat="server" Text="Make panel visible" AutoPostBack="True" />
                    </td>
                    <td>
                        <asp:Button ID="btnrefresh" runat="server" Text="Refresh Panel" OnClick="btnrefresh_Click" />
                    </td>
                </tr>
            </table>

        </div>
        <asp:Timer ID="Timer1" runat="server">
        </asp:Timer>
    </form>

</body>
</html>
