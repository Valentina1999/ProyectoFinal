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
        public string Foto { get; set; }
        public string Estado { get; set; }
        public int IdUsuario { get; set; }

        public int mtdRegistrarProducto(clProducto objClProducto)
        {
            string consulta = "Insert Into Producto (Nombrep, Cantidad, Foto, Estado, IdUsuario)values('" + objClProducto.NombreP + "','" + objClProducto.Cantidad + "','"+ objClProducto.Foto + "','"+objClProducto.Estado+"',"+objClProducto.IdUsuario+")";
            clConexion clConexion = new clConexion();
            int resultado = clConexion.mtdConectado(consulta);
            return resultado;

        }
    }
}