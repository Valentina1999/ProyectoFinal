using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Servicio.Datos
{
    public class clTipoInsumo
    {
        public int IdTipoInsumo { get; set; }
        public string Tipo { get; set; }


        public DataSet mtdListarRol()
        {
            string consulta = "select * from TipoInsumo";
            DataSet dsInsumo = new DataSet();
            clConexion objConexion = new clConexion();
            dsInsumo = objConexion.mtdDesconectado(consulta);
            return dsInsumo;
        }
    }
}