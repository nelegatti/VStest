using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["edad"] != null)
        {
            LabelCkResult.Text = "La cookie es:"+Request.Cookies["edad"].Value;
        }else
        {
            LabelCkResult.Text = " No existe la cookie edad";
        }
    }
}