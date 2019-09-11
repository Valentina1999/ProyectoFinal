using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Presentacion.Master
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        ServicioUsuario.WebService1SoapClient ServicioU = new ServicioUsuario.WebService1SoapClient();
        ServicioUsuario.clUsuario objUsu = new ServicioUsuario.clUsuario();
        int Id;
        protected void Page_Load(object sender, EventArgs e)
        {
            mtdDatos();
            
        }
        protected void mtdDatos()
        {
            Id = int.Parse(Application["IdUsuario"].ToString());
            objUsu.IdUsuario = Id;
            DataSet dsDatos = new DataSet();
            dsDatos = ServicioU.mtdBuscar(objUsu);
            txtDocumento.Value = dsDatos.Tables["tblDatos"].Rows[0]["Documento"].ToString();
            txtNombre.Value = dsDatos.Tables["tblDatos"].Rows[0]["Nombre"].ToString();
            txtApellido.Value = dsDatos.Tables["tblDatos"].Rows[0]["Apellido"].ToString();
            txtCorreo.Value = dsDatos.Tables["tblDatos"].Rows[0]["Correo"].ToString();
            txtClave.Value = dsDatos.Tables["tblDatos"].Rows[0]["Clave"].ToString();
            txtTelefono.Value = dsDatos.Tables["tblDatos"].Rows[0]["Numero"].ToString();
            txtRol.Value = dsDatos.Tables["tblDatos"].Rows[0]["Rol"].ToString();

        }

        protected void btnEditar(object sender, EventArgs e)
        {
            try
            {
                objUsu.Documento = Request.Form[txtDocumento.UniqueID];
                objUsu.Nombre = Request.Form[txtNombre.UniqueID];
                objUsu.Apellido = Request.Form[txtApellido.UniqueID];
                objUsu.Correo = Request.Form[txtCorreo.UniqueID];
                objUsu.Clave = Request.Form[txtClave.UniqueID];
                objUsu.Numero = Request.Form[txtTelefono.UniqueID];
                objUsu.IdUsuario = Id;

                int resultado = ServicioU.mtdEditarUsuarios(objUsu);

                if (resultado == 1)
                {
                    alert.Visible = true;
                    //string script = @"<script type='text/javascript'>
                    //        alert('Se ha editado Exitosamente');
                    //        window.location = 'EditarUsuario.aspx';
                    //    </script>";

                    //ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

                }
                else
                {
                    danger.Visible = true;
                    //string script = @"<script type='text/javascript'>
                    //        alert('Error');
                    //    </script>";

                    //ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                }
            }
            catch (Exception)
            {
                danger.Visible = true;
            }
        }
    }
}