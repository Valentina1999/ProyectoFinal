using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Servicio.Datos
{
    public class clRol
    {

        public int IdRol { get; set; }
        public string Rol { get; set; }

        
        public DataSet mtdListarRol()
        {
            string consulta = "select * from Rol";
            DataSet dsRol = new DataSet();
            clConexion objConexion = new clConexion();
            dsRol = objConexion.mtdDesconectado(consulta);
            return dsRol;
        }
    }
}