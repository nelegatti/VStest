using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class consulta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonSearch_Click(object sender, EventArgs e)
    {
        try
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            SqlConnection con = new SqlConnection(s);
            con.Open();
            SqlCommand comando = new SqlCommand("select nombre,mail from usuarios where nombre ='" + TextBoxNombre.Text + "'", con);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                LabelResult.Text = "El nombre del Usuario es :" + registro["nombre"]+"<br/>"+" El Mail del usuario es:" + registro["mail"];
            }else
            {
                LabelResult.Text = " No hay un usuario con ese nombre";
            }
            con.Close();
        }catch(SqlException sq)
        {
            LabelResult.Text = "Ocurrio un error, code:" + sq.ToString();
        }
    }
}