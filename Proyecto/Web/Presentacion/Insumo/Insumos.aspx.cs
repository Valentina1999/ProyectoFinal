using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Presentacion.Insumos
{
    public partial class Insumos : System.Web.UI.Page
    {
        ServicioUsuario.WebService1SoapClient S = new ServicioUsuario.WebService1SoapClient();
        ServicioUsuario.clInsumo objIns = new ServicioUsuario.clInsumo();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public void mtdCargar()
        {
            DataSet listar = new DataSet();
            listar = S.mtdListarTipoInsumo();
            ddlTipoInsumo.DataSource = listar.Tables["tblDatos"];
            ddlTipoInsumo.DataTextField = "Tipo";
            ddlTipoInsumo.DataValueField = "IdTipoInsumo";
            ddlTipoInsumo.DataBind();
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            mtdCargar();
        }

        protected void BtnGuardar(object sender, EventArgs e)
        {
            if (FileImage.HasFile)
            {
                //opteniendo la extension

                string ext = System.IO.Path.GetExtension(FileImage.FileName);
                ext = ext.ToLower();
                //optener nombre archivo
                string nom = FileImage.FileName;
                //Configurando el tamaño de Bytes
                //int tam = FileImage.PostedFile.ContentLength;
                //Response.Write(ext + " , " + tam);
                //Guardamos en el servidor
                FileImage.SaveAs(Server.MapPath("~/ImagenesInsumos/" + FileImage.FileName));
            }
            else
            {
                Response.Write("Seleccione una imagen");
            }
            string nom2 = FileImage.FileName;

            objIns.Nombre = Request.Form["txtNombre"];
            objIns.Foto = nom2;
            objIns.Descripcion = Request.Form["txtDescripcion"];
            objIns.IdTipoInsumo = int.Parse(ddlTipoInsumo.SelectedValue);


            int resultado = S.mtdRegistrarInsumo(objIns);

            if (resultado > 0)
            {
                string script = @"<script type='text/javascript'>
                            alert('Se ha editado Exitosamente');
                            window.location = 'Insumos.aspx';
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

            }
            else
            {
                string script = @"<script type='text/javascript'>
                            alert('Error');
                        </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }

        }
    }
}