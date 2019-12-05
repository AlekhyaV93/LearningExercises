<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="first.aspx.cs" Inherits="WebFormEx1.first" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:TreeView ID="TreeView1" runat="server" ImageSet="Arrows" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged">
            <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
            <Nodes>
                <asp:TreeNode Text="Science Club" Value="Science Club">
                    <asp:TreeNode Text="Picture Gallery" Value="Picture Gallery"></asp:TreeNode>
                    <asp:TreeNode Text="Home" Value="Home">
                        <asp:TreeNode Text="History" Value="History"></asp:TreeNode>
                        <asp:TreeNode Text="About Us" Value="About Us"></asp:TreeNode>
                        <asp:TreeNode Text="Contact Us" Value="Contact Us"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="Products" Value="Products"></asp:TreeNode>
                    <asp:TreeNode Text="Research" Value="Research"></asp:TreeNode>
                    <asp:TreeNode Text="Board Members" Value="Board Members">
                        <asp:TreeNode Text="Sandeep" Value="Sandeep"></asp:TreeNode>
                        <asp:TreeNode Text="Alekhya" Value="Alekhya"></asp:TreeNode>
                    </asp:TreeNode>
                </asp:TreeNode>
            </Nodes>
            <NodeStyle Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
            <ParentNodeStyle Font-Bold="False" />
            <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />


        </asp:TreeView>
       
        <asp:Label ID="lblmessage" runat="server" Text=" " ></asp:Label><br />
        <asp:TextBox ID="txtmessage" runat="server" Text=" "></asp:TextBox>
        <input type="text" id="text1" runat="server" value="Abcdefghi" />
        <table id="table1" runat="server">
            <tr>
                <th>
                    Name
                </th>
                <th>
                    Employee ID
                </th>
                <th>
                    Department
                </th>
            </tr>
            <tr>
                <td>
                    Alekhya
                </td>
                <td>
                    316660
                </td>
                <td>
                    Manufacturing and Hi-Tech
                </td>
            </tr>
            <tr>
                <td>
                    Sandeep
                </td>
                <td>
                    345892
                </td>
                <td>
                    Banking and Finance
                </td>
            </tr>

        </table>

        <br />
        <asp:AdRotator ID="AdRotator1" runat="server"  Target="_newwindow" AdvertisementFile="~/Ads.xml" />
        <asp:DropDownList ID="DropDownList1" runat="server" >
            <asp:ListItem Enabled="true" Text="Select Month" Value="-1"></asp:ListItem>
            <asp:ListItem Text="January" Value="1"></asp:ListItem>
            <asp:ListItem Text="February" Value="2"></asp:ListItem>
            <asp:ListItem Text="March" Value="3"></asp:ListItem>
            <asp:ListItem Text="April" Value="4"></asp:ListItem>
            <asp:ListItem Value="5">may</asp:ListItem>
        </asp:DropDownList>
        <<asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem Enabled="false" Text="Select Year" Value="-1"></asp:ListItem>
            <asp:ListItem Text="1990" Value="1"></asp:ListItem>
            <asp:ListItem Text="1991" Value="2"></asp:ListItem>         
            <asp:ListItem Text="1992" Value="3"></asp:ListItem>
         </asp:CheckBoxList>
        <asp:ListBox ID="ListBox1" runat="server">
            <asp:ListItem Enabled="false" Text="Select Date" Value="-1"></asp:ListItem>
            <asp:ListItem Text="1" Value="1"></asp:ListItem>        
            <asp:ListItem Text="3" Value="2"></asp:ListItem>
            <asp:ListItem Text="5" Value="3"></asp:ListItem>
            <asp:ListItem Text="7" Value="4"></asp:ListItem>        
            <asp:ListItem Text="9" Value="5"></asp:ListItem>
            <asp:ListItem Text="11" Value="6"></asp:ListItem>
        </asp:ListBox>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Enabled="false" Text="Select Gender" Value="-1"></asp:ListItem>
            <asp:ListItem Text="Male" Value="1"></asp:ListItem>
            <asp:ListItem Text="Female" Value="2"></asp:ListItem>
         </asp:RadioButtonList>
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Second.aspx">HyperLink</asp:HyperLink>
        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        <br />
        <br />
    </form>
</body>
</html>
