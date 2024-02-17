// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 12-11-2019
//
// Last Modified By : pepit
// Last Modified On : 12-13-2019
// ***********************************************************************
// <copyright file="OpcionCotizacion.cs" company="">
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
    /// Class OpcionCotizacion.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class OpcionCotizacion : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpcionCotizacion"/> class.
        /// </summary>
        public OpcionCotizacion()
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
        /// Handles the Click event of the label1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the btnFacturar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnFacturar_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Cotizacion());
            btnCotizacion.Visible = false;
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
            AbrirFormPanel(new Historial_Cotizaciones());
            btnCotizacion.Visible = false;
            btnHistorial.Visible = false;
            label1.Visible = false;
        }
    }
}
