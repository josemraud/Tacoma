// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 12-13-2019
//
// Last Modified By : pepit
// Last Modified On : 12-13-2019
// ***********************************************************************
// <copyright file="Facturacion.cs" company="">
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
    /// Class Facturacion.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Facturacion : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Facturacion"/> class.
        /// </summary>
        public Facturacion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the Facturacion control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Facturacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.VwDetalleFactura' Puede moverla o quitarla según sea necesario.
            //this.vwDetalleFacturaTableAdapter.Fill(this.tacomaDBDataSet.VwDetalleFactura);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.Detalle_Factura' Puede moverla o quitarla según sea necesario.
           // this.detalle_FacturaTableAdapter.Fill(this.tacomaDBDataSet.Detalle_Factura);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.VwProductos' Puede moverla o quitarla según sea necesario.
           // this.vwProductosTableAdapter.Fill(this.tacomaDBDataSet.VwProductos);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.TipoDePago' Puede moverla o quitarla según sea necesario.
           // this.tipoDePagoTableAdapter.Fill(this.tacomaDBDataSet.TipoDePago);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.Factura' Puede moverla o quitarla según sea necesario.
            //this.facturaTableAdapter.Fill(this.tacomaDBDataSet.Factura);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.VwCliente' Puede moverla o quitarla según sea necesario.
            //this.vwClienteTableAdapter.Fill(this.tacomaDBDataSet.VwCliente);
           
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
                errorRTN.SetError(rTNTextBox, "Campo invalido");
                MessageBox.Show("Ingrese un RTN válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
               
                try
                {
                    cmbTipoPago.Enabled = true;
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
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Ingrese un RTN correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnNuevaFac control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnNuevaFac_Click(object sender, EventArgs e)
        {
            int idpago = 0;
            string codE = "";
            codE = CompartirDatos.cod;
            if (rTNTextBox.TextLength < 14 || rTNTextBox.TextLength > 14)
            {
                errorRTN.SetError(rTNTextBox, "Campo invalido");
                MessageBox.Show("Ingrese un RTN correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            { 
                if (cmbTipoPago.Text == "Contado")
                {
                    idpago = 1;
                }
                else
                {
                    idpago = 2;
                }
                producto_CodTextBox.Enabled = true;
                btnBuscarProd.Enabled = true;
                this.CargarFactura();
                this.facturaBindingSource.AddNew();
                FacturaMetodos fac = new FacturaMetodos();
                
                fac.AñadirFactura(this.factura_FechaDateTimePicker.Value, this.rTNTextBox.Text, 0, codE, idpago);
                rTNTextBox.Enabled = false;
                factura_FechaDateTimePicker.Enabled = false;
                btnBuscarRTN.Enabled = false;
                cmbTipoPago.Enabled = false;
                btnNuevaFac.Enabled = false;
                producto_CodTextBox.Enabled = true;
                btnBuscarProd.Enabled = true;
                cantidadTextBox.Enabled = false;
                producto_CodTextBox.Focus();
                nombreTextBox.Enabled = false;
                btnBuscarClienteNom.Enabled = false;
                descripcionTextBox.Enabled = false;
                //btnBuscarDesc.Enabled = true;
            }
        }
        /// <summary>
        /// Cargars the factura.
        /// </summary>
        public void CargarFactura()
        {
            BaseDeDatos ba = new BaseDeDatos();
            ba.Conectar();
            SqlCommand com = new SqlCommand("SELECT * FROM Factura", ba.cone);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            facturaBindingSource.DataSource = dt;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the cmbTipoPago control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cmbTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnNuevaFac.Enabled = true;
        }

        /// <summary>
        /// Handles the Click event of the btnBuscarProd control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarPorCodigoProd(int.Parse(this.producto_CodTextBox.Text));
                this.btnAñadir.Enabled = true;
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
                SqlCommand com = new SqlCommand("SELECT * FROM VwProductos WHERE [Codigo de Producto] = @cod   ", ba.cone);
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
        /// Handles the Click event of the btnAñadir control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            FacturaMetodos fac = new FacturaMetodos();
            fac.Validar_FacturaProducto(int.Parse(producto_CodTextBox.Text));
            int cod = 0, cant = 0;
            if (cantidadTextBox.Text=="" || cantidadTextBox.Text=="0")
            {
                errorCant.SetError(cantidadTextBox, "No valido");
                MessageBox.Show(null, "Campo Obligatorio", "ERROR" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if(descripcionTextBox.Text=="")
            {
                MessageBox.Show(null, "Producto No existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (CompartirDatos.codVFP == 0)
            {
                MessageBox.Show(null, "El producto ya fue ingresado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                float pre = 0;
                double tot = 0;
                btnAñadir.Enabled = false;
                cantidadTextBox.Enabled = false;
                cod = int.Parse(producto_CodTextBox.Text);
                cant = int.Parse(cantidadTextBox.Text);
                pre = float.Parse(precio_UnitarioTextBox.Text);

                this.CargarDetalle();
                this.detalle_FacturaBindingSource.AddNew();
                fac.AñadirDetalle(cod, cant, pre);
                this.CargarDetalle();
                btnFinalizar.Enabled = true;
                btnCancelarFac.Enabled = true;
                btnImprimir.Enabled = true;
                btnEliminar.Enabled = true;
                tot = float.Parse(cantidadTextBox.Text) * float.Parse(precio_UnitarioTextBox.Text);
                dgvDetalle.Rows.Add(cod, descripcionTextBox.Text, precio_UnitarioTextBox.Text, cantidadTextBox.Text, tot);
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
            SqlCommand com = new SqlCommand("SELECT * FROM Detalle_Factura", ba.cone);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.detalle_FacturaBindingSource.DataSource = dt;
        }

        /// <summary>
        /// Handles the TextChanged event of the rTNTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void rTNTextBox_TextChanged(object sender, EventArgs e)
        {
            errorRTN.Clear();
        }

        /// <summary>
        /// Handles the KeyPress event of the rTNTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void rTNTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
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
        /// Handles the KeyPress event of the producto_CodTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void producto_CodTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the KeyPress event of the cantidadTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void cantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
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
        /// Handles the Click event of the btnFinalizar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            cmbTipoPago.Text = "";
            btnBuscarClienteNom.Enabled = true;
            nombreTextBox.Enabled = true;
            //btnBuscarDesc.Enabled = false;
            descripcionTextBox.Enabled = false;
            btnEliminar.Enabled = false;
            cantidadTextBox.Text = "";
            btnBuscarRTN.Enabled = true;
            rTNTextBox.Clear();
            nombreTextBox.Clear();
            direcciónTextBox.Clear();
            telefonoTextBox.Clear();
            ciudadTextBox.Clear();
            paisTextBox.Clear();
            btnNuevaFac.Enabled = false;
            btnBuscarProd.Enabled = true;
            rTNTextBox.Enabled = true;
            btnBuscarProd.Enabled = false;
            producto_CodTextBox.Enabled = false;
            cantidadTextBox.Enabled = false;
            btnFinalizar.Enabled = false;
            btnImprimir.Enabled = false;
            btnCancelarFac.Enabled = false;
            dgvDetalle.Rows.Clear();
            FacturaMetodos fac = new FacturaMetodos();
            fac.TotalizarFac();
        }

        /// <summary>
        /// Handles the Click event of the btnEliminar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FacturaMetodos fac = new FacturaMetodos();
            fac.EliminarDetalleFac(int.Parse(dgvDetalle.CurrentRow.Cells[0].Value.ToString()), int.Parse(dgvDetalle.CurrentRow.Cells[3].Value.ToString()), float.Parse(dgvDetalle.CurrentRow.Cells[2].Value.ToString()));
            dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow);
            if(dgvDetalle.Rows.Count > 0)
            {
                btnEliminar.Enabled = true;
                btnFinalizar.Enabled = true;
                btnImprimir.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
                btnFinalizar.Enabled = false;
                btnImprimir.Enabled = false;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnCancelarFac control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnCancelarFac_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Handles the TextChanged event of the cantidadTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cantidadTextBox_TextChanged(object sender, EventArgs e)
        {
            errorCant.Clear();
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
        /// Handles the Click event of the btnBuscarClienteNom control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnBuscarClienteNom_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text == "")
            {
                errorNombre.SetError(nombreTextBox, "Ingrese un nombre válido");
                MessageBox.Show("Debe ingresar nombre de cliente valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                
                try
                {
                    cmbTipoPago.Enabled = true;
                    BuscarPorNombre(this.nombreTextBox.Text);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Ingrese un nombre valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
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
        /// Handles the Click event of the btnBuscarDesc control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnBuscarDesc_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarPorNombreProd(this.descripcionTextBox.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Ingrese un nombre valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        /// <summary>
        /// Buscars the por nombre product.
        /// </summary>
        /// <param name="nom">The nom.</param>
        public void BuscarPorNombreProd(String nom)
        {
            BaseDeDatos ba = new BaseDeDatos();
            ba.Conectar();
            try
            {


                SqlCommand com = new SqlCommand("SELECT * FROM VwProductos WHERE [Descripcion] like '%'+ @nom +'%'   ", ba.cone);
                com.Parameters.AddWithValue("@nom", nom);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.vwProductosDataGridView.DataSource = dt;
                this.vwProductosBindingSource.DataSource = dt;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Debe ingresar nombre de cliente valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnImprimir control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
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

                int cod = 0;
                string prod = null;
                int cant = 0;
                float prec = 0;
                float sub = 0;
                int coti = 0;
                float acum = 0;

                
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
                graph.DrawString(nombreTextBox.Text, font1, XBrushes.Black, new XRect(180, 240, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);


                graph.DrawString(direcciónTextBox.Text, font1, XBrushes.Black, new XRect(180, 270, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                graph.DrawString(telefonoTextBox.Text, font1, XBrushes.Black, new XRect(180, 305, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                graph.DrawString(factura_FechaDateTimePicker.Text, font1, XBrushes.Black, new XRect(180, 335, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                graph.DrawString(rTNTextBox.Text, font1, XBrushes.Black, new XRect(180, 365, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

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

                    graph.DrawString(cant.ToString(), font1, XBrushes.Black, new XRect(120, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(prec.ToString(), font1, XBrushes.Black, new XRect(410, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(sub.ToString(), font1, XBrushes.Black, new XRect(490, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);


                    yPoint = yPoint + 13;
                }
                double totasub = acum / 1.15;


                graph.DrawString(totasub.ToString("N2"), font1, XBrushes.Black, new XRect(468, 625, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                double brute = totasub * 0.15;
                graph.DrawString(brute.ToString("N2"), font1, XBrushes.Black, new XRect(468, 638, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                graph.DrawString(acum.ToString(), font1, XBrushes.Black, new XRect(468, 655, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);




                string pdfFilename = coti.ToString() + "factura.pdf";
                pdf.Save(pdfFilename);
                Process.Start(pdfFilename);
                pdf.Close();
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
            cmbTipoPago.Text = "";
            btnBuscarClienteNom.Enabled = true;
            nombreTextBox.Enabled = true;
            //btnBuscarDesc.Enabled = false;
            descripcionTextBox.Enabled = false;
            btnEliminar.Enabled = false;
            cantidadTextBox.Text = "";
            btnBuscarRTN.Enabled = true;
            btnNuevaFac.Enabled = false;
            btnBuscarProd.Enabled = true;
            rTNTextBox.Enabled = true;
            btnBuscarProd.Enabled = false;
            producto_CodTextBox.Enabled = false;
            cantidadTextBox.Enabled = false;
            btnFinalizar.Enabled = false;
            btnImprimir.Enabled = true;
            btnCancelarFac.Enabled = false;
            FacturaMetodos fac = new FacturaMetodos();
            fac.TotalizarFac();
        }

        private void btnCancelarFac_Click_1(object sender, EventArgs e)
        {
            cmbTipoPago.Text = "";
            dgvDetalle.Rows.Clear();
            FacturaMetodos fac = new FacturaMetodos();
            fac.EliminarFactura();
            cantidadTextBox.Text = "";
            btnBuscarRTN.Enabled = true;
            rTNTextBox.Clear();
            nombreTextBox.Clear();
            direcciónTextBox.Clear();
            telefonoTextBox.Clear();
            ciudadTextBox.Clear();
            paisTextBox.Clear();
            btnNuevaFac.Enabled = false;
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
            //btnBuscarDesc.Enabled = false;
            descripcionTextBox.Enabled = false;
        }
    }
}
