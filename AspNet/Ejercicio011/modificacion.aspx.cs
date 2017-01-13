using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class modificacion : System.Web.UI.Page
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
            SqlCommand buscar = new SqlCommand("Select nombre,password,mail from usuarios where nombre ='" + TextBoxNameSearch.Text + "'", con);
            SqlDataReader resultData = buscar.ExecuteReader();
            if (resultData.Read())
            {
                TextBoxNameUpdate.Text = resultData["nombre"].ToString();
                TextBoxPassUpdate.Text = resultData["password"].ToString();
                TextBoxEmailUpdate.Text = resultData["mail"].ToString();
                LabelUpdate.Text = "Se encontró una coincidencia";
            }
            else
            {
                LabelUpdate.Text = "No se Encontro ninguna Coincidencia";
                TextBoxNameUpdate.Text = null;
                TextBoxPassUpdate.Text = null;
                TextBoxEmailUpdate.Text = null;
            }
        }
        catch (SqlException es)
        {
            LabelUpdate.Text = "Ocurrio Un error ,CODE ERROR" + es;
        }

    }

    protected void ButtonUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            String s = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaconexion1"].ConnectionString;
            SqlConnection con = new SqlConnection(s);
            con.Open();
            SqlCommand updateUser = new SqlCommand("update usuarios set password = '" +
                TextBoxPassUpdate.Text + "',mail = '" + TextBoxEmailUpdate.Text + "' where nombre ='" + TextBoxNameSearch.Text + "'",con);
            int resultUpdate = updateUser.ExecuteNonQuery();
            if (resultUpdate != 1)
            {
                LabelUpdate.Text = "No se puede actualizar el usuario";
            }
            else
            {
                LabelUpdate.Text = "Usuario Actualizado con Exito";

            }
        }
        catch(SqlException sq)
        {

        }
    }
}