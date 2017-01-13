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
        try
        {
            int x1 = int.Parse(TextBox1.Text);
            int x2 = int.Parse(TextBox2.Text);
            if(ListBox1.Items[0].Selected)
            {
                int x3 = x1 + x2;
                Label1.Text = "El resultado de la suma es: " + x3.ToString()+"<br>";
            }
            if (ListBox1.Items[1].Selected)
            {
                int x3 = x1 - x2;
                Label1.Text = Label1.Text + "El resultado de la resta es: " + x3.ToString() + "<br>";
            }
            if (ListBox1.Items[2].Selected)
            {
                int x3 = x1 * x2;
                Label1.Text = Label1.Text + "El resultado de la Multiplicación es : " + x3.ToString() + "<br>";
            }
            if (ListBox1.Items[3].Selected)
            {
                int x3 = x1 / x2;
                Label1.Text = Label1.Text + "El resultado de la división es: " + x3.ToString() + "<br>";
            }
        }catch(Exception ex)
        {
            Label1.Text = Label1.Text + "OCURRIO UN ERROR" + ex + "<br>";
        }
    }
}