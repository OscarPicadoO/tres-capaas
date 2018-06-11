using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using Datos;

namespace Negocio
{
    public class AccesoLogica
    {
//utiliza el metodo de AccesoDatos para obtenernerlos y asi verlos en la capa de presentaicon mas adelante
        public static DataTable ObtenerEmpleados()
        {
            return AccesoDatos.ObtenerEmpleados();
        }
        //metodo para insertar

        public int Insert(string cedula, string Nombre, string Apellidos, int Edad)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.Insert(cedula, Nombre, Apellidos, Edad);

        }
    }
}
