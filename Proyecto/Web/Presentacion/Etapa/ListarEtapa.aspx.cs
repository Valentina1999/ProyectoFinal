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
             
        

        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet dsListar = new DataSet();
           
            dsListar = miServicio.mtdfecha();
             dvListarEtapas.DataSource = dsListar;
            dvListarEtapas.DataBind();

        }
    }
}