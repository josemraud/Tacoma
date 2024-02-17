// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 12-02-2019
//
// Last Modified By : pepit
// Last Modified On : 12-10-2019
// ***********************************************************************
// <copyright file="MantenimientoMetodos.cs" company="">
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
    /// Class MantenimientoMetodos.
    /// </summary>
    class MantenimientoMetodos
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MantenimientoMetodos"/> class.
        /// </summary>
        public MantenimientoMetodos()
        {

        }
        /// <summary>
        /// The ba
        /// </summary>
        BaseDeDatos ba = new BaseDeDatos();
        /// <summary>
        /// Añadirs the pais.
        /// </summary>
        /// <param name="nom">The nom.</param>
        public void Añadir_Pais(String nom)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("Añadir_Pais", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@pais", nom);
            com.ExecuteNonQuery();
            ba.Cerrar();
        }
        /// <summary>
        /// Actualizars the pais.
        /// </summary>
        /// <param name="nom">The nom.</param>
        /// <param name="cod">The cod.</param>
        public void Actualizar_Pais(String nom, int cod)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("Actualizar_Pais", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@pais", nom);
            com.Parameters.AddWithValue("@cod", cod);

            com.ExecuteNonQuery();
            ba.Cerrar();
        }

        /// <summary>
        /// Añadirs the ciudad.
        /// </summary>
        /// <param name="nom">The nom.</param>
        /// <param name="codPai">The cod pai.</param>
        public void Añadir_Ciudad(string nom,int codPai)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("Añadir_Ciudad", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@nomCiudad", nom);
            com.Parameters.AddWithValue("@codPais", codPai);

            com.ExecuteNonQuery();
            ba.Cerrar();
        }

        /// <summary>
        /// Actualizars the ciudad.
        /// </summary>
        /// <param name="nom">The nom.</param>
        /// <param name="codPai">The cod pai.</param>
        /// <param name="codCiu">The cod ciu.</param>
        public void Actualizar_Ciudad(string nom, int codPai,int codCiu)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("Actualizar_Ciudad", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@nomCiudad", nom);
            com.Parameters.AddWithValue("@codPais", codPai);
            com.Parameters.AddWithValue("@codCiudad", codPai);

            com.ExecuteNonQuery();
            ba.Cerrar();
        }
        /// <summary>
        /// Añadirs the subcategoria.
        /// </summary>
        /// <param name="nom">The nom.</param>
        /// <param name="codCat">The cod cat.</param>
        public void Añadir_Subcategoria(string nom, int codCat)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("Añadir_SubCategoria", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@descrip", nom);
            com.Parameters.AddWithValue("@codCategoria", codCat);

            com.ExecuteNonQuery();
            ba.Cerrar();
        }
        /// <summary>
        /// Actualizars the subcategoria.
        /// </summary>
        /// <param name="nom">The nom.</param>
        /// <param name="codCat">The cod cat.</param>
        /// <param name="codSubcat">The cod subcat.</param>
        public void Actualizar_Subcategoria(string nom, int codCat,int codSubcat)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("Actualizar_SubCategoria", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@descrip", nom);
            com.Parameters.AddWithValue("@codCategoria", codCat);
            com.Parameters.AddWithValue("@codSubcate", codCat);

            com.ExecuteNonQuery();
            ba.Cerrar();
        }

        /// <summary>
        /// Añadirs the estado.
        /// </summary>
        /// <param name="nom">The nom.</param>
        public void Añadir_Estado(string nom)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("Añadir_Estado", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@descrip", nom);
        

            com.ExecuteNonQuery();
            ba.Cerrar();
        }
        /// <summary>
        /// Actualizars the estado.
        /// </summary>
        /// <param name="nom">The nom.</param>
        /// <param name="codE">The cod e.</param>
        public void Actualizar_Estado(string nom,int codE)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("Actualizar_Estado", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@descrip", nom);
            com.Parameters.AddWithValue("@cod", codE);

            com.ExecuteNonQuery();
            ba.Cerrar();
        }
        /// <summary>
        /// Añadirs the depar.
        /// </summary>
        /// <param name="nom">The nom.</param>
        public void Añadir_Depar(string nom)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("Añadir_Departamento", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@descrip", nom);


            com.ExecuteNonQuery();
            ba.Cerrar();
        }
        /// <summary>
        /// Actualizars the depar.
        /// </summary>
        /// <param name="nom">The nom.</param>
        /// <param name="codE">The cod e.</param>
        public void Actualizar_Depar(string nom,int codE)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("Actualizar_Departamento", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@descrip", nom);
            com.Parameters.AddWithValue("@codDepar", codE);

            com.ExecuteNonQuery();
            ba.Cerrar();
        }
        /// <summary>
        /// Añadirs the rol.
        /// </summary>
        /// <param name="nom">The nom.</param>
        public void Añadir_Rol(string nom)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("Añadir_Rol", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@descrip", nom);


            com.ExecuteNonQuery();
            ba.Cerrar();
        }
        /// <summary>
        /// Actualizars the rol.
        /// </summary>
        /// <param name="nom">The nom.</param>
        /// <param name="codE">The cod e.</param>
        public void Actualizar_Rol(string nom, int codE)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("Actualizar_Departamento", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@descrip", nom);
            com.Parameters.AddWithValue("@codDepar", codE);

            com.ExecuteNonQuery();
            ba.Cerrar();
        }
        /// <summary>
        /// Añadirs the rolen depar.
        /// </summary>
        /// <param name="codRol">The cod rol.</param>
        /// <param name="codDepar">The cod depar.</param>
        public void Añadir_RolenDepar(int codRol,int codDepar)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("Añadir_RolenDepar", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@codRol", codRol);
            com.Parameters.AddWithValue("@codDepar", codDepar);


            com.ExecuteNonQuery();
            ba.Cerrar();
        }
        /// <summary>
        /// Eliminars the rolen depar.
        /// </summary>
        /// <param name="codRol">The cod rol.</param>
        /// <param name="codDepar">The cod depar.</param>
        public void Eliminar_RolenDepar(int codRol, int codDepar)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("Eliminar_RolenDepar", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@codRol", codRol);
            com.Parameters.AddWithValue("@codDepar", codDepar);


            com.ExecuteNonQuery();
            ba.Cerrar();
        }

        /// <summary>
        /// Validars the subcategoria.
        /// </summary>
        /// <param name="subcat">The subcat.</param>
        public void ValidarSubcategoria(string subcat)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("ValidarSubCategoria", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@subcat", subcat);

            SqlParameter cod = new SqlParameter("@cod", DbType.Int32);
            cod.Direction = ParameterDirection.Output;
            com.Parameters.Add(cod);

            com.ExecuteScalar();

            ba.Cerrar();

            int codigo = Convert.ToInt32(com.Parameters["@cod"].Value);
            CompartirDatos.codSC = codigo;
        }

        /// <summary>
        /// Validars the rol.
        /// </summary>
        /// <param name="rol">The rol.</param>
        public void ValidarRol(string rol)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("ValidarRol", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@rd", rol);

            SqlParameter cod = new SqlParameter("@cod", DbType.Int32);
            cod.Direction = ParameterDirection.Output;
            com.Parameters.Add(cod);

            com.ExecuteScalar();

            ba.Cerrar();

            int codigo = Convert.ToInt32(com.Parameters["@cod"].Value);
            CompartirDatos.codRol = codigo;
        }

        /// <summary>
        /// Rols the depar.
        /// </summary>
        /// <param name="codR">The cod r.</param>
        /// <param name="codD">The cod d.</param>
        public void Rol_Depar(int codR, int codD)
        {
            BaseDeDatos ba = new BaseDeDatos();
            ba.Conectar();
            SqlCommand cmd = new SqlCommand("Añadir_RolenDepar", ba.cone);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codRol", codR);
            cmd.Parameters.AddWithValue("@codDep", codD);
            SqlParameter cod1 = new SqlParameter("@cod", DbType.Int32);
            cod1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(cod1);

            cmd.ExecuteScalar();

            int cod = Convert.ToInt32(cmd.Parameters["@cod"].Value);
            CompartirDatos.codRolD = cod;

            ba.Cerrar();
        }

        /// <summary>
        /// Validars the pais.
        /// </summary>
        /// <param name="pais">The pais.</param>
        public void ValidarPais(string pais)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("ValidarPais", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@pais", pais);

            SqlParameter cod = new SqlParameter("@cod", DbType.Int32);
            cod.Direction = ParameterDirection.Output;
            com.Parameters.Add(cod);

            com.ExecuteScalar();

            ba.Cerrar();

            int codigo = Convert.ToInt32(com.Parameters["@cod"].Value);
            CompartirDatos.codPais = codigo;
        }

        /// <summary>
        /// Validars the ciudad.
        /// </summary>
        /// <param name="ciudad">The ciudad.</param>
        public void ValidarCiudad(string ciudad)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("ValidarCiudad", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@ciu", ciudad);

            SqlParameter cod = new SqlParameter("@cod", DbType.Int32);
            cod.Direction = ParameterDirection.Output;
            com.Parameters.Add(cod);

            com.ExecuteScalar();

            ba.Cerrar();

            int codigo = Convert.ToInt32(com.Parameters["@cod"].Value);
            CompartirDatos.codCiu = codigo;
        }

        /// <summary>
        /// Validars the departamento.
        /// </summary>
        /// <param name="dep">The dep.</param>
        public void ValidarDepartamento(string dep)
        {
            ba.Conectar();
            SqlCommand com = new SqlCommand("ValidarDepartamentos", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@dep", dep);

            SqlParameter cod = new SqlParameter("@cod", DbType.Int32);
            cod.Direction = ParameterDirection.Output;
            com.Parameters.Add(cod);

            com.ExecuteScalar();

            ba.Cerrar();

            int codigo = Convert.ToInt32(com.Parameters["@cod"].Value);
            CompartirDatos.codDep = codigo;
        }
    }
}

