using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class Configuracion
    {
        //definicion de la cadena conexion
        static string cadenaConexion = @"Data Source=.;Initial Catalog=Empleados;Integrated Security=True";

        //metodo para obtener la cadena 
        public static string CadenaConexion
        {
            get { return cadenaConexion; }
        }
    }
}
