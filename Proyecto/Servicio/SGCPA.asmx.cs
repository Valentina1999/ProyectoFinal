using Servicio.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Servicio
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod]
        public DataSet mtdListarRol()
        {
            DataSet dsRol = new DataSet();
            clRol objRol = new clRol();
            dsRol = objRol.mtdListarRol();
            return dsRol;
        }

        [WebMethod]
        public int mtdRegistrarUsuario(clUsuario objUsu)
        {
            clUsuario objClUsuario = new clUsuario();
            int resul = objClUsuario.mtdRegistrarUsuario(objUsu);
            return resul;
        }


        [WebMethod]
        public int mtdEditarUsuarios(clUsuario objUsu)
        {
            clUsuario objUsuarios = new clUsuario();
            int result = objUsuarios.mtdEditarUsuario(objUsuarios);
            return result;
        }
    }
}
