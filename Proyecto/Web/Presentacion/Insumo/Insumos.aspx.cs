using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Presentacion.Insumos
{
    public partial class Insumos : System.Web.UI.Page
    {
        ServicioUsuario.WebService1SoapClient S = new ServicioUsuario.WebService1SoapClient();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}