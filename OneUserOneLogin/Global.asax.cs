using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace OneUserOneLogin
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }

        protected void Application_PreRequestHandlerExecute(object sender, EventArgs e)
        {

            // Let's write a message to show this got fired---
            Response.Write("Session ID:" + Session.SessionID.ToString() + "; User Key:" + (string)Session["user"]);

            // e.g. this is after an initial logon
            if (Session["user"] != null)
            {
                string sKey = (string)Session["user"];

                // Accessing the Cache Item extends the Sliding Expiration automatically
                string sUser = (string)HttpContext.Current.Cache[sKey];
            }
        }
    }
}