// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 12-13-2019
//
// Last Modified By : pepit
// Last Modified On : 12-13-2019
// ***********************************************************************
// <copyright file="CotizacionMetodos.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class CotizacionMetodos.
    /// </summary>
    class CotizacionMetodos
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CotizacionMetodos"/> class.
        /// </summary>
        public CotizacionMetodos()
       {

       }

        /// <summary>
        /// The ba
        /// </summary>
        BaseDeDatos ba = new BaseDeDatos();
        /// <summary>
        /// Añadirs the cotizacion.
        /// </summary>
        /// <param name="fecha">The fecha.</param>
        /// <param name="codigo_cliente">The codigo cliente.</param>
        /// <param name="empleado">The empleado.</param>
        public void AñadirCotizacion(DateTime fecha, string codigo_cliente, int empleado)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("NuevaCotizacion", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@codcot", 1);
            com.Parameters.AddWithValue("@fecha", fecha);
            com.Parameters.AddWithValue("@cliente", codigo_cliente);
            com.Parameters.AddWithValue("@empleado", empleado);
            com.ExecuteNonQuery();
            ba.Cerrar();
        }

        /// <summary>
        /// Añadirs the detalle.
        /// </summary>
        /// <param name="cod">The cod.</param>
        /// <param name="cant">The cant.</param>
        /// <param name="prec">The prec.</param>
        public void AñadirDetalle(int cod, int cant, float prec)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("NuevoCotDetalle", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@codcoti",0);
            com.Parameters.AddWithValue("@prod", cod);
            com.Parameters.AddWithValue("@cant", cant);
            com.Parameters.AddWithValue("@precio", prec);
            com.ExecuteNonQuery();
            ba.Cerrar();
        }

        /// <summary>
        /// Eliminars the cot det.
        /// </summary>
        /// <param name="prod">The product.</param>
        /// <param name="cant">The cant.</param>
        /// <param name="pre">The pre.</param>
        public void EliminarCotDet(int prod, int cant, float pre)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("EliminarCotDet", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@cot", 1);
            com.Parameters.AddWithValue("@producto", prod);
            com.Parameters.AddWithValue("@cantidad", cant);
            com.Parameters.AddWithValue("@precio", pre);
            com.ExecuteNonQuery();
            ba.Cerrar();
        }

        /// <summary>
        /// Eliminars the cot.
        /// </summary>
        public void EliminarCot()
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("EliminarCot", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@cot", 1);
            com.ExecuteNonQuery();
            ba.Cerrar();
        }
        /// <summary>
        /// Validars the cotizacion producto.
        /// </summary>
        /// <param name="codPro">The cod pro.</param>
        public void Validar_CotizacionProducto(int codPro)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("Validar_CotizacionProducto", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@codPro", codPro);
            com.Parameters.AddWithValue("@codCot", 1);
            SqlParameter cod = new SqlParameter("@cod", DbType.Int32);
            cod.Direction = ParameterDirection.Output;
            com.Parameters.Add(cod);
            com.ExecuteScalar();
            ba.Cerrar();
            int codigo = Convert.ToInt32(com.Parameters["@cod"].Value);
            CompartirDatos.codVCP = codigo;
        }
    }
}
