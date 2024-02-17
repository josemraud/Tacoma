// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 12-04-2019
//
// Last Modified By : pepit
// Last Modified On : 12-05-2019
// ***********************************************************************
// <copyright file="ProveedorProducto.Designer.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class ProveedorProducto.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class ProveedorProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nombre_ProveedorLabel;
            System.Windows.Forms.Label nombre_de_ProductoLabel;
            this.tacomaDBDataSet = new Tacoma_ProyectoDesarrollo.TacomaDBDataSet();
            this.vwProveedorProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwProveedorProductoTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.VwProveedorProductoTableAdapter();
            this.tableAdapterManager = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.TableAdapterManager();
            this.vwProveedorProductoDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tacomaDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbProveedores = new System.Windows.Forms.ComboBox();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedoresTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.ProveedoresTableAdapter();
            this.productoTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.ProductoTableAdapter();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tacomaDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vwProveedorProductoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.codigoDeProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDeProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDeProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombre_ProveedorLabel = new System.Windows.Forms.Label();
            nombre_de_ProductoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProveedorProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProveedorProductoDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProveedorProductoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre_ProveedorLabel
            // 
            nombre_ProveedorLabel.AutoSize = true;
            nombre_ProveedorLabel.Location = new System.Drawing.Point(42, 53);
            nombre_ProveedorLabel.Name = "nombre_ProveedorLabel";
            nombre_ProveedorLabel.Size = new System.Drawing.Size(132, 17);
            nombre_ProveedorLabel.TabIndex = 0;
            nombre_ProveedorLabel.Text = "Nombre Proveedor:";
            // 
            // nombre_de_ProductoLabel
            // 
            nombre_de_ProductoLabel.AutoSize = true;
            nombre_de_ProductoLabel.Location = new System.Drawing.Point(31, 127);
            nombre_de_ProductoLabel.Name = "nombre_de_ProductoLabel";
            nombre_de_ProductoLabel.Size = new System.Drawing.Size(143, 17);
            nombre_de_ProductoLabel.TabIndex = 2;
            nombre_de_ProductoLabel.Text = "Nombre de Producto:";
            // 
            // tacomaDBDataSet
            // 
            this.tacomaDBDataSet.DataSetName = "TacomaDBDataSet";
            this.tacomaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwProveedorProductoBindingSource
            // 
            this.vwProveedorProductoBindingSource.DataMember = "VwProveedorProducto";
            this.vwProveedorProductoBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // vwProveedorProductoTableAdapter
            // 
            this.vwProveedorProductoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CiudadTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Cotizacion_DetalleTableAdapter = null;
            this.tableAdapterManager.CotizacionTableAdapter = null;
            this.tableAdapterManager.DepartamentosTableAdapter = null;
            this.tableAdapterManager.DepartamentoTableAdapter = null;
            this.tableAdapterManager.Detalle_FacturaTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.EsclavoTableAdapter = null;
            this.tableAdapterManager.EstadoTableAdapter = null;
            this.tableAdapterManager.FacturaTableAdapter = null;
            this.tableAdapterManager.ISV_HistoricoTableAdapter = null;
            this.tableAdapterManager.MunicipiosTableAdapter = null;
            this.tableAdapterManager.PaisTableAdapter = null;
            this.tableAdapterManager.Producto_CategoriaTableAdapter = null;
            this.tableAdapterManager.Producto_SubcategoriaTableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.Proveedores_ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.Rol_SistemaTableAdapter = null;
            this.tableAdapterManager.Roles_DepartamentosTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.TipoDePagoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // vwProveedorProductoDataGridView
            // 
            this.vwProveedorProductoDataGridView.AllowUserToAddRows = false;
            this.vwProveedorProductoDataGridView.AllowUserToDeleteRows = false;
            this.vwProveedorProductoDataGridView.AutoGenerateColumns = false;
            this.vwProveedorProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vwProveedorProductoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDeProveedorDataGridViewTextBoxColumn,
            this.nombreProveedorDataGridViewTextBoxColumn,
            this.codigoDeProductoDataGridViewTextBoxColumn,
            this.nombreDeProductoDataGridViewTextBoxColumn});
            this.vwProveedorProductoDataGridView.DataSource = this.vwProveedorProductoBindingSource1;
            this.vwProveedorProductoDataGridView.Location = new System.Drawing.Point(28, 106);
            this.vwProveedorProductoDataGridView.Name = "vwProveedorProductoDataGridView";
            this.vwProveedorProductoDataGridView.ReadOnly = true;
            this.vwProveedorProductoDataGridView.RowHeadersWidth = 51;
            this.vwProveedorProductoDataGridView.RowTemplate.Height = 24;
            this.vwProveedorProductoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vwProveedorProductoDataGridView.Size = new System.Drawing.Size(465, 220);
            this.vwProveedorProductoDataGridView.TabIndex = 1;
            this.vwProveedorProductoDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vwProveedorProductoDataGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(nombre_de_ProductoLabel);
            this.panel1.Controls.Add(this.cmbProducto);
            this.panel1.Controls.Add(nombre_ProveedorLabel);
            this.panel1.Controls.Add(this.cmbProveedores);
            this.panel1.Location = new System.Drawing.Point(511, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 220);
            this.panel1.TabIndex = 2;
            // 
            // cmbProducto
            // 
            this.cmbProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwProveedorProductoBindingSource, "Nombre de Producto", true));
            this.cmbProducto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vwProveedorProductoBindingSource, "Nombre de Producto", true));
            this.cmbProducto.DataSource = this.productoBindingSource;
            this.cmbProducto.DisplayMember = "Producto_Descripcion";
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(180, 124);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(169, 24);
            this.cmbProducto.TabIndex = 3;
            this.cmbProducto.ValueMember = "Producto_Cod";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.tacomaDBDataSetBindingSource;
            // 
            // tacomaDBDataSetBindingSource
            // 
            this.tacomaDBDataSetBindingSource.DataSource = this.tacomaDBDataSet;
            this.tacomaDBDataSetBindingSource.Position = 0;
            // 
            // cmbProveedores
            // 
            this.cmbProveedores.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwProveedorProductoBindingSource, "Nombre Proveedor", true));
            this.cmbProveedores.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vwProveedorProductoBindingSource, "Nombre Proveedor", true));
            this.cmbProveedores.DataSource = this.proveedoresBindingSource;
            this.cmbProveedores.DisplayMember = "Proveedor_Nombre";
            this.cmbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedores.FormattingEnabled = true;
            this.cmbProveedores.Location = new System.Drawing.Point(180, 50);
            this.cmbProveedores.Name = "cmbProveedores";
            this.cmbProveedores.Size = new System.Drawing.Size(169, 24);
            this.cmbProveedores.TabIndex = 1;
            this.cmbProveedores.ValueMember = "Proveedor_ID";
            this.cmbProveedores.SelectedIndexChanged += new System.EventHandler(this.cmbProveedores_SelectedIndexChanged);
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.tacomaDBDataSetBindingSource;
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(28, 398);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(99, 23);
            this.btnAñadir.TabIndex = 3;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(133, 398);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(238, 398);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(343, 398);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(183, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 58);
            this.label1.TabIndex = 39;
            this.label1.Text = "Proveedores por Producto";
            // 
            // tacomaDBDataSetBindingSource1
            // 
            this.tacomaDBDataSetBindingSource1.DataSource = this.tacomaDBDataSet;
            this.tacomaDBDataSetBindingSource1.Position = 0;
            // 
            // vwProveedorProductoBindingSource1
            // 
            this.vwProveedorProductoBindingSource1.DataMember = "VwProveedorProducto";
            this.vwProveedorProductoBindingSource1.DataSource = this.tacomaDBDataSet;
            // 
            // codigoDeProveedorDataGridViewTextBoxColumn
            // 
            this.codigoDeProveedorDataGridViewTextBoxColumn.DataPropertyName = "Codigo de Proveedor";
            this.codigoDeProveedorDataGridViewTextBoxColumn.HeaderText = "Codigo de Proveedor";
            this.codigoDeProveedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoDeProveedorDataGridViewTextBoxColumn.Name = "codigoDeProveedorDataGridViewTextBoxColumn";
            this.codigoDeProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDeProveedorDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreProveedorDataGridViewTextBoxColumn
            // 
            this.nombreProveedorDataGridViewTextBoxColumn.DataPropertyName = "Nombre Proveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.HeaderText = "Nombre Proveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreProveedorDataGridViewTextBoxColumn.Name = "nombreProveedorDataGridViewTextBoxColumn";
            this.nombreProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreProveedorDataGridViewTextBoxColumn.Width = 125;
            // 
            // codigoDeProductoDataGridViewTextBoxColumn
            // 
            this.codigoDeProductoDataGridViewTextBoxColumn.DataPropertyName = "Codigo de Producto";
            this.codigoDeProductoDataGridViewTextBoxColumn.HeaderText = "Codigo de Producto";
            this.codigoDeProductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoDeProductoDataGridViewTextBoxColumn.Name = "codigoDeProductoDataGridViewTextBoxColumn";
            this.codigoDeProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDeProductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDeProductoDataGridViewTextBoxColumn
            // 
            this.nombreDeProductoDataGridViewTextBoxColumn.DataPropertyName = "Nombre de Producto";
            this.nombreDeProductoDataGridViewTextBoxColumn.HeaderText = "Nombre de Producto";
            this.nombreDeProductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDeProductoDataGridViewTextBoxColumn.Name = "nombreDeProductoDataGridViewTextBoxColumn";
            this.nombreDeProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDeProductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ProveedorProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.vwProveedorProductoDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProveedorProducto";
            this.Text = "ProveedorProducto";
            this.Load += new System.EventHandler(this.ProveedorProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProveedorProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProveedorProductoDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProveedorProductoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// The tacoma database data set
        /// </summary>
        private TacomaDBDataSet tacomaDBDataSet;
        /// <summary>
        /// The vw proveedor producto binding source
        /// </summary>
        private System.Windows.Forms.BindingSource vwProveedorProductoBindingSource;
        /// <summary>
        /// The vw proveedor producto table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.VwProveedorProductoTableAdapter vwProveedorProductoTableAdapter;
        /// <summary>
        /// The table adapter manager
        /// </summary>
        private TacomaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        /// <summary>
        /// The vw proveedor producto data grid view
        /// </summary>
        private System.Windows.Forms.DataGridView vwProveedorProductoDataGridView;
        /// <summary>
        /// The panel1
        /// </summary>
        private System.Windows.Forms.Panel panel1;
        /// <summary>
        /// The CMB producto
        /// </summary>
        private System.Windows.Forms.ComboBox cmbProducto;
        /// <summary>
        /// The CMB proveedores
        /// </summary>
        private System.Windows.Forms.ComboBox cmbProveedores;
        /// <summary>
        /// The tacoma database data set binding source
        /// </summary>
        private System.Windows.Forms.BindingSource tacomaDBDataSetBindingSource;
        /// <summary>
        /// The proveedores binding source
        /// </summary>
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        /// <summary>
        /// The proveedores table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        /// <summary>
        /// The producto binding source
        /// </summary>
        private System.Windows.Forms.BindingSource productoBindingSource;
        /// <summary>
        /// The producto table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        /// <summary>
        /// The BTN añadir
        /// </summary>
        private System.Windows.Forms.Button btnAñadir;
        /// <summary>
        /// The BTN guardar
        /// </summary>
        private System.Windows.Forms.Button btnGuardar;
        /// <summary>
        /// The BTN eliminar
        /// </summary>
        private System.Windows.Forms.Button btnEliminar;
        /// <summary>
        /// The BTN cancelar
        /// </summary>
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDeProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDeProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDeProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vwProveedorProductoBindingSource1;
        private System.Windows.Forms.BindingSource tacomaDBDataSetBindingSource1;
    }
}