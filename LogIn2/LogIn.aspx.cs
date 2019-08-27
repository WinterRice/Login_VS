using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// Previously commented out the next two "using" lines.
using System.Data.SqlClient;
using System.Configuration;

namespace LogIn2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None; // Gets rid of jquery error
        }

        protected void Button_LogIn_Click(object sender, EventArgs e)
        {
            Response.Write("You have successfully logged in!!!");
        }
    }
}