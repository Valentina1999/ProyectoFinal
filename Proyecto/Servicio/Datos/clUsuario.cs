using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Servicio.Datos
{
    public class clUsuario
    {
        public int IdUsuario { get; set; }
        public string Documento { get; set; }
        public string Nombre{ get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string Numero { get; set; }
        public int IdRol { get; set; }


        public int mtdRegistrarUsuario(clUsuario objClUsuario)
        {
            string consulta = "Insert Into Usuario(Documento,Nombre, Apellido, Correo, Clave, Numero, IdRol)values('"+objClUsuario.Documento+"','"+objClUsuario.Nombre+"','"+objClUsuario.Apellido+"','"+objClUsuario.Correo+"','"+objClUsuario.Clave+"','"+objClUsuario.Numero+"',"+objClUsuario.IdRol+")";
            clConexion clConexion = new clConexion();
            int resultado = clConexion.mtdConectado(consulta);
            return resultado;

        }

        public int mtdEditarUsuario(clUsuario objUsu)
        {
            string consulta = "Update Usuario set Documento = '" + objUsu.Documento + "', Nombre = '" + objUsu.Nombre + "', " +
                "Apellido = '" + objUsu.Apellido + "', Correo = '" + objUsu.Correo + "', Clave = '" + objUsu.Clave + "', Numero = '" + objUsu.Numero + "' " +
                "where IdUsuario = '" + objUsu.IdUsuario + "'";
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(consulta);
            return resultado;
        }

        public DataSet mtdBuscar(clUsuario objUsu)
        {
            string consulta = "Select Documento,Nombre, Apellido, Correo, Clave, Numero, Rol From Usuario inner join Rol on Usuario.IdRol = Rol.IdRol " +
                "Where IdUsuario = '"+objUsu.IdUsuario+"'";
            DataSet dsUsuario = new DataSet();
            clConexion objConexion = new clConexion();
            dsUsuario = objConexion.mtdDesconectado(consulta);
            return dsUsuario;
        }
    }
}