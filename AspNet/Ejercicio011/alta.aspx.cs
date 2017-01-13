using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class alta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
          //string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            SqlConnection con = new SqlConnection(s);
            con.Open();
            SqlCommand comando = new SqlCommand("insert into usuarios(nombre,password,mail) values ('" + TextBoxName.Text + "','" + TextBoxPassword.Text + "','" + TextBoxEmail.Text + "')", con);
            comando.ExecuteNonQuery();

            con.Close();
            LabelResult.Text = "Datos Guardados con Exito";
        }catch(SqlException sql)
        {
            if (sql.ErrorCode.Equals(-2146232060))
                LabelResult.Text = "YA EXISTE UN USUARIO CON ESE NOMBRE";
            else
                LabelResult.Text = "OCURRIO UN ERROR, CODE: " + sql;
        }

    }
}