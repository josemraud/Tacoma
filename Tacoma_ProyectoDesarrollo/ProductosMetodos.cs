// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 11-24-2019
//
// Last Modified By : pepit
// Last Modified On : 12-10-2019
// ***********************************************************************
// <copyright file="ProductosMetodos.cs" company="">
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
    /// Class ProductosMetodos.
    /// </summary>
    class ProductosMetodos
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductosMetodos"/> class.
        /// </summary>
        public ProductosMetodos()
        {

        }
        /// <summary>
        /// The ba
        /// </summary>
        BaseDeDatos ba = new BaseDeDatos();
        /// <summary>
        /// Añadirs the producto.
        /// </summary>
        /// <param name="desc">The desc.</param>
        /// <param name="preuni">The preuni.</param>
        /// <param name="subcat">The subcat.</param>
        /// <param name="estado">The estado.</param>
        public void AñadirProducto(string desc, decimal preuni, int subcat,
            int estado)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("Añadir_Productos", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@descripcion", desc);
            com.Parameters.AddWithValue("@preciouni", preuni);
            com.Parameters.AddWithValue("@subcategoria_id", subcat);
            com.Parameters.AddWithValue("@estado_Cod", estado);
            com.ExecuteNonQuery();
            ba.Cerrar();
        }
        /// <summary>
        /// Actualizars the producto.
        /// </summary>
        /// <param name="codProd">The cod product.</param>
        /// <param name="desc">The desc.</param>
        /// <param name="preuni">The preuni.</param>
        /// <param name="subcat">The subcat.</param>
        /// <param name="estado">The estado.</param>
        public void ActualizarProducto(int codProd,string desc, decimal preuni, int subcat,
            int estado)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("Actualizar_Producto", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@codProd", codProd);
            com.Parameters.AddWithValue("@descripcion", desc);
            com.Parameters.AddWithValue("@preciouni", preuni);
            
            com.Parameters.AddWithValue("@subcategoria_id", subcat);
            com.Parameters.AddWithValue("@estado_Cod", estado);
            com.ExecuteNonQuery();
            ba.Cerrar();
        }

        /// <summary>
        /// Validars the producto.
        /// </summary>
        /// <param name="correo">The correo.</param>
        public void ValidarProducto(string correo)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("ValidarProducto", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@pro", correo);

            SqlParameter cod = new SqlParameter("@cod", DbType.Int32);
            cod.Direction = ParameterDirection.Output;
            com.Parameters.Add(cod);

            com.ExecuteScalar();

            ba.Cerrar();

            int codigo = Convert.ToInt32(com.Parameters["@cod"].Value);
            CompartirDatos.codPro = codigo;
        }

        public void ProductoModificar(string nom)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("ProductoV", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@nom", nom);

            SqlParameter cod = new SqlParameter("@sum", DbType.Int32);
            cod.Direction = ParameterDirection.Output;
            com.Parameters.Add(cod);

            com.ExecuteScalar();

            ba.Cerrar();

            int suma = Convert.ToInt32(com.Parameters["@sum"].Value);
            CompartirDatos.sumPro = suma;
        }
}
}
