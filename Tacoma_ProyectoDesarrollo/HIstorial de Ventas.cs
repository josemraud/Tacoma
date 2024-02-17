// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 12-13-2019
//
// Last Modified By : pepit
// Last Modified On : 12-13-2019
// ***********************************************************************
// <copyright file="HIstorial de Ventas.cs" company="">
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

namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class HIstorial_de_Ventas.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class HIstorial_de_Ventas : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HIstorial_de_Ventas"/> class.
        /// </summary>
        public HIstorial_de_Ventas()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Handles the Load event of the HIstorial_de_Ventas control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void HIstorial_de_Ventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.VwDetalleFactura' Puede moverla o quitarla según sea necesario.
            //this.vwDetalleFacturaTableAdapter.Fill(this.tacomaDBDataSet.VwDetalleFactura);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.HistorialDetallesFactura' Puede moverla o quitarla según sea necesario.
            this.historialDetallesFacturaTableAdapter.Fill(this.tacomaDBDataSet.HistorialDetallesFactura);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.HistorialFacturas' Puede moverla o quitarla según sea necesario.
            this.historialFacturasTableAdapter.Fill(this.tacomaDBDataSet.HistorialFacturas);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.VwFactura' Puede moverla o quitarla según sea necesario.
            this.vwFacturaTableAdapter.Fill(this.tacomaDBDataSet.VwFactura);
            //this.CargarData();
            //this.CargarDataDet();
        }

        /// <summary>
        /// Handles the CellContentClick event of the historialFacturasDataGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void historialFacturasDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// Buscars the por codigo.
        /// </summary>
        /// <param name="cod">The cod.</param>
        public void BuscarPorCodigo(string cod)
        {
            try
            {
                BaseDeDatos ba = new BaseDeDatos();
                ba.Conectar();
                SqlCommand com = new SqlCommand("SELECT * FROM HistorialDetallesFactura WHERE [Factura] =@cod   ", ba.cone);
                com.Parameters.AddWithValue("@cod", cod);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                //this.historialDetallesFacturaDataGridView.DataSource = dt;
                this.historialDetallesFacturaBindingSource.DataSource = dt;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Ingrese un valor correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Handles the TextChanged event of the facturaTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void facturaTextBox_TextChanged(object sender, EventArgs e)
        {
            //BuscarPorCodigo(facturaTextBox.Text);
        }

        /// <summary>
        /// Handles the Click event of the facturaLabel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void facturaLabel_Click(object sender, EventArgs e)
        {

        }

        private void vwFacturaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void CargarData()
        {
            BaseDeDatos ba = new BaseDeDatos();
            ba.Conectar();
            SqlCommand com = new SqlCommand("SELECT * FROM VwFactura", ba.cone);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            vwFacturaDataGridView.DataSource = dt;
            vwFacturaBindingSource.DataSource = dt;
        }
        public void CargarDataDet()
        {
            BaseDeDatos ba = new BaseDeDatos();
            ba.Conectar();
            SqlCommand com = new SqlCommand("SELECT * FROM VwDetalleFactura", ba.cone);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //historialDetallesFacturaDataGridView.DataSource = dt;
            historialFacturasBindingSource.DataSource = dt;
        }

        private void facturaTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void facturaTextBox_TextChanged_2(object sender, EventArgs e)
        {
            //BuscarPorCodigo(facturaTextBox.Text);
        }

        private void facturaTextBox_TextChanged_3(object sender, EventArgs e)
        {
            //BuscarPorCodigo(facturaTextBox.Text);
        }

        private void historialDetallesFacturaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void facturaTextBox_TextChanged_4(object sender, EventArgs e)
        {
            //BuscarPorCodigo(facturaTextBox.Text);
        }
    }
}
