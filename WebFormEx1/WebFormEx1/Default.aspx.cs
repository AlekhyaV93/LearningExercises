using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormEx1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(HttpContext.Current.Server.MachineName);
            //Server.HtmlDecode("Alekhya");
            Response.Write(HttpContext.Current.Server.HtmlEncode("Alekhya"));
            Response.Write(HttpContext.Current.Server.UrlEncode(HttpContext.Current.Request.Url.ToString()));
            
            
            
        }

    }
}