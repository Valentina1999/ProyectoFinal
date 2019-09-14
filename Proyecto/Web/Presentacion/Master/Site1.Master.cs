using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        int IdUsuario;

        ServicioUsuario.WebService1SoapClient ServicioU = new ServicioUsuario.WebService1SoapClient();
        ServicioUsuario.clUsuario objUsu = new ServicioUsuario.clUsuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            mtdVerificarUsuario();
        }

        protected void mtdVerificarUsuario()
        {
            try
            {
                IdUsuario = int.Parse(Application["IdUsuario"].ToString());
            }
            catch (Exception e)
            {
                IdUsuario = 0;
            }

            if (IdUsuario>0)
            {
                objUsu.IdUsuario = IdUsuario;
                DataSet dsUsuario = new DataSet();
                dsUsuario = ServicioU.mtdBuscar(objUsu);

                Nombre.InnerText = dsUsuario.Tables["tblDatos"].Rows[0]["Nombre"].ToString() + " " + dsUsuario.Tables["tblDatos"].Rows[0]["Apellido"].ToString();
                Nombre1.InnerText = dsUsuario.Tables["tblDatos"].Rows[0]["Nombre"].ToString() + " " + dsUsuario.Tables["tblDatos"].Rows[0]["Apellido"].ToString();
                Rol.InnerText = dsUsuario.Tables["tblDatos"].Rows[0]["Rol"].ToString();

                MenuUsuario.Attributes["style"] = "visibility:visible";
                inS.Attributes["style"] = "visibility:hidden";
                alarm.Attributes["style"] = "visibility:visible";
                terr.Attributes["style"] = "visibility:visible";
                menEta1.Attributes["style"] = "visibility:visible";
                
                menForo1.Attributes["style"] = "visibility:visible";
            }
            else
            {
                inS.Attributes["style"] = "visibility:visible";
                MenuUsuario.Attributes["style"] = "visibility:hidden";
                alarm.Attributes["style"] = "visibility:hidden";
                terr.Attributes["style"] = "visibility:hidden";
                menEta1.Attributes["style"] = "visibility:hidden";
               
                menForo1.Attributes["style"] = "visibility:hidden";
            }
        }
        protected void salir(object sender, EventArgs e)
        {
            Application["IdUsuario"] = 0;
            Response.Redirect("../Index/Index.aspx");
        }
    }
}