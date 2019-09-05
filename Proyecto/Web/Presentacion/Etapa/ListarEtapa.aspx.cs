using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Presentacion.Master
{
    public partial class Formulario_web13 : System.Web.UI.Page
    {
        ServicioUsuario.WebService1SoapClient miServicio = new ServicioUsuario.WebService1SoapClient();
            Servicio.Datos.clEtapas objClEtapas = new Servicio.Datos.clEtapas();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet dsListar = new DataSet();
            dsListar = miServicio.mtdListarEtapas();
            Reapeter1.DataSource = dsListar;
            //int a = int.Parse(Request.Form["IdEtapa"]);
            //int x = a;
            Reapeter1.DataBind();
           
            
        }
        protected void mostrar(object sender, EventArgs e)
        {

            
         
        }

        protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}