using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace kstarbox
{
    public partial class Account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(User.Identity.IsAuthenticated)
            {
                if(User.IsInRole("admin"))
                {
                    adminlink.Visible = true;
                }
                else
                {
                    adminlink.Visible = false;
                }
            }
        }

        protected void sOut_Click(object sender, EventArgs e)
        {
            HttpContext.Current.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}