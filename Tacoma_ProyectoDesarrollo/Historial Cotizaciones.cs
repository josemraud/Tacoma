// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 12-13-2019
//
// Last Modified By : pepit
// Last Modified On : 12-13-2019
// ***********************************************************************
// <copyright file="Historial Cotizaciones.cs" company="">
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

using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;
using PdfDocument = PdfSharp.Pdf.PdfDocument;

namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class Historial_Cotizaciones.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Historial_Cotizaciones : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Historial_Cotizaciones"/> class.
        /// </summary>
        public Historial_Cotizaciones()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the Historial_Cotizaciones control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Historial_Cotizaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.TipoDePago' Puede moverla o quitarla según sea necesario.
            this.tipoDePagoTableAdapter.Fill(this.tacomaDBDataSet.TipoDePago);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.TipoDePago' Puede moverla o quitarla según sea necesario.
            //this.tipoDePagoTableAdapter.Fill(this.tacomaDBDataSet.TipoDePago);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.VwCliente' Puede moverla o quitarla según sea necesario.
            //this.vwClienteTableAdapter.Fill(this.tacomaDBDataSet.VwCliente);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.HistorialDetalleCotizacion' Puede moverla o quitarla según sea necesario.
            // this.historialDetalleCotizacionTableAdapter.Fill(this.tacomaDBDataSet.HistorialDetalleCotizacion);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.HistorialCotizacion' Puede moverla o quitarla según sea necesario.
            // this.historialCotizacionTableAdapter.Fill(this.tacomaDBDataSet.HistorialCotizacion);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.VwCotizacion' Puede moverla o quitarla según sea necesario.
            //this.vwCotizacionTableAdapter.Fill(this.tacomaDBDataSet.VwCotizacion);
            CargarData();

            if(cotizacionTextBox.Text == "")
            {
                btnFacturar.Enabled = false;
                btnCancelar.Enabled = false;
            }
            else
            {
                btnFacturar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        /// <summary>
        /// Handles the TextChanged event of the cotizacionTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cotizacionTextBox_TextChanged(object sender, EventArgs e)
        {
            BuscarPorCodigo(int.Parse(cotizacionTextBox.Text));
        }
        /// <summary>
        /// Buscars the por codigo.
        /// </summary>
        /// <param name="cod">The cod.</param>
        public void BuscarPorCodigo(int cod)
        {
            try
            {
                BaseDeDatos ba = new BaseDeDatos();
                ba.Conectar();
                SqlCommand com = new SqlCommand("SELECT * FROM HistorialDetalleCotizacion WHERE [Cotización] = @cod ", ba.cone);
                com.Parameters.AddWithValue("@cod", cod);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.historialDetalleCotizacionDataGridView.DataSource = dt;
                this.historialDetalleCotizacionBindingSource.DataSource = dt;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Ingrese un Codigo correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the CellContentClick event of the vwCotizacionDataGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void vwCotizacionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the btnFacturar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnFacturar_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
        }

        /// <summary>
        /// Handles the KeyPress event of the cmbTipoPago control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void cmbTipoPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the comboBox1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbBusqueda.Text == "Todo")
            {
                this.txtBuscar.Clear();
                this.txtBuscar.Enabled = false;
                this.btnBuscar.Enabled = false;
                this.CargarData();
            }
            else
            {
                this.txtBuscar.Enabled = true;
                this.btnBuscar.Enabled = true;
            }
        }
        /// <summary>
        /// Cargars the data.
        /// </summary>
        public void CargarData()
        {
            BaseDeDatos ba = new BaseDeDatos();
            ba.Conectar();
            SqlCommand com = new SqlCommand("SELECT * FROM VwCotizacion", ba.cone);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            vwCotizacionDataGridView.DataSource = dt;
            vwCotizacionBindingSource.DataSource = dt;
        }

        /// <summary>
        /// Handles the Click event of the btnBuscar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbBusqueda.Text == "Código de Cotización")
            {
                try
                {
                    BuscarPorCodigoCot(int.Parse(this.txtBuscar.Text));
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Ingrese un codigo de empleado valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (cmbBusqueda.Text == "RTN")
            {
                try
                {
                    BuscarPorRTN(this.txtBuscar.Text);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Ingrese un codigo de empleado valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (cmbBusqueda.Text == "Nombre de Cliente")
            {
                try
                {
                    BuscarPorCliente(this.txtBuscar.Text);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Ingrese un codigo de empleado valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Buscars the por codigo cot.
        /// </summary>
        /// <param name="cod">The cod.</param>
        public void BuscarPorCodigoCot(int cod)
        {
            try
            {
                BaseDeDatos ba = new BaseDeDatos();
                ba.Conectar();
                SqlCommand com = new SqlCommand("SELECT * FROM VwCotizacion WHERE [Cotizacion] = @cod   ", ba.cone);
                com.Parameters.AddWithValue("@cod", cod);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                vwCotizacionDataGridView.DataSource = dt;
                vwCotizacionBindingSource.DataSource = dt;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Ingrese un nombre correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Buscars the por RTN.
        /// </summary>
        /// <param name="cod">The cod.</param>
        public void BuscarPorRTN(string cod)
        {
            try
            {
                BaseDeDatos ba = new BaseDeDatos();
                ba.Conectar();
                SqlCommand com = new SqlCommand("SELECT * FROM VwCotizacion WHERE [RTN del Cliente] like '%'+@cod+'%'   ", ba.cone);
                com.Parameters.AddWithValue("@cod", cod);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                vwCotizacionDataGridView.DataSource = dt;
                vwCotizacionBindingSource.DataSource = dt;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Ingrese un nombre correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Buscars the por cliente.
        /// </summary>
        /// <param name="nom">The nom.</param>
        public void BuscarPorCliente(string nom)
        {
            try
            {
                BaseDeDatos ba = new BaseDeDatos();
                ba.Conectar();
                SqlCommand com = new SqlCommand("SELECT * FROM VwCotizacion WHERE [Nombre del Cliente] like '%'+@nom+'%'  ", ba.cone);
                com.Parameters.AddWithValue("@nom", nom);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                vwCotizacionDataGridView.DataSource = dt;
                vwCotizacionBindingSource.DataSource = dt;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Ingrese un nombre correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnCancelar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;

        }

        /// <summary>
        /// Handles the Click event of the btnGuardar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            string prod, cant, pre;
            FacturaMetodos fac = new FacturaMetodos();

            if (cmbTipoPago.Text == "")
            {
                MessageBox.Show("Escoja un metodo de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int idpago=0;
                if(cmbTipoPago.Text=="Contado")
                {
                    idpago = 1;
                }
                else
                {
                    idpago = 2;
                }
                fac.AñadirFactura(dateTimePicker1.Value, rTN_del_ClienteTextBox.Text, 0, CompartirDatos.cod, idpago);
                for (int i = 0; i < historialDetalleCotizacionDataGridView.Rows.Count; i++)
                {
                    prod = historialDetalleCotizacionDataGridView.Rows[i].Cells[1].Value.ToString();
                    cant = historialDetalleCotizacionDataGridView.Rows[i].Cells[3].Value.ToString();
                    pre = historialDetalleCotizacionDataGridView.Rows[i].Cells[4].Value.ToString();
                    fac.AñadirDetalle(int.Parse(prod), int.Parse(cant), float.Parse(pre));
                }
                fac.TotalizarFac();

                btnGuardar.Enabled = false;
                btnImprimir.Enabled = true;
            }


        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                int i = 0;
                string sql = null;
                int yPoint = 0;

                int cod = 0;
                string prod = null;
                int cant = 0;
                float prec = 0;
                float sub = 0;
                int coti = 0;
                float acum = 0;

                BaseDeDatos ba = new BaseDeDatos();

                sql = " Select Factura_Cod ,Detalle_Factura.Producto_Cod,Producto_Descripcion,Cantidad,Precio,SUM(Precio*Cantidad) as Subtotal from Detalle_Factura inner join Producto on Detalle_Factura.Producto_Cod=Producto.Producto_Cod where Factura_Cod = (Select MAX(Factura_Cod) from Detalle_Factura) group by Factura_Cod,Detalle_Factura.Producto_Cod,Producto_Descripcion,Cantidad,Precio";
                ba.cone.Open();
                command = new SqlCommand(sql, ba.cone);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                ba.cone.Close();
                string directory = $""; //direccion relativa al projecto presente
                XImage xImagePosterBackground = XImage.FromFile(directory + "tacoma.pdf");
                PdfDocument pdf = new PdfDocument();
                pdf.Info.Title = "FacturaTacoma";

                PdfSharp.Pdf.PdfPage pdfPage = pdf.AddPage();
                XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                graph.DrawImage(xImagePosterBackground, new XPoint(0, 0));
                //XFont font = new XFont("Times", 20, XFontStyle.Bold);
                XFont font1 = new XFont("Times", 12, XFontStyle.Regular);

                yPoint = yPoint + 100;
                coti = int.Parse(ds.Tables[0].Rows[0].ItemArray[0].ToString());
                graph.DrawString("Codigo de Factura: " + coti.ToString(), font1, XBrushes.Black, new XRect(180, 750, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                yPoint = yPoint + 100;
                graph.DrawString(nombre_del_ClienteTextBox.Text, font1, XBrushes.Black, new XRect(180, 240, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);


                graph.DrawString(direccionTextBox.Text, font1, XBrushes.Black, new XRect(180, 270, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                graph.DrawString(telefonoTextBox.Text, font1, XBrushes.Black, new XRect(180, 305, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                graph.DrawString(dateTimePicker1.Text, font1, XBrushes.Black, new XRect(180, 335, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                graph.DrawString(rTN_del_ClienteTextBox.Text, font1, XBrushes.Black, new XRect(180, 365, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                yPoint = yPoint + 185;

                yPoint = yPoint + 50;
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    cod = int.Parse(ds.Tables[0].Rows[i].ItemArray[1].ToString());
                    prod = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    cant = int.Parse(ds.Tables[0].Rows[i].ItemArray[3].ToString());
                    prec = float.Parse(ds.Tables[0].Rows[i].ItemArray[4].ToString());
                    sub = float.Parse(ds.Tables[0].Rows[i].ItemArray[5].ToString());
                    acum = acum + sub;


                    //graph.DrawString(cod.ToString(), font1, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(prod, font1, XBrushes.Black, new XRect(170, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(cant.ToString(), font1, XBrushes.Black, new XRect(140, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(prec.ToString(), font1, XBrushes.Black, new XRect(410, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(sub.ToString(), font1, XBrushes.Black, new XRect(490, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);


                    yPoint = yPoint + 13;
                }
                double totasub = acum / 1.15;


                graph.DrawString(totasub.ToString("N2"), font1, XBrushes.Black, new XRect(478, 625, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                double brute = totasub * 0.15;
                graph.DrawString(brute.ToString("N2"), font1, XBrushes.Black, new XRect(478, 638, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                graph.DrawString(acum.ToString(), font1, XBrushes.Black, new XRect(478, 655, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);




                string pdfFilename = coti.ToString() + "factura.pdf";
                pdf.Save(pdfFilename);
                Process.Start(pdfFilename);
                pdf.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void telefonoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefonoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void cotizacónTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cotizacionTextBox_TextChanged_1(object sender, EventArgs e)
        {
            BuscarPorCodigo(int.Parse(cotizacionTextBox.Text));
        }
    }
}
