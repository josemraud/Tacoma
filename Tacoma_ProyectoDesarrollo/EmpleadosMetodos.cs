// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 11-24-2019
//
// Last Modified By : pepit
// Last Modified On : 12-11-2019
// ***********************************************************************
// <copyright file="EmpleadosMetodos.cs" company="">
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
using System.Windows.Forms;

namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class EmpleadosMetodos.
    /// </summary>
    class EmpleadosMetodos
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmpleadosMetodos"/> class.
        /// </summary>
        public EmpleadosMetodos()
        {

        }
        /// <summary>
        /// The ba
        /// </summary>
        BaseDeDatos ba = new BaseDeDatos();
        /// <summary>
        /// Añadirs the empleado.
        /// </summary>
        /// <param name="nom">The nom.</param>
        /// <param name="direccion">The direccion.</param>
        /// <param name="telefono">The telefono.</param>
        /// <param name="departamento">The departamento.</param>
        /// <param name="usuario">The usuario.</param>
        /// <param name="contra">The contra.</param>
        /// <param name="estado_cod">The estado cod.</param>
        /// <param name="codigoRS">The codigo rs.</param>
        /// <param name="correo">The correo.</param>
        /// <param name="RolCodigo">The rol codigo.</param>
        /// 


        public int VerificarDepar(string depar)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("ValidarID_Depar", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@depar", depar);
            SqlParameter cod = new SqlParameter("@cod", DbType.Int32);
            cod.Direction = ParameterDirection.Output;
            com.Parameters.Add(cod);
            com.ExecuteScalar();
            ba.Cerrar();
            int codi = Convert.ToInt32(com.Parameters["@cod"].Value); 
            return codi;
        }
        public int VerificarMuni(string depar, string muni)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("ValidarID_Muni", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@depar", depar);
            com.Parameters.AddWithValue("@muni", muni);
            SqlParameter cod = new SqlParameter("@cod", DbType.Int32);
            cod.Direction = ParameterDirection.Output;
            com.Parameters.Add(cod);
            com.ExecuteScalar();
            ba.Cerrar();
            int codi = Convert.ToInt32(com.Parameters["@cod"].Value);
            return codi;
        }

        public void AñadirEmpleado(string cod,string nom,string direccion,string telefono,int departamento,
            string usuario,string contra,int estado_cod, int codigoRS, string correo, int RolCodigo)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("Añadir_Empleado", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", cod);
            com.Parameters.AddWithValue("@nombre", nom);
            com.Parameters.AddWithValue("@direccion", direccion);
            com.Parameters.AddWithValue("@telefono", telefono);
            com.Parameters.AddWithValue("@departamento_id", departamento);
            com.Parameters.AddWithValue("@usuario", usuario);
            com.Parameters.AddWithValue("@contra", contra);
            com.Parameters.AddWithValue("@estado_Cod", estado_cod);
            com.Parameters.AddWithValue("@CodigoRS", codigoRS);
            com.Parameters.AddWithValue("@correo", correo);
            com.Parameters.AddWithValue("@RolCodigo", RolCodigo);
            com.ExecuteNonQuery();
            ba.Cerrar();
        }

        public void AñadirEmpleadoSU(string cod ,string nom, string direccion, string telefono, int departamento,
            int estado_cod, int codigoRS, string correo, int RolCodigo)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("Añadir_Empleado", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id", cod);
            com.Parameters.AddWithValue("@nombre", nom);
            com.Parameters.AddWithValue("@direccion", direccion);
            com.Parameters.AddWithValue("@telefono", telefono);
            com.Parameters.AddWithValue("@departamento_id", departamento);
            com.Parameters.AddWithValue("@usuario", "NULL");
            com.Parameters.AddWithValue("@contra", "NULL");
            com.Parameters.AddWithValue("@estado_Cod", estado_cod);
            com.Parameters.AddWithValue("@CodigoRS", codigoRS);
            com.Parameters.AddWithValue("@correo", correo);
            com.Parameters.AddWithValue("@RolCodigo", RolCodigo);
            com.ExecuteNonQuery();
            ba.Cerrar();
        }

        /// <summary>
        /// Actualizars the empleado.
        /// </summary>
        /// <param name="cod">The cod.</param>
        /// <param name="nom">The nom.</param>
        /// <param name="direccion">The direccion.</param>
        /// <param name="telefono">The telefono.</param>
        /// <param name="departamento">The departamento.</param>
        /// <param name="usuario">The usuario.</param>
        /// <param name="contra">The contra.</param>
        /// <param name="estado_cod">The estado cod.</param>
        /// <param name="codigoRS">The codigo rs.</param>
        /// <param name="correo">The correo.</param>
        /// <param name="RolCodigo">The rol codigo.</param>
        public void ActualizarEmpleado(string cod,string nom, string direccion, string telefono, int departamento,
            string usuario, string contra, int estado_cod, int codigoRS, string correo, int RolCodigo)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("Actualizar_Empleado", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@cod", cod);
            com.Parameters.AddWithValue("@nombre", nom);
            com.Parameters.AddWithValue("@direccion", direccion);
            com.Parameters.AddWithValue("@telefono", telefono);
            com.Parameters.AddWithValue("@departamento_id", departamento);
            com.Parameters.AddWithValue("@usuario", usuario);
            com.Parameters.AddWithValue("@contra", contra);
            com.Parameters.AddWithValue("@estado_Cod", estado_cod);
            com.Parameters.AddWithValue("@CodigoRS", codigoRS);
            com.Parameters.AddWithValue("@correo", correo);
            com.Parameters.AddWithValue("@RolCodigo", RolCodigo);
            com.ExecuteNonQuery();
            ba.Cerrar();
        }


        public void ActualizarEmpleadoSU(string cod, string nom, string direccion, string telefono, int departamento,
            int estado_cod, int codigoRS, string correo, int RolCodigo)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("Actualizar_Empleado", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@cod", cod);
            com.Parameters.AddWithValue("@nombre", nom);
            com.Parameters.AddWithValue("@direccion", direccion);
            com.Parameters.AddWithValue("@telefono", telefono);
            com.Parameters.AddWithValue("@departamento_id", departamento);
            com.Parameters.AddWithValue("@usuario", "NULL");
            com.Parameters.AddWithValue("@contra", "NULL");
            com.Parameters.AddWithValue("@estado_Cod", estado_cod);
            com.Parameters.AddWithValue("@CodigoRS", codigoRS);
            com.Parameters.AddWithValue("@correo", correo);
            com.Parameters.AddWithValue("@RolCodigo", RolCodigo);
            com.ExecuteNonQuery();
            ba.Cerrar();
        }
        /// <summary>
        /// Validars the correo.
        /// </summary>
        /// <param name="correo">The correo.</param>
        public void ValidarCorreo(string correo)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("ValidarCorreo",ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@email", correo);

            SqlParameter cod = new SqlParameter("@cod", DbType.Int32);
            cod.Direction = ParameterDirection.Output;
            com.Parameters.Add(cod);

            com.ExecuteScalar();

            ba.Cerrar();

            int codigo = Convert.ToInt32(com.Parameters["@cod"].Value);
            CompartirDatos.codC = codigo;
        }

        /// <summary>
        /// Validars the telefono.
        /// </summary>
        /// <param name="num">The number.</param>
        public void ValidarTelefono(string num)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("ValidarTelefono", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@tel", num);

            SqlParameter cod = new SqlParameter("@cod", DbType.Int32);
            cod.Direction = ParameterDirection.Output;
            com.Parameters.Add(cod);

            com.ExecuteScalar();

            ba.Cerrar();

            int codigo = Convert.ToInt32(com.Parameters["@cod"].Value);
            CompartirDatos.codT = codigo;
        }

        /// <summary>
        /// Validars the usuario.
        /// </summary>
        /// <param name="user">The user.</param>
        public void ValidarUsuario(string user)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("ValidarUsuario", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@user", user);

            SqlParameter cod = new SqlParameter("@cod", DbType.Int32);
            cod.Direction = ParameterDirection.Output;
            com.Parameters.Add(cod);

            com.ExecuteScalar();

            ba.Cerrar();

            int codigo = Convert.ToInt32(com.Parameters["@cod"].Value);
            CompartirDatos.codU = codigo;
        }

        /// <summary>
        /// Modificars the telefono.
        /// </summary>
        /// <param name="tel">The tel.</param>
        public void ModificarTelefono(int tel)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("Numero", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@num", tel);

            SqlParameter cod = new SqlParameter("@sum", DbType.Int32);
            cod.Direction = ParameterDirection.Output;
            com.Parameters.Add(cod);

            com.ExecuteScalar();

            ba.Cerrar();

            int suma = Convert.ToInt32(com.Parameters["@sum"].Value);
            CompartirDatos.sumTelEmp = suma;
        }

        /// <summary>
        /// Modificars the correo.
        /// </summary>
        /// <param name="correo">The correo.</param>
        public void ModificarCorreo(string correo)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("Correo", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@email", correo);

            SqlParameter cod = new SqlParameter("@sum", DbType.Int32);
            cod.Direction = ParameterDirection.Output;
            com.Parameters.Add(cod);

            com.ExecuteScalar();

            ba.Cerrar();

            int suma = Convert.ToInt32(com.Parameters["@sum"].Value);
            CompartirDatos.sumCorEmp = suma;
        }

        /// <summary>
        /// Modificars the usuario.
        /// </summary>
        /// <param name="user">The user.</param>
        public void ModificarUsuario(string user)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("Users", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@user", user);

            SqlParameter cod = new SqlParameter("@sum", DbType.Int32);
            cod.Direction = ParameterDirection.Output;
            com.Parameters.Add(cod);

            com.ExecuteScalar();

            ba.Cerrar();

            int suma = Convert.ToInt32(com.Parameters["@sum"].Value);
            CompartirDatos.sumUser = suma;
        }
    }
}
