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
            string usu = txtCorreo.Text;
            string cla = txtClave.Text;

            ServicioUsuario.WebService1SoapClient Con = new ServicioUsuario.WebService1SoapClient();

            int resultado = Con.mtdLogin(usu, cla); 
    
               
                if (resultado > 0)
                {
                Application["IdUsuario"] = resultado;
                Response.Redirect("../Suelos/EstudioSuelos.aspx");
                    
                }else{
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "popup", "alert('Correo y/o Contraseña Incorrecta')", true);
                }

            }
          

                
        }
    }
