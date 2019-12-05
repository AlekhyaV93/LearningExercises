using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormEx1
{
    public partial class fifth : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Visible = chkvisible.Checked;
            /*if(!IsPostBack){

            }
            if (ViewState["lblvalue"] != null)
            {
                for (int i = 0; i <= (int)ViewState["lblvalue"]; i++)
                {
                    Label lbl = new Label();
                    lbl.Text = "Label" + i.ToString();
                    Panel1.Controls.Add(lbl);
                    Panel1.Controls.Add(new LiteralControl("<br />"));

                }
            }

            if (ViewState["txtboxvalues"] !=null)
            {
                for (int i = 0; i <= (int)ViewState["txtboxvalues"]; i++)
                {
                    TextBox tb = new TextBox();
                    tb.Text = "text box" + i.ToString();
                    Panel1.Controls.Add(tb);

                    Panel1.Controls.Add(new LiteralControl("<br />"));
                }
            }*/
           
         
        }

        protected void btnrefresh_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(ddlLabels.SelectedItem.Value);
            ViewState["lblvalue"] = n;
            for (int i = 0; i <= n; i++)
            {
                Label lbl = new Label();
                lbl.Text = "Label" + i.ToString();
                Panel1.Controls.Add(lbl);
                Panel1.Controls.Add(new LiteralControl("<br />"));
            }

            int j = Int32.Parse(ddltxtboxes.SelectedItem.Text);
            ViewState["txtboxvalues"] = j;
            for (int i = 0; i <= j; i++)
            {
                TextBox tb = new TextBox();
                tb.Text = "text box" + i.ToString();
                Panel1.Controls.Add(tb);

                Panel1.Controls.Add(new LiteralControl("<br />"));
            }
        }
    }
}