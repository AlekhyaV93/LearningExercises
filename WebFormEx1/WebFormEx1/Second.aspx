

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Second.aspx.cs" Inherits="WebFormEx1.Second"   %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .style1
        {
            width:150px;
        }

        .style2
        {
            width:300px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table id="table1" style="width:54%;">
        <tr>
            <td class="style1">
                Name:
            </td>
            <td class="style2">
               <asp:TextBox ID="txtName" Text=" " runat="server" AccessKey="2" ></asp:TextBox>
                
                                                                                         
            </td>
        </tr>
        <tr>
            <td class="style1">
                ID:
            </td>
            <td class="style2">
                <asp:TextBox ID="txtID" Text=" " runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">
                email:
            </td>
            <td class="style2">
               <asp:TextBox ID="txtemail" Text=" " runat="server"></asp:TextBox>
            </td>
        </tr>
        
         <tr>
            <td class="style1">
               Joining Date:
            </td>
            <td class="style2">
              <uc1:CalenderCtrl ID ="CalenderCtrl1" runat="server"></uc1:CalenderCtrl>                          
                <br />
                <br />
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="style1"></td>
            <td class="style2"></td>
        </tr>
        <tr>
            <td class="style1"></td>
           <td class="style2" runat="server" id="displayRow">
              <!-- <asp:Label ID="lblResult" Text=" " runat="server"></asp:Label>-->
           </td>
        </tr>
    </table>
        <asp:Button  ID="btnClick" Text="Click" runat="server" OnClick="btnClick_Click"/>
        
        
        <br />
        <br />
        
    </div>
    </form>
</body>
</html>
