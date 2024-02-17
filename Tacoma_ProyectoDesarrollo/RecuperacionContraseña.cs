// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 11-26-2019
//
// Last Modified By : pepit
// Last Modified On : 12-13-2019
// ***********************************************************************
// <copyright file="RecuperacionContraseña.cs" company="">
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
using System.Net;//Libreria para mandar Correo
using System.Net.Mail;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
//using System.Data;
using System.Runtime.InteropServices;

namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class RecuperacionContraseña.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class RecuperacionContraseña : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecuperacionContraseña"/> class.
        /// </summary>
        public RecuperacionContraseña()
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
        /// Restablecers this instance.
        /// </summary>
        private void Restablecer()
        {
            if (txtUser.Text == "" || txtUser.Text.StartsWith(" "))
            {
                MessageBox.Show("Ingrese su usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cont = "<h1>";
                string email = " ";
                string usuario = txtUser.Text;

                BaseDeDatos ba = new BaseDeDatos();
                ba.Conectar();
                SqlCommand com1 = new SqlCommand("SELECT Empleado_Contraseña FROM Empleado where Empleado_Usuario = @user", ba.cone);
                SqlCommand com2 = new SqlCommand("SELECT Empleado_Correo FROM Empleado where Empleado_Usuario = @user", ba.cone);

                com1.Parameters.AddWithValue("@user", usuario);
                com2.Parameters.AddWithValue("@user", usuario);

                cont += Convert.ToString(com1.ExecuteScalar()) + "</h1>";
                email = Convert.ToString(com2.ExecuteScalar());

                try
                {
                    MailMessage mensaje = new MailMessage("desarrollo.2.software@gmail.com", email, "Restablecimiento de contraseña", "Su contraseña es: " + cont);//Crea el cuerpo del correo
                                                                                                                                                                   //MailMessage(Quien lo envia, A quien se lo enviamos, titulo del correo, cuerpo del correo)
                    mensaje.IsBodyHtml = true;//el texto que se envia tiene una codificacion html
                    SmtpClient mail = new SmtpClient("smtp.gmail.com", 2525); // usar el servicio de gmail y especificar el puerto
                    mail.UseDefaultCredentials = false; //No estoy seguro de esto
                    NetworkCredential ntc = new NetworkCredential("desarrollo.2.software@gmail.com", "Desarrollo2019"); // El correo que lo envia y su contrasena
                    mail.Credentials = ntc; // le pasa las credenciales para poder enviar el correo
                    mail.EnableSsl = true;// No estoy seguro de esto
                    mail.Send(mensaje);//Envia el mensaje creado
                    MessageBox.Show("Su contraseña ha sido enviada", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();//Reinicia la aplicacion

                }
                catch (Exception ex)
                {
                    MessageBox.Show("El usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //MessageBox.Show(Convert.ToString(ex));

                }
            }
        }

        /// <summary>
        /// Handles the Click event of the btnRest control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnRest_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "NULL" || txtUser.Text == "NULl" ||
                txtUser.Text == "NUlL" || txtUser.Text == "NUll" || 
                txtUser.Text == "NuLL" || txtUser.Text == "NuLl" || 
                txtUser.Text == "NulL" || txtUser.Text == "Null" || 
                txtUser.Text == "nULL" || txtUser.Text == "nULl" || 
                txtUser.Text == "nUlL" || txtUser.Text == "nUll" || 
                txtUser.Text == "nuLL" || txtUser.Text == "nuLl" || 
                txtUser.Text == "nulL" || txtUser.Text == "null" )
            {
                MessageBox.Show("Credenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Restablecer();
            }
        }

        /// <summary>
        /// Handles the Click event of the label1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the MouseDown event of the RecuperacionContraseña control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void RecuperacionContraseña_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Handles the TextChanged event of the txtUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if(txtUser.Text == "")
            {

            }
        }

        /// <summary>
        /// Handles the Click event of the btnCerrar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /// <summary>
        /// Handles the MouseDown event of the txtUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void txtUser_MouseDown(object sender, MouseEventArgs e)
        {

        }

        /// <summary>
        /// Handles the KeyPress event of the txtUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
    }
}
