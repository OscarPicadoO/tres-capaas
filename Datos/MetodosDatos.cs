using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
   public class MetodosDatos
    {
//este metodos servir{a para crea un comando sql estandard como un select y ser{a regresado por un return
       public static SqlCommand CrearComando()
       {
           string _cadenaConexion = Configuracion.CadenaConexion;
           SqlConnection _conexion = new SqlConnection();
           _conexion.ConnectionString = _cadenaConexion;
           SqlCommand _comando = new SqlCommand();
           _comando = _conexion.CreateCommand();
           _comando.CommandType = CommandType.Text;
           return _comando;
       }

       //obtiene como parametro un comando que proviene del metodo anterior CrearComando

       public static int EjecutarComandoInsert(SqlCommand comando)
       {

           try
           {
               comando.Connection.Open();
               return comando.ExecuteNonQuery();
           }
           catch { throw; }
           
           finally 
           {
               comando.Connection.Dispose();
               comando.Connection.Close();
           
           
           }
       
       }

       //este metodo ejecuta un select el cual regresa un datatable
       public static DataTable EjecutarComandoSelect(SqlCommand comando)
       {
           DataTable _tabla = new DataTable();
           try
           {

               comando.Connection.Open();
               SqlDataAdapter adaptador = new SqlDataAdapter();
               adaptador.SelectCommand = comando;
               adaptador.Fill(_tabla);

           }
           catch (Exception ex)
           {
               throw ex;

           }
           finally
           {
               comando.Connection.Close();
           }
           return _tabla;
       }
           

   }
}
