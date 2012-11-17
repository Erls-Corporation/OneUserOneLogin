using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OneUserOneLogin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            //validate your user here (Forms Auth or Database, for example)
            // this could be a new "illegal" logon, so we need to check
            // if these credentials are already in the Cache 
            string sKey = TextBoxUserName.Text;
            string sUser = (string)HttpContext.Current.Cache[sKey];

            if (sUser == null || sUser == string.Empty)
            {
                // No Cache item, so sesion is either expired or user is new sign-on
                // Set the cache item and Session hit-test for this user---

                TimeSpan SessionTimeout = new TimeSpan(0, 0, HttpContext.Current.Session.Timeout, 0, 0);

                HttpContext.Current.Cache.Insert(sKey, sKey, null, DateTime.MaxValue, SessionTimeout, System.Web.Caching.CacheItemPriority.NotRemovable, null);

                Session["user"] = sKey;

                // Let them in - redirect to main page, etc.
                LabelWelcome.Text = "<h1>Welcome!</h1>";
            }
            else
            {
                // cache item exists, so too bad...
                LabelWelcome.Text = "<h1><font color=red>ILLEGAL LOGIN ATTEMPT!!!</font></h1>";
                return;
            }
        }
    }
}