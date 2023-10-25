using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Libreria para conectarme a base de datos...
using System.Data.SqlClient; //Libreria para manipular datos en SQLServer.

namespace ejercicios
{
    class Conexion
    {
        SqlConnection miConexion = new SqlConnection(); //Conectarme a  la BD
        SqlCommand miComando = new SqlCommand(); //ejecutar consultas SQL en la base de datos.
        SqlDataAdapter miAdaptador = new SqlDataAdapter(); //Sirve como un intermediario entre la BD y la aplicacion.
        DataSet miDs = new DataSet(); //Es una representacion grafica de la BD en memoria.

        public Conexion()
        {
            String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academico.mdf;Integrated Security=True";
            miConexion.ConnectionString = cadenaConexion;
            miConexion.Open();
            parametrizacion();
        }
        public DataSet obtenerDatos()
        {
            miDs.Clear();
            miComando.Connection = miConexion;

            miComando.CommandText = "select * from materias";
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(miDs, "materias");

            miComando.CommandText = "select * from alumnos";
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(miDs, "alumnos");

            return miDs;
        }
        private void parametrizacion()
        {
            miComando.Parameters.Add("@id", SqlDbType.Int).Value = 0;
            miComando.Parameters.Add("@cod", SqlDbType.Char).Value = "";
            miComando.Parameters.Add("@nom", SqlDbType.Char).Value = "";
            //uv = Unidades Valorativas de la tabla materias
            miComando.Parameters.Add("@uv", SqlDbType.Int).Value = 0;
        }
        public String mtoMaterias(String[] materia)
        {
            String sql = "";
            if (materia[0] == "nuevo") {
                sql = "INSERT INTO materias (codigo, materia, uv) VALUES(@cod, @nom, @uv)";
            }else if(materia[0] == "modificar"){
                sql = "UPDATE materias SET codigo=@cod, materia=@nom, uv=@uv WHERE idMateria=@id";
            }else if(materia[0] == "eliminar"){
                sql = "DELETE FROM materias WHERE idMateria=@id)";
            }
            miComando.Parameters["@cod"].Value = materia[1];
            miComando.Parameters["@nom"].Value = materia[2];
            miComando.Parameters["@uv"].Value = materia[3];
            miComando.Parameters["@id"].Value = materia[4];
            return ejecutarSql(sql);
        }
        private String ejecutarSql(String sql)
        {
            try {
                miComando.Connection = miConexion;
                miComando.CommandText = sql;
                return miComando.ExecuteNonQuery().ToString();
            }catch(Exception e){
                return e.Message;
            }
        }
    }
}
