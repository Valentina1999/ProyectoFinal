using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string txtFech = System.DateTime.Now.ToShortDateString();

            Label1.Text = txtFech;
            string a = Label1.Text;

        }
    }
}