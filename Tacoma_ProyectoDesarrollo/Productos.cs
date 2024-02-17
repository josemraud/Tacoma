// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 11-24-2019
//
// Last Modified By : pepit
// Last Modified On : 12-11-2019
// ***********************************************************************
// <copyright file="Productos.cs" company="">
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
using System.Globalization;

namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class Productos.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Productos : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Productos"/> class.
        /// </summary>
        public Productos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the Productos control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Productos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.VwProductos' Puede moverla o quitarla según sea necesario.
            this.vwProductosTableAdapter.Fill(this.tacomaDBDataSet.VwProductos);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.Estado' Puede moverla o quitarla según sea necesario.
            this.estadoTableAdapter.Fill(this.tacomaDBDataSet.Estado);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.Estado' Puede moverla o quitarla según sea necesario.
            // this.estadoTableAdapter.Fill(this.tacomaDBDataSet.Estado);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.VwProductos' Puede moverla o quitarla según sea necesario.
            // this.vwProductosTableAdapter.Fill(this.tacomaDBDataSet.VwProductos);
            this.CargarSubCategoria();
            this.CargarData();

            if(codigo_de_ProductoTextBox.Text == "")
            {
                btnModificar.Enabled = false; 
            }
            else
            {
                btnModificar.Enabled = true;    
            }
        }
        /// <summary>
        /// Cargars the sub categoria.
        /// </summary>
        public void CargarSubCategoria()
        {
            BaseDeDatos ba = new BaseDeDatos();
            ba.Conectar();
            SqlCommand com = new SqlCommand("SELECT Subcategoria_ID, Subcategoria_Descripcion FROM Producto_Subcategoria WHERE Categoria_ID = 2", ba.cone);

            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);

            subcategoriaComboBox.ValueMember = "Subcategoria_ID";
            subcategoriaComboBox.DisplayMember = "Subcategoria_Descripcion";
            subcategoriaComboBox.DataSource = dt;

        }
        /// <summary>
        /// Cargars the data.
        /// </summary>
        public void CargarData()
        {
            BaseDeDatos ba = new BaseDeDatos();
            ba.Conectar();
            SqlCommand com = new SqlCommand("SELECT * FROM VwProductos", ba.cone);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            vwProductosDataGridView.DataSource = dt;
            vwProductosBindingSource.DataSource = dt;
        }
        /// <summary>
        /// Handles the Paint event of the Panel1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
       

        /// <summary>
        /// Handles the Click event of the BtnAñadir control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            this.CargarData();
            this.vwProductosBindingSource.AddNew();
            btnAñadir.Enabled = false;
            btnAceptar.Enabled = true;
            panel1.Enabled = true;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            this.descripcionTextBox.Clear();
            this.precio_UnitarioTextBox.Clear();
            vwProductosDataGridView.Enabled = true;
        }

        /// <summary>
        /// Handles the Click event of the BtnAceptar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            ProductosMetodos pm = new ProductosMetodos();
            pm.ValidarProducto(descripcionTextBox.Text);

            if (this.descripcionTextBox.Text == "")
            {
                errorDescrip.SetError(descripcionTextBox, "Campo Obligatorio.");
            }
            if (this.precio_UnitarioTextBox.Text == "" || precio_UnitarioTextBox.Text.StartsWith("0"))
            {
                errorPrecio.SetError(precio_UnitarioTextBox, "Campo Obligatorio");
            }
            if (this.subcategoriaComboBox.Text == "")
            {
                errorSubcategoria.SetError(subcategoriaComboBox, "Campo Obligatorio");
            }
            if (this.estadoComboBox.Text == "")
            {
                errorEstado.SetError(estadoComboBox, "Campo Obligatorio.");
            }

            if (descripcionTextBox.Text.StartsWith(" "))
            {
                MessageBox.Show("No puede comenzar con espacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.descripcionTextBox.TextLength < 5)
            {
                MessageBox.Show("Debe tener mas de 5 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CompartirDatos.codPro == 1)
            {
                MessageBox.Show("El producto " + descripcionTextBox.Text + " ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(this.descripcionTextBox.Text == ""|| this.precio_UnitarioTextBox.Text == ""||
                this.subcategoriaComboBox.Text == ""|| this.estadoComboBox.Text == "")
            {
                MessageBox.Show("Campos incompletos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double precio = Convert.ToDouble(precio_UnitarioTextBox.Text);
                double precior = Math.Round(precio, 2, MidpointRounding.AwayFromZero);

                ProductosMetodos pro = new ProductosMetodos();
                pro.AñadirProducto(this.descripcionTextBox.Text,
                    (decimal)decimal.Parse(precio_UnitarioTextBox.Text),
                    int.Parse(subcategoriaComboBox.SelectedValue.ToString()), int.Parse(this.estadoComboBox.SelectedValue.ToString()));

                this.vwProductosDataGridView.Refresh();
                this.CargarData();
                btnAñadir.Enabled = true;
                btnModificar.Enabled = true;
                btnAceptar.Enabled = false;
                btnCancelar.Enabled = false;
                panel1.Enabled = false;
            }
           
        }

        /// <summary>
        /// Handles the Click event of the BtnModificar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// 
        static string nombre;
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnAñadir.Enabled = false;
            btnguardar.Enabled = true;
            btnAceptar.Enabled = false;
            btnCancelar.Enabled = true;
            panel1.Enabled = true;
            nombre = descripcionTextBox.Text;
            label2.Text = nombre;
        }

        /// <summary>
        /// Handles the Click event of the Btnguardar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Btnguardar_Click(object sender, EventArgs e)
        {
            ProductosMetodos pm = new ProductosMetodos();
            pm.ProductoModificar(descripcionTextBox.Text);

            if (this.descripcionTextBox.Text == "")
            {
                errorDescrip.SetError(descripcionTextBox, "Campo Obligatorio.");
            }
            if (this.precio_UnitarioTextBox.Text == "" || precio_UnitarioTextBox.Text.StartsWith("0"))
            {
                errorPrecio.SetError(precio_UnitarioTextBox, "Campo Obligatorio");
            }

            if (descripcionTextBox.Text != label2.Text) 
            {
                if (CompartirDatos.sumPro >= 1)
                {
                    MessageBox.Show("El producto " + descripcionTextBox.Text + " ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (descripcionTextBox.Text.StartsWith(" "))
                {
                    MessageBox.Show("No puede comenzar con espacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (this.descripcionTextBox.TextLength < 5)
                {
                    MessageBox.Show("Debe tener mas de 5 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (this.descripcionTextBox.Text == "" || this.precio_UnitarioTextBox.Text == "")
                {
                    MessageBox.Show("Campos Incompletos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            if (descripcionTextBox.Text.StartsWith(" "))
            {
                MessageBox.Show("No puede comenzar con espacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.descripcionTextBox.TextLength < 5)
            {
                MessageBox.Show("Debe tener mas de 5 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.descripcionTextBox.Text == "" || this.precio_UnitarioTextBox.Text == "")
            {
                MessageBox.Show("Campos Incompletos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ProductosMetodos pro = new ProductosMetodos();
                pro.ActualizarProducto(int.Parse(this.codigo_de_ProductoTextBox.Text), this.descripcionTextBox.Text,
                    (decimal)decimal.Parse(precio_UnitarioTextBox.Text),
                    int.Parse(subcategoriaComboBox.SelectedValue.ToString()), int.Parse(this.estadoComboBox.SelectedValue.ToString()));

                this.vwProductosDataGridView.Refresh();
                this.CargarData();
                btnAñadir.Enabled = true;
                btnModificar.Enabled = true;
                btnAceptar.Enabled = false;
                btnCancelar.Enabled = false;
                panel1.Enabled = false;
                btnguardar.Enabled = false;
            }
           
        }

        /// <summary>
        /// Handles the CellClick event of the VwProductosDataGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void VwProductosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            this.codigo_de_ProductoTextBox.Text = vwProductosDataGridView.CurrentRow.Cells[0].Value.ToString();
            this.descripcionTextBox.Text = vwProductosDataGridView.CurrentRow.Cells[1].Value.ToString();
            this.precio_UnitarioTextBox.Text = vwProductosDataGridView.CurrentRow.Cells[2].Value.ToString();
            this.subcategoriaComboBox.Text = vwProductosDataGridView.CurrentRow.Cells[3].Value.ToString();
            this.estadoComboBox.Text = vwProductosDataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        /// <summary>
        /// Handles the Click event of the BtnCancelar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.vwProductosBindingSource1.CancelEdit();
            this.CargarData();
            btnAceptar.Enabled = false;
            btnAñadir.Enabled = true;
            btnguardar.Enabled = false;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = false;
            panel1.Enabled = false;
            this.codigo_de_ProductoTextBox.Clear();
            this.descripcionTextBox.Clear();
            this.precio_UnitarioTextBox.Clear();
            this.subcategoriaComboBox.Text = "";
            this.estadoComboBox.Text = "";
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the CmbBusqueda control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CmbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbBusqueda.Text == "Todos los productos")
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
        /// Handles the Click event of the BtnBuscar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbBusqueda.Text == "Codigo")
            {
                try
                {
                    BuscarPorCodigo(int.Parse(this.txtBuscar.Text));
                    this.btnAñadir.Enabled = false;
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Ingrese un codigo de producto valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

            if (cmbBusqueda.Text == "Nombre")
            {
                try
                {
                    BuscarPorNombre(this.txtBuscar.Text);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Ingrese un nombre valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
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
        /// Buscars the por nombre.
        /// </summary>
        /// <param name="nom">The nom.</param>
        public void BuscarPorNombre(String nom)
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
        /// Handles the TextChanged event of the DescripcionTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DescripcionTextBox_TextChanged(object sender, EventArgs e)
        {
            errorDescrip.Clear();
        }

        /// <summary>
        /// Handles the TextChanged event of the Precio_UnitarioTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Precio_UnitarioTextBox_TextChanged(object sender, EventArgs e)
        {
            errorPrecio.Clear();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the SubcategoriaComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SubcategoriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorSubcategoria.Clear();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the EstadoComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void EstadoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorEstado.Clear();
        }

        /// <summary>
        /// Handles the KeyPress event of the DescripcionTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void DescripcionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the KeyPress event of the Precio_UnitarioTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void Precio_UnitarioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the KeyPress event of the TxtBuscar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.cmbBusqueda.Text == "Codigo")
            {
                if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    e.Handled = true;
            }
            else
            {

                if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void precio_UnitarioLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
