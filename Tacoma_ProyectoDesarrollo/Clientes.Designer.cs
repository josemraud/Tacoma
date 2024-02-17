// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 11-24-2019
//
// Last Modified By : pepit
// Last Modified On : 12-13-2019
// ***********************************************************************
// <copyright file="Clientes.Designer.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class Clientes.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class Clientes
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
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label paisLabel;
            System.Windows.Forms.Label persona_de_ContactoLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRTN = new System.Windows.Forms.TextBox();
            this.vwCliente1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tacomaDBDataSet = new Tacoma_ProyectoDesarrollo.TacomaDBDataSet();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDirecc = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.pais1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.ciudad1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPersona = new System.Windows.Forms.TextBox();
            this.ciudadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarCam = new System.Windows.Forms.Button();
            this.btnGuardarCli = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.errorRTN = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDireccion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPais = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCiudad = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cmbBusqueda = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vwEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwEmpleadoTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.VwEmpleadoTableAdapter();
            this.tableAdapterManager = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.TableAdapterManager();
            this.ciudadTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.CiudadTableAdapter();
            this.clienteTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.ClienteTableAdapter();
            this.paisTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.PaisTableAdapter();
            this.vwClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ciudadBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.paisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vwClienteTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.VwClienteTableAdapter();
            this.vwClienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vwCliente1TableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.VwCliente1TableAdapter();
            this.vwClienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacomaDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ciudad1TableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.Ciudad1TableAdapter();
            this.pais1TableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.Pais1TableAdapter();
            this.errorPersona = new System.Windows.Forms.ErrorProvider(this.components);
            rTNLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            persona_de_ContactoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwCliente1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pais1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudad1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwClienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwClienteDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // rTNLabel
            // 
            rTNLabel.AutoSize = true;
            rTNLabel.Location = new System.Drawing.Point(27, 39);
            rTNLabel.Name = "rTNLabel";
            rTNLabel.Size = new System.Drawing.Size(33, 13);
            rTNLabel.TabIndex = 0;
            rTNLabel.Text = "RTN:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(27, 65);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(27, 91);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 4;
            direccionLabel.Text = "Direccion:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(27, 117);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 6;
            telefonoLabel.Text = "Telefono:";
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Location = new System.Drawing.Point(27, 170);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(43, 13);
            ciudadLabel.TabIndex = 8;
            ciudadLabel.Text = "Ciudad:";
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Location = new System.Drawing.Point(27, 143);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(30, 13);
            paisLabel.TabIndex = 10;
            paisLabel.Text = "Pais:";
            // 
            // persona_de_ContactoLabel
            // 
            persona_de_ContactoLabel.AutoSize = true;
            persona_de_ContactoLabel.Location = new System.Drawing.Point(27, 197);
            persona_de_ContactoLabel.Name = "persona_de_ContactoLabel";
            persona_de_ContactoLabel.Size = new System.Drawing.Size(110, 13);
            persona_de_ContactoLabel.TabIndex = 12;
            persona_de_ContactoLabel.Text = "Persona de Contacto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(rTNLabel);
            this.panel1.Controls.Add(this.txtRTN);
            this.panel1.Controls.Add(nombreLabel);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(direccionLabel);
            this.panel1.Controls.Add(this.txtDirecc);
            this.panel1.Controls.Add(telefonoLabel);
            this.panel1.Controls.Add(this.txtTel);
            this.panel1.Controls.Add(ciudadLabel);
            this.panel1.Controls.Add(this.cmbPais);
            this.panel1.Controls.Add(paisLabel);
            this.panel1.Controls.Add(this.cmbCiudad);
            this.panel1.Controls.Add(persona_de_ContactoLabel);
            this.panel1.Controls.Add(this.txtPersona);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(534, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 260);
            this.panel1.TabIndex = 2;
            // 
            // txtRTN
            // 
            this.txtRTN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwCliente1BindingSource, "RTN", true));
            this.txtRTN.Location = new System.Drawing.Point(143, 36);
            this.txtRTN.Name = "txtRTN";
            this.txtRTN.Size = new System.Drawing.Size(121, 20);
            this.txtRTN.TabIndex = 1;
            this.txtRTN.TextChanged += new System.EventHandler(this.TxtRTN_TextChanged);
            this.txtRTN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRTN_KeyPress);
            // 
            // vwCliente1BindingSource
            // 
            this.vwCliente1BindingSource.DataMember = "VwCliente1";
            this.vwCliente1BindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // tacomaDBDataSet
            // 
            this.tacomaDBDataSet.DataSetName = "TacomaDBDataSet";
            this.tacomaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwCliente1BindingSource, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(143, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombre_KeyPress);
            // 
            // txtDirecc
            // 
            this.txtDirecc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwCliente1BindingSource, "Direccion", true));
            this.txtDirecc.Location = new System.Drawing.Point(143, 88);
            this.txtDirecc.Name = "txtDirecc";
            this.txtDirecc.Size = new System.Drawing.Size(121, 20);
            this.txtDirecc.TabIndex = 5;
            this.txtDirecc.TextChanged += new System.EventHandler(this.txtDirecc_TextChanged_1);
            this.txtDirecc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDirecc_KeyPress);
            // 
            // txtTel
            // 
            this.txtTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwCliente1BindingSource, "Telefono", true));
            this.txtTel.Location = new System.Drawing.Point(143, 114);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(121, 20);
            this.txtTel.TabIndex = 7;
            this.txtTel.TextChanged += new System.EventHandler(this.TxtTel_TextChanged);
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTel_KeyPress);
            // 
            // cmbPais
            // 
            this.cmbPais.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwCliente1BindingSource, "Ciudad", true));
            this.cmbPais.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vwCliente1BindingSource, "Pais", true));
            this.cmbPais.DataSource = this.pais1BindingSource;
            this.cmbPais.DisplayMember = "Pais_Nombre";
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(143, 140);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(121, 21);
            this.cmbPais.TabIndex = 9;
            this.cmbPais.ValueMember = "Pais_Nombre";
            this.cmbPais.SelectedIndexChanged += new System.EventHandler(this.CmbPais_SelectedIndexChanged);
            // 
            // pais1BindingSource
            // 
            this.pais1BindingSource.DataMember = "Pais1";
            this.pais1BindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwCliente1BindingSource, "Pais", true));
            this.cmbCiudad.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vwCliente1BindingSource, "Ciudad", true));
            this.cmbCiudad.DataSource = this.ciudad1BindingSource;
            this.cmbCiudad.DisplayMember = "Ciudad_Nombre";
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(143, 167);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(121, 21);
            this.cmbCiudad.TabIndex = 11;
            this.cmbCiudad.ValueMember = "Ciudad_codigo";
            this.cmbCiudad.SelectedIndexChanged += new System.EventHandler(this.CmbCiudad_SelectedIndexChanged);
            // 
            // ciudad1BindingSource
            // 
            this.ciudad1BindingSource.DataMember = "Ciudad1";
            this.ciudad1BindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // txtPersona
            // 
            this.txtPersona.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwCliente1BindingSource, "Persona de Contacto", true));
            this.txtPersona.Location = new System.Drawing.Point(143, 194);
            this.txtPersona.MaxLength = 50;
            this.txtPersona.Name = "txtPersona";
            this.txtPersona.Size = new System.Drawing.Size(121, 20);
            this.txtPersona.TabIndex = 13;
            this.txtPersona.TextChanged += new System.EventHandler(this.TxtPersona_TextChanged);
            this.txtPersona.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPersona_KeyPress);
            // 
            // ciudadBindingSource
            // 
            this.ciudadBindingSource.DataMember = "Ciudad";
            this.ciudadBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(428, 363);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnGuardarCam
            // 
            this.btnGuardarCam.Enabled = false;
            this.btnGuardarCam.Location = new System.Drawing.Point(313, 363);
            this.btnGuardarCam.Name = "btnGuardarCam";
            this.btnGuardarCam.Size = new System.Drawing.Size(109, 23);
            this.btnGuardarCam.TabIndex = 33;
            this.btnGuardarCam.Text = "Guardar cambios";
            this.btnGuardarCam.UseVisualStyleBackColor = true;
            this.btnGuardarCam.Click += new System.EventHandler(this.BtnGuardarCam_Click);
            // 
            // btnGuardarCli
            // 
            this.btnGuardarCli.Enabled = false;
            this.btnGuardarCli.Location = new System.Drawing.Point(94, 363);
            this.btnGuardarCli.Name = "btnGuardarCli";
            this.btnGuardarCli.Size = new System.Drawing.Size(137, 23);
            this.btnGuardarCli.TabIndex = 32;
            this.btnGuardarCli.Text = "Guardar nuevo cliente";
            this.btnGuardarCli.UseVisualStyleBackColor = true;
            this.btnGuardarCli.Click += new System.EventHandler(this.BtnGuardarCli_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(237, 363);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 31;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(26, 363);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(62, 23);
            this.btnAñadir.TabIndex = 30;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.BtnAñadir_Click);
            // 
            // errorRTN
            // 
            this.errorRTN.ContainerControl = this;
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // errorDireccion
            // 
            this.errorDireccion.ContainerControl = this;
            // 
            // errorTelefono
            // 
            this.errorTelefono.ContainerControl = this;
            // 
            // errorPais
            // 
            this.errorPais.ContainerControl = this;
            // 
            // errorCiudad
            // 
            this.errorCiudad.ContainerControl = this;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(418, 74);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 23);
            this.btnBuscar.TabIndex = 37;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(115, 76);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(297, 20);
            this.txtBuscar.TabIndex = 36;
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // cmbBusqueda
            // 
            this.cmbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusqueda.FormattingEnabled = true;
            this.cmbBusqueda.Items.AddRange(new object[] {
            "Codigo",
            "Nombre",
            "Todos los clientes"});
            this.cmbBusqueda.Location = new System.Drawing.Point(16, 76);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Size = new System.Drawing.Size(92, 21);
            this.cmbBusqueda.TabIndex = 35;
            this.cmbBusqueda.SelectedIndexChanged += new System.EventHandler(this.CmbBusqueda_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(752, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(790, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // vwEmpleadoBindingSource
            // 
            this.vwEmpleadoBindingSource.DataMember = "VwEmpleado";
            this.vwEmpleadoBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // vwEmpleadoTableAdapter
            // 
            this.vwEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Ciudad1TableAdapter = null;
            this.tableAdapterManager.CiudadTableAdapter = this.ciudadTableAdapter;
            this.tableAdapterManager.Cliente1TableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.Cotizacion_Detalle1TableAdapter = null;
            this.tableAdapterManager.Cotizacion_DetalleTableAdapter = null;
            this.tableAdapterManager.Cotizacion1TableAdapter = null;
            this.tableAdapterManager.CotizacionTableAdapter = null;
            this.tableAdapterManager.Departamento1TableAdapter = null;
            this.tableAdapterManager.Departamentos1TableAdapter = null;
            this.tableAdapterManager.DepartamentosTableAdapter = null;
            this.tableAdapterManager.DepartamentoTableAdapter = null;
            this.tableAdapterManager.Detalle_Factura1TableAdapter = null;
            this.tableAdapterManager.Detalle_FacturaTableAdapter = null;
            this.tableAdapterManager.Empleado1TableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.Esclavo1TableAdapter = null;
            this.tableAdapterManager.EsclavoTableAdapter = null;
            this.tableAdapterManager.Estado1TableAdapter = null;
            this.tableAdapterManager.EstadoTableAdapter = null;
            this.tableAdapterManager.Factura1TableAdapter = null;
            this.tableAdapterManager.FacturaTableAdapter = null;
            this.tableAdapterManager.ISV_Historico1TableAdapter = null;
            this.tableAdapterManager.ISV_HistoricoTableAdapter = null;
            this.tableAdapterManager.Municipios1TableAdapter = null;
            this.tableAdapterManager.MunicipiosTableAdapter = null;
            this.tableAdapterManager.Pais1TableAdapter = null;
            this.tableAdapterManager.PaisTableAdapter = this.paisTableAdapter;
            this.tableAdapterManager.Producto_Categoria1TableAdapter = null;
            this.tableAdapterManager.Producto_CategoriaTableAdapter = null;
            this.tableAdapterManager.Producto_Subcategoria1TableAdapter = null;
            this.tableAdapterManager.Producto_SubcategoriaTableAdapter = null;
            this.tableAdapterManager.Producto1TableAdapter = null;
            this.tableAdapterManager.ProductoTableAdapter = null;
            this.tableAdapterManager.Proveedores_Productos1TableAdapter = null;
            this.tableAdapterManager.Proveedores_ProductosTableAdapter = null;
            this.tableAdapterManager.Proveedores1TableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.Rol_Sistema1TableAdapter = null;
            this.tableAdapterManager.Rol_SistemaTableAdapter = null;
            this.tableAdapterManager.Roles_Departamentos1TableAdapter = null;
            this.tableAdapterManager.Roles_DepartamentosTableAdapter = null;
            this.tableAdapterManager.Roles1TableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.TipoDePago1TableAdapter = null;
            this.tableAdapterManager.TipoDePagoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ciudadTableAdapter
            // 
            this.ciudadTableAdapter.ClearBeforeFill = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // paisTableAdapter
            // 
            this.paisTableAdapter.ClearBeforeFill = true;
            // 
            // vwClienteBindingSource
            // 
            this.vwClienteBindingSource.DataMember = "VwCliente";
            this.vwClienteBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // paisBindingSource
            // 
            this.paisBindingSource.DataMember = "Pais";
            this.paisBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // ciudadBindingSource1
            // 
            this.ciudadBindingSource1.DataMember = "Ciudad";
            this.ciudadBindingSource1.DataSource = this.tacomaDBDataSet;
            // 
            // paisBindingSource1
            // 
            this.paisBindingSource1.DataMember = "Pais";
            this.paisBindingSource1.DataSource = this.tacomaDBDataSet;
            // 
            // vwClienteTableAdapter
            // 
            this.vwClienteTableAdapter.ClearBeforeFill = true;
            // 
            // vwClienteBindingSource1
            // 
            this.vwClienteBindingSource1.DataMember = "VwCliente";
            this.vwClienteBindingSource1.DataSource = this.tacomaDBDataSet;
            // 
            // vwCliente1TableAdapter
            // 
            this.vwCliente1TableAdapter.ClearBeforeFill = true;
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
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.vwClienteDataGridView.DataSource = this.vwCliente1BindingSource;
            this.vwClienteDataGridView.Location = new System.Drawing.Point(16, 116);
            this.vwClienteDataGridView.Name = "vwClienteDataGridView";
            this.vwClienteDataGridView.ReadOnly = true;
            this.vwClienteDataGridView.Size = new System.Drawing.Size(487, 236);
            this.vwClienteDataGridView.TabIndex = 39;
            this.vwClienteDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VwClienteDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RTN";
            this.dataGridViewTextBoxColumn1.HeaderText = "RTN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ciudad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ciudad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Pais";
            this.dataGridViewTextBoxColumn6.HeaderText = "Pais";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Persona de Contacto";
            this.dataGridViewTextBoxColumn7.HeaderText = "Persona de Contacto";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // tacomaDBDataSetBindingSource
            // 
            this.tacomaDBDataSetBindingSource.DataSource = this.tacomaDBDataSet;
            this.tacomaDBDataSetBindingSource.Position = 0;
            // 
            // ciudad1TableAdapter
            // 
            this.ciudad1TableAdapter.ClearBeforeFill = true;
            // 
            // pais1TableAdapter
            // 
            this.pais1TableAdapter.ClearBeforeFill = true;
            // 
            // errorPersona
            // 
            this.errorPersona.ContainerControl = this;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.vwClienteDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cmbBusqueda);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarCam);
            this.Controls.Add(this.btnGuardarCli);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwCliente1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pais1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudad1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwClienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwClienteDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>
        /// The label1
        /// </summary>
        private System.Windows.Forms.Label label1;
        /// <summary>
        /// The tacoma database data set
        /// </summary>
        private TacomaDBDataSet tacomaDBDataSet;
        /// <summary>
        /// The vw empleado binding source
        /// </summary>
        private System.Windows.Forms.BindingSource vwEmpleadoBindingSource;
        /// <summary>
        /// The vw empleado table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.VwEmpleadoTableAdapter vwEmpleadoTableAdapter;
        /// <summary>
        /// The table adapter manager
        /// </summary>
        private TacomaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        /// <summary>
        /// The vw cliente binding source
        /// </summary>
        private System.Windows.Forms.BindingSource vwClienteBindingSource;
        /// <summary>
        /// The pais table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.PaisTableAdapter paisTableAdapter;
        /// <summary>
        /// The pais binding source
        /// </summary>
        private System.Windows.Forms.BindingSource paisBindingSource;
        /// <summary>
        /// The cliente table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        /// <summary>
        /// The cliente binding source
        /// </summary>
        private System.Windows.Forms.BindingSource clienteBindingSource;
        /// <summary>
        /// The ciudad table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.CiudadTableAdapter ciudadTableAdapter;
        /// <summary>
        /// The ciudad binding source
        /// </summary>
        private System.Windows.Forms.BindingSource ciudadBindingSource;
        /// <summary>
        /// The panel1
        /// </summary>
        private System.Windows.Forms.Panel panel1;
        /// <summary>
        /// The pais binding source1
        /// </summary>
        private System.Windows.Forms.BindingSource paisBindingSource1;
        /// <summary>
        /// The BTN cancelar
        /// </summary>
        private System.Windows.Forms.Button btnCancelar;
        /// <summary>
        /// The BTN guardar cam
        /// </summary>
        private System.Windows.Forms.Button btnGuardarCam;
        /// <summary>
        /// The BTN guardar cli
        /// </summary>
        private System.Windows.Forms.Button btnGuardarCli;
        /// <summary>
        /// The BTN modificar
        /// </summary>
        private System.Windows.Forms.Button btnModificar;
        /// <summary>
        /// The BTN añadir
        /// </summary>
        private System.Windows.Forms.Button btnAñadir;
        //     private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        /// <summary>
        /// The error RTN
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorRTN;
        /// <summary>
        /// The error nombre
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorNombre;
        /// <summary>
        /// The error direccion
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorDireccion;
        /// <summary>
        /// The error telefono
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorTelefono;
        /// <summary>
        /// The error pais
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorPais;
        /// <summary>
        /// The error ciudad
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorCiudad;
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
        /// The ciudad binding source1
        /// </summary>
        private System.Windows.Forms.BindingSource ciudadBindingSource1;
        /// <summary>
        /// The vw cliente table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.VwClienteTableAdapter vwClienteTableAdapter;
        /// <summary>
        /// The vw cliente binding source1
        /// </summary>
        private System.Windows.Forms.BindingSource vwClienteBindingSource1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource vwCliente1BindingSource;
        private TacomaDBDataSetTableAdapters.VwCliente1TableAdapter vwCliente1TableAdapter;
        private System.Windows.Forms.DataGridView vwClienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox txtRTN;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDirecc;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.TextBox txtPersona;
        private System.Windows.Forms.BindingSource tacomaDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource ciudad1BindingSource;
        private TacomaDBDataSetTableAdapters.Ciudad1TableAdapter ciudad1TableAdapter;
        private System.Windows.Forms.BindingSource pais1BindingSource;
        private TacomaDBDataSetTableAdapters.Pais1TableAdapter pais1TableAdapter;
        private System.Windows.Forms.ErrorProvider errorPersona;
    }
}