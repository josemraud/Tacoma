// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 11-24-2019
//
// Last Modified By : pepit
// Last Modified On : 12-13-2019
// ***********************************************************************
// <copyright file="Login.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class Login.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Login : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Login"/> class.
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Releases the capture.
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="hwnd">The HWND.</param>
        /// <param name="wmsg">The WMSG.</param>
        /// <param name="wparam">The wparam.</param>
        /// <param name="lparam">The lparam.</param>
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        /// <summary>
        /// Handles the Enter event of the txtUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.WhiteSmoke;
            }
        }

        /// <summary>
        /// Handles the Leave event of the txtUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.White;
            }
        }

        /// <summary>
        /// Handles the Enter event of the txtCont control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtCont_Enter(object sender, EventArgs e)
        {
            if (txtCont.Text == "CONTRASEÑA")
            {
                txtCont.Text = "";
                txtCont.ForeColor = Color.WhiteSmoke;
                txtCont.UseSystemPasswordChar = true;
            }
        }

        /// <summary>
        /// Handles the Leave event of the txtCont control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtCont_Leave(object sender, EventArgs e)
        {
            if (txtCont.Text == "")
            {
                txtCont.Text = "CONTRASEÑA";
                txtCont.ForeColor = Color.White;
                txtCont.UseSystemPasswordChar = false;
            }
        }

        /// <summary>
        /// Handles the Click event of the pictureBox1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Handles the Click event of the btnMin control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Handles the MouseDown event of the Form1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Handles the MouseDown event of the panel1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #region Login
        /// <summary>
        /// Loginses this instance.
        /// </summary>
        public void Logins()
        {
            string user, pass;
            user = txtUser.Text;
            pass = txtCont.Text;

            BaseDeDatos ba = new BaseDeDatos();
            ba.Conectar();
            SqlCommand cmd = new SqlCommand("Logins", ba.cone);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@contra", pass);

            SqlParameter cod = new SqlParameter("@cod", DbType.Int32);
            cod.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(cod);
            SqlParameter cod1 = new SqlParameter();
            cod1.ParameterName = "@cod1";
            cod1.SqlDbType = SqlDbType.NVarChar;    
            cod1.Size = 13;
            cod1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(cod1);

            SqlParameter userf = new SqlParameter();
            userf.ParameterName = "@userf";
            userf.SqlDbType = SqlDbType.NVarChar;
            userf.Size = 20;
            userf.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(userf);

            SqlParameter contraf = new SqlParameter();
            contraf.ParameterName = "@contraf";
            contraf.SqlDbType = SqlDbType.NVarChar;
            contraf.Size = 20;
            contraf.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(contraf);


            cmd.ExecuteScalar();
            int codigo = Convert.ToInt32(cmd.Parameters["@cod"].Value);
            string  user1 = cmd.Parameters["@userf"].Value.ToString();
            string contra1 = cmd.Parameters["@contraf"].Value.ToString();



            if (codigo == 1)
            {
                MessageBox.Show("Datos Incorrectos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                txtUser.Text = "USUARIO";
                txtCont.Text = "CONTRASEÑA";
                txtCont.UseSystemPasswordChar = false;
            }
            else if (codigo == 0)
            {
                SqlCommand com = new SqlCommand("ValidarUsuarioActivo", ba.cone);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@user", user);
                com.Parameters.AddWithValue("@pass", pass);
                SqlParameter codUV = new SqlParameter("@cod", DbType.Int32);
                codUV.Direction = ParameterDirection.Output;
                com.Parameters.Add(codUV);
                com.ExecuteScalar();
                int codigo2 = Convert.ToInt32(com.Parameters["@cod"].Value);
                ba.Cerrar();
                if (codigo2 == 2)
                {
                    MessageBox.Show("El empleado no se encuentra activo", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                    txtUser.Text = "USUARIO";
                    txtCont.Text = "CONTRASEÑA";
                    txtCont.UseSystemPasswordChar = false;
                }
                else
                    if(!this.txtUser.Text.Equals(user1)||!this.txtCont.Text.Equals(contra1))
                    {
                        MessageBox.Show("Datos Incorrectos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                        txtUser.Text = "USUARIO";
                        txtCont.Text = "CONTRASEÑA";
                        txtCont.UseSystemPasswordChar = false;
                }
                else
                
                  {
                     string codigo1 =cmd.Parameters["@cod1"].Value.ToString();
                     CompartirDatos.cod = codigo1;

                     MessageBox.Show("Login exitoso", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                     Principal PR = new Principal();
                     PR.Show();

                     this.Close();
                }
            }
        }

        #endregion


        /// <summary>
        /// Handles the Click event of the btnAcceder control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnAcceder_Click(object sender, EventArgs e)
        {

            if (txtUser.Text == "USUARIO" || txtCont.Text == "CONTRASEÑA" || txtCont.Text == "" || txtUser.Text=="")
            {
                MessageBox.Show("Llene los dos campos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            if(txtUser.Text == "NULL" || txtCont.Text == "NULL" || txtUser.Text == "NULl" || txtCont.Text == "NULl" ||
                txtUser.Text == "NUlL" || txtCont.Text == "NUlL" || txtUser.Text == "NUll" || txtCont.Text == "NUll" ||
                txtUser.Text == "NuLL" || txtCont.Text == "NuLL" || txtUser.Text == "NuLl" || txtCont.Text == "NuLl" ||
                txtUser.Text == "NulL" || txtCont.Text == "NulL" || txtUser.Text == "Null" || txtCont.Text == "Null" ||
                txtUser.Text == "nULL" || txtCont.Text == "nULL" || txtUser.Text == "nULl" || txtCont.Text == "nULl" ||
                txtUser.Text == "nUlL" || txtCont.Text == "nUlL" || txtUser.Text == "nUll" || txtCont.Text == "nUll" ||
                txtUser.Text == "nuLL" || txtCont.Text == "nuLL" || txtUser.Text == "nuLl" || txtCont.Text == "nuLl" ||
                txtUser.Text == "nulL" || txtCont.Text == "nulL" || txtUser.Text == "null" || txtCont.Text == "null")
            {
                MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Logins();
            }

        }

        /// <summary>
        /// Handles the KeyPress event of the txtCont control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void txtCont_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the Paint event of the panel1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        /// <summary>
        /// Handles the Load event of the Login control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Login_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the TextChanged event of the txtUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the LinkClicked event of the linkpass control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void linkpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperacionContraseña rc = new RecuperacionContraseña();
            rc.Show();
            this.Close();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
    }
}
