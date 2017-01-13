using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class baja : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ELIMINAR_Click(object sender, EventArgs e)
    {
        try
        {
            String s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            SqlConnection con = new SqlConnection(s);
            con.Open();
            SqlCommand deleteAction = new SqlCommand("delete from usuarios where nombre = '" + TextBoxBaja.Text + "'", con);
            int cant = deleteAction.ExecuteNonQuery();
            if (cant != 1)
                LabelResultOperation.Text = "No se puede eliminar el usuario";

            else
                LabelResultOperation.Text = "Usuario Eliminado";
        } catch(SqlException sq)
        {
            LabelResultOperation.Text = "Ocurrio un error durante la eliminación , ERROR CODE: " + sq;
        }
    }
}