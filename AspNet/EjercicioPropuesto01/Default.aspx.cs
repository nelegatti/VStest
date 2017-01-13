using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            if(TextBox1.Text != "" && TextBox2.Text != "")
            {
                String nameSurname = TextBox1.Text + "," + TextBox2.Text;
                Label1.Text = nameSurname;
            }
        }
        catch (Exception ex)
        {
            Label1.Text = "Ocurrio un Error, " + ex;
        }
    }
}