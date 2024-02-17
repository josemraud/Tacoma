// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 11-24-2019
//
// Last Modified By : pepit
// Last Modified On : 12-13-2019
// ***********************************************************************
// <copyright file="BaseDeDatos.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class BaseDeDatos.
    /// </summary>
    public class BaseDeDatos
    {
        /// <summary>
        /// The cone
        /// </summary>
        public SqlConnection cone = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|Data\\TacomaDB.mdf; Integrated Security = true;User Instance = true");

        /// <summary>
        /// Conectars this instance.
        /// </summary>
        public void Conectar()
        {

            try
            {
                cone.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desconectado: " + ex.ToString());
            }
        }
        /// <summary>
        /// Cerrars this instance.
        /// </summary>
        public void Cerrar()
        {
            cone.Close();
        }
    }
}
