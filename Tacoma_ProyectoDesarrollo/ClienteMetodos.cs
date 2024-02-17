// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 11-24-2019
//
// Last Modified By : pepit
// Last Modified On : 12-11-2019
// ***********************************************************************
// <copyright file="ClienteMetodos.cs" company="">
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
using System.Windows.Forms;

namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class ClienteMetodos.
    /// </summary>
    class ClienteMetodos
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClienteMetodos"/> class.
        /// </summary>
        public ClienteMetodos()
        {

        }

        /// <summary>
        /// The ba
        /// </summary>
        BaseDeDatos ba = new BaseDeDatos();

        /// <summary>
        /// Añadirs the cliente.
        /// </summary>
        /// <param name="RTN">The RTN.</param>
        /// <param name="Nom">The nom.</param>
        /// <param name="Direcc">The direcc.</param>
        /// <param name="Tel">The tel.</param>
        /// <param name="codciu">The codciu.</param>
        public void Añadir_Cliente(string RTN, string Nom, string Direcc, string Tel, int codciu,string persona)
        {
            try
            {
                ba.Conectar();
                SqlCommand com = new SqlCommand("Añadir_Cliente", ba.cone);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@RTN", RTN);
                com.Parameters.AddWithValue("@nombre", Nom);
                com.Parameters.AddWithValue("@direcc", Direcc);
                com.Parameters.AddWithValue("@tel", Tel);
                com.Parameters.AddWithValue("@ciudadcod", codciu);
                com.Parameters.AddWithValue("@persona", persona);
                com.ExecuteNonQuery();
                ba.Cerrar();
            }
            catch(System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("El RTN Ingresado ya fue ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Actualizars the cliente.
        /// </summary>
        /// <param name="RTN">The RTN.</param>
        /// <param name="Nom">The nom.</param>
        /// <param name="Direcc">The direcc.</param>
        /// <param name="Tel">The tel.</param>
        /// <param name="codciu">The codciu.</param>
        public void Actualizar_Cliente(string RTN, string Nom, string Direcc, string Tel, int codciu, string persona)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("Actualizar_Cliente", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@RTN", RTN);
            com.Parameters.AddWithValue("@nombre", Nom);
            com.Parameters.AddWithValue("@direcc", Direcc);
            com.Parameters.AddWithValue("@tel", Tel);
            com.Parameters.AddWithValue("@ciudadcod", codciu);
            com.Parameters.AddWithValue("@persona", persona);

            com.ExecuteNonQuery();
            ba.Cerrar();
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
        /// Validars the RTN.
        /// </summary>
        /// <param name="rtn">The RTN.</param>
        public void ValidarRTN(string rtn)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("ValidarRTN", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@rtn", rtn);

            SqlParameter cod = new SqlParameter("@cod", DbType.Int32);
            cod.Direction = ParameterDirection.Output;
            com.Parameters.Add(cod);

            com.ExecuteScalar();

            ba.Cerrar();

            int codigo = Convert.ToInt32(com.Parameters["@cod"].Value);
            CompartirDatos.codRTN = codigo;
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
            CompartirDatos.sumTelCli = suma;
        }

        /// <summary>
        /// Modificars the RTN.
        /// </summary>
        /// <param name="rtn">The RTN.</param>
        public void ModificarRTN(string rtn)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("RTN", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@rtn", rtn);

            SqlParameter cod = new SqlParameter("@sum", DbType.Int32);
            cod.Direction = ParameterDirection.Output;
            com.Parameters.Add(cod);

            com.ExecuteScalar();

            ba.Cerrar();

            int suma = Convert.ToInt32(com.Parameters["@sum"].Value);
            CompartirDatos.sumRTN = suma;
        }
    }
}
