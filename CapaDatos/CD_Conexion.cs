﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Conexion
    {
        private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-2V27RAM;DataBase=SellPointFinal;Integrated security=true");

        public SqlConnection AbrirConexion()
        {        
            if (Conexion.State ==ConnectionState.Closed)
            Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
            Conexion.Close();
            return Conexion;
        }
    }
}
