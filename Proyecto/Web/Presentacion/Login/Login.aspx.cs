using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Web.Presentacion.Login
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static int Id;
        public static string Nombre;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnEntrar_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SGCPA2ConnectionString1"].ConnectionString)) {

                con.Open();
                SqlCommand cmd = new SqlCommand("Select IdUsuario,Nombre,Correo from Usuario where Correo= '" + txtCorreo.Text+ "' and Clave= '"+txtClave.Text+"' " ,con);
                SqlDataReader dr = cmd.ExecuteReader();
               
                if (dr.HasRows == true)
                {
                    dr.Read();
                    Session["NombreUsuario"] = dr["Nombre"].ToString();
                    Session["id"] = dr["IdUsuario"];
                    Nombre = Session["NombreUsuario"].ToString();
                    Id = int.Parse(Session["id"].ToString());
                    Response.Redirect("../Index/Index.aspx");
                    
                }
                else
                {
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "popup", "alert('Correo y/o Contraseña Incorrecta')", true);
                }

            }
          

                
        }
    }
}