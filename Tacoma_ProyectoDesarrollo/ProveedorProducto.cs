// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 12-04-2019
//
// Last Modified By : pepit
// Last Modified On : 12-05-2019
// ***********************************************************************
// <copyright file="ProveedorProducto.cs" company="">
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
    /// Class ProveedorProducto.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class ProveedorProducto : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProveedorProducto"/> class.
        /// </summary>
        public ProveedorProducto()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the ProveedorProducto control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ProveedorProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.tacomaDBDataSet.Producto);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.tacomaDBDataSet.Proveedores);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.VwProveedorProducto' Puede moverla o quitarla según sea necesario.
            this.vwProveedorProductoTableAdapter.Fill(this.tacomaDBDataSet.VwProveedorProducto);
            CargarData();
            CargarCombo();
            panel1.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        /// <summary>
        /// Cargars the data.
        /// </summary>
        public void CargarData()
        {
            BaseDeDatos ba = new BaseDeDatos();
            ba.Conectar();
            SqlCommand com = new SqlCommand("SELECT * FROM VwProveedorProducto", ba.cone);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            vwProveedorProductoDataGridView.DataSource = dt;
            vwProveedorProductoBindingSource.DataSource = dt;
        }

        /// <summary>
        /// Cargars the combo.
        /// </summary>
        public void CargarCombo()
        {
            BaseDeDatos ba = new BaseDeDatos();
            ba.Conectar();
            SqlCommand com = new SqlCommand("select a.Producto_Cod, a.Producto_Descripcion from Producto a join Producto_Subcategoria b" +
                " on a.Subcategoria_ID = b.Subcategoria_ID where b.Categoria_ID = @cat", ba.cone);
            com.Parameters.AddWithValue("@cat", 1);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbProducto.ValueMember = "a.Producto_Cod";
            cmbProducto.DisplayMember = "a.Producto_Descripcion";
            cmbProducto.DataSource = dt;

        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the cmbProveedores control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cmbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the btnAñadir control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            this.CargarData();
            this.vwProveedorProductoBindingSource.AddNew();
            btnAñadir.Enabled = false;
            btnGuardar.Enabled = true;
            panel1.Enabled = true;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = true;
            vwProveedorProductoDataGridView.Enabled = true;
        }

        /// <summary>
        /// Añadirs the empleado.
        /// </summary>
        /// <param name="codProv">The cod prov.</param>
        /// <param name="codProc">The cod proc.</param>
        public void AñadirEmpleado(int codProv, int codProc)
        {
            BaseDeDatos ba = new BaseDeDatos();
            ba.Conectar();
            SqlCommand com = new SqlCommand("Añadir_ProveedorProducto", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@codProv", codProv);
            com.Parameters.AddWithValue("@codProc", codProc);
            com.ExecuteNonQuery();
            ba.Cerrar();
        }

        /// <summary>
        /// Handles the Click event of the btnGuardar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int cod;

            BaseDeDatos ba = new BaseDeDatos();
            ba.Conectar();
            SqlCommand cmd = new SqlCommand("Validar_ProvProd", ba.cone);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codProv", (int)this.cmbProveedores.SelectedValue);
            cmd.Parameters.AddWithValue("@codProc", (int)this.cmbProducto.SelectedValue);
            SqlParameter cod1 = new SqlParameter("@cod", DbType.Int32);
            cod1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(cod1);

            cmd.ExecuteScalar();

            cod = Convert.ToInt32(cmd.Parameters["@cod"].Value);

            ba.Cerrar();


            if (cod == 0)
            {
                MessageBox.Show("El proveedor " + cmbProveedores.Text + " ya nos distribuye el prodcuto " + cmbProducto.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            if(cod == 1)
            {
                AñadirEmpleado((int)this.cmbProveedores.SelectedValue, (int)this.cmbProducto.SelectedValue);
                this.vwProveedorProductoDataGridView.Refresh();
                this.CargarData();
                btnAñadir.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                panel1.Enabled = false; 
            }
        }

        /// <summary>
        /// Eliminars the proveedor producto.
        /// </summary>
        /// <param name="codProv">The cod prov.</param>
        /// <param name="codProd">The cod product.</param>
        public void Eliminar_ProveedorProducto(int codProv, int codProd)
        {
            BaseDeDatos ba = new BaseDeDatos();
            ba.Conectar();
            SqlCommand com = new SqlCommand("Eliminar_ProveedorProducto", ba.cone);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@codProv", codProv);
            com.Parameters.AddWithValue("@codProc", codProd);


            com.ExecuteNonQuery();
            ba.Cerrar();
        }

        /// <summary>
        /// Handles the Click event of the btnEliminar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea eliminar "+cmbProducto.Text+" a ser distribuido por "+cmbProveedores.Text+" ?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Eliminar_ProveedorProducto(int.Parse(cmbProveedores.SelectedValue.ToString()), int.Parse(cmbProducto.SelectedValue.ToString()));
                this.vwProveedorProductoDataGridView.Refresh();
                CargarData();
            }
            else
            {

            }



        }

        /// <summary>
        /// Handles the Click event of the btnCancelar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.btnAñadir.Enabled = true;
            this.btnGuardar.Enabled = false;
            this.btnCancelar.Enabled = false;
            this.vwProveedorProductoBindingSource.CancelEdit();
            panel1.Enabled = false;
            CargarData();
        }

        private void vwProveedorProductoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.cmbProveedores.Text = vwProveedorProductoDataGridView.CurrentRow.Cells[1].Value.ToString();
            this.cmbProducto.Text = vwProveedorProductoDataGridView.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
