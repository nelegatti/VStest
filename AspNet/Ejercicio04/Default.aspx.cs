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

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "";
        try
        {
            if (CheckBox1.Checked)
            {
                int x3 = int.Parse(TextBox1.Text) + int.Parse(TextBox2.Text);
                Label1.Text = x3.ToString();

            }
            if (CheckBox2.Checked)
            {
                int x3 = int.Parse(TextBox1.Text) - int.Parse(TextBox2.Text);
                Label1.Text = Label1.Text + "<br>"+ x3.ToString()  ;
            }
        }catch(Exception ex)
        {
            Label1.Text = "Ocurrio un Error: " + ex.ToString();
        }
    }
}