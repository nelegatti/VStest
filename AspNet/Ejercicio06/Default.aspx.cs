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
    
        int x1 = int.Parse(TextBox1.Text);
        int x2 = int.Parse(TextBox2.Text);
        if (DropDownList1.Items[0].Selected)
        {
            int x3 = x1 + x2;
            Label1.Text = "La suma es igual a " + x3.ToString();
        }else if (DropDownList1.Items[1].Selected)
        {
            int x3 = x1 - x2;
            Label1.Text = "La resta es igual a " + x3.ToString();
        }else if (DropDownList1.Items[2].Selected)
        {
            int x3 = x1 * x2;
            Label1.Text = "La Multiplicación es igual a " + x3.ToString();
        }else if (DropDownList1.Items[3].Selected)
        {
            int x3 = x1 / x2;
            Label1.Text = "La división es igual a " + x3.ToString();
        }

    }
}