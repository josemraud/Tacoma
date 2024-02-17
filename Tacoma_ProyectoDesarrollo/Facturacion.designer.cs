// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 12-13-2019
//
// Last Modified By : pepit
// Last Modified On : 12-13-2019
// ***********************************************************************
// <copyright file="Facturacion.designer.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class Facturacion.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class Facturacion
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
            System.Windows.Forms.Label rTNLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label direcciónLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label paisLabel;
            System.Windows.Forms.Label factura_FechaLabel;
            System.Windows.Forms.Label pago_DescripcionLabel;
            System.Windows.Forms.Label codigo_de_ProductoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label precio_UnitarioLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion));
            this.vwClienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tacomaDBDataSet = new Tacoma_ProyectoDesarrollo.TacomaDBDataSet();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.ciudadTextBox = new System.Windows.Forms.TextBox();
            this.paisTextBox = new System.Windows.Forms.TextBox();
            this.btnBuscarRTN = new System.Windows.Forms.Button();
            this.btnNuevaFac = new System.Windows.Forms.Button();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.errorRTN = new System.Windows.Forms.ErrorProvider(this.components);
            this.vwProductosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.precio_UnitarioTextBox = new System.Windows.Forms.TextBox();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.vwDetalleFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producto_CodTextBox = new System.Windows.Forms.TextBox();
            this.detalle_FacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_uni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.errorCant = new System.Windows.Forms.ErrorProvider(this.components);
            this.rTNTextBox = new System.Windows.Forms.TextBox();
            this.btnBuscarClienteNom = new System.Windows.Forms.Button();
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.factura_FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.direcciónTextBox = new System.Windows.Forms.TextBox();
            this.btnCancelarFac = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoDePagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            rTNLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            direcciónLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            factura_FechaLabel = new System.Windows.Forms.Label();
            pago_DescripcionLabel = new System.Windows.Forms.Label();
            codigo_de_ProductoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            precio_UnitarioLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vwClienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDetalleFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalle_FacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDePagoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rTNLabel
            // 
            rTNLabel.AutoSize = true;
            rTNLabel.Location = new System.Drawing.Point(140, 70);
            rTNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rTNLabel.Name = "rTNLabel";
            rTNLabel.Size = new System.Drawing.Size(41, 17);
            rTNLabel.TabIndex = 1;
            rTNLabel.Text = "RTN:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(140, 102);
            nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(62, 17);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // direcciónLabel
            // 
            direcciónLabel.AutoSize = true;
            direcciónLabel.Location = new System.Drawing.Point(140, 134);
            direcciónLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            direcciónLabel.Name = "direcciónLabel";
            direcciónLabel.Size = new System.Drawing.Size(71, 17);
            direcciónLabel.TabIndex = 5;
            direcciónLabel.Text = "Dirección:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(140, 166);
            telefonoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(68, 17);
            telefonoLabel.TabIndex = 7;
            telefonoLabel.Text = "Telefono:";
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Location = new System.Drawing.Point(140, 198);
            ciudadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(56, 17);
            ciudadLabel.TabIndex = 9;
            ciudadLabel.Text = "Ciudad:";
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Location = new System.Drawing.Point(140, 230);
            paisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(39, 17);
            paisLabel.TabIndex = 11;
            paisLabel.Text = "Pais:";
            // 
            // factura_FechaLabel
            // 
            factura_FechaLabel.AutoSize = true;
            factura_FechaLabel.Location = new System.Drawing.Point(368, 20);
            factura_FechaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            factura_FechaLabel.Name = "factura_FechaLabel";
            factura_FechaLabel.Size = new System.Drawing.Size(51, 17);
            factura_FechaLabel.TabIndex = 16;
            factura_FechaLabel.Text = "Fecha:";
            // 
            // pago_DescripcionLabel
            // 
            pago_DescripcionLabel.AutoSize = true;
            pago_DescripcionLabel.Location = new System.Drawing.Point(140, 262);
            pago_DescripcionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pago_DescripcionLabel.Name = "pago_DescripcionLabel";
            pago_DescripcionLabel.Size = new System.Drawing.Size(97, 17);
            pago_DescripcionLabel.TabIndex = 19;
            pago_DescripcionLabel.Text = "Tipo de Pago:";
            // 
            // codigo_de_ProductoLabel
            // 
            codigo_de_ProductoLabel.AutoSize = true;
            codigo_de_ProductoLabel.Location = new System.Drawing.Point(660, 70);
            codigo_de_ProductoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codigo_de_ProductoLabel.Name = "codigo_de_ProductoLabel";
            codigo_de_ProductoLabel.Size = new System.Drawing.Size(137, 17);
            codigo_de_ProductoLabel.TabIndex = 22;
            codigo_de_ProductoLabel.Text = "Codigo de Producto:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(660, 102);
            descripcionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(86, 17);
            descripcionLabel.TabIndex = 24;
            descripcionLabel.Text = "Descripcion:";
            // 
            // precio_UnitarioLabel
            // 
            precio_UnitarioLabel.AutoSize = true;
            precio_UnitarioLabel.Location = new System.Drawing.Point(660, 134);
            precio_UnitarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            precio_UnitarioLabel.Name = "precio_UnitarioLabel";
            precio_UnitarioLabel.Size = new System.Drawing.Size(105, 17);
            precio_UnitarioLabel.TabIndex = 26;
            precio_UnitarioLabel.Text = "Precio Unitario:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(660, 166);
            cantidadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(68, 17);
            cantidadLabel.TabIndex = 32;
            cantidadLabel.Text = "Cantidad:";
            // 
            // vwClienteDataGridView
            // 
            this.vwClienteDataGridView.AllowUserToAddRows = false;
            this.vwClienteDataGridView.AllowUserToDeleteRows = false;
            this.vwClienteDataGridView.AutoGenerateColumns = false;
            this.vwClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vwClienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.vwClienteDataGridView.DataSource = this.vwClienteBindingSource;
            this.vwClienteDataGridView.Location = new System.Drawing.Point(63, 708);
            this.vwClienteDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vwClienteDataGridView.Name = "vwClienteDataGridView";
            this.vwClienteDataGridView.ReadOnly = true;
            this.vwClienteDataGridView.RowHeadersWidth = 51;
            this.vwClienteDataGridView.Size = new System.Drawing.Size(13, 12);
            this.vwClienteDataGridView.TabIndex = 1;
            this.vwClienteDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RTN";
            this.dataGridViewTextBoxColumn1.HeaderText = "RTN";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ciudad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ciudad";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Pais";
            this.dataGridViewTextBoxColumn6.HeaderText = "Pais";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // vwClienteBindingSource
            // 
            this.vwClienteBindingSource.DataMember = "VwCliente";
            this.vwClienteBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // tacomaDBDataSet
            // 
            this.tacomaDBDataSet.DataSetName = "TacomaDBDataSet";
            this.tacomaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwClienteBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(247, 98);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombreTextBox.MaxLength = 50;
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(117, 22);
            this.nombreTextBox.TabIndex = 4;
            this.nombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreTextBox_KeyPress);
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwClienteBindingSource, "Telefono", true));
            this.telefonoTextBox.Enabled = false;
            this.telefonoTextBox.Location = new System.Drawing.Point(247, 162);
            this.telefonoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(179, 22);
            this.telefonoTextBox.TabIndex = 8;
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwClienteBindingSource, "Ciudad", true));
            this.ciudadTextBox.Enabled = false;
            this.ciudadTextBox.Location = new System.Drawing.Point(247, 194);
            this.ciudadTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.ciudadTextBox.Size = new System.Drawing.Size(179, 22);
            this.ciudadTextBox.TabIndex = 10;
            // 
            // paisTextBox
            // 
            this.paisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwClienteBindingSource, "Pais", true));
            this.paisTextBox.Enabled = false;
            this.paisTextBox.Location = new System.Drawing.Point(247, 226);
            this.paisTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paisTextBox.Name = "paisTextBox";
            this.paisTextBox.Size = new System.Drawing.Size(179, 22);
            this.paisTextBox.TabIndex = 12;
            // 
            // btnBuscarRTN
            // 
            this.btnBuscarRTN.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarRTN.Image")));
            this.btnBuscarRTN.Location = new System.Drawing.Point(395, 64);
            this.btnBuscarRTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarRTN.Name = "btnBuscarRTN";
            this.btnBuscarRTN.Size = new System.Drawing.Size(32, 28);
            this.btnBuscarRTN.TabIndex = 13;
            this.btnBuscarRTN.UseVisualStyleBackColor = true;
            this.btnBuscarRTN.Click += new System.EventHandler(this.btnBuscarRTN_Click);
            // 
            // btnNuevaFac
            // 
            this.btnNuevaFac.Enabled = false;
            this.btnNuevaFac.Location = new System.Drawing.Point(144, 292);
            this.btnNuevaFac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevaFac.Name = "btnNuevaFac";
            this.btnNuevaFac.Size = new System.Drawing.Size(283, 28);
            this.btnNuevaFac.TabIndex = 18;
            this.btnNuevaFac.Text = "Ingresar nueva factura";
            this.btnNuevaFac.UseVisualStyleBackColor = true;
            this.btnNuevaFac.Click += new System.EventHandler(this.btnNuevaFac_Click);
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPago.Enabled = false;
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Items.AddRange(new object[] {
            "Contado",
            "Crédito"});
            this.cmbTipoPago.Location = new System.Drawing.Point(248, 258);
            this.cmbTipoPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(177, 24);
            this.cmbTipoPago.TabIndex = 21;
            this.cmbTipoPago.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPago_SelectedIndexChanged);
            this.cmbTipoPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTipoPago_KeyPress);
            // 
            // errorRTN
            // 
            this.errorRTN.ContainerControl = this;
            // 
            // vwProductosDataGridView
            // 
            this.vwProductosDataGridView.AutoGenerateColumns = false;
            this.vwProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vwProductosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.vwProductosDataGridView.DataSource = this.vwProductosBindingSource;
            this.vwProductosDataGridView.Location = new System.Drawing.Point(84, 708);
            this.vwProductosDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vwProductosDataGridView.Name = "vwProductosDataGridView";
            this.vwProductosDataGridView.RowHeadersWidth = 51;
            this.vwProductosDataGridView.Size = new System.Drawing.Size(13, 12);
            this.vwProductosDataGridView.TabIndex = 21;
            this.vwProductosDataGridView.Visible = false;
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
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwProductosBindingSource, "Descripcion", true));
            this.descripcionTextBox.Enabled = false;
            this.descripcionTextBox.Location = new System.Drawing.Point(807, 98);
            this.descripcionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descripcionTextBox.MaxLength = 50;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(177, 22);
            this.descripcionTextBox.TabIndex = 25;
            // 
            // precio_UnitarioTextBox
            // 
            this.precio_UnitarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwProductosBindingSource, "Precio Unitario", true));
            this.precio_UnitarioTextBox.Enabled = false;
            this.precio_UnitarioTextBox.Location = new System.Drawing.Point(807, 130);
            this.precio_UnitarioTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.precio_UnitarioTextBox.Name = "precio_UnitarioTextBox";
            this.precio_UnitarioTextBox.Size = new System.Drawing.Size(177, 22);
            this.precio_UnitarioTextBox.TabIndex = 27;
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.Enabled = false;
            this.btnBuscarProd.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProd.Image")));
            this.btnBuscarProd.Location = new System.Drawing.Point(953, 63);
            this.btnBuscarProd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(32, 28);
            this.btnBuscarProd.TabIndex = 30;
            this.btnBuscarProd.UseVisualStyleBackColor = true;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Enabled = false;
            this.btnAñadir.Location = new System.Drawing.Point(664, 194);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(321, 28);
            this.btnAñadir.TabIndex = 32;
            this.btnAñadir.Text = "Añadir a la compra";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwDetalleFacturaBindingSource, "Cantidad", true));
            this.cantidadTextBox.Enabled = false;
            this.cantidadTextBox.Location = new System.Drawing.Point(807, 162);
            this.cantidadTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cantidadTextBox.MaxLength = 5;
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(177, 22);
            this.cantidadTextBox.TabIndex = 33;
            this.cantidadTextBox.TextChanged += new System.EventHandler(this.cantidadTextBox_TextChanged);
            this.cantidadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidadTextBox_KeyPress);
            // 
            // vwDetalleFacturaBindingSource
            // 
            this.vwDetalleFacturaBindingSource.DataMember = "VwDetalleFactura";
            this.vwDetalleFacturaBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // producto_CodTextBox
            // 
            this.producto_CodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_FacturaBindingSource, "Producto_Cod", true));
            this.producto_CodTextBox.Enabled = false;
            this.producto_CodTextBox.Location = new System.Drawing.Point(807, 66);
            this.producto_CodTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.producto_CodTextBox.MaxLength = 4;
            this.producto_CodTextBox.Name = "producto_CodTextBox";
            this.producto_CodTextBox.Size = new System.Drawing.Size(124, 22);
            this.producto_CodTextBox.TabIndex = 34;
            this.producto_CodTextBox.TextChanged += new System.EventHandler(this.producto_CodTextBox_TextChanged);
            this.producto_CodTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.producto_CodTextBox_KeyPress);
            // 
            // detalle_FacturaBindingSource
            // 
            this.detalle_FacturaBindingSource.DataMember = "Detalle_Factura";
            this.detalle_FacturaBindingSource.DataSource = this.tacomaDBDataSet;
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
            this.dgvDetalle.Location = new System.Drawing.Point(144, 327);
            this.dgvDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.Size = new System.Drawing.Size(841, 254);
            this.dgvDetalle.TabIndex = 39;
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
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(144, 588);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 42;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // errorCant
            // 
            this.errorCant.ContainerControl = this;
            // 
            // rTNTextBox
            // 
            this.rTNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwClienteBindingSource, "RTN", true));
            this.rTNTextBox.Location = new System.Drawing.Point(247, 66);
            this.rTNTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rTNTextBox.MaxLength = 14;
            this.rTNTextBox.Name = "rTNTextBox";
            this.rTNTextBox.Size = new System.Drawing.Size(117, 22);
            this.rTNTextBox.TabIndex = 43;
            // 
            // btnBuscarClienteNom
            // 
            this.btnBuscarClienteNom.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarClienteNom.Image")));
            this.btnBuscarClienteNom.Location = new System.Drawing.Point(395, 98);
            this.btnBuscarClienteNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarClienteNom.Name = "btnBuscarClienteNom";
            this.btnBuscarClienteNom.Size = new System.Drawing.Size(32, 28);
            this.btnBuscarClienteNom.TabIndex = 44;
            this.btnBuscarClienteNom.UseVisualStyleBackColor = true;
            this.btnBuscarClienteNom.Click += new System.EventHandler(this.btnBuscarClienteNom_Click);
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // factura_FechaDateTimePicker
            // 
            this.factura_FechaDateTimePicker.Enabled = false;
            this.factura_FechaDateTimePicker.Location = new System.Drawing.Point(429, 15);
            this.factura_FechaDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.factura_FechaDateTimePicker.Name = "factura_FechaDateTimePicker";
            this.factura_FechaDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.factura_FechaDateTimePicker.TabIndex = 46;
            // 
            // direcciónTextBox
            // 
            this.direcciónTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwClienteBindingSource, "Direccion", true));
            this.direcciónTextBox.Enabled = false;
            this.direcciónTextBox.Location = new System.Drawing.Point(247, 130);
            this.direcciónTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.direcciónTextBox.Name = "direcciónTextBox";
            this.direcciónTextBox.Size = new System.Drawing.Size(180, 22);
            this.direcciónTextBox.TabIndex = 47;
            // 
            // btnCancelarFac
            // 
            this.btnCancelarFac.Enabled = false;
            this.btnCancelarFac.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarFac.Image")));
            this.btnCancelarFac.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarFac.Location = new System.Drawing.Point(885, 635);
            this.btnCancelarFac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelarFac.Name = "btnCancelarFac";
            this.btnCancelarFac.Size = new System.Drawing.Size(100, 60);
            this.btnCancelarFac.TabIndex = 50;
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
            this.btnImprimir.Location = new System.Drawing.Point(777, 635);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 60);
            this.btnImprimir.TabIndex = 49;
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
            this.btnFinalizar.Location = new System.Drawing.Point(669, 635);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(100, 60);
            this.btnFinalizar.TabIndex = 48;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click_1);
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataMember = "Factura";
            this.facturaBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // tipoDePagoBindingSource
            // 
            this.tipoDePagoBindingSource.DataMember = "TipoDePago";
            this.tipoDePagoBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1239, 745);
            this.Controls.Add(this.btnCancelarFac);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.direcciónTextBox);
            this.Controls.Add(this.factura_FechaDateTimePicker);
            this.Controls.Add(this.btnBuscarClienteNom);
            this.Controls.Add(this.rTNTextBox);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.producto_CodTextBox);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnBuscarProd);
            this.Controls.Add(codigo_de_ProductoLabel);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(precio_UnitarioLabel);
            this.Controls.Add(this.precio_UnitarioTextBox);
            this.Controls.Add(this.vwProductosDataGridView);
            this.Controls.Add(this.cmbTipoPago);
            this.Controls.Add(pago_DescripcionLabel);
            this.Controls.Add(this.btnNuevaFac);
            this.Controls.Add(factura_FechaLabel);
            this.Controls.Add(this.btnBuscarRTN);
            this.Controls.Add(rTNLabel);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(direcciónLabel);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(ciudadLabel);
            this.Controls.Add(this.ciudadTextBox);
            this.Controls.Add(paisLabel);
            this.Controls.Add(this.paisTextBox);
            this.Controls.Add(this.vwClienteDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwClienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDetalleFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalle_FacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDePagoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// The tacoma database data set
        /// </summary>
        private TacomaDBDataSet tacomaDBDataSet;
        /// <summary>
        /// The vw cliente binding source
        /// </summary>
        private System.Windows.Forms.BindingSource vwClienteBindingSource;
        /// <summary>
        /// The vw cliente data grid view
        /// </summary>
        private System.Windows.Forms.DataGridView vwClienteDataGridView;
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
        /// The data grid view text box column6
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
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
        /// The factura binding source
        /// </summary>
        private System.Windows.Forms.BindingSource facturaBindingSource;
        /// <summary>
        /// The BTN nueva fac
        /// </summary>
        private System.Windows.Forms.Button btnNuevaFac;
        /// <summary>
        /// The tipo de pago binding source
        /// </summary>
        private System.Windows.Forms.BindingSource tipoDePagoBindingSource;
        /// <summary>
        /// The CMB tipo pago
        /// </summary>
        private System.Windows.Forms.ComboBox cmbTipoPago;
        /// <summary>
        /// The error RTN
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorRTN;
        /// <summary>
        /// The vw productos binding source
        /// </summary>
        private System.Windows.Forms.BindingSource vwProductosBindingSource;
        /// <summary>
        /// The vw productos data grid view
        /// </summary>
        private System.Windows.Forms.DataGridView vwProductosDataGridView;
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
        /// The descripcion text box
        /// </summary>
        private System.Windows.Forms.TextBox descripcionTextBox;
        /// <summary>
        /// The precio unitario text box
        /// </summary>
        private System.Windows.Forms.TextBox precio_UnitarioTextBox;
        /// <summary>
        /// The detalle factura binding source
        /// </summary>
        private System.Windows.Forms.BindingSource detalle_FacturaBindingSource;
        /// <summary>
        /// The BTN buscar product
        /// </summary>
        private System.Windows.Forms.Button btnBuscarProd;
        /// <summary>
        /// The vw detalle factura binding source
        /// </summary>
        private System.Windows.Forms.BindingSource vwDetalleFacturaBindingSource;
        /// <summary>
        /// The BTN añadir
        /// </summary>
        private System.Windows.Forms.Button btnAñadir;
        /// <summary>
        /// The cantidad text box
        /// </summary>
        private System.Windows.Forms.TextBox cantidadTextBox;
        /// <summary>
        /// The producto cod text box
        /// </summary>
        private System.Windows.Forms.TextBox producto_CodTextBox;
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
        /// The BTN eliminar
        /// </summary>
        private System.Windows.Forms.Button btnEliminar;
        /// <summary>
        /// The error cant
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorCant;
        /// <summary>
        /// The r tn text box
        /// </summary>
        private System.Windows.Forms.TextBox rTNTextBox;
        /// <summary>
        /// The BTN buscar cliente nom
        /// </summary>
        private System.Windows.Forms.Button btnBuscarClienteNom;
        /// <summary>
        /// The error nombre
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorNombre;
        /// <summary>
        /// The factura fecha date time picker
        /// </summary>
        private System.Windows.Forms.DateTimePicker factura_FechaDateTimePicker;
        /// <summary>
        /// The dirección text box
        /// </summary>
        private System.Windows.Forms.TextBox direcciónTextBox;
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