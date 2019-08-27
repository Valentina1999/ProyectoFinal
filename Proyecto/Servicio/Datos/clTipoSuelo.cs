using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Servicio.Datos
{
    public class clTipoSuelo
    {
        public int idtipoSuelo { get; set; }
        public string TipoSuelo { get; set; }


        public DataSet mtdListarSuelo()
        {
            string consulta = "select * from TipoSuelo";
            DataSet dsSuelo = new DataSet();
            clConexion objConexion = new clConexion();
            dsSuelo = objConexion.mtdDesconectado(consulta);
            return dsSuelo;
        }
    }
}