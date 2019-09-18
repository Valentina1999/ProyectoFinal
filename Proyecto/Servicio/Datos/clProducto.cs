using System;
using System.Collections.Generic;
using System.Data;
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

        public int mtdEditarProducto(clProducto objPro)
        {
            string consulta = "update Producto set Estado = 'Agotado' where IdProducto='" + objPro.IdProducto + "'";
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(consulta);
            return resultado;
        }

        public DataSet mtdListarProductos()
        {
            string consulta = "select Nombre, Apellido, Numero, NombreP, Cantidad, Foto from Producto inner join Usuario on Producto.IdUsuario = Usuario.IdUsuario where Producto.Estado='Disponible'";
            clConexion objConexion = new clConexion();
            DataSet dsProductos = new DataSet();
            dsProductos = objConexion.mtdDesconectado(consulta);
            return dsProductos;
        }

        public DataSet mtdListarProductosUsuarios(clProducto objProducto)
        {
            string consulta = "select IdProducto, Nombre, Apellido, Numero, NombreP, Cantidad, Foto from Producto inner join Usuario on Producto.IdUsuario = Usuario.IdUsuario where Producto.IdUsuario='" + objProducto.IdUsuario + "' and Producto.Estado = 'Disponible'";
            clConexion objConexion = new clConexion();
            DataSet dsProductos = new DataSet();
            dsProductos = objConexion.mtdDesconectado(consulta);
            return dsProductos;
        }
    }
}