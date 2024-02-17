// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 11-24-2019
//
// Last Modified By : pepit
// Last Modified On : 12-02-2019
// ***********************************************************************
// <copyright file="MateriaPrima.cs" company="">
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
    /// Class frmInventarioMateriaP.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class frmInventarioMateriaP : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="frmInventarioMateriaP"/> class.
        /// </summary>
        public frmInventarioMateriaP()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the Label1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Load event of the FrmInventarioMateriaP control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FrmInventarioMateriaP_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.InventarioMateriaPrima' Puede moverla o quitarla según sea necesario.
            this.inventarioMateriaPrimaTableAdapter.Fill(this.tacomaDBDataSet.InventarioMateriaPrima);

        }

        /// <summary>
        /// Handles the Click event of the BtnActualizar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            
            
            if (txtcant.Text == "") 
            {
                errorCantidad.SetError(txtcant, "Campo obligatorio. Solo numeros.");
            }

            if (txtcant.Text=="")
            {
                MessageBox.Show("Datos Inorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CMateriaPrima ma = new CMateriaPrima();
                ma.ActulizarInventario(int.Parse(txtCod.Text), int.Parse(txtcant.Text));
                this.inventarioMateriaPrimaDataGridView.Refresh();
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the Txtcant control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void Txtcant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the TextChanged event of the Txtcant control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Txtcant_TextChanged(object sender, EventArgs e)
        {
            errorCantidad.Clear();
        }

        /// <summary>
        /// Handles the Validating event of the Txtcant control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void Txtcant_Validating(object sender, CancelEventArgs e)
        {

            if (txtcant.Text == "")
            {
                errorCantidad.SetError(txtcant, "Campo obligatorio. Solo numeros.");
            }

        }
    }
}
