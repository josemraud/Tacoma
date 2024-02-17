// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 12-13-2019
//
// Last Modified By : pepit
// Last Modified On : 12-13-2019
// ***********************************************************************
// <copyright file="Historial Cotizaciones.designer.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class Historial_Cotizaciones.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class Historial_Cotizaciones
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
            System.Windows.Forms.Label cotizacionLabel1;
            System.Windows.Forms.Label rTN_del_ClienteLabel;
            System.Windows.Forms.Label nombre_del_ClienteLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label cotizacionLabel;
            this.vwCotizacionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwCotizacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tacomaDBDataSet = new Tacoma_ProyectoDesarrollo.TacomaDBDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.vwClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.tipoDePagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoDePagoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cotizacionTextBox1 = new System.Windows.Forms.TextBox();
            this.rTN_del_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.nombre_del_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.cmbBusqueda = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.historialDetalleCotizacionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historialDetalleCotizacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historialCotizacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoDePagoTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.TipoDePagoTableAdapter();
            this.historialCotizacionTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.HistorialCotizacionTableAdapter();
            this.tableAdapterManager = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.TableAdapterManager();
            this.vwCotizacionTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.VwCotizacionTableAdapter();
            this.cotizacionTextBox = new System.Windows.Forms.TextBox();
            cotizacionLabel1 = new System.Windows.Forms.Label();
            rTN_del_ClienteLabel = new System.Windows.Forms.Label();
            nombre_del_ClienteLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            cotizacionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vwCotizacionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCotizacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDePagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDePagoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialDetalleCotizacionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialDetalleCotizacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialCotizacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cotizacionLabel1
            // 
            cotizacionLabel1.AutoSize = true;
            cotizacionLabel1.Location = new System.Drawing.Point(28, 34);
            cotizacionLabel1.Name = "cotizacionLabel1";
            cotizacionLabel1.Size = new System.Drawing.Size(77, 17);
            cotizacionLabel1.TabIndex = 0;
            cotizacionLabel1.Text = "Cotizacion:";
            // 
            // rTN_del_ClienteLabel
            // 
            rTN_del_ClienteLabel.AutoSize = true;
            rTN_del_ClienteLabel.Location = new System.Drawing.Point(28, 59);
            rTN_del_ClienteLabel.Name = "rTN_del_ClienteLabel";
            rTN_del_ClienteLabel.Size = new System.Drawing.Size(111, 17);
            rTN_del_ClienteLabel.TabIndex = 2;
            rTN_del_ClienteLabel.Text = "RTN del Cliente:";
            // 
            // nombre_del_ClienteLabel
            // 
            nombre_del_ClienteLabel.AutoSize = true;
            nombre_del_ClienteLabel.Location = new System.Drawing.Point(28, 85);
            nombre_del_ClienteLabel.Name = "nombre_del_ClienteLabel";
            nombre_del_ClienteLabel.Size = new System.Drawing.Size(132, 17);
            nombre_del_ClienteLabel.TabIndex = 4;
            nombre_del_ClienteLabel.Text = "Nombre del Cliente:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(28, 167);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(51, 17);
            fechaLabel.TabIndex = 6;
            fechaLabel.Text = "Fecha:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(28, 112);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(71, 17);
            direccionLabel.TabIndex = 24;
            direccionLabel.Text = "Direccion:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(28, 140);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(68, 17);
            telefonoLabel.TabIndex = 25;
            telefonoLabel.Text = "Telefono:";
            // 
            // cotizacionLabel
            // 
            cotizacionLabel.AutoSize = true;
            cotizacionLabel.Location = new System.Drawing.Point(195, 167);
            cotizacionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cotizacionLabel.Name = "cotizacionLabel";
            cotizacionLabel.Size = new System.Drawing.Size(77, 17);
            cotizacionLabel.TabIndex = 9;
            cotizacionLabel.Text = "Cotizacion:";
            // 
            // vwCotizacionDataGridView
            // 
            this.vwCotizacionDataGridView.AllowUserToAddRows = false;
            this.vwCotizacionDataGridView.AllowUserToDeleteRows = false;
            this.vwCotizacionDataGridView.AutoGenerateColumns = false;
            this.vwCotizacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vwCotizacionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.vwCotizacionDataGridView.DataSource = this.vwCotizacionBindingSource;
            this.vwCotizacionDataGridView.Location = new System.Drawing.Point(55, 78);
            this.vwCotizacionDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vwCotizacionDataGridView.Name = "vwCotizacionDataGridView";
            this.vwCotizacionDataGridView.ReadOnly = true;
            this.vwCotizacionDataGridView.RowHeadersWidth = 62;
            this.vwCotizacionDataGridView.RowTemplate.Height = 28;
            this.vwCotizacionDataGridView.Size = new System.Drawing.Size(664, 263);
            this.vwCotizacionDataGridView.TabIndex = 1;
            this.vwCotizacionDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vwCotizacionDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cotizacion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cotizacion";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RTN del Cliente";
            this.dataGridViewTextBoxColumn4.HeaderText = "RTN del Cliente";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Nombre del Cliente";
            this.dataGridViewTextBoxColumn9.HeaderText = "Nombre del Cliente";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn10.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // vwCotizacionBindingSource
            // 
            this.vwCotizacionBindingSource.DataMember = "VwCotizacion";
            this.vwCotizacionBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // tacomaDBDataSet
            // 
            this.tacomaDBDataSet.DataSetName = "TacomaDBDataSet";
            this.tacomaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(telefonoLabel);
            this.panel1.Controls.Add(this.telefonoTextBox);
            this.panel1.Controls.Add(direccionLabel);
            this.panel1.Controls.Add(this.direccionTextBox);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.cmbTipoPago);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(cotizacionLabel1);
            this.panel1.Controls.Add(this.cotizacionTextBox1);
            this.panel1.Controls.Add(rTN_del_ClienteLabel);
            this.panel1.Controls.Add(this.rTN_del_ClienteTextBox);
            this.panel1.Controls.Add(nombre_del_ClienteLabel);
            this.panel1.Controls.Add(this.nombre_del_ClienteTextBox);
            this.panel1.Controls.Add(fechaLabel);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(724, 107);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 366);
            this.panel1.TabIndex = 4;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwClienteBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(164, 137);
            this.telefonoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telefonoTextBox.MaxLength = 8;
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(177, 22);
            this.telefonoTextBox.TabIndex = 26;
            this.telefonoTextBox.TextChanged += new System.EventHandler(this.telefonoTextBox_TextChanged);
            this.telefonoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefonoTextBox_KeyPress);
            // 
            // vwClienteBindingSource
            // 
            this.vwClienteBindingSource.DataMember = "VwCliente";
            this.vwClienteBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwClienteBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(164, 110);
            this.direccionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.direccionTextBox.MaxLength = 50;
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(177, 22);
            this.direccionTextBox.TabIndex = 25;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(129, 288);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 58);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar Factura";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(237, 288);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(103, 58);
            this.btnImprimir.TabIndex = 23;
            this.btnImprimir.Text = "Imprimir Factura";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tipoDePagoBindingSource, "Pago_ID", true));
            this.cmbTipoPago.DataSource = this.tipoDePagoBindingSource1;
            this.cmbTipoPago.DisplayMember = "Pago_Descripcion";
            this.cmbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Location = new System.Drawing.Point(164, 191);
            this.cmbTipoPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(177, 24);
            this.cmbTipoPago.TabIndex = 22;
            this.cmbTipoPago.ValueMember = "Pago_ID";
            this.cmbTipoPago.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPago_SelectedIndexChanged);
            this.cmbTipoPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTipoPago_KeyPress);
            // 
            // tipoDePagoBindingSource
            // 
            this.tipoDePagoBindingSource.DataMember = "TipoDePago";
            this.tipoDePagoBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // tipoDePagoBindingSource1
            // 
            this.tipoDePagoBindingSource1.DataMember = "TipoDePago";
            this.tipoDePagoBindingSource1.DataSource = this.tacomaDBDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tipo de Pago:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(164, 164);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // cotizacionTextBox1
            // 
            this.cotizacionTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwCotizacionBindingSource, "Cotizacion", true));
            this.cotizacionTextBox1.Enabled = false;
            this.cotizacionTextBox1.Location = new System.Drawing.Point(164, 31);
            this.cotizacionTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cotizacionTextBox1.Name = "cotizacionTextBox1";
            this.cotizacionTextBox1.Size = new System.Drawing.Size(177, 22);
            this.cotizacionTextBox1.TabIndex = 1;
            // 
            // rTN_del_ClienteTextBox
            // 
            this.rTN_del_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwCotizacionBindingSource, "RTN del Cliente", true));
            this.rTN_del_ClienteTextBox.Enabled = false;
            this.rTN_del_ClienteTextBox.Location = new System.Drawing.Point(164, 57);
            this.rTN_del_ClienteTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rTN_del_ClienteTextBox.Name = "rTN_del_ClienteTextBox";
            this.rTN_del_ClienteTextBox.Size = new System.Drawing.Size(177, 22);
            this.rTN_del_ClienteTextBox.TabIndex = 3;
            // 
            // nombre_del_ClienteTextBox
            // 
            this.nombre_del_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwCotizacionBindingSource, "Nombre del Cliente", true));
            this.nombre_del_ClienteTextBox.Enabled = false;
            this.nombre_del_ClienteTextBox.Location = new System.Drawing.Point(164, 82);
            this.nombre_del_ClienteTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombre_del_ClienteTextBox.Name = "nombre_del_ClienteTextBox";
            this.nombre_del_ClienteTextBox.Size = new System.Drawing.Size(177, 22);
            this.nombre_del_ClienteTextBox.TabIndex = 5;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(749, 78);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(80, 26);
            this.btnFacturar.TabIndex = 5;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // cmbBusqueda
            // 
            this.cmbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusqueda.FormattingEnabled = true;
            this.cmbBusqueda.Items.AddRange(new object[] {
            "Código de Cotización",
            "RTN",
            "Nombre de Cliente",
            "Todo"});
            this.cmbBusqueda.Location = new System.Drawing.Point(53, 38);
            this.cmbBusqueda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Size = new System.Drawing.Size(143, 24);
            this.cmbBusqueda.TabIndex = 6;
            this.cmbBusqueda.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(203, 39);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(356, 22);
            this.txtBuscar.TabIndex = 7;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(563, 37);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 26);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(835, 78);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 26);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // historialDetalleCotizacionDataGridView
            // 
            this.historialDetalleCotizacionDataGridView.AllowUserToAddRows = false;
            this.historialDetalleCotizacionDataGridView.AllowUserToDeleteRows = false;
            this.historialDetalleCotizacionDataGridView.AutoGenerateColumns = false;
            this.historialDetalleCotizacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historialDetalleCotizacionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn11});
            this.historialDetalleCotizacionDataGridView.DataSource = this.historialDetalleCotizacionBindingSource;
            this.historialDetalleCotizacionDataGridView.Location = new System.Drawing.Point(53, 357);
            this.historialDetalleCotizacionDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.historialDetalleCotizacionDataGridView.Name = "historialDetalleCotizacionDataGridView";
            this.historialDetalleCotizacionDataGridView.ReadOnly = true;
            this.historialDetalleCotizacionDataGridView.RowHeadersWidth = 62;
            this.historialDetalleCotizacionDataGridView.RowTemplate.Height = 28;
            this.historialDetalleCotizacionDataGridView.Size = new System.Drawing.Size(664, 286);
            this.historialDetalleCotizacionDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cotización";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cotización";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Código de Producto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Código de Producto";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Producto";
            this.dataGridViewTextBoxColumn7.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn8.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Precio Unitario";
            this.dataGridViewTextBoxColumn11.HeaderText = "Precio Unitario";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // historialDetalleCotizacionBindingSource
            // 
            this.historialDetalleCotizacionBindingSource.DataMember = "HistorialDetalleCotizacion";
            this.historialDetalleCotizacionBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // historialCotizacionBindingSource
            // 
            this.historialCotizacionBindingSource.DataMember = "HistorialCotizacion";
            this.historialCotizacionBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // tipoDePagoTableAdapter
            // 
            this.tipoDePagoTableAdapter.ClearBeforeFill = true;
            // 
            // historialCotizacionTableAdapter
            // 
            this.historialCotizacionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CiudadTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
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
            this.tableAdapterManager.TipoDePagoTableAdapter = this.tipoDePagoTableAdapter;
            this.tableAdapterManager.UpdateOrder = Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // vwCotizacionTableAdapter
            // 
            this.vwCotizacionTableAdapter.ClearBeforeFill = true;
            // 
            // cotizacionTextBox
            // 
            this.cotizacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwCotizacionBindingSource, "Cotizacion", true));
            this.cotizacionTextBox.Location = new System.Drawing.Point(335, 164);
            this.cotizacionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cotizacionTextBox.Name = "cotizacionTextBox";
            this.cotizacionTextBox.Size = new System.Drawing.Size(265, 22);
            this.cotizacionTextBox.TabIndex = 10;
            this.cotizacionTextBox.TextChanged += new System.EventHandler(this.cotizacionTextBox_TextChanged_1);
            // 
            // Historial_Cotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 705);
            this.Controls.Add(this.vwCotizacionDataGridView);
            this.Controls.Add(cotizacionLabel);
            this.Controls.Add(this.cotizacionTextBox);
            this.Controls.Add(this.historialDetalleCotizacionDataGridView);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cmbBusqueda);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Historial_Cotizaciones";
            this.Text = "Historial_Cotizaciones";
            this.Load += new System.EventHandler(this.Historial_Cotizaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwCotizacionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwCotizacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDePagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDePagoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialDetalleCotizacionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialDetalleCotizacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialCotizacionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// The tacoma database data set
        /// </summary>
        private TacomaDBDataSet tacomaDBDataSet;
        /// <summary>
        /// The vw cotizacion binding source
        /// </summary>
        private System.Windows.Forms.BindingSource vwCotizacionBindingSource;
        /// <summary>
        /// The historial cotizacion binding source
        /// </summary>
        private System.Windows.Forms.BindingSource historialCotizacionBindingSource;
        /// <summary>
        /// The data grid view text box column1
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        /// <summary>
        /// The data grid view text box column3
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        /// <summary>
        /// The historial detalle cotizacion binding source
        /// </summary>
        private System.Windows.Forms.BindingSource historialDetalleCotizacionBindingSource;
        /// <summary>
        /// The vw cotizacion data grid view
        /// </summary>
        private System.Windows.Forms.DataGridView vwCotizacionDataGridView;
        /// <summary>
        /// The panel1
        /// </summary>
        private System.Windows.Forms.Panel panel1;
        /// <summary>
        /// The date time picker1
        /// </summary>
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        /// <summary>
        /// The cotizacion text box1
        /// </summary>
        private System.Windows.Forms.TextBox cotizacionTextBox1;
        /// <summary>
        /// The r tn delete cliente text box
        /// </summary>
        private System.Windows.Forms.TextBox rTN_del_ClienteTextBox;
        /// <summary>
        /// The nombre delete cliente text box
        /// </summary>
        private System.Windows.Forms.TextBox nombre_del_ClienteTextBox;
        /// <summary>
        /// The BTN facturar
        /// </summary>
        private System.Windows.Forms.Button btnFacturar;
        /// <summary>
        /// The label1
        /// </summary>
        private System.Windows.Forms.Label label1;
        /// <summary>
        /// The CMB tipo pago
        /// </summary>
        private System.Windows.Forms.ComboBox cmbTipoPago;
        /// <summary>
        /// The CMB busqueda
        /// </summary>
        private System.Windows.Forms.ComboBox cmbBusqueda;
        /// <summary>
        /// The text buscar
        /// </summary>
        private System.Windows.Forms.TextBox txtBuscar;
        /// <summary>
        /// The BTN buscar
        /// </summary>
        private System.Windows.Forms.Button btnBuscar;
        /// <summary>
        /// The BTN cancelar
        /// </summary>
        private System.Windows.Forms.Button btnCancelar;
        /// <summary>
        /// The BTN imprimir
        /// </summary>
        private System.Windows.Forms.Button btnImprimir;
        /// <summary>
        /// The BTN guardar
        /// </summary>
        private System.Windows.Forms.Button btnGuardar;
        /// <summary>
        /// The historial detalle cotizacion data grid view
        /// </summary>
        private System.Windows.Forms.DataGridView historialDetalleCotizacionDataGridView;
        /// <summary>
        /// The data grid view text box column5
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        /// <summary>
        /// The data grid view text box column6
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        /// <summary>
        /// The data grid view text box column7
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        /// <summary>
        /// The data grid view text box column8
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        /// <summary>
        /// The data grid view text box column11
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.BindingSource vwClienteBindingSource;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.BindingSource tipoDePagoBindingSource;
        private System.Windows.Forms.BindingSource tipoDePagoBindingSource1;
        private TacomaDBDataSetTableAdapters.TipoDePagoTableAdapter tipoDePagoTableAdapter;
        private TacomaDBDataSetTableAdapters.HistorialCotizacionTableAdapter historialCotizacionTableAdapter;
        private TacomaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private TacomaDBDataSetTableAdapters.VwCotizacionTableAdapter vwCotizacionTableAdapter;
        private System.Windows.Forms.TextBox cotizacionTextBox;
    }
}