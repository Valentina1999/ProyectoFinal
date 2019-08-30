using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servicio.Datos
{
    public class clProducto
    {
        public int IdProducto { get; set; }
        public string NombreP { get; set; }
        public int Cantidad { get; set; }
        public int IdEtapa { get; set; }

        public int mtdRegistrarProducto(clProducto objClProducto)
        {
            string consulta = "Insert Into Porducto(Nombrep, Cantidad, IdEtapa)values('" + objClProducto.NombreP + "','" + objClProducto.Cantidad + "',"+ objClProducto.IdEtapa +")";
            clConexion clConexion = new clConexion();
            int resultado = clConexion.mtdConectado(consulta);
            return resultado;

        }
    }
}