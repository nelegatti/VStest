using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (File.Exists(Server.MapPath(".") + "/contador.txt"))
        {
            StreamReader arch = new StreamReader(Server.MapPath(".") + "/contador.txt");
            string valor = arch.ReadToEnd();
            int contador = int.Parse(valor);
            contador = contador + 1;//FIXME contador++
            arch.Close();
            StreamWriter arch1 = new StreamWriter(Server.MapPath(".") + "/contador.txt");
            arch1.WriteLine(contador.ToString());
            arch1.Close();
            Label1.Text = contador.ToString();

        }
        else
        {
            StreamWriter arch = new StreamWriter(Server.MapPath(".") + "/contador.txt");
            arch.WriteLine("1");
            arch.Close();
            Label1.Text = "1";

        }
    }
}