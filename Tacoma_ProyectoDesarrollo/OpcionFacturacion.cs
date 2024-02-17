// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 12-07-2019
//
// Last Modified By : pepit
// Last Modified On : 12-13-2019
// ***********************************************************************
// <copyright file="OpcionFacturacion.cs" company="">
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

namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class OpcionFacturacion.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class OpcionFacturacion : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpcionFacturacion"/> class.
        /// </summary>
        public OpcionFacturacion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Abrirs the form panel.
        /// </summary>
        /// <param name="FormHijo">The form hijo.</param>
        public void AbrirFormPanel(object FormHijo)
        {
            if (this.panel.Controls.Count > 0)
                this.panel.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel.Controls.Add(fh);
            this.panel.Tag = fh;
            fh.Show();
        }

        /// <summary>
        /// Handles the 1 event of the btnFacturar_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnFacturar_Click_1(object sender, EventArgs e)
        {
            AbrirFormPanel(new Facturacion());
            btnFacturar.Visible = false;
            btnHistorial.Visible = false;
            label1.Visible = false;
        }

        /// <summary>
        /// Handles the Click event of the btnHistorial control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new HIstorial_de_Ventas());
            btnFacturar.Visible = false;
            btnHistorial.Visible = false;
            label1.Visible = false;
        }

        /// <summary>
        /// Handles the Paint event of the panel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
