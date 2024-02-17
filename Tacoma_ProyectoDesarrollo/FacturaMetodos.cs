// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 12-13-2019
//
// Last Modified By : pepit
// Last Modified On : 12-13-2019
// ***********************************************************************
// <copyright file="FacturaMetodos.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class FacturaMetodos.
    /// </summary>
    class FacturaMetodos
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FacturaMetodos"/> class.
        /// </summary>
        public FacturaMetodos()
        {

        }
        /// <summary>
        /// The ba
        /// </summary>
        BaseDeDatos ba = new BaseDeDatos();
        /// <summary>
        /// Añadirs the factura.
        /// </summary>
        /// <param name="fecha">The fecha.</param>
        /// <param name="codigo_cliente">The codigo cliente.</param>
        /// <param name="isv">The isv.</param>
        /// <param name="empleado">The empleado.</param>
        /// <param name="tipo">The tipo.</param>
        public void AñadirFactura(DateTime fecha, string codigo_cliente, float isv, String empleado, int tipo)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("AñadirFactura", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@codFactura", 1);
            com.Parameters.AddWithValue("@fecha", fecha);
            com.Parameters.AddWithValue("@codigo", codigo_cliente);
            com.Parameters.AddWithValue("@imp", isv);
            com.Parameters.AddWithValue("@emp", empleado);
            com.Parameters.AddWithValue("@pago", tipo);
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
            SqlCommand com = new SqlCommand("AñadirDetalle", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@factura", 1);
            com.Parameters.AddWithValue("@producto", cod);
            com.Parameters.AddWithValue("@cantidad", cant);
            com.Parameters.AddWithValue("@precio", prec);
            com.ExecuteNonQuery();
            ba.Cerrar();
        }
        /// <summary>
        /// Eliminars the detalle fac.
        /// </summary>
        /// <param name="prod">The product.</param>
        /// <param name="cant">The cant.</param>
        /// <param name="pre">The pre.</param>
        public void EliminarDetalleFac(int prod,int cant,float pre)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("EliminarDetalleFac", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@factura", 1);
            com.Parameters.AddWithValue("@producto", prod);
            com.Parameters.AddWithValue("@cantidad", cant);
            com.Parameters.AddWithValue("@precio", pre);
            com.ExecuteNonQuery();
            ba.Cerrar();
        }

        /// <summary>
        /// Eliminars the factura.
        /// </summary>
        public void EliminarFactura()
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("EliminarFactura", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@factura", 1);
            com.ExecuteNonQuery();
            ba.Cerrar();
        }

        /// <summary>
        /// Totalizars the fac.
        /// </summary>
        public void TotalizarFac()
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("TotalizarFac", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@cod", 1);
            com.Parameters.AddWithValue("@isv", 1);
            com.ExecuteNonQuery();
            ba.Cerrar();
        }
        /// <summary>
        /// Validars the factura producto.
        /// </summary>
        /// <param name="codPro">The cod pro.</param>
        public void Validar_FacturaProducto(int codPro)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("Validar_FacturaProducto", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@codPro", codPro);
            com.Parameters.AddWithValue("@codFac", 1);
            SqlParameter cod = new SqlParameter("@cod", DbType.Int32);
            cod.Direction = ParameterDirection.Output;
            com.Parameters.Add(cod);
            com.ExecuteScalar();
            ba.Cerrar();
            int codigo = Convert.ToInt32(com.Parameters["@cod"].Value);
            CompartirDatos.codVFP = codigo;
        }

    }
}
