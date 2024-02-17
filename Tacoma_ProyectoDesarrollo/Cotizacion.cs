// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 12-13-2019
//
// Last Modified By : pepit
// Last Modified On : 12-13-2019
// ***********************************************************************
// <copyright file="Cotizacion.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;
using PdfDocument = PdfSharp.Pdf.PdfDocument;

namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class Cotizacion.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Cotizacion : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cotizacion"/> class.
        /// </summary>
        public Cotizacion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the cotizacion_DetalleBindingNavigatorSaveItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cotizacion_DetalleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cotizacion_DetalleBindingSource.EndEdit();
           // this.tableAdapterManager.UpdateAll(this.tacomaDBDataSet);

        }

        /// <summary>
        /// Handles the Load event of the Cotizacion control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Cotizacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.VwProductos' Puede moverla o quitarla según sea necesario.
            //this.vwProductosTableAdapter.Fill(this.tacomaDBDataSet.VwProductos);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.Producto' Puede moverla o quitarla según sea necesario.
           // this.productoTableAdapter.Fill(this.tacomaDBDataSet.Producto);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.VwCotizacion_Detalle' Puede moverla o quitarla según sea necesario.
            //this.vwCotizacion_DetalleTableAdapter.Fill(this.tacomaDBDataSet.VwCotizacion_Detalle);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.VwCliente' Puede moverla o quitarla según sea necesario.
           // this.vwClienteTableAdapter.Fill(this.tacomaDBDataSet.VwCliente);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.Cotizacion' Puede moverla o quitarla según sea necesario.
           // this.cotizacionTableAdapter.Fill(this.tacomaDBDataSet.Cotizacion);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.VwDetalleFactura' Puede moverla o quitarla según sea necesario.
            // this.vwDetalleFacturaTableAdapter.Fill(this.tacomaDBDataSet.VwDetalleFactura);

            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.Detalle_Factura' Puede moverla o quitarla según sea necesario.
            //this.detalle_FacturaTableAdapter.Fill(this.tacomaDBDataSet.Detalle_Factura);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.Cotizacion_Detalle' Puede moverla o quitarla según sea necesario.
           // this.cotizacion_DetalleTableAdapter.Fill(this.tacomaDBDataSet.Cotizacion_Detalle);

        }

        /// <summary>
        /// Handles the Click event of the btnBuscarRTN control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnBuscarRTN_Click(object sender, EventArgs e)
        {
            if (rTNTextBox.TextLength > 14 || rTNTextBox.TextLength < 14)
            {
                //errorRTN.SetError(rTNTextBox, "Campo invalido");
                MessageBox.Show("Ingrese un RTN válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    
                    BuscarPorCodigo(this.rTNTextBox.Text);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Ingrese un codigo de empleado valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Buscars the por codigo.
        /// </summary>
        /// <param name="rtn">The RTN.</param>
        public void BuscarPorCodigo(string rtn)
        {
            try
            {
                BaseDeDatos ba = new BaseDeDatos();
                ba.Conectar();
                SqlCommand com = new SqlCommand("SELECT * FROM VwCliente WHERE [RTN] =@rtn   ", ba.cone);
                com.Parameters.AddWithValue("@rtn", rtn);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.vwClienteDataGridView.DataSource = dt;
                this.vwClienteBindingSource.DataSource = dt;
                this.btnNuevaCot.Enabled = true;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Ingrese un RTN correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Buscars the por nombre.
        /// </summary>
        /// <param name="nom">The nom.</param>
        public void BuscarPorNombre(String nom)
        {
            BaseDeDatos ba = new BaseDeDatos();
            ba.Conectar();
            try
            {


                SqlCommand com = new SqlCommand("SELECT * FROM VwCliente WHERE [Nombre] like '%'+@nom+'%'   ", ba.cone);
                com.Parameters.AddWithValue("@nom", nom);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.vwClienteDataGridView.DataSource = dt;
                this.vwClienteBindingSource.DataSource = dt;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Debe ingresar nombre de cliente valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Handles the Click event of the button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text == "")
            {
                //errorNombre.SetError(nombreTextBox, "Ingrese un nombre válido");
                MessageBox.Show("Debe ingresar nombre de cliente valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                try
                {
                    
                    BuscarPorNombre(this.nombreTextBox.Text);
                    this.btnNuevaCot.Enabled = true;

                }
                catch (System.FormatException)
                {
                    errorNombre.SetError(nombreTextBox, "Ingrese un nombre válido");
                    MessageBox.Show("Ingrese un nombre valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                
            }
        }

        /// <summary>
        /// Handles the Click event of the button2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarPorCodigoProd(int.Parse(this.producto_CodTextBox.Text));
                this.btnAnadir.Enabled = true;
                cantidadTextBox.Enabled = true;
            }
            catch (System.FormatException)
            {

                MessageBox.Show("Ingrese un codigo de producto valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Buscars the por codigo product.
        /// </summary>
        /// <param name="cod">The cod.</param>
        public void BuscarPorCodigoProd(int cod)
        {
            try
            {
                BaseDeDatos ba = new BaseDeDatos();
                ba.Conectar();
                SqlCommand com = new SqlCommand("SELECT * FROM VwProductos WHERE [Codigo de Producto] =@cod   ", ba.cone);
                com.Parameters.AddWithValue("@cod", cod);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.vwProductosDataGridView.DataSource = dt;
                this.vwProductosBindingSource.DataSource = dt;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Ingrese un Codigo correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnNuevaFac control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnNuevaFac_Click(object sender, EventArgs e)
        {
            if (rTNTextBox.TextLength < 14 || rTNTextBox.TextLength > 14)
            {
                errorRTN.SetError(rTNTextBox, "Campo invalido");
                MessageBox.Show("Ingrese un RTN correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                producto_CodTextBox.Enabled = true;
                btnBuscarProd.Enabled = true;
                //this.CargarFactura();
                //this.cotizacionBindingSource.AddNew();
                CotizacionMetodos fac = new CotizacionMetodos();
                fac.AñadirCotizacion(this.cotizacion_FechaDateTimePicker.Value, this.rTNTextBox.Text, 1);
                rTNTextBox.Enabled = false;
                cotizacion_FechaDateTimePicker.Enabled = false;
                btnBuscarRTN.Enabled = false;
                //cmbTipoPago.Enabled = false;
                btnNuevaCot.Enabled = false;
                producto_CodTextBox.Enabled = true;
                btnBuscarProd.Enabled = true;
                cantidadTextBox.Enabled = false;
                producto_CodTextBox.Focus();
                nombreTextBox.Enabled = false;
                btnBuscarClienteNom.Enabled = false;
                descripcionTextBox.Enabled = false;
                btnBuscarProd.Enabled = true;
                producto_CodTextBox.Enabled = true;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnAnadir control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            CotizacionMetodos cot = new CotizacionMetodos();
            cot.Validar_CotizacionProducto(int.Parse(producto_CodTextBox.Text));

            int cod = 0, cant = 0;
            if (CompartirDatos.codVCP == 0)
            {
                MessageBox.Show(null, "El producto ya fue ingresado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (cantidadTextBox.Text == "" || cantidadTextBox.Text == "0")
            {
                //errorCant.SetError(cantidadTextBox, "No valido");
                MessageBox.Show(null, "Campo Obligatorio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (descripcionTextBox.Text == "")
            {
                MessageBox.Show(null, "Producto No existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float pre = 0;
                double tot = 0;
                btnAnadir.Enabled = false;
                cantidadTextBox.Enabled = false;
                cod = int.Parse(producto_CodTextBox.Text);
                cant = int.Parse(cantidadTextBox.Text);
                pre = float.Parse(precio_UnitarioTextBox.Text);
                //this.cotizacion_DetalleBindingSource.AddNew();
                CotizacionMetodos cotm = new CotizacionMetodos();
                cotm.AñadirDetalle(cod, cant, pre);
                this.CargarDetalle();
                btnFinalizar.Enabled = true;
                btnCancelarFac.Enabled = true;
                btnImprimir.Enabled = true;
                btnEliminar.Enabled = true;
                tot = float.Parse(cantidadTextBox.Text) * float.Parse(precio_UnitarioTextBox.Text);
                dgvDetalle.Rows.Add(cod, descripcionTextBox.Text, precio_UnitarioTextBox.Text, cantidadTextBox.Text, tot);
                //this.vwCotizacion_DetalleTableAdapter.Fill();
                //cotizacion_DetalleTableAdapter.Update();
                //vwCotizacion_DetalleTableAdapter.Fill(this.tacomaDBDataSet.VwCotizacion_Detalle);
                this.dgvDetalle.Refresh();
                //producto_CodTextBox.Text = "";
                //cantidadTextBox.Text = ""; 
            }
        }
        /// <summary>
        /// Cargars the detalle.
        /// </summary>
        public void CargarDetalle()
        {
            BaseDeDatos ba = new BaseDeDatos();
            ba.Conectar();
            SqlCommand com = new SqlCommand("SELECT * FROM Cotizacion_Detalle", ba.cone);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.detalle_FacturaBindingSource.DataSource = dt;
        }

        /// <summary>
        /// Handles the CellContentClick event of the vwCotizacion_DetalleDataGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void vwCotizacion_DetalleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the btnCancelarFac control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnCancelarFac_Click(object sender, EventArgs e)
        {
            dgvDetalle.Rows.Clear();
            CotizacionMetodos coti = new CotizacionMetodos();
            coti.EliminarCot();
            cantidadTextBox.Text = "";
            btnBuscarRTN.Enabled = true;
            rTNTextBox.Clear();
            nombreTextBox.Clear();
            direcciónTextBox.Clear();
            telefonoTextBox.Clear();
            ciudadTextBox.Clear();
            paisTextBox.Clear();
            btnNuevaCot.Enabled = false;
            btnBuscarProd.Enabled = true;
            rTNTextBox.Enabled = true;
            btnBuscarProd.Enabled = false;
            producto_CodTextBox.Enabled = false;
            cantidadTextBox.Enabled = false;
            btnFinalizar.Enabled = false;
            btnImprimir.Enabled = false;
            btnCancelarFac.Enabled = false;
            dgvDetalle.Rows.Clear();
            btnEliminar.Enabled = false;
            btnBuscarClienteNom.Enabled = true;
            nombreTextBox.Enabled = true;
            descripcionTextBox.Enabled = false;
        }

        /// <summary>
        /// Handles the Click event of the btnFinalizar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>


        /// <summary>
        /// Handles the Click event of the btnEliminar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CotizacionMetodos coti = new CotizacionMetodos();
            coti.EliminarCotDet(int.Parse(dgvDetalle.CurrentRow.Cells[0].Value.ToString()), int.Parse(dgvDetalle.CurrentRow.Cells[3].Value.ToString()), float.Parse(dgvDetalle.CurrentRow.Cells[2].Value.ToString()));
            dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow);
        }

        /// <summary>
        /// Handles the TextChanged event of the cantidadTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cantidadTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the cantidadLabel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cantidadLabel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the TextChanged event of the precio_UnitarioTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void precio_UnitarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the precio_UnitarioLabel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void precio_UnitarioLabel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the TextChanged event of the descripcionTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void descripcionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the descripcionLabel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void descripcionLabel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the TextChanged event of the producto_CodTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void producto_CodTextBox_TextChanged(object sender, EventArgs e)
        {

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
        /// Handles the TextChanged event of the paisTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void paisTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the paisLabel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void paisLabel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the TextChanged event of the ciudadTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ciudadTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the ciudadLabel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ciudadLabel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the TextChanged event of the telefonoTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void telefonoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the telefonoLabel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void telefonoLabel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the TextChanged event of the direcciónTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void direcciónTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the direcciónLabel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void direcciónLabel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the TextChanged event of the nombreTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the nombreLabel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void nombreLabel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the TextChanged event of the rTNTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void rTNTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the rTNLabel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void rTNLabel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the KeyPress event of the nombreTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void nombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Buscars the por codigo cot.
        /// </summary>
        /// <param name="cot">The cot.</param>
        public void BuscarPorCodigoCot(string cot)
        {
            try
            {
                BaseDeDatos ba = new BaseDeDatos();
                ba.Conectar();
                SqlCommand com = new SqlCommand("SELECT * FROM Cotizacion_Detalle WHERE Cotizacion_ID =@cot", ba.cone);
                com.Parameters.AddWithValue("@cot", cot);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                
                this.dgvDetalle.DataSource = dt;
                dgvDetalle.Refresh();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Ingrese un codigo correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Handles the Click event of the btnBuscarCot control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnBuscarCot_Click(object sender, EventArgs e)
        {
            try
            {

                BuscarPorCodigoCot(cotizacion_IDTextBox.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Ingrese un codigo valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            try
            {
                BaseDeDatos ba = new BaseDeDatos();
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                int i = 0;
                string sql = null;
                int yPoint = 0;
                string sql2 = null;
                int cod = 0;
                string prod = null;
                int cant = 0;
                float prec = 0;
                float sub = 0;

                sql = "Select Producto_ID,Producto_Descripcion,Cantidad,Precio,SUM(Precio*Cantidad) as Subtotal from Cotizacion_Detalle inner join Producto on Cotizacion_Detalle.Producto_ID=Producto.Producto_Cod where Cotizacion_ID = (Select MAX(Cotizacion_ID) from Cotizacion_Detalle) group by Cotizacion_ID, Producto_ID,Producto_Descripcion,Cantidad,Precio";
                sql2 = "Select MAX(Cotizacion_ID) from Cotizacion_Detalle";
                ba.cone.Open();
                command = new SqlCommand(sql, ba.cone);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                ba.cone.Close();

                PdfDocument pdf = new PdfDocument();
                pdf.Info.Title = "Database to PDF";
                PdfSharp.Pdf.PdfPage pdfPage = pdf.AddPage();
                XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                XFont font = new XFont("Verdana", 20, XFontStyle.Regular);

                yPoint = yPoint + 100;
                graph.DrawString("Fecha: " + cotizacion_FechaDateTimePicker.Text, font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                yPoint = yPoint + 50;
                graph.DrawString("RTN: " + rTNTextBox.Text, font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                graph.DrawString("Cliente: " + nombreTextBox.Text, font, XBrushes.Black, new XRect(40, yPoint + 40, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                yPoint = yPoint + 100;
                graph.DrawString("N°", font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                graph.DrawString("Producto", font, XBrushes.Black, new XRect(80, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                graph.DrawString("Cantidad", font, XBrushes.Black, new XRect(270, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                graph.DrawString("Precio", font, XBrushes.Black, new XRect(450, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                graph.DrawString("Total", font, XBrushes.Black, new XRect(520, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                float tota = 0;


                yPoint = yPoint + 50;
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    cod = int.Parse(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                    prod = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    cant = int.Parse(ds.Tables[0].Rows[i].ItemArray[2].ToString());
                    prec = float.Parse(ds.Tables[0].Rows[i].ItemArray[3].ToString());
                    sub = float.Parse(ds.Tables[0].Rows[i].ItemArray[4].ToString());




                    graph.DrawString(cod.ToString(), font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(prod, font, XBrushes.Black, new XRect(80, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(cant.ToString(), font, XBrushes.Black, new XRect(290, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(prec.ToString(), font, XBrushes.Black, new XRect(450, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(sub.ToString(), font, XBrushes.Black, new XRect(520, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    yPoint = yPoint + 40;

                    tota = tota + sub;
                }


                string tot = Convert.ToString(tota);

                graph.DrawString(tot.ToString(), font, XBrushes.Black, new XRect(490, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                string pdfFilename = "dbtopdf.pdf";
                pdf.Save(pdfFilename);
                Process.Start(pdfFilename);
                btnImprimir.Enabled = false;
                dgvDetalle.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFinalizar_Click_1(object sender, EventArgs e)
        {
            btnBuscarClienteNom.Enabled = true;
            nombreTextBox.Enabled = true;
            //btnBuscarDesc.Enabled = false;
            descripcionTextBox.Enabled = false;
            btnEliminar.Enabled = false;
            cantidadTextBox.Text = "";
            btnBuscarRTN.Enabled = true;
            
            btnNuevaCot.Enabled = false;
            btnBuscarProd.Enabled = true;
            rTNTextBox.Enabled = true;
            btnBuscarProd.Enabled = false;
            producto_CodTextBox.Enabled = false;
            cantidadTextBox.Enabled = false;
            btnFinalizar.Enabled = false;
            btnImprimir.Enabled = true;
            btnCancelarFac.Enabled = false;
           
        }

        private void btnCancelarFac_Click_1(object sender, EventArgs e)
        {
            dgvDetalle.Rows.Clear();
            CotizacionMetodos coti = new CotizacionMetodos();
            coti.EliminarCot();
            cantidadTextBox.Text = "";
            btnBuscarRTN.Enabled = true;
            rTNTextBox.Clear();
            nombreTextBox.Clear();
            direcciónTextBox.Clear();
            telefonoTextBox.Clear();
            ciudadTextBox.Clear();
            paisTextBox.Clear();
            btnNuevaCot.Enabled = false;
            btnBuscarProd.Enabled = true;
            rTNTextBox.Enabled = true;
            btnBuscarProd.Enabled = false;
            producto_CodTextBox.Enabled = false;
            cantidadTextBox.Enabled = false;
            btnFinalizar.Enabled = false;
            btnImprimir.Enabled = false;
            btnCancelarFac.Enabled = false;
            dgvDetalle.Rows.Clear();
            btnEliminar.Enabled = false;
            btnBuscarClienteNom.Enabled = true;
            nombreTextBox.Enabled = true;
            descripcionTextBox.Enabled = false;
        }
    }
    }
  

