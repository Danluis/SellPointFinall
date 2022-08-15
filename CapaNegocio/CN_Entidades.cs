using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Entidades
    {
        private CD_Entidades ObjetoCD = new CD_Entidades();

        public DataTable MostrarEnt()
        {
            DataTable tabla = new DataTable();
            tabla = ObjetoCD.Mostrar();
            return tabla;
        }
        public void InsertarEnt(String Descripcion,String Direccion,String Localidad,String TipoEntidad,String TipoDocumento,String NumeroDocumento,String Telefonos,String URLPaginaWeb,String URLFacebook,String URLInstagram,String URLTwitter,String URLTikTok,String CodigoPostal,String CoordenadasGPS,String LimiteCredito,String UserNameEntidad,String PasswordEntidad,String RollUserEntidad,String Comentario,String Status,String NoEliminable){
            ObjetoCD.Insertar(Descripcion,Direccion,Localidad,TipoEntidad,TipoDocumento,Convert.ToInt32(NumeroDocumento),Telefonos,URLPaginaWeb,URLFacebook,URLInstagram,URLTwitter,URLTikTok,CodigoPostal,CoordenadasGPS,Convert.ToDouble(LimiteCredito),UserNameEntidad,PasswordEntidad,RollUserEntidad,Comentario,Status,Convert.ToBoolean(NoEliminable));
            
    }

        public void EditarEnt(String Descripcion,String Direccion,String Localidad,
            String TipoEntidad,String TipoDocumento,String NumeroDocumento,String Telefonos,
            String URLPaginaWeb,String URLFacebook,String URLInstagram,String URLTwitter,String URLTikTok,
            String CodigoPostal,String CoordenadasGPS, String LimiteCredito, String UserNameEntidad
            ,String PasswordEntidad,String RollUserEntidad,String Comentario,String Status, 
            String NoEliminable,String IdEntidad)
        {
            ObjetoCD.Editar(Descripcion,Direccion,Localidad,TipoEntidad,
                TipoDocumento,Convert.ToInt32(NumeroDocumento),Telefonos,URLPaginaWeb,
                URLFacebook,URLInstagram,URLTwitter,URLTikTok,CodigoPostal,CoordenadasGPS,
                Convert.ToDouble(LimiteCredito),UserNameEntidad,PasswordEntidad,RollUserEntidad,
                Comentario,Status,Convert.ToBoolean(NoEliminable),Convert.ToInt32(IdEntidad));

        }
        public void EliminarEnt(String IdEntidad)
        {
            ObjetoCD.Eliminar(Convert.ToInt32(IdEntidad));
        }
    }
}
