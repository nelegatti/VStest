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

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            int x1 = int.Parse(TextBox1.Text);
            int x2 = int.Parse(TextBox2.Text);
            if (RadioButton1.Checked)
            {
                int x3 = x1 + x2;
                Label1.Text = "El resultado de la Suma es = " + x3.ToString();

            }
            else if (RadioButton2.Checked)
            {
                int x3 = x1 - x2;
                Label1.Text = "El resultado de la Resta es = " + x3.ToString();
            }
            else
            {
                Label1.Text = ("Seleccione una Operación para calcular");
            }
        }catch(Exception ex)
        {
            Label1.Text = ("OCURRIO UN ERROR: " + ex);
        }
    }
}