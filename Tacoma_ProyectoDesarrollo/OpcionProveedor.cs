// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 12-11-2019
//
// Last Modified By : pepit
// Last Modified On : 12-13-2019
// ***********************************************************************
// <copyright file="OpcionProveedor.cs" company="">
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
    /// Class OpcionProveedor.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class OpcionProveedor : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpcionProveedor"/> class.
        /// </summary>
        public OpcionProveedor()
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
        /// Handles the Click event of the btnProveedor control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnProveedor_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new Proveedores());
            btnProPro.Visible = false;
            btnProveedor.Visible = false;
            label1.Visible = false;
        }

        /// <summary>
        /// Handles the Click event of the btnProPro control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnProPro_Click(object sender, EventArgs e)
        {
            AbrirFormPanel(new ProveedorProducto());
            btnProPro.Visible = false;
            btnProveedor.Visible = false;
            label1.Visible = false;
        }
    }
}
