using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Presentacion.Fases
{
    public partial class ListaFases : System.Web.UI.Page
    {
        ServicioUsuario.WebService1SoapClient servicioU = new ServicioUsuario.WebService1SoapClient();
        Servicio.Datos.clFases objFases = new Servicio.Datos.clFases();
        public string nombre;

        protected void Page_Load(object sender, EventArgs e)
        {
            listar();
        }
        
        protected void listar()
        {
            //DirectoryInfo di = new DirectoryInfo("C:\\Users\\Valentina\\source\\repos\\ProyectoFinal0\\Proyecto\\Web\\images\\FENOLOGIA");
            //var ficheros = di.GetFiles();

            DataSet dsListar = new DataSet();
            dsListar = servicioU.mtdListarFases();
            repeater.DataSource = dsListar;
            repeater.DataBind();

            //foreach (FileInfo fi in ficheros)
            //{
            //    Response.Write(string.Format("<img src='../../images/FENOLOGIA/{0}' alt='Ver{0}' height='100' width='100'/>", fi.Name));
            //}





        }

    }
}