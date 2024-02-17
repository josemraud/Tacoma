// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 12-13-2019
//
// Last Modified By : pepit
// Last Modified On : 12-13-2019
// ***********************************************************************
// <copyright file="Cotizacion.designer.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class Cotizacion.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class Cotizacion
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
            System.Windows.Forms.Label cotizacion_FechaLabel;
            System.Windows.Forms.Label rTNLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label direcciónLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label paisLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label precio_UnitarioLabel;
            System.Windows.Forms.Label cotizacion_IDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cotizacion));
            this.tacomaDBDataSet = new Tacoma_ProyectoDesarrollo.TacomaDBDataSet();
            this.rTNTextBox = new System.Windows.Forms.TextBox();
            this.vwClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.ciudadTextBox = new System.Windows.Forms.TextBox();
            this.paisTextBox = new System.Windows.Forms.TextBox();
            this.btnBuscarRTN = new System.Windows.Forms.Button();
            this.btnBuscarClienteNom = new System.Windows.Forms.Button();
            this.btnNuevaCot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.vwProductosDataGridView = new System.Windows.Forms.DataGridView();
            this.vwClienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.vwProductosDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.vwDetalleFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.precio_UnitarioTextBox = new System.Windows.Forms.TextBox();
            this.cotizacion_IDTextBox = new System.Windows.Forms.TextBox();
            this.cotizacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBuscarCot = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_uni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direcciónTextBox = new System.Windows.Forms.TextBox();
            this.cotizacion_FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.producto_CodTextBox = new System.Windows.Forms.TextBox();
            this.btnCancelarFac = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.cotizacion_DetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalle_FacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwCotizacion_DetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            cotizacion_FechaLabel = new System.Windows.Forms.Label();
            rTNLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            direcciónLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            precio_UnitarioLabel = new System.Windows.Forms.Label();
            cotizacion_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwClienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDetalleFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotizacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotizacion_DetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalle_FacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCotizacion_DetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cotizacion_FechaLabel
            // 
            cotizacion_FechaLabel.AutoSize = true;
            cotizacion_FechaLabel.Location = new System.Drawing.Point(431, 20);
            cotizacion_FechaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cotizacion_FechaLabel.Name = "cotizacion_FechaLabel";
            cotizacion_FechaLabel.Size = new System.Drawing.Size(51, 17);
            cotizacion_FechaLabel.TabIndex = 0;
            cotizacion_FechaLabel.Text = "Fecha:";
            // 
            // rTNLabel
            // 
            rTNLabel.AutoSize = true;
            rTNLabel.Location = new System.Drawing.Point(247, 78);
            rTNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rTNLabel.Name = "rTNLabel";
            rTNLabel.Size = new System.Drawing.Size(41, 17);
            rTNLabel.TabIndex = 2;
            rTNLabel.Text = "RTN:";
            rTNLabel.Click += new System.EventHandler(this.rTNLabel_Click);
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(247, 110);
            nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(62, 17);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
            nombreLabel.Click += new System.EventHandler(this.nombreLabel_Click);
            // 
            // direcciónLabel
            // 
            direcciónLabel.AutoSize = true;
            direcciónLabel.Location = new System.Drawing.Point(247, 142);
            direcciónLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            direcciónLabel.Name = "direcciónLabel";
            direcciónLabel.Size = new System.Drawing.Size(71, 17);
            direcciónLabel.TabIndex = 6;
            direcciónLabel.Text = "Dirección:";
            direcciónLabel.Click += new System.EventHandler(this.direcciónLabel_Click);
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(247, 174);
            telefonoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(68, 17);
            telefonoLabel.TabIndex = 8;
            telefonoLabel.Text = "Telefono:";
            telefonoLabel.Click += new System.EventHandler(this.telefonoLabel_Click);
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Location = new System.Drawing.Point(247, 206);
            ciudadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(56, 17);
            ciudadLabel.TabIndex = 10;
            ciudadLabel.Text = "Ciudad:";
            ciudadLabel.Click += new System.EventHandler(this.ciudadLabel_Click);
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Location = new System.Drawing.Point(247, 238);
            paisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(39, 17);
            paisLabel.TabIndex = 12;
            paisLabel.Text = "Pais:";
            paisLabel.Click += new System.EventHandler(this.paisLabel_Click);
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(717, 174);
            cantidadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(68, 17);
            cantidadLabel.TabIndex = 53;
            cantidadLabel.Text = "Cantidad:";
            cantidadLabel.Click += new System.EventHandler(this.cantidadLabel_Click);
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(717, 110);
            descripcionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(86, 17);
            descripcionLabel.TabIndex = 49;
            descripcionLabel.Text = "Descripcion:";
            descripcionLabel.Click += new System.EventHandler(this.descripcionLabel_Click);
            // 
            // precio_UnitarioLabel
            // 
            precio_UnitarioLabel.AutoSize = true;
            precio_UnitarioLabel.Location = new System.Drawing.Point(717, 142);
            precio_UnitarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            precio_UnitarioLabel.Name = "precio_UnitarioLabel";
            precio_UnitarioLabel.Size = new System.Drawing.Size(105, 17);
            precio_UnitarioLabel.TabIndex = 51;
            precio_UnitarioLabel.Text = "Precio Unitario:";
            precio_UnitarioLabel.Click += new System.EventHandler(this.precio_UnitarioLabel_Click);
            // 
            // cotizacion_IDLabel
            // 
            cotizacion_IDLabel.AutoSize = true;
            cotizacion_IDLabel.Location = new System.Drawing.Point(196, 313);
            cotizacion_IDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cotizacion_IDLabel.Name = "cotizacion_IDLabel";
            cotizacion_IDLabel.Size = new System.Drawing.Size(94, 17);
            cotizacion_IDLabel.TabIndex = 54;
            cotizacion_IDLabel.Text = "Cotizacion ID:";
            // 
            // tacomaDBDataSet
            // 
            this.tacomaDBDataSet.DataSetName = "TacomaDBDataSet";
            this.tacomaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rTNTextBox
            // 
            this.rTNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwClienteBindingSource, "RTN", true));
            this.rTNTextBox.Location = new System.Drawing.Point(328, 74);
            this.rTNTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.rTNTextBox.Name = "rTNTextBox";
            this.rTNTextBox.Size = new System.Drawing.Size(132, 22);
            this.rTNTextBox.TabIndex = 3;
            this.rTNTextBox.TextChanged += new System.EventHandler(this.rTNTextBox_TextChanged);
            // 
            // vwClienteBindingSource
            // 
            this.vwClienteBindingSource.DataMember = "VwCliente";
            this.vwClienteBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwClienteBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(328, 106);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(132, 22);
            this.nombreTextBox.TabIndex = 5;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.nombreTextBox_TextChanged);
            this.nombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreTextBox_KeyPress);
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwClienteBindingSource, "Telefono", true));
            this.telefonoTextBox.Enabled = false;
            this.telefonoTextBox.Location = new System.Drawing.Point(328, 170);
            this.telefonoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(172, 22);
            this.telefonoTextBox.TabIndex = 9;
            this.telefonoTextBox.TextChanged += new System.EventHandler(this.telefonoTextBox_TextChanged);
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwClienteBindingSource, "Ciudad", true));
            this.ciudadTextBox.Enabled = false;
            this.ciudadTextBox.Location = new System.Drawing.Point(328, 203);
            this.ciudadTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.ciudadTextBox.Size = new System.Drawing.Size(172, 22);
            this.ciudadTextBox.TabIndex = 11;
            this.ciudadTextBox.TextChanged += new System.EventHandler(this.ciudadTextBox_TextChanged);
            // 
            // paisTextBox
            // 
            this.paisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwClienteBindingSource, "Pais", true));
            this.paisTextBox.Enabled = false;
            this.paisTextBox.Location = new System.Drawing.Point(328, 234);
            this.paisTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.paisTextBox.Name = "paisTextBox";
            this.paisTextBox.Size = new System.Drawing.Size(172, 22);
            this.paisTextBox.TabIndex = 13;
            this.paisTextBox.TextChanged += new System.EventHandler(this.paisTextBox_TextChanged);
            // 
            // btnBuscarRTN
            // 
            this.btnBuscarRTN.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarRTN.Image")));
            this.btnBuscarRTN.Location = new System.Drawing.Point(469, 74);
            this.btnBuscarRTN.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarRTN.Name = "btnBuscarRTN";
            this.btnBuscarRTN.Size = new System.Drawing.Size(32, 28);
            this.btnBuscarRTN.TabIndex = 14;
            this.btnBuscarRTN.UseVisualStyleBackColor = true;
            this.btnBuscarRTN.Click += new System.EventHandler(this.btnBuscarRTN_Click);
            // 
            // btnBuscarClienteNom
            // 
            this.btnBuscarClienteNom.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarClienteNom.Image")));
            this.btnBuscarClienteNom.Location = new System.Drawing.Point(469, 106);
            this.btnBuscarClienteNom.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarClienteNom.Name = "btnBuscarClienteNom";
            this.btnBuscarClienteNom.Size = new System.Drawing.Size(32, 28);
            this.btnBuscarClienteNom.TabIndex = 15;
            this.btnBuscarClienteNom.UseVisualStyleBackColor = true;
            this.btnBuscarClienteNom.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNuevaCot
            // 
            this.btnNuevaCot.Enabled = false;
            this.btnNuevaCot.Location = new System.Drawing.Point(251, 266);
            this.btnNuevaCot.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevaCot.Name = "btnNuevaCot";
            this.btnNuevaCot.Size = new System.Drawing.Size(283, 28);
            this.btnNuevaCot.TabIndex = 19;
            this.btnNuevaCot.Text = "Ingresar nueva cotizacion";
            this.btnNuevaCot.UseVisualStyleBackColor = true;
            this.btnNuevaCot.Click += new System.EventHandler(this.btnNuevaFac_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(717, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Codigo: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.Enabled = false;
            this.btnBuscarProd.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProd.Image")));
            this.btnBuscarProd.Location = new System.Drawing.Point(965, 69);
            this.btnBuscarProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(32, 28);
            this.btnBuscarProd.TabIndex = 29;
            this.btnBuscarProd.UseVisualStyleBackColor = true;
            this.btnBuscarProd.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAnadir
            // 
            this.btnAnadir.Enabled = false;
            this.btnAnadir.Location = new System.Drawing.Point(720, 228);
            this.btnAnadir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(321, 28);
            this.btnAnadir.TabIndex = 33;
            this.btnAnadir.Text = "Añadir a la cotizacion";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(197, 619);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 31);
            this.btnEliminar.TabIndex = 46;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // vwProductosDataGridView
            // 
            this.vwProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vwProductosDataGridView.Location = new System.Drawing.Point(43, 828);
            this.vwProductosDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.vwProductosDataGridView.Name = "vwProductosDataGridView";
            this.vwProductosDataGridView.RowHeadersWidth = 51;
            this.vwProductosDataGridView.Size = new System.Drawing.Size(13, 12);
            this.vwProductosDataGridView.TabIndex = 48;
            this.vwProductosDataGridView.Visible = false;
            // 
            // vwClienteDataGridView
            // 
            this.vwClienteDataGridView.AllowUserToAddRows = false;
            this.vwClienteDataGridView.AllowUserToDeleteRows = false;
            this.vwClienteDataGridView.AutoGenerateColumns = false;
            this.vwClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vwClienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.vwClienteDataGridView.DataSource = this.vwClienteBindingSource;
            this.vwClienteDataGridView.Location = new System.Drawing.Point(21, 828);
            this.vwClienteDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.vwClienteDataGridView.Name = "vwClienteDataGridView";
            this.vwClienteDataGridView.ReadOnly = true;
            this.vwClienteDataGridView.RowHeadersWidth = 51;
            this.vwClienteDataGridView.Size = new System.Drawing.Size(13, 12);
            this.vwClienteDataGridView.TabIndex = 47;
            this.vwClienteDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RTN";
            this.dataGridViewTextBoxColumn6.HeaderText = "RTN";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn12.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn14.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Ciudad";
            this.dataGridViewTextBoxColumn15.HeaderText = "Ciudad";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Pais";
            this.dataGridViewTextBoxColumn16.HeaderText = "Pais";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // vwProductosDataGridView1
            // 
            this.vwProductosDataGridView1.AutoGenerateColumns = false;
            this.vwProductosDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vwProductosDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.vwProductosDataGridView1.DataSource = this.vwProductosBindingSource;
            this.vwProductosDataGridView1.Location = new System.Drawing.Point(43, 809);
            this.vwProductosDataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.vwProductosDataGridView1.Name = "vwProductosDataGridView1";
            this.vwProductosDataGridView1.RowHeadersWidth = 51;
            this.vwProductosDataGridView1.Size = new System.Drawing.Size(13, 12);
            this.vwProductosDataGridView1.TabIndex = 48;
            this.vwProductosDataGridView1.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Codigo de Producto";
            this.dataGridViewTextBoxColumn7.HeaderText = "Codigo de Producto";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn8.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Precio Unitario";
            this.dataGridViewTextBoxColumn9.HeaderText = "Precio Unitario";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Subcategoria";
            this.dataGridViewTextBoxColumn10.HeaderText = "Subcategoria";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn11.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // vwProductosBindingSource
            // 
            this.vwProductosBindingSource.DataMember = "VwProductos";
            this.vwProductosBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwDetalleFacturaBindingSource, "Cantidad", true));
            this.cantidadTextBox.Enabled = false;
            this.cantidadTextBox.Location = new System.Drawing.Point(864, 169);
            this.cantidadTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cantidadTextBox.MaxLength = 5;
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(177, 22);
            this.cantidadTextBox.TabIndex = 54;
            this.cantidadTextBox.TextChanged += new System.EventHandler(this.cantidadTextBox_TextChanged);
            // 
            // vwDetalleFacturaBindingSource
            // 
            this.vwDetalleFacturaBindingSource.DataMember = "VwDetalleFactura";
            this.vwDetalleFacturaBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwProductosBindingSource, "Descripcion", true));
            this.descripcionTextBox.Enabled = false;
            this.descripcionTextBox.Location = new System.Drawing.Point(864, 105);
            this.descripcionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descripcionTextBox.MaxLength = 50;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(177, 22);
            this.descripcionTextBox.TabIndex = 50;
            this.descripcionTextBox.TextChanged += new System.EventHandler(this.descripcionTextBox_TextChanged);
            // 
            // precio_UnitarioTextBox
            // 
            this.precio_UnitarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwProductosBindingSource, "Precio Unitario", true));
            this.precio_UnitarioTextBox.Enabled = false;
            this.precio_UnitarioTextBox.Location = new System.Drawing.Point(864, 137);
            this.precio_UnitarioTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.precio_UnitarioTextBox.Name = "precio_UnitarioTextBox";
            this.precio_UnitarioTextBox.Size = new System.Drawing.Size(177, 22);
            this.precio_UnitarioTextBox.TabIndex = 52;
            this.precio_UnitarioTextBox.TextChanged += new System.EventHandler(this.precio_UnitarioTextBox_TextChanged);
            // 
            // cotizacion_IDTextBox
            // 
            this.cotizacion_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cotizacionBindingSource, "Cotizacion_ID", true));
            this.cotizacion_IDTextBox.Location = new System.Drawing.Point(301, 309);
            this.cotizacion_IDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cotizacion_IDTextBox.Name = "cotizacion_IDTextBox";
            this.cotizacion_IDTextBox.Size = new System.Drawing.Size(348, 22);
            this.cotizacion_IDTextBox.TabIndex = 55;
            // 
            // cotizacionBindingSource
            // 
            this.cotizacionBindingSource.DataMember = "Cotizacion";
            this.cotizacionBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // btnBuscarCot
            // 
            this.btnBuscarCot.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCot.Image")));
            this.btnBuscarCot.Location = new System.Drawing.Point(659, 306);
            this.btnBuscarCot.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCot.Name = "btnBuscarCot";
            this.btnBuscarCot.Size = new System.Drawing.Size(32, 28);
            this.btnBuscarCot.TabIndex = 56;
            this.btnBuscarCot.UseVisualStyleBackColor = true;
            this.btnBuscarCot.Click += new System.EventHandler(this.btnBuscarCot_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Precio_uni,
            this.Cantidad,
            this.Total});
            this.dgvDetalle.Location = new System.Drawing.Point(200, 342);
            this.dgvDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.Size = new System.Drawing.Size(841, 270);
            this.dgvDetalle.TabIndex = 57;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 200;
            // 
            // Precio_uni
            // 
            this.Precio_uni.HeaderText = "Precio Unitario";
            this.Precio_uni.MinimumWidth = 6;
            this.Precio_uni.Name = "Precio_uni";
            this.Precio_uni.ReadOnly = true;
            this.Precio_uni.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total Producto";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 125;
            // 
            // direcciónTextBox
            // 
            this.direcciónTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwClienteBindingSource, "Direccion", true));
            this.direcciónTextBox.Enabled = false;
            this.direcciónTextBox.Location = new System.Drawing.Point(328, 139);
            this.direcciónTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.direcciónTextBox.Name = "direcciónTextBox";
            this.direcciónTextBox.Size = new System.Drawing.Size(172, 22);
            this.direcciónTextBox.TabIndex = 58;
            // 
            // cotizacion_FechaDateTimePicker
            // 
            this.cotizacion_FechaDateTimePicker.Enabled = false;
            this.cotizacion_FechaDateTimePicker.Location = new System.Drawing.Point(489, 16);
            this.cotizacion_FechaDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cotizacion_FechaDateTimePicker.Name = "cotizacion_FechaDateTimePicker";
            this.cotizacion_FechaDateTimePicker.Size = new System.Drawing.Size(269, 22);
            this.cotizacion_FechaDateTimePicker.TabIndex = 59;
            // 
            // producto_CodTextBox
            // 
            this.producto_CodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwProductosBindingSource, "Codigo de Producto", true));
            this.producto_CodTextBox.Enabled = false;
            this.producto_CodTextBox.Location = new System.Drawing.Point(864, 73);
            this.producto_CodTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.producto_CodTextBox.Name = "producto_CodTextBox";
            this.producto_CodTextBox.Size = new System.Drawing.Size(89, 22);
            this.producto_CodTextBox.TabIndex = 60;
            // 
            // btnCancelarFac
            // 
            this.btnCancelarFac.Enabled = false;
            this.btnCancelarFac.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarFac.Image")));
            this.btnCancelarFac.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarFac.Location = new System.Drawing.Point(943, 671);
            this.btnCancelarFac.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarFac.Name = "btnCancelarFac";
            this.btnCancelarFac.Size = new System.Drawing.Size(100, 60);
            this.btnCancelarFac.TabIndex = 63;
            this.btnCancelarFac.Text = "Cancelar";
            this.btnCancelarFac.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarFac.UseVisualStyleBackColor = true;
            this.btnCancelarFac.Click += new System.EventHandler(this.btnCancelarFac_Click_1);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.Location = new System.Drawing.Point(835, 671);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 60);
            this.btnImprimir.TabIndex = 62;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click_1);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizar.Image")));
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFinalizar.Location = new System.Drawing.Point(727, 671);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(100, 60);
            this.btnFinalizar.TabIndex = 61;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click_1);
            // 
            // cotizacion_DetalleBindingSource
            // 
            this.cotizacion_DetalleBindingSource.DataMember = "Cotizacion_Detalle";
            this.cotizacion_DetalleBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // detalle_FacturaBindingSource
            // 
            this.detalle_FacturaBindingSource.DataMember = "Detalle_Factura";
            this.detalle_FacturaBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // vwCotizacion_DetalleBindingSource
            // 
            this.vwCotizacion_DetalleBindingSource.DataMember = "VwCotizacion_Detalle";
            this.vwCotizacion_DetalleBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // Cotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1261, 788);
            this.Controls.Add(this.btnCancelarFac);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.producto_CodTextBox);
            this.Controls.Add(this.cotizacion_FechaDateTimePicker);
            this.Controls.Add(this.direcciónTextBox);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.btnBuscarCot);
            this.Controls.Add(cotizacion_IDLabel);
            this.Controls.Add(this.cotizacion_IDTextBox);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(precio_UnitarioLabel);
            this.Controls.Add(this.precio_UnitarioTextBox);
            this.Controls.Add(this.vwProductosDataGridView1);
            this.Controls.Add(this.vwProductosDataGridView);
            this.Controls.Add(this.vwClienteDataGridView);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.btnBuscarProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNuevaCot);
            this.Controls.Add(this.btnBuscarClienteNom);
            this.Controls.Add(this.btnBuscarRTN);
            this.Controls.Add(rTNLabel);
            this.Controls.Add(this.rTNTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(direcciónLabel);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(ciudadLabel);
            this.Controls.Add(this.ciudadTextBox);
            this.Controls.Add(paisLabel);
            this.Controls.Add(this.paisTextBox);
            this.Controls.Add(cotizacion_FechaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cotizacion";
            this.Text = "Cotizacion";
            this.Load += new System.EventHandler(this.Cotizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwClienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDetalleFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotizacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotizacion_DetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalle_FacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCotizacion_DetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// The tacoma database data set
        /// </summary>
        private TacomaDBDataSet tacomaDBDataSet;
        /// <summary>
        /// The cotizacion detalle binding source
        /// </summary>
        private System.Windows.Forms.BindingSource cotizacion_DetalleBindingSource;
        /// <summary>
        /// The detalle factura binding source
        /// </summary>
        private System.Windows.Forms.BindingSource detalle_FacturaBindingSource;
        /// <summary>
        /// The vw detalle factura binding source
        /// </summary>
        private System.Windows.Forms.BindingSource vwDetalleFacturaBindingSource;
        /// <summary>
        /// The cotizacion binding source
        /// </summary>
        private System.Windows.Forms.BindingSource cotizacionBindingSource;
        /// <summary>
        /// The vw cliente binding source
        /// </summary>
        private System.Windows.Forms.BindingSource vwClienteBindingSource;
        /// <summary>
        /// The r tn text box
        /// </summary>
        private System.Windows.Forms.TextBox rTNTextBox;
        /// <summary>
        /// The nombre text box
        /// </summary>
        private System.Windows.Forms.TextBox nombreTextBox;
        /// <summary>
        /// The telefono text box
        /// </summary>
        private System.Windows.Forms.TextBox telefonoTextBox;
        /// <summary>
        /// The ciudad text box
        /// </summary>
        private System.Windows.Forms.TextBox ciudadTextBox;
        /// <summary>
        /// The pais text box
        /// </summary>
        private System.Windows.Forms.TextBox paisTextBox;
        /// <summary>
        /// The BTN buscar RTN
        /// </summary>
        private System.Windows.Forms.Button btnBuscarRTN;
        /// <summary>
        /// The BTN buscar cliente nom
        /// </summary>
        private System.Windows.Forms.Button btnBuscarClienteNom;
        /// <summary>
        /// The BTN nueva cot
        /// </summary>
        private System.Windows.Forms.Button btnNuevaCot;
        /// <summary>
        /// The vw cotizacion detalle binding source
        /// </summary>
        private System.Windows.Forms.BindingSource vwCotizacion_DetalleBindingSource;
        /// <summary>
        /// The label1
        /// </summary>
        private System.Windows.Forms.Label label1;
        /// <summary>
        /// The BTN buscar product
        /// </summary>
        private System.Windows.Forms.Button btnBuscarProd;
        /// <summary>
        /// The BTN anadir
        /// </summary>
        private System.Windows.Forms.Button btnAnadir;
        /// <summary>
        /// The BTN eliminar
        /// </summary>
        private System.Windows.Forms.Button btnEliminar;
        /// <summary>
        /// The vw productos data grid view
        /// </summary>
        private System.Windows.Forms.DataGridView vwProductosDataGridView;
        /// <summary>
        /// The vw cliente data grid view
        /// </summary>
        private System.Windows.Forms.DataGridView vwClienteDataGridView;
        /// <summary>
        /// The data grid view text box column6
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        /// <summary>
        /// The data grid view text box column12
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        /// <summary>
        /// The data grid view text box column14
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        /// <summary>
        /// The data grid view text box column15
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        /// <summary>
        /// The data grid view text box column16
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        /// <summary>
        /// The error RTN
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorRTN;
        /// <summary>
        /// The error nombre
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorNombre;
        /// <summary>
        /// The producto binding source
        /// </summary>
        private System.Windows.Forms.BindingSource productoBindingSource;
        /// <summary>
        /// The vw productos binding source
        /// </summary>
        private System.Windows.Forms.BindingSource vwProductosBindingSource;
        /// <summary>
        /// The vw productos data grid view1
        /// </summary>
        private System.Windows.Forms.DataGridView vwProductosDataGridView1;
        /// <summary>
        /// The data grid view text box column7
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        /// <summary>
        /// The data grid view text box column8
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        /// <summary>
        /// The data grid view text box column9
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        /// <summary>
        /// The data grid view text box column10
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        /// <summary>
        /// The data grid view text box column11
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        /// <summary>
        /// The cantidad text box
        /// </summary>
        private System.Windows.Forms.TextBox cantidadTextBox;
        /// <summary>
        /// The descripcion text box
        /// </summary>
        private System.Windows.Forms.TextBox descripcionTextBox;
        /// <summary>
        /// The precio unitario text box
        /// </summary>
        private System.Windows.Forms.TextBox precio_UnitarioTextBox;
        /// <summary>
        /// The BTN buscar cot
        /// </summary>
        private System.Windows.Forms.Button btnBuscarCot;
        /// <summary>
        /// The cotizacion identifier text box
        /// </summary>
        private System.Windows.Forms.TextBox cotizacion_IDTextBox;
        /// <summary>
        /// The DGV detalle
        /// </summary>
        private System.Windows.Forms.DataGridView dgvDetalle;
        /// <summary>
        /// The codigo
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        /// <summary>
        /// The descripcion
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        /// <summary>
        /// The precio uni
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_uni;
        /// <summary>
        /// The cantidad
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        /// <summary>
        /// The total
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        /// <summary>
        /// The dirección text box
        /// </summary>
        private System.Windows.Forms.TextBox direcciónTextBox;
        /// <summary>
        /// The cotizacion fecha date time picker
        /// </summary>
        private System.Windows.Forms.DateTimePicker cotizacion_FechaDateTimePicker;
        /// <summary>
        /// The producto cod text box
        /// </summary>
        private System.Windows.Forms.TextBox producto_CodTextBox;
        /// <summary>
        /// The BTN cancelar fac
        /// </summary>
        private System.Windows.Forms.Button btnCancelarFac;
        /// <summary>
        /// The BTN imprimir
        /// </summary>
        private System.Windows.Forms.Button btnImprimir;
        /// <summary>
        /// The BTN finalizar
        /// </summary>
        private System.Windows.Forms.Button btnFinalizar;
    }
}