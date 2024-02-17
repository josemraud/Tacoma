// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 12-02-2019
//
// Last Modified By : pepit
// Last Modified On : 12-13-2019
// ***********************************************************************
// <copyright file="ProveedoresMetodos.cs" company="">
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
    /// Class ProveedoresMetodos.
    /// </summary>
    class ProveedoresMetodos
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProveedoresMetodos"/> class.
        /// </summary>
        public ProveedoresMetodos()
        {

        }
        /// <summary>
        /// The bas
        /// </summary>
        BaseDeDatos bas = new BaseDeDatos();

        /// <summary>
        /// Añadirs the proveedor.
        /// </summary>
        /// <param name="nombre">The nombre.</param>
        /// <param name="direccion">The direccion.</param>
        /// <param name="correo">The correo.</param>
        /// <param name="numero">The numero.</param>
        /// <param name="ciudad">The ciudad.</param>
        public void AñadirProveedor(string nombre, string direccion, string correo, string numero, int ciudad)
        {
            bas.Conectar();
            SqlCommand coma = new SqlCommand("Añadir_Proveedor", bas.cone);
            coma.CommandType = CommandType.StoredProcedure;
            coma.Parameters.AddWithValue("@nombre", nombre);
            coma.Parameters.AddWithValue("@direccion", direccion);
            coma.Parameters.AddWithValue("@correo", correo);
            coma.Parameters.AddWithValue("@numero", numero);
            coma.Parameters.AddWithValue("@codCiu", ciudad);
            coma.ExecuteNonQuery();
            bas.Cerrar();
        }

        /// <summary>
        /// Actualizars the proveedores.
        /// </summary>
        /// <param name="cod">The cod.</param>
        /// <param name="nombre">The nombre.</param>
        /// <param name="direccion">The direccion.</param>
        /// <param name="correo">The correo.</param>
        /// <param name="numero">The numero.</param>
        /// <param name="ciudad">The ciudad.</param>
        public void ActualizarProveedores(int cod, string nombre, string direccion, string correo, string numero, int ciudad)
        {
            bas.Conectar();
            SqlCommand coma = new SqlCommand("ActualizarProveedor", bas.cone);
            coma.CommandType = CommandType.StoredProcedure;
            coma.Parameters.AddWithValue("@codi", cod);
            coma.Parameters.AddWithValue("@nombre", nombre);
            coma.Parameters.AddWithValue("@direccion", direccion);
            coma.Parameters.AddWithValue("@correo", correo);
            coma.Parameters.AddWithValue("@numero", numero);
            coma.Parameters.AddWithValue("@codCiu", ciudad);
            coma.ExecuteNonQuery();
            bas.Cerrar();
        }

        public void ValidarProveedor(string nom)
        {
            bas.Conectar();
            SqlCommand com = new SqlCommand("ValidarProveedorNombre", bas.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@nom", nom);

            SqlParameter cod = new SqlParameter("@cod", DbType.Int32);
            cod.Direction = ParameterDirection.Output;
            com.Parameters.Add(cod);

            com.ExecuteScalar();

            bas.Cerrar();

            int codigo = Convert.ToInt32(com.Parameters["@cod"].Value);
            CompartirDatos.codC = codigo;
        }

        /// <summary>
        /// Validars the correo.
        /// </summary>
        /// <param name="correo">The correo.</param>
        public void ValidarCorreo(string correo)
        {
            bas.Conectar();
            SqlCommand com = new SqlCommand("ValidarCorreo", bas.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@email", correo);

            SqlParameter cod = new SqlParameter("@cod", DbType.Int32);
            cod.Direction = ParameterDirection.Output;
            com.Parameters.Add(cod);

            com.ExecuteScalar();

            bas.Cerrar();

            int codigo = Convert.ToInt32(com.Parameters["@cod"].Value);
            CompartirDatos.codC = codigo;
        }

        /// <summary>
        /// Validars the telefono.
        /// </summary>
        /// <param name="num">The number.</param>
        public void ValidarTelefono(string num)
        {
            bas.Conectar();
            SqlCommand com = new SqlCommand("ValidarTelefono", bas.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@tel", num);

            SqlParameter cod = new SqlParameter("@cod", DbType.Int32);
            cod.Direction = ParameterDirection.Output;
            com.Parameters.Add(cod);

            com.ExecuteScalar();

            bas.Cerrar();

            int codigo = Convert.ToInt32(com.Parameters["@cod"].Value);
            CompartirDatos.codT = codigo;
        }

        /// <summary>
        /// Modificars the telefono.
        /// </summary>
        /// <param name="tel">The tel.</param>
        public void ModificarTelefono(int tel)
        {
            bas.Conectar();
            SqlCommand com = new SqlCommand("Numero", bas.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@num", tel);

            SqlParameter cod = new SqlParameter("@sum", DbType.Int32);
            cod.Direction = ParameterDirection.Output;
            com.Parameters.Add(cod);

            com.ExecuteScalar();

            bas.Cerrar();

            int suma = Convert.ToInt32(com.Parameters["@sum"].Value);
            CompartirDatos.sumTelPro = suma;
        }

        /// <summary>
        /// Modificars the correo.
        /// </summary>
        /// <param name="correo">The correo.</param>
        public void ModificarCorreo(string correo)
        {
            bas.Conectar();
            SqlCommand com = new SqlCommand("Correo", bas.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@email", correo);

            SqlParameter cod = new SqlParameter("@sum", DbType.Int32);
            cod.Direction = ParameterDirection.Output;
            com.Parameters.Add(cod);

            com.ExecuteScalar();

            bas.Cerrar();

            int suma = Convert.ToInt32(com.Parameters["@sum"].Value);
            CompartirDatos.sumCorPro = suma;
        }

        public void ModificarProveedor(string nom)
        {
            bas.Conectar();
            SqlCommand com = new SqlCommand("ProveedorV", bas.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@nom", nom);

            SqlParameter cod = new SqlParameter("@sum", DbType.Int32);
            cod.Direction = ParameterDirection.Output;
            com.Parameters.Add(cod);

            com.ExecuteScalar();

            bas.Cerrar();

            int suma = Convert.ToInt32(com.Parameters["@sum"].Value);
            CompartirDatos.sumPro = suma;
        }
    }
       
}
