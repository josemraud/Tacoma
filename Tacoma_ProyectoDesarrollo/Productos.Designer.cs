// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 11-24-2019
//
// Last Modified By : pepit
// Last Modified On : 11-21-2019
// ***********************************************************************
// <copyright file="Productos.Designer.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class Productos.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class Productos
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
            System.Windows.Forms.Label codigo_de_ProductoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label precio_UnitarioLabel;
            System.Windows.Forms.Label subcategoriaLabel;
            System.Windows.Forms.Label estadoLabel;
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cmbBusqueda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.vwProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tacomaDBDataSet = new Tacoma_ProyectoDesarrollo.TacomaDBDataSet();
            this.estadoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subcategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.codigo_de_ProductoTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.precio_UnitarioTextBox = new System.Windows.Forms.TextBox();
            this.estadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwProductosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.errorDescrip = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPrecio = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSubcategoria = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEstado = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.estadoTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.EstadoTableAdapter();
            this.vwProductosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vwProductosTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.VwProductosTableAdapter();
            codigo_de_ProductoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            precio_UnitarioLabel = new System.Windows.Forms.Label();
            subcategoriaLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescrip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSubcategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // codigo_de_ProductoLabel
            // 
            codigo_de_ProductoLabel.AutoSize = true;
            codigo_de_ProductoLabel.Location = new System.Drawing.Point(8, 28);
            codigo_de_ProductoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codigo_de_ProductoLabel.Name = "codigo_de_ProductoLabel";
            codigo_de_ProductoLabel.Size = new System.Drawing.Size(137, 17);
            codigo_de_ProductoLabel.TabIndex = 0;
            codigo_de_ProductoLabel.Text = "Codigo de Producto:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(8, 60);
            descripcionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(86, 17);
            descripcionLabel.TabIndex = 2;
            descripcionLabel.Text = "Descripcion:";
            // 
            // precio_UnitarioLabel
            // 
            precio_UnitarioLabel.AutoSize = true;
            precio_UnitarioLabel.Location = new System.Drawing.Point(8, 92);
            precio_UnitarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            precio_UnitarioLabel.Name = "precio_UnitarioLabel";
            precio_UnitarioLabel.Size = new System.Drawing.Size(105, 17);
            precio_UnitarioLabel.TabIndex = 4;
            precio_UnitarioLabel.Text = "Precio Unitario:";
            precio_UnitarioLabel.Click += new System.EventHandler(this.precio_UnitarioLabel_Click);
            // 
            // subcategoriaLabel
            // 
            subcategoriaLabel.AutoSize = true;
            subcategoriaLabel.Location = new System.Drawing.Point(8, 124);
            subcategoriaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            subcategoriaLabel.Name = "subcategoriaLabel";
            subcategoriaLabel.Size = new System.Drawing.Size(96, 17);
            subcategoriaLabel.TabIndex = 6;
            subcategoriaLabel.Text = "Subcategoria:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(8, 158);
            estadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(56, 17);
            estadoLabel.TabIndex = 8;
            estadoLabel.Text = "Estado:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Location = new System.Drawing.Point(653, 118);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 38;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(159, 119);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(488, 22);
            this.txtBuscar.TabIndex = 37;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // cmbBusqueda
            // 
            this.cmbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusqueda.FormattingEnabled = true;
            this.cmbBusqueda.Items.AddRange(new object[] {
            "Codigo",
            "Nombre",
            "Todos los productos"});
            this.cmbBusqueda.Location = new System.Drawing.Point(31, 118);
            this.cmbBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Size = new System.Drawing.Size(121, 24);
            this.cmbBusqueda.TabIndex = 36;
            this.cmbBusqueda.SelectedIndexChanged += new System.EventHandler(this.CmbBusqueda_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(424, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 58);
            this.label1.TabIndex = 35;
            this.label1.Text = "Productos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(estadoLabel);
            this.panel1.Controls.Add(this.estadoComboBox);
            this.panel1.Controls.Add(subcategoriaLabel);
            this.panel1.Controls.Add(this.subcategoriaComboBox);
            this.panel1.Controls.Add(codigo_de_ProductoLabel);
            this.panel1.Controls.Add(this.codigo_de_ProductoTextBox);
            this.panel1.Controls.Add(descripcionLabel);
            this.panel1.Controls.Add(this.descripcionTextBox);
            this.panel1.Controls.Add(precio_UnitarioLabel);
            this.panel1.Controls.Add(this.precio_UnitarioTextBox);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(772, 186);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 229);
            this.panel1.TabIndex = 40;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwProductosBindingSource, "Estado", true));
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vwProductosBindingSource, "Estado", true));
            this.estadoComboBox.DataSource = this.estadoBindingSource1;
            this.estadoComboBox.DisplayMember = "Estado_Descripcion";
            this.estadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Location = new System.Drawing.Point(155, 154);
            this.estadoComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(160, 24);
            this.estadoComboBox.TabIndex = 9;
            this.estadoComboBox.ValueMember = "Estado_Cod";
            this.estadoComboBox.SelectedIndexChanged += new System.EventHandler(this.EstadoComboBox_SelectedIndexChanged);
            // 
            // vwProductosBindingSource
            // 
            this.vwProductosBindingSource.DataMember = "VwProductos";
            this.vwProductosBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // tacomaDBDataSet
            // 
            this.tacomaDBDataSet.DataSetName = "TacomaDBDataSet";
            this.tacomaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estadoBindingSource1
            // 
            this.estadoBindingSource1.DataMember = "Estado";
            this.estadoBindingSource1.DataSource = this.tacomaDBDataSet;
            // 
            // subcategoriaComboBox
            // 
            this.subcategoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwProductosBindingSource, "Subcategoria", true));
            this.subcategoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vwProductosBindingSource, "Subcategoria", true));
            this.subcategoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subcategoriaComboBox.FormattingEnabled = true;
            this.subcategoriaComboBox.Location = new System.Drawing.Point(155, 121);
            this.subcategoriaComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.subcategoriaComboBox.Name = "subcategoriaComboBox";
            this.subcategoriaComboBox.Size = new System.Drawing.Size(160, 24);
            this.subcategoriaComboBox.TabIndex = 7;
            this.subcategoriaComboBox.SelectedIndexChanged += new System.EventHandler(this.SubcategoriaComboBox_SelectedIndexChanged);
            // 
            // codigo_de_ProductoTextBox
            // 
            this.codigo_de_ProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwProductosBindingSource, "Codigo de Producto", true));
            this.codigo_de_ProductoTextBox.Enabled = false;
            this.codigo_de_ProductoTextBox.Location = new System.Drawing.Point(155, 25);
            this.codigo_de_ProductoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.codigo_de_ProductoTextBox.Name = "codigo_de_ProductoTextBox";
            this.codigo_de_ProductoTextBox.ReadOnly = true;
            this.codigo_de_ProductoTextBox.Size = new System.Drawing.Size(160, 22);
            this.codigo_de_ProductoTextBox.TabIndex = 1;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwProductosBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(155, 55);
            this.descripcionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descripcionTextBox.MaxLength = 50;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(160, 22);
            this.descripcionTextBox.TabIndex = 3;
            this.descripcionTextBox.TextChanged += new System.EventHandler(this.DescripcionTextBox_TextChanged);
            this.descripcionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescripcionTextBox_KeyPress);
            // 
            // precio_UnitarioTextBox
            // 
            this.precio_UnitarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwProductosBindingSource, "Precio Unitario", true));
            this.precio_UnitarioTextBox.Location = new System.Drawing.Point(155, 89);
            this.precio_UnitarioTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.precio_UnitarioTextBox.MaxLength = 8;
            this.precio_UnitarioTextBox.Name = "precio_UnitarioTextBox";
            this.precio_UnitarioTextBox.Size = new System.Drawing.Size(160, 22);
            this.precio_UnitarioTextBox.TabIndex = 5;
            this.precio_UnitarioTextBox.TextChanged += new System.EventHandler(this.Precio_UnitarioTextBox_TextChanged);
            this.precio_UnitarioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Precio_UnitarioTextBox_KeyPress);
            // 
            // estadoBindingSource
            // 
            this.estadoBindingSource.DataMember = "Estado";
            this.estadoBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // vwProductosDataGridView
            // 
            this.vwProductosDataGridView.AllowUserToAddRows = false;
            this.vwProductosDataGridView.AllowUserToDeleteRows = false;
            this.vwProductosDataGridView.AutoGenerateColumns = false;
            this.vwProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vwProductosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.vwProductosDataGridView.DataSource = this.vwProductosBindingSource1;
            this.vwProductosDataGridView.Location = new System.Drawing.Point(31, 186);
            this.vwProductosDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.vwProductosDataGridView.Name = "vwProductosDataGridView";
            this.vwProductosDataGridView.ReadOnly = true;
            this.vwProductosDataGridView.RowHeadersWidth = 51;
            this.vwProductosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vwProductosDataGridView.Size = new System.Drawing.Size(724, 271);
            this.vwProductosDataGridView.TabIndex = 40;
            this.vwProductosDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VwProductosDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo de Producto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo de Producto";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Precio Unitario";
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio Unitario";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Subcategoria";
            this.dataGridViewTextBoxColumn4.HeaderText = "Subcategoria";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn5.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(655, 482);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Enabled = false;
            this.btnguardar.Location = new System.Drawing.Point(471, 482);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(145, 28);
            this.btnguardar.TabIndex = 44;
            this.btnguardar.Text = "Guardar cambios";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.Btnguardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(348, 482);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 43;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(132, 482);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(183, 28);
            this.btnAceptar.TabIndex = 42;
            this.btnAceptar.Text = "Guardar nuevo producto";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(31, 482);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(83, 28);
            this.btnAñadir.TabIndex = 41;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.BtnAñadir_Click);
            // 
            // errorDescrip
            // 
            this.errorDescrip.ContainerControl = this;
            // 
            // errorPrecio
            // 
            this.errorPrecio.ContainerControl = this;
            // 
            // errorSubcategoria
            // 
            this.errorSubcategoria.ContainerControl = this;
            // 
            // errorEstado
            // 
            this.errorEstado.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1102, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // estadoTableAdapter
            // 
            this.estadoTableAdapter.ClearBeforeFill = true;
            // 
            // vwProductosBindingSource1
            // 
            this.vwProductosBindingSource1.DataMember = "VwProductos";
            this.vwProductosBindingSource1.DataSource = this.tacomaDBDataSet;
            // 
            // vwProductosTableAdapter
            // 
            this.vwProductosTableAdapter.ClearBeforeFill = true;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 601);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.vwProductosDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cmbBusqueda);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescrip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSubcategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// The BTN buscar
        /// </summary>
        private System.Windows.Forms.Button btnBuscar;
        /// <summary>
        /// The text buscar
        /// </summary>
        private System.Windows.Forms.TextBox txtBuscar;
        /// <summary>
        /// The CMB busqueda
        /// </summary>
        private System.Windows.Forms.ComboBox cmbBusqueda;
        /// <summary>
        /// The label1
        /// </summary>
        private System.Windows.Forms.Label label1;
        /// <summary>
        /// The tacoma database data set
        /// </summary>
        private TacomaDBDataSet tacomaDBDataSet;
        /// <summary>
        /// The vw productos binding source
        /// </summary>
        private System.Windows.Forms.BindingSource vwProductosBindingSource;
        /// <summary>
        /// The panel1
        /// </summary>
        private System.Windows.Forms.Panel panel1;
        /// <summary>
        /// The codigo de producto text box
        /// </summary>
        private System.Windows.Forms.TextBox codigo_de_ProductoTextBox;
        /// <summary>
        /// The descripcion text box
        /// </summary>
        private System.Windows.Forms.TextBox descripcionTextBox;
        /// <summary>
        /// The precio unitario text box
        /// </summary>
        private System.Windows.Forms.TextBox precio_UnitarioTextBox;
        /// <summary>
        /// The vw productos data grid view
        /// </summary>
        private System.Windows.Forms.DataGridView vwProductosDataGridView;
        /// <summary>
        /// The data grid view text box column1
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        /// <summary>
        /// The data grid view text box column2
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        /// <summary>
        /// The data grid view text box column3
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        /// <summary>
        /// The data grid view text box column4
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        /// <summary>
        /// The data grid view text box column5
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        /// <summary>
        /// The BTN cancelar
        /// </summary>
        private System.Windows.Forms.Button btnCancelar;
        /// <summary>
        /// The btnguardar
        /// </summary>
        private System.Windows.Forms.Button btnguardar;
        /// <summary>
        /// The BTN modificar
        /// </summary>
        private System.Windows.Forms.Button btnModificar;
        /// <summary>
        /// The BTN aceptar
        /// </summary>
        private System.Windows.Forms.Button btnAceptar;
        /// <summary>
        /// The BTN añadir
        /// </summary>
        private System.Windows.Forms.Button btnAñadir;
        /// <summary>
        /// The subcategoria ComboBox
        /// </summary>
        private System.Windows.Forms.ComboBox subcategoriaComboBox;
        /// <summary>
        /// The estado ComboBox
        /// </summary>
        private System.Windows.Forms.ComboBox estadoComboBox;
        /// <summary>
        /// The estado binding source
        /// </summary>
        private System.Windows.Forms.BindingSource estadoBindingSource;
        /// <summary>
        /// The error descrip
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorDescrip;
        /// <summary>
        /// The error precio
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorPrecio;
        /// <summary>
        /// The error subcategoria
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorSubcategoria;
        /// <summary>
        /// The error estado
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource estadoBindingSource1;
        private TacomaDBDataSetTableAdapters.EstadoTableAdapter estadoTableAdapter;
        private System.Windows.Forms.BindingSource vwProductosBindingSource1;
        private TacomaDBDataSetTableAdapters.VwProductosTableAdapter vwProductosTableAdapter;
    }
}