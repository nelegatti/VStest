using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack == false)
        {
            if (Request.Cookies["mail"] != null)
            {
                TextBoxMail.Text = Request.Cookies["mail"].Value;
            }
        }
    }

    protected void ButtonAddMail_Click(object sender, EventArgs e)
    {
        try {
            HttpCookie cookie1 = new HttpCookie("mail", TextBoxMail.Text);
            cookie1.Expires = new DateTime(2017, 01, 08);
            Response.Cookies.Add(cookie1);
            Response.Redirect("Default4.aspx");
        } catch (Exception exc) {
            TextBoxMail.Text = exc.ToString();

        }
    }

}