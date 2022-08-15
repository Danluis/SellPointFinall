using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Entidades
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarEntidades";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void Insertar(String Descripcion,String Direccion,String Localidad,String TipoEntidad,
            String TipoDocumento,int NumeroDocumento,String Telefonos,String URLPaginaWeb,String URLFacebook,
            String URLInstagram,String URLTwitter,String URLTikTok,String CodigoPostal,String CoordenadasGPS,
            double LimiteCredito,String UserNameEntidad,String PassworEntidad, String RolUserEntidad,String Comentario,
            String Status,Boolean NoEliminable)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarEntidades";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Descripcion",Descripcion);
            comando.Parameters.AddWithValue("@Direccion", Direccion);
            comando.Parameters.AddWithValue("@Localidad", Localidad);
            comando.Parameters.AddWithValue("@TipoEntidad", TipoEntidad);
            comando.Parameters.AddWithValue("@TipoDocumento", TipoDocumento);
            comando.Parameters.AddWithValue("@NumeroDocumento", NumeroDocumento);
            comando.Parameters.AddWithValue("@Telefonos", Telefonos);
            comando.Parameters.AddWithValue("@URLPaginaWeb", URLPaginaWeb);
            comando.Parameters.AddWithValue("@URLFacebook", URLFacebook);
            comando.Parameters.AddWithValue("@URLInstagram", URLInstagram);
            comando.Parameters.AddWithValue("@URLTwitter", URLTwitter);
            comando.Parameters.AddWithValue("@URLTikTok", URLTikTok);
            comando.Parameters.AddWithValue("@CodigoPostal", CodigoPostal);
            comando.Parameters.AddWithValue("@CoordenadasGPS", CoordenadasGPS);
            comando.Parameters.AddWithValue("@LimiteCredito", LimiteCredito);
            comando.Parameters.AddWithValue("@UserNameEntidad", UserNameEntidad);
            comando.Parameters.AddWithValue("@PassworEntidad", PassworEntidad);
            comando.Parameters.AddWithValue("@RolUserEntidad", RolUserEntidad);
            comando.Parameters.AddWithValue("@Status", Status);
            comando.Parameters.AddWithValue("@Comentario", Comentario);
            comando.Parameters.AddWithValue("@NoEliminable", NoEliminable);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void Editar(String Descripcion,String Direccion,String Localidad,String TipoEntidad,String TipoDocumento,
            int NumeroDocumento,String Telefonos,String URLPaginaWeb,String URLFacebook,String URLInstagram,
            String URLTwitter,String URLTikTok,String CodigoPostal,String CoordenadasGPS,double LimiteCredito,
            String UserNameEntidad, String PassworEntidad,String RolUserEntidad,String Comentario,String Status,
            Boolean NoEliminable,int IdEntidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarEntidad";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            comando.Parameters.AddWithValue("@Direccion", Direccion);
            comando.Parameters.AddWithValue("@Localidad", Localidad);
            comando.Parameters.AddWithValue("@TipoEntidad", TipoEntidad);
            comando.Parameters.AddWithValue("@TipoDocumento", TipoDocumento);
            comando.Parameters.AddWithValue("@NumeroDocumento", NumeroDocumento);
            comando.Parameters.AddWithValue("@Telefonos", Telefonos);
            comando.Parameters.AddWithValue("@URLPaginaWeb", URLPaginaWeb);
            comando.Parameters.AddWithValue("@URLFacebook", URLFacebook);
            comando.Parameters.AddWithValue("@URLInstagram", URLInstagram);
            comando.Parameters.AddWithValue("@URLTwitter", URLTwitter);
            comando.Parameters.AddWithValue("@URLTikTok", URLTikTok);
            comando.Parameters.AddWithValue("@CodigoPostal", CodigoPostal);
            comando.Parameters.AddWithValue("@CoordenadasGPS", CoordenadasGPS);
            comando.Parameters.AddWithValue("@LimiteCredito", LimiteCredito);
            comando.Parameters.AddWithValue("@UserNameEntidad", UserNameEntidad);
            comando.Parameters.AddWithValue("@PassworEntidad", PassworEntidad);
            comando.Parameters.AddWithValue("@RolUserEntidad", RolUserEntidad);
            comando.Parameters.AddWithValue("@Status", Status);
            comando.Parameters.AddWithValue("@Comentario", Comentario);
            comando.Parameters.AddWithValue("@NoEliminable", NoEliminable);
            comando.Parameters.AddWithValue("@IdEntidad", IdEntidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }
        public void Eliminar (int IdEntidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarEntidad";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idEnt", IdEntidad);
            comando.ExecuteNonQuery ();
            comando.Parameters.Clear();
        }
    }
}
