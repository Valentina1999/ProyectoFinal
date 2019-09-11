using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Servicio.Datos
{
    public class clInterno
    {
        public int IdInterno { get; set; }
        public int IdEtapa { get; set; }
        public string Fase { get; set; }
        public int Dias { get; set; }
        public bool Check { get; set; }
        public bool ch = true;

        public int mtdCheckear(clInterno objInterno) {
            string consulta = "Update Interno set chec = 'true' where IdInterno = '" + objInterno.IdInterno + "'";
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(consulta);
            return resultado;
        }
        public DataSet mtdListar(clInterno ObjInterno)
        {
            string consulta = "Select * From Interno where IdEtapa="+ObjInterno.IdEtapa+"";
            DataSet dsInterno = new DataSet();
            clConexion objConexion = new clConexion();
            dsInterno = objConexion.mtdDesconectado(consulta);

            return dsInterno;
        }

    }
}