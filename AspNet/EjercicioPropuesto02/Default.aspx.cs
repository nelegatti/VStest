using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Button1_Click(object sender,EventArgs e)
    {
        if (!RadioButton1.Checked)
        {
            Label1.Text = "Error, La respuesta Correcta es: " + RadioButton1.Text;
        }
        if (!RadioButton5.Checked)
        {
            Label1.Text = Label1.Text + "<br>" + "Error, La respuesta Correcta es: " + RadioButton5.Text;
        }
    }
}