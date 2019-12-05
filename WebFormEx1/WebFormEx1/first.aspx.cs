using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormEx1
{
    public partial class first : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtmessage.Text = " ";
            DropDownList1.Items.Add("july");
            ListItem li = new ListItem() { Text = "august", Value = "8" };//1.this is done through object initializer
            DropDownList1.Items.Add(li);

            //string[] st1 = { "September", "October", "November" };
            //2.if i can add an array of list items to dropdownlist
            ListItem[] li2={new ListItem{Text="December",Value="12"},new ListItem{Text="one more month",Value="13"}};
            DropDownList1.Items.AddRange(li2);
            
            //3.another is populating dropdownlist from database

            //4. how to use collections to populate the dropdownlist
            List<ListItem> li3 = new List<ListItem>();
            li3.Add(new ListItem("september", "9"));
            li3.Add(new ListItem("October", "10"));
            li3.Add(new ListItem("November", "11"));
            DropDownList1.DataValueField = "Value";
            DropDownList1.DataTextField = "Text";
            DropDownList1.DataSource = li3;
            DropDownList1.DataBind();

            

           // txtname.EnableViewState = true;

            //In the design panel of .aspx or by assigning values to <asp:ListItem> in the aspx
            
        }

        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {
            txtmessage.Text = " ";
            lblmessage.Text = "The Selected Node is" + " " + TreeView1.SelectedNode.Text;
            TreeNodeCollection childNodes = TreeView1.SelectedNode.ChildNodes;
            if (childNodes != null)
            {
                txtmessage.Text = " ";
                foreach (TreeNode ch in childNodes)
                {
                    txtmessage.Text += ch.Value;
                }
            }
        }

        /*protected void AdRotator1_AdCreated(object sender, AdCreatedEventArgs e)
        {
            e.NavigateUrl = "http://www.microsoft.com";
        }*/
    }
}