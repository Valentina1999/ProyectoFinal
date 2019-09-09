using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Servicio.Datos
{
    public class clInsumo
    {
        public int IdInsumo { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public string Descripcion { get; set; }
        public int IdTipoInsumo { get; set; }

        public int mtdRegistraInsumo(clInsumo objClInsumo)
        {
            string consulta = "Insert Into Insumos(Nombre,Foto,Descripcion,IdTipoInsumo)values('" + objClInsumo.Nombre + "' , '" + objClInsumo.Foto + "' , '" + objClInsumo.Descripcion + "' , " + objClInsumo.IdTipoInsumo + ")";
            clConexion clConexion = new clConexion();
            int resultado = clConexion.mtdConectado(consulta);
            return resultado;

        }

        public DataSet mtdlistarInsumo()
        {
            string consulta = "select IdInsumos, Nombre, Descripcion, Tipo from Insumos inner join TipoInsumo on Insumos.IdTipoInsumo = TipoInsumo.IdTipoInsumo";
            DataSet dsInsumo = new DataSet();
            clConexion objConexion = new clConexion();
            dsInsumo = objConexion.mtdDesconectado(consulta);
            return dsInsumo;
        }
    }
}