// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 11-24-2019
//
// Last Modified By : pepit
// Last Modified On : 12-12-2019
// ***********************************************************************
// <copyright file="Principal.cs" company="">
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
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;

namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class Principal.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Principal : Form
    {
        /// <summary>
        /// Usuarioes this instance.
        /// </summary>
        public void Usuario()
        {
            string cod = CompartirDatos.cod;

            BaseDeDatos ba = new BaseDeDatos();
            ba.cone.Open();
            SqlCommand pa = new SqlCommand("Datos_Empleado", ba.cone);
            pa.CommandType = CommandType.StoredProcedure;
            SqlParameter code = new SqlParameter("@cod", cod);
            code.Direction = ParameterDirection.Input;
            pa.Parameters.Add(code);

            SqlParameter nom = new SqlParameter();
            nom.ParameterName = "@nom";
            nom.IsNullable = true;
            nom.SqlDbType = SqlDbType.NVarChar;
            nom.Size = 50;
            nom.Direction = ParameterDirection.Output;
            pa.Parameters.Add(nom);

            SqlParameter rol = new SqlParameter();
            rol.ParameterName = "@rol";
            rol.IsNullable = true;
            rol.SqlDbType = SqlDbType.VarChar;
            rol.Size = 20;
            rol.Direction = ParameterDirection.Output;
            pa.Parameters.Add(rol);

            SqlParameter email = new SqlParameter();
            email.ParameterName = "@email";
            email.IsNullable = true;
            email.SqlDbType = SqlDbType.NVarChar;
            email.Size = 50;
            email.Direction = ParameterDirection.Output;
            pa.Parameters.Add(email);

            pa.ExecuteNonQuery();

            string nombre = pa.Parameters["@nom"].Value.ToString();
            string roles = pa.Parameters["@rol"].Value.ToString();
            string correo = pa.Parameters["@email"].Value.ToString();

            label1.Text = "\n" + nombre;
            label2.Text = "\n" + roles;
            label3.Text = "\n" + correo;

            if (roles == "Administrador")
            {
                btnClientes.Visible = true;
                btnEmpleados.Visible = true;
                btnInventario.Visible = true;
                btnMantenimiento.Visible = true;
                btnProductos.Visible = true;
                btnProveedores.Visible = true;
            }
            else
            if (roles == "Usuario")
            {
                btnClientes.Visible = true;
                btnClientes.Location = new Point(0, 185);
                btnEmpleados.Visible = false;
                btnInventario.Visible = false;
                btnMantenimiento.Visible = false;
                btnProductos.Visible = false;
                btnProveedores.Visible = false;

            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Principal"/> class.
        /// </summary>
        public Principal()
        {
            InitializeComponent();
            Usuario();
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
        /// The cod
        /// </summary>
        public static int cod;

        /// <summary>
        /// Handles the Load event of the Principal control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Abrirs the form panel.
        /// </summary>
        /// <param name="FormHijo">The form hijo.</param>
        public void AbrirFormPanel(object FormHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        /// <summary>
        /// Handles the 1 event of the iconminimizar_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void iconminimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Handles the 1 event of the iconcerrar_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void iconcerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Handles the Paint event of the barraTitulo control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void barraTitulo_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Handles the Paint event of the MenuVertical control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {       
            
        }

        /// <summary>
        /// Handles the Click event of the btnVentas control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new OpcionFacturacion());
        }

        /// <summary>
        /// Handles the Click event of the button3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Productos());
        }

        /// <summary>
        /// Handles the Click event of the btnEmpleados control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Empleados());
        }

        /// <summary>
        /// Handles the Click event of the btnClientes control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Clientes());
        }

        /// <summary>
        /// Handles the Click event of the btnProveedores control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new OpcionProveedor());
        }

        /// <summary>
        /// Handles the Click event of the btnInventario control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmInventarioMateriaP());

        }

        /// <summary>
        /// Handles the Click event of the btnMantenimiento control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Mantenimiento());
        }

        /// <summary>
        /// Handles the Click event of the button2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new OpcionCotizacion());
        }

        /// <summary>
        /// Handles the Click event of the pictureBox3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new frmEstadisticas());
        }

        /// <summary>
        /// Handles the MouseDown event of the barraTitulo control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Handles the Click event of the label2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Handles the Click event of the pictureBox4 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login lo = new Login();

            this.Close();

            lo.Show();
        }

        /// <summary>
        /// Handles the Click event of the label4 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
