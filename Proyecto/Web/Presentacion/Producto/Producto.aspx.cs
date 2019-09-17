using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Presentacion.Producto
{
    public partial class Producto : System.Web.UI.Page
    {
        ServicioUsuario.WebService1SoapClient Produc = new ServicioUsuario.WebService1SoapClient();
        ServicioUsuario.clProducto objProducto = new ServicioUsuario.clProducto();


        int Id;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_ServerClick(object sender, EventArgs e)
        {
            Id = int.Parse(Application["IdUsuario"].ToString());

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
                FileImage.SaveAs(Server.MapPath("~/ImagenesProductos/" + FileImage.FileName));
                string nom2 = FileImage.FileName;

                objProducto.NombreP = txtNombre.Text;
                objProducto.Foto = nom2;
                objProducto.Estado = "Disponible";
                
                objProducto.Cantidad = int.Parse(Request.Form[txtC.UniqueID].ToString());
                objProducto.IdUsuario = Id;

                

                int resultado = Produc.mtdRegistrarProducto(objProducto);

                if (resultado > 0)
                {
                    string script = @"<script type='text/javascript'>
                                    alert('Se ha guardado Exitosamente');
                                    window.location = 'Producto.aspx';
                                </script>";

                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);

                }
            }
        
            else
            {
                Response.Write("Seleccione una imagen");

                string script = @"<script type='text/javascript'>
                                    alert('Error No se pudo Registrar llene todos los campos');
                                </script>";

                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
            }
        }

        }  
    }
