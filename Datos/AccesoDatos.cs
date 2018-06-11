using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class AccesoDatos
    {
//metodo insert
        public int Insert(string Cedula, string Nombre, string Apellido, int Edad)
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.Parameters.AddWithValue("@cedula", Cedula);
            _comando.Parameters.AddWithValue("@nombre", Nombre);
            _comando.Parameters.AddWithValue("@apellidos", Apellido);
            _comando.Parameters.AddWithValue("@edad", Edad);
            return MetodosDatos.EjecutarComandoInsert(_comando);
        }
        public static DataTable ObtenerEmpleados()
        {
            SqlCommand _comando = MetodosDatos.CrearComando();
            _comando.CommandText = "Select *from Datos";
            return MetodosDatos.EjecutarComandoSelect(_comando);
        }

    }
}
