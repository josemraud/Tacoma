// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 11-24-2019
//
// Last Modified By : pepit
// Last Modified On : 11-15-2019
// ***********************************************************************
// <copyright file="CMateriaPrima.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class CMateriaPrima.
    /// </summary>
    class CMateriaPrima
    {
        /// <summary>
        /// Actulizars the inventario.
        /// </summary>
        /// <param name="cod">The cod.</param>
        /// <param name="cant">The cant.</param>
        public void ActulizarInventario(int cod, int cant)
        {
            BaseDeDatos ba = new BaseDeDatos();
            ba.Conectar();
            SqlCommand cmd = new SqlCommand("Actulizar_Inventario", ba.cone);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@cod", cod);
            cmd.Parameters.AddWithValue("@cantidad", cant);

            cmd.ExecuteNonQuery();
            ba.Cerrar();




        }
    }
}
