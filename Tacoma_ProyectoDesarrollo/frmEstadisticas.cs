// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 12-13-2019
//
// Last Modified By : pepit
// Last Modified On : 12-13-2019
// ***********************************************************************
// <copyright file="frmEstadisticas.cs" company="">
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
//using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Diagnostics;
using PdfDocument = PdfSharp.Pdf.PdfDocument;

namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class frmEstadisticas.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class frmEstadisticas : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="frmEstadisticas"/> class.
        /// </summary>
        public frmEstadisticas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the FrmEstadisticas control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FrmEstadisticas_Load(object sender, EventArgs e)
        {
            lblAñoActual.Text = DateTime.Now.Year.ToString();
            /*Tamaño maximo de los campos*/
            this.txtDesdeProd.MaxLength = 2;
            this.txtHastaProd.MaxLength = 2;
            this.txtDesdeCli.MaxLength = 2;
            this.txtHastaCli.MaxLength = 2;
            this.txtDesdeEmp.MaxLength = 2;
            this.txtHastaEmp.MaxLength = 2;
            //////////////////////////////////
            // TODO: This line of code loads data into the 'tacomaDBDataSet.VwEstadisticaFecha' table. You can move, or remove it, as needed.
            //this.vwEstadisticaFechaTableAdapter.Fill(this.tacomaDBDataSet.VwEstadisticaFecha);
            // TODO: This line of code loads data into the 'tacomaDBDataSet.VwEstadisticaEmpleado' table. You can move, or remove it, as needed.
            tacomaDBDataSet.EnforceConstraints = false;
            //this.vwEstadisticaEmpleadoTableAdapter.Fill(this.tacomaDBDataSet.VwEstadisticaEmpleado);
            CargarEmpleado();
            // TODO: This line of code loads data into the 'tacomaDBDataSet.VwEstadisticaCliente' table. You can move, or remove it, as needed.
            tacomaDBDataSet.EnforceConstraints = false;
            this.vwEstadisticaClienteTableAdapter.Fill(this.tacomaDBDataSet.VwEstadisticaCliente);
            // TODO: This line of code loads data into the 'tacomaDBDataSet.VwEstadisticaProducto' table. You can move, or remove it, as needed.
            tacomaDBDataSet.EnforceConstraints = false;
            this.vwEstadisticaProductoTableAdapter.Fill(this.tacomaDBDataSet.VwEstadisticaProducto);

        }


        /*Estadistica Producto*/
        /// <summary>
        /// Handles the Click event of the BtnBuscarRTN control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnBuscarRTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDesdeProd.Text) || string.IsNullOrEmpty(txtHastaProd.Text) || string.IsNullOrEmpty(txtCodProd.Text))
            {
                
                MessageBox.Show("Campos Vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(int.Parse(txtDesdeProd.Text) <= 0 || int.Parse(txtDesdeProd.Text) > 12 || int.Parse(txtHastaProd.Text) <= 0 || int.Parse(txtHastaProd.Text) > 12)
            {
                MessageBox.Show("Meses entre 1 y 12", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.Parse(txtDesdeProd.Text) > int.Parse(txtHastaProd.Text))
                {
                    MessageBox.Show("Rango no valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        BuscarProd(int.Parse(txtCodProd.Text), int.Parse(txtDesdeProd.Text), int.Parse(txtHastaProd.Text));

                    }
                    catch (System.FormatException)
                    {

                        MessageBox.Show("Ingrese un codigo de producto valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
                
              
            

            
           
        }

        /*public void BuscarFac(int codigo)
        {
            try
            {
                BaseDeDatos ba = new BaseDeDatos();
                ba.Conectar();
                SqlCommand com = new SqlCommand("SELECT * FROM VwEstadisticaProducto where [Factura] = @cod ", ba.cone);
                com.Parameters.AddWithValue("@cod", codigo);

                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.vwEstadisticaProductoDataGridView.DataSource = dt;
                this.vwEstadisticaBindingSource.DataSource = dt;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Ingrese un Codigo correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/
        /// <summary>
        /// Buscars the product.
        /// </summary>
        /// <param name="codigo">The codigo.</param>
        /// <param name="desde">The desde.</param>
        /// <param name="hasta">The hasta.</param>
        public void BuscarProd(int codigo,int desde,int hasta)
        {
            try
            {
                BaseDeDatos ba = new BaseDeDatos();
                ba.Conectar();
                SqlCommand com = new SqlCommand("SELECT * FROM VwEstadisticaProducto where ([Codigo de producto] = @cod) and (month([Fecha]) between @desde and @hasta) ", ba.cone);
                com.Parameters.AddWithValue("@cod", codigo);
                com.Parameters.AddWithValue("@desde", desde);
                com.Parameters.AddWithValue("@hasta", hasta);

                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.vwEstadisticaProductoDataGridView.DataSource = dt;
                this.vwEstadisticaBindingSource.DataSource = dt;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Ingrese un Codigo de producto correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Click event of the RTNLabel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RTNLabel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the TextChanged event of the TxtCodFact control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TxtCodFact_TextChanged(object sender, EventArgs e)
        {
            
        }

        /*Estadistica Cliente*/
        /// <summary>
        /// Handles the Click event of the BtnBuscarCliente control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDesdeCli.Text) || string.IsNullOrEmpty(txtHastaCli.Text) || string.IsNullOrEmpty(txtNombre.Text))
            {

                MessageBox.Show("Campos Vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.Parse(txtDesdeCli.Text) <= 0 || int.Parse(txtDesdeCli.Text) > 12 || int.Parse(txtHastaCli.Text) <= 0 || int.Parse(txtHastaCli.Text) > 12)
            {
                MessageBox.Show("Meses entre 1 y 12", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(int.Parse(txtDesdeCli.Text) > int.Parse(txtHastaCli.Text))
                {
                    MessageBox.Show("Rango no valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        BuscarNombre(this.txtNombre.Text, int.Parse(txtDesdeCli.Text), int.Parse(txtHastaCli.Text));
                    }
                    catch (System.FormatException)
                    {
                        MessageBox.Show("Ingrese un Nombre de cleinte valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }

           
            
        }


        /// <summary>
        /// Buscars the nombre.
        /// </summary>
        /// <param name="nombre">The nombre.</param>
        /// <param name="desde">The desde.</param>
        /// <param name="hasta">The hasta.</param>
        public void BuscarNombre(string nombre,int desde,int hasta)
        {
            try
            {
                BaseDeDatos ba = new BaseDeDatos();
                ba.Conectar();
                SqlCommand com = new SqlCommand("SELECT * FROM VwEstadisticaCliente where ([Nombre] = @nombre) and (month([Fecha]) between @desde and @hasta) ", ba.cone);
                com.Parameters.AddWithValue("@nombre", nombre);
                com.Parameters.AddWithValue("@desde", desde);
                com.Parameters.AddWithValue("@hasta", hasta);

                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.vwEstadisticaClienteDataGridView.DataSource = dt;
                this.vwEstadisticaClienteBindingSource.DataSource = dt;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Ingrese un Nombre correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }








        /// <summary>
        /// Handles the TextChanged event of the TxtRTN control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TxtRTN_TextChanged(object sender, EventArgs e)
        {
            
        }


        /*Estadistica Empleado*/
        /// <summary>
        /// Handles the Click event of the BtnBuscarEmpleado control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDesdeEmp.Text) || string.IsNullOrEmpty(txtHastaEmp.Text) || string.IsNullOrEmpty(txtNomEmp.Text))
            {

                MessageBox.Show("Campos Vacios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.Parse(txtDesdeEmp.Text) <= 0 || int.Parse(txtDesdeEmp.Text) > 12 || int.Parse(txtHastaEmp.Text) <= 0 || int.Parse(txtHastaEmp.Text) > 12)
            {
                MessageBox.Show("Meses entre 1 y 12", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (int.Parse(txtDesdeEmp.Text) > int.Parse(txtHastaEmp.Text))
                {
                    MessageBox.Show("Rango no valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {

                        BuscarNombreEmple(Convert.ToString(txtNomEmp.Text), int.Parse(txtDesdeEmp.Text), int.Parse(txtHastaEmp.Text));
                    }
                    catch (System.FormatException)
                    {
                        MessageBox.Show("Ingrese un Nombre de empleado valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
                

        }
        /// <summary>
        /// Buscars the nombre emple.
        /// </summary>
        /// <param name="codigo">The codigo.</param>
        /// <param name="desde">The desde.</param>
        /// <param name="hasta">The hasta.</param>
        public void BuscarNombreEmple(string nombre,int desde, int hasta)
        {
            try
            {
                BaseDeDatos ba = new BaseDeDatos();
                ba.Conectar();
                SqlCommand com = new SqlCommand("SELECT * FROM VwEstadisticaEmpleado where ([Nombre] like '%" +@nombre+ "%') and (month([Fecha]) between @desde and @hasta)", ba.cone);
                com.Parameters.AddWithValue("@nombre", nombre);
                com.Parameters.AddWithValue("@desde", desde);
                com.Parameters.AddWithValue("@hasta", hasta);

                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.vwEstadisticaEmpleadoDataGridView.DataSource = dt;
                this.vwEstadisticaEmpleadoBindingSource.DataSource = dt;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Ingrese un Nombre correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarEmpleado()
        {
            BaseDeDatos ba = new BaseDeDatos();
            ba.Conectar();
            SqlCommand com = new SqlCommand("SELECT * FROM VwEstadisticaEmpleado", ba.cone);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.vwEstadisticaEmpleadoDataGridView.DataSource = dt;
            this.vwEstadisticaEmpleadoBindingSource.DataSource = dt;
        }

        /// <summary>
        /// Handles the KeyPress event of the TxtNombre control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) )
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the TextChanged event of the TxtnombreEmp control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TxtnombreEmp_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the KeyPress event of the TxtnombreEmp control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TxtnombreEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) )
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the KeyPress event of the TxtCodFact control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TxtCodFact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the Click event of the TabPage1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the TextChanged event of the TxtCodProd control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TxtCodProd_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the KeyPress event of the TxtCodProd control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TxtCodProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }





        /// <summary>
        /// Handles the KeyPress event of the TxtFecha control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TxtFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the KeyPress event of the TxtCodigoEmp control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TxtCodigoEmp_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the KeyPress event of the TxtDesdeEmp control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TxtDesdeEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the KeyPress event of the TxtHastaEmp control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TxtHastaEmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the KeyPress event of the TxtDesdeProd control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TxtDesdeProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the KeyPress event of the TxtHastaProd control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TxtHastaProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the KeyPress event of the TxtDesdeCli control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TxtDesdeCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the KeyPress event of the TxtHastaCli control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TxtHastaCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the TextChanged event of the TxtDesdeProd control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TxtDesdeProd_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the LblAñoActual control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void LblAñoActual_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button1_Click(object sender, EventArgs e)
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
                string prec = null;


               
                sql = "SELECT * FROM VwEstadisticaProducto where([Codigo de producto] = " + int.Parse(txtCodProd.Text) + ") and(month([Fecha]) between " + int.Parse(txtDesdeProd.Text) + " and " + int.Parse(txtHastaProd.Text) + ") ";

               
                ba.cone.Open();
                command = new SqlCommand(sql, ba.cone);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                ba.cone.Close();

                PdfDocument pdf = new PdfDocument();
                pdf.Info.Title = "Estadistica Producto";


                PdfSharp.Pdf.PdfPage pdfPage = pdf.AddPage();
                //string directory = @"C:\Users\pepit\Desktop\Tacoma_ProyectoDesarrollo (1)\Tacoma_ProyectoDesarrollo\Tacoma_ProyectoDesarrollo\bin\Debug\";

                XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                XFont font = new XFont("Verdana", 13, XFontStyle.Regular);
                XFont font1 = new XFont("Verdana", 30, XFontStyle.Bold);

                graph.DrawString("Estadistica de Producto", font1, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                yPoint = yPoint + 100;
                graph.DrawString("No.", font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                graph.DrawString("Producto", font, XBrushes.Black, new XRect(80, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                graph.DrawString("Cantidad", font, XBrushes.Black, new XRect(300, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                graph.DrawString("Fecha", font, XBrushes.Black, new XRect(400, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                yPoint = yPoint + 50;
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {


                    cod = int.Parse(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                    prod = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    cant = int.Parse(ds.Tables[0].Rows[i].ItemArray[2].ToString());
                    prec = ds.Tables[0].Rows[i].ItemArray[3].ToString();





                    graph.DrawString(cod.ToString(), font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(prod, font, XBrushes.Black, new XRect(80, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(cant.ToString(), font, XBrushes.Black, new XRect(300, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(prec.ToString(), font, XBrushes.Black, new XRect(400, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    //graph.DrawString(sub.ToString(), font, XBrushes.Black, new XRect(520, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    yPoint = yPoint + 40;


                }




                string pdfFilename = "ReporteProducto.pdf";
                pdf.Save(pdfFilename);
                Process.Start(pdfFilename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                BaseDeDatos ba = new BaseDeDatos();
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet ds = new DataSet();
                int i = 0;
                string sql = null;
                int yPoint = 0;

                string rtn = null;
                string nom;
                int cant = 0;
                float totc = 0;
                string fech = null;



                
                sql = "SELECT * FROM VwEstadisticaCliente where([Nombre] like '"+txtNombre.Text+"') and(month([Fecha]) between " + int.Parse(txtDesdeCli.Text) + " and " + int.Parse(txtHastaCli.Text) + ")";

                ba.cone.Open();
                command = new SqlCommand(sql, ba.cone);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                ba.cone.Close();

                PdfDocument pdf = new PdfDocument();
                pdf.Info.Title = "Estadistica Cliente";


                PdfSharp.Pdf.PdfPage pdfPage = pdf.AddPage();
                XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                XFont font = new XFont("Verdana", 13, XFontStyle.Regular);
                XFont font1 = new XFont("Verdana", 30, XFontStyle.Bold);

                graph.DrawString("Estadistica de Cliente", font1, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                yPoint = yPoint + 100;
                graph.DrawString("R.T.N.", font, XBrushes.Black, new XRect(30, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                graph.DrawString("Cliente", font, XBrushes.Black, new XRect(160, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                graph.DrawString("Cantidad", font, XBrushes.Black, new XRect(280, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                graph.DrawString("Total", font, XBrushes.Black, new XRect(350, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                graph.DrawString("Fecha", font, XBrushes.Black, new XRect(420, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                yPoint = yPoint + 50;
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {


                    rtn = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    nom = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    cant = int.Parse(ds.Tables[0].Rows[i].ItemArray[2].ToString());
                    totc = float.Parse(ds.Tables[0].Rows[i].ItemArray[3].ToString());
                    fech = ds.Tables[0].Rows[i].ItemArray[4].ToString();






                    graph.DrawString(rtn, font, XBrushes.Black, new XRect(30, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(nom, font, XBrushes.Black, new XRect(160, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(cant.ToString(), font, XBrushes.Black, new XRect(320, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(totc.ToString(), font, XBrushes.Black, new XRect(350, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(fech.ToString(), font, XBrushes.Black, new XRect(420, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    yPoint = yPoint + 40;


                }




                string pdfFilename = "ReporteCliente.pdf";
                pdf.Save(pdfFilename);
                Process.Start(pdfFilename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Handles the Click event of the button3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button3_Click(object sender, EventArgs e)
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

                int codigo = 0;
                string nom = null;
                int cant = 0;
                float venta = 0;
                string fech = null;
                


                
                sql = "SELECT* FROM VwEstadisticaEmpleado where([Codigo]= "+txtNomEmp.Text+") and(month([Fecha]) between "+int.Parse(txtDesdeEmp.Text)+" and "+int.Parse(txtHastaEmp.Text)+")";
                ba.cone.Open();
                command = new SqlCommand(sql, ba.cone);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                ba.cone.Close();

                PdfDocument pdf = new PdfDocument();
                pdf.Info.Title = "Estadistica Producto";


                PdfSharp.Pdf.PdfPage pdfPage = pdf.AddPage();
                //string directory = @"C:\Users\Jelsy\Desktop\Tacoma_ProyectoDesarrollo (1)\Tacoma_ProyectoDesarrollo\Tacoma_ProyectoDesarrollo\bin\Debug\";

                XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                XFont font = new XFont("Verdana", 13, XFontStyle.Regular);
                XFont font1 = new XFont("Verdana", 30, XFontStyle.Bold);

                graph.DrawString("Estadistica de Empleado", font1, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                yPoint = yPoint + 100;
                graph.DrawString("Codigo", font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                graph.DrawString("Nombre", font, XBrushes.Black, new XRect(100, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                graph.DrawString("Cantidad", font, XBrushes.Black, new XRect(250, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                graph.DrawString("Venta", font, XBrushes.Black, new XRect(350, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
                graph.DrawString("Fecha", font, XBrushes.Black, new XRect(430, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                yPoint = yPoint + 50;
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {


                    codigo = int.Parse(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                    nom = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    cant = int.Parse(ds.Tables[0].Rows[i].ItemArray[2].ToString());
                    venta = float.Parse(ds.Tables[0].Rows[i].ItemArray[3].ToString());
                    fech= ds.Tables[0].Rows[i].ItemArray[4].ToString();





                    graph.DrawString(codigo.ToString(), font, XBrushes.Black, new XRect(40, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(nom, font, XBrushes.Black, new XRect(100, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(cant.ToString(), font, XBrushes.Black, new XRect(280, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(venta.ToString(), font, XBrushes.Black, new XRect(350, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(fech, font, XBrushes.Black, new XRect(430, yPoint, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

                    yPoint = yPoint + 40;


                }




                string pdfFilename = "ReporteProducto.pdf";
                pdf.Save(pdfFilename);
                Process.Start(pdfFilename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
    }
