using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void ButtonCrear_Click1(object sender, EventArgs e)
    {
        try
        {
            HttpCookie c1 = new HttpCookie("edad", TextBoxCookie.Text);
            c1.Expires = new DateTime(2017, 01, 06);
            Response.Cookies.Add(c1);
            LabelResult.Text = "Se creo la cookie";

        }
        catch (ArgumentNullException nl)
        {
            LabelResult.Text = "Ocurrio un error, ERROR CODE" + nl;
        }
    }
}
