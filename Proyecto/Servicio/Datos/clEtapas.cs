using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Servicio.Datos
{
    public class clEtapas
    {

        public int IdEtapa { get; set; }
        public int Etapa { get; set; }
        public int IdCultivo { get; set; }



        public DataSet mtdListar()
        {
            string consulta = "Select * From Etapa";
            DataSet dsEtapa = new DataSet();
            clConexion objConexion = new clConexion();
            dsEtapa = objConexion.mtdDesconectado(consulta);

            return dsEtapa;
        }

    }
}