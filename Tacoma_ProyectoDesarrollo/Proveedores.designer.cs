// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 12-02-2019
//
// Last Modified By : pepit
// Last Modified On : 12-02-2019
// ***********************************************************************
// <copyright file="Proveedores.designer.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class Proveedores.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class Proveedores
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
            System.Windows.Forms.Label codigo_de_ProveedorLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label numero_de_telefonoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label correo_electronicoLabel;
            System.Windows.Forms.Label paisLabel;
            System.Windows.Forms.Label ciudad_Label;
            this.tacomaDBDataSet = new Tacoma_ProyectoDesarrollo.TacomaDBDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.vwProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.paisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tacomaDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.ciudadBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.paisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tacomaDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ciudadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnGuardarNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.cmbBusqueda = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fKProveedoresProductosProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDirre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNumer = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCorr = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPais = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCiudad = new System.Windows.Forms.ErrorProvider(this.components);
            this.proveedoresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwProveedoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.paisTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.PaisTableAdapter();
            this.ciudadTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.CiudadTableAdapter();
            this.vwProveedoresTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.VwProveedoresTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            codigo_de_ProveedorLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            numero_de_telefonoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            correo_electronicoLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            ciudad_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProveedoresProductosProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDirre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCorr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCiudad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProveedoresBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // codigo_de_ProveedorLabel
            // 
            codigo_de_ProveedorLabel.AutoSize = true;
            codigo_de_ProveedorLabel.Location = new System.Drawing.Point(47, 28);
            codigo_de_ProveedorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codigo_de_ProveedorLabel.Name = "codigo_de_ProveedorLabel";
            codigo_de_ProveedorLabel.Size = new System.Drawing.Size(146, 17);
            codigo_de_ProveedorLabel.TabIndex = 0;
            codigo_de_ProveedorLabel.Text = "Codigo de Proveedor:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(47, 60);
            nombreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(62, 17);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre:";
            // 
            // numero_de_telefonoLabel
            // 
            numero_de_telefonoLabel.AutoSize = true;
            numero_de_telefonoLabel.Location = new System.Drawing.Point(47, 92);
            numero_de_telefonoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            numero_de_telefonoLabel.Name = "numero_de_telefonoLabel";
            numero_de_telefonoLabel.Size = new System.Drawing.Size(137, 17);
            numero_de_telefonoLabel.TabIndex = 4;
            numero_de_telefonoLabel.Text = "Numero de telefono:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(47, 124);
            direccionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(71, 17);
            direccionLabel.TabIndex = 6;
            direccionLabel.Text = "Direccion:";
            // 
            // correo_electronicoLabel
            // 
            correo_electronicoLabel.AutoSize = true;
            correo_electronicoLabel.Location = new System.Drawing.Point(47, 156);
            correo_electronicoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            correo_electronicoLabel.Name = "correo_electronicoLabel";
            correo_electronicoLabel.Size = new System.Drawing.Size(128, 17);
            correo_electronicoLabel.TabIndex = 8;
            correo_electronicoLabel.Text = "Correo electronico:";
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Location = new System.Drawing.Point(47, 188);
            paisLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(39, 17);
            paisLabel.TabIndex = 10;
            paisLabel.Text = "Pais:";
            // 
            // ciudad_Label
            // 
            ciudad_Label.AutoSize = true;
            ciudad_Label.Location = new System.Drawing.Point(47, 222);
            ciudad_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ciudad_Label.Name = "ciudad_Label";
            ciudad_Label.Size = new System.Drawing.Size(60, 17);
            ciudad_Label.TabIndex = 12;
            ciudad_Label.Text = "Ciudad :";
            // 
            // tacomaDBDataSet
            // 
            this.tacomaDBDataSet.DataSetName = "TacomaDBDataSet";
            this.tacomaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(codigo_de_ProveedorLabel);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(nombreLabel);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(numero_de_telefonoLabel);
            this.panel1.Controls.Add(this.txtNumero);
            this.panel1.Controls.Add(direccionLabel);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(correo_electronicoLabel);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(paisLabel);
            this.panel1.Controls.Add(this.cmbPais);
            this.panel1.Controls.Add(ciudad_Label);
            this.panel1.Controls.Add(this.cmbCiudad);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(705, 155);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 298);
            this.panel1.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwProveedoresBindingSource, "Codigo de Proveedor", true));
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(201, 25);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(160, 22);
            this.txtCodigo.TabIndex = 1;
            // 
            // vwProveedoresBindingSource
            // 
            this.vwProveedoresBindingSource.DataMember = "VwProveedores";
            this.vwProveedoresBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwProveedoresBindingSource, "Nombre", true));
            this.txtNombre.Location = new System.Drawing.Point(201, 57);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 22);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtNumero
            // 
            this.txtNumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwProveedoresBindingSource, "Numero de telefono", true));
            this.txtNumero.Location = new System.Drawing.Point(201, 89);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.MaxLength = 8;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(160, 22);
            this.txtNumero.TabIndex = 5;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwProveedoresBindingSource, "Direccion", true));
            this.txtDireccion.Location = new System.Drawing.Point(201, 121);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(160, 22);
            this.txtDireccion.TabIndex = 7;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // txtCorreo
            // 
            this.txtCorreo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwProveedoresBindingSource, "Correo electronico", true));
            this.txtCorreo.Location = new System.Drawing.Point(201, 153);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(160, 22);
            this.txtCorreo.TabIndex = 9;
            this.txtCorreo.TextChanged += new System.EventHandler(this.correo_electronicoTextBox_TextChanged);
            this.txtCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCorreo_Validating);
            // 
            // cmbPais
            // 
            this.cmbPais.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwProveedoresBindingSource, "Pais", true));
            this.cmbPais.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vwProveedoresBindingSource, "Pais", true));
            this.cmbPais.DataSource = this.paisBindingSource1;
            this.cmbPais.DisplayMember = "Pais_Nombre";
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(201, 185);
            this.cmbPais.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(160, 24);
            this.cmbPais.TabIndex = 11;
            this.cmbPais.ValueMember = "Pais_Codigo";
            this.cmbPais.SelectedIndexChanged += new System.EventHandler(this.cmbPais_SelectedIndexChanged_1);
            // 
            // paisBindingSource1
            // 
            this.paisBindingSource1.DataMember = "Pais";
            this.paisBindingSource1.DataSource = this.tacomaDBDataSetBindingSource1;
            // 
            // tacomaDBDataSetBindingSource1
            // 
            this.tacomaDBDataSetBindingSource1.DataSource = this.tacomaDBDataSet;
            this.tacomaDBDataSetBindingSource1.Position = 0;
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwProveedoresBindingSource, "Ciudad ", true));
            this.cmbCiudad.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vwProveedoresBindingSource, "Ciudad ", true));
            this.cmbCiudad.DataSource = this.ciudadBindingSource1;
            this.cmbCiudad.DisplayMember = "Ciudad_Nombre";
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(201, 218);
            this.cmbCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(160, 24);
            this.cmbCiudad.TabIndex = 13;
            this.cmbCiudad.ValueMember = "Ciudad_codigo";
            this.cmbCiudad.SelectedIndexChanged += new System.EventHandler(this.cmbCiudad_SelectedIndexChanged);
            // 
            // ciudadBindingSource1
            // 
            this.ciudadBindingSource1.DataMember = "Ciudad";
            this.ciudadBindingSource1.DataSource = this.tacomaDBDataSetBindingSource1;
            // 
            // paisBindingSource
            // 
            this.paisBindingSource.DataMember = "Pais";
            this.paisBindingSource.DataSource = this.tacomaDBDataSetBindingSource;
            // 
            // tacomaDBDataSetBindingSource
            // 
            this.tacomaDBDataSetBindingSource.DataSource = this.tacomaDBDataSet;
            this.tacomaDBDataSetBindingSource.Position = 0;
            // 
            // ciudadBindingSource
            // 
            this.ciudadBindingSource.DataMember = "Ciudad";
            this.ciudadBindingSource.DataSource = this.tacomaDBDataSetBindingSource;
            // 
            // proveedoresBindingSource1
            // 
            this.proveedoresBindingSource1.DataMember = "Proveedores";
            this.proveedoresBindingSource1.DataSource = this.tacomaDBDataSetBindingSource;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(571, 475);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Enabled = false;
            this.btnguardar.Location = new System.Drawing.Point(417, 475);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(145, 28);
            this.btnguardar.TabIndex = 33;
            this.btnguardar.Text = "Guardar cambios";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnGuardarNuevo
            // 
            this.btnGuardarNuevo.Enabled = false;
            this.btnGuardarNuevo.Location = new System.Drawing.Point(125, 475);
            this.btnGuardarNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarNuevo.Name = "btnGuardarNuevo";
            this.btnGuardarNuevo.Size = new System.Drawing.Size(183, 28);
            this.btnGuardarNuevo.TabIndex = 32;
            this.btnGuardarNuevo.Text = "Guardar nuevo proveedor";
            this.btnGuardarNuevo.UseVisualStyleBackColor = true;
            this.btnGuardarNuevo.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(316, 475);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 31;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(35, 475);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(83, 28);
            this.btnAñadir.TabIndex = 30;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // cmbBusqueda
            // 
            this.cmbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusqueda.FormattingEnabled = true;
            this.cmbBusqueda.Items.AddRange(new object[] {
            "Código",
            "Nombre",
            "Todos los proveedores"});
            this.cmbBusqueda.Location = new System.Drawing.Point(35, 97);
            this.cmbBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Size = new System.Drawing.Size(121, 24);
            this.cmbBusqueda.TabIndex = 35;
            this.cmbBusqueda.SelectedIndexChanged += new System.EventHandler(this.cmbBusqueda_SelectedIndexChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(167, 98);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(395, 22);
            this.txtBuscar.TabIndex = 36;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(571, 97);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 37;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(407, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 58);
            this.label1.TabIndex = 38;
            this.label1.Text = "Proveedores";
            // 
            // fKProveedoresProductosProveedoresBindingSource
            // 
            this.fKProveedoresProductosProveedoresBindingSource.DataMember = "FK_Proveedores/Productos_Proveedores";
            this.fKProveedoresProductosProveedoresBindingSource.DataSource = this.proveedoresBindingSource;
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // errorDirre
            // 
            this.errorDirre.ContainerControl = this;
            // 
            // errorNumer
            // 
            this.errorNumer.ContainerControl = this;
            // 
            // errorCorr
            // 
            this.errorCorr.ContainerControl = this;
            // 
            // errorPais
            // 
            this.errorPais.ContainerControl = this;
            // 
            // errorCiudad
            // 
            this.errorCiudad.ContainerControl = this;
            // 
            // proveedoresDataGridView
            // 
            this.proveedoresDataGridView.AllowUserToAddRows = false;
            this.proveedoresDataGridView.AllowUserToDeleteRows = false;
            this.proveedoresDataGridView.AutoGenerateColumns = false;
            this.proveedoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proveedoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.proveedoresDataGridView.DataSource = this.vwProveedoresBindingSource1;
            this.proveedoresDataGridView.Location = new System.Drawing.Point(35, 155);
            this.proveedoresDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.proveedoresDataGridView.Name = "proveedoresDataGridView";
            this.proveedoresDataGridView.ReadOnly = true;
            this.proveedoresDataGridView.RowHeadersWidth = 51;
            this.proveedoresDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.proveedoresDataGridView.Size = new System.Drawing.Size(636, 271);
            this.proveedoresDataGridView.TabIndex = 38;
            this.proveedoresDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.proveedoresDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo de Proveedor";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo de Proveedor";
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Numero de telefono";
            this.dataGridViewTextBoxColumn3.HeaderText = "Numero de telefono";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Correo electronico";
            this.dataGridViewTextBoxColumn5.HeaderText = "Correo electronico";
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
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Ciudad ";
            this.dataGridViewTextBoxColumn7.HeaderText = "Ciudad ";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // vwProveedoresBindingSource1
            // 
            this.vwProveedoresBindingSource1.DataMember = "VwProveedores";
            this.vwProveedoresBindingSource1.DataSource = this.tacomaDBDataSet;
            // 
            // paisTableAdapter
            // 
            this.paisTableAdapter.ClearBeforeFill = true;
            // 
            // ciudadTableAdapter
            // 
            this.ciudadTableAdapter.ClearBeforeFill = true;
            // 
            // vwProveedoresTableAdapter
            // 
            this.vwProveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(960, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1012, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1075, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "label4";
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 577);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.proveedoresDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cmbBusqueda);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnGuardarNuevo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAñadir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vwProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProveedoresProductosProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDirre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCorr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCiudad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwProveedoresBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        /// <summary>
        /// The tacoma database data set
        /// </summary>
        private TacomaDBDataSet tacomaDBDataSet;
        /// <summary>
        /// The tacoma database data set binding source
        /// </summary>
        private System.Windows.Forms.BindingSource tacomaDBDataSetBindingSource;
        /// <summary>
        /// The proveedores binding source
        /// </summary>
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        /// <summary>
        /// The panel1
        /// </summary>
        private System.Windows.Forms.Panel panel1;
        /// <summary>
        /// The BTN cancelar
        /// </summary>
        private System.Windows.Forms.Button btnCancelar;
        /// <summary>
        /// The btnguardar
        /// </summary>
        private System.Windows.Forms.Button btnguardar;
        /// <summary>
        /// The BTN guardar nuevo
        /// </summary>
        private System.Windows.Forms.Button btnGuardarNuevo;
        /// <summary>
        /// The BTN modificar
        /// </summary>
        private System.Windows.Forms.Button btnModificar;
        /// <summary>
        /// The BTN añadir
        /// </summary>
        private System.Windows.Forms.Button btnAñadir;
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
        /// The label1
        /// </summary>
        private System.Windows.Forms.Label label1;
        /// <summary>
        /// The f k proveedores productos proveedores binding source
        /// </summary>
        private System.Windows.Forms.BindingSource fKProveedoresProductosProveedoresBindingSource;
        /// <summary>
        /// The proveedores binding source1
        /// </summary>
        private System.Windows.Forms.BindingSource proveedoresBindingSource1;
        /// <summary>
        /// The error nombre
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorNombre;
        /// <summary>
        /// The error dirre
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorDirre;
        /// <summary>
        /// The error numer
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorNumer;
        /// <summary>
        /// The error corr
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorCorr;
        /// <summary>
        /// The error pais
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorPais;
        /// <summary>
        /// The error ciudad
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorCiudad;
        /// <summary>
        /// The pais binding source
        /// </summary>
        private System.Windows.Forms.BindingSource paisBindingSource;
        /// <summary>
        /// The ciudad binding source
        /// </summary>
        private System.Windows.Forms.BindingSource ciudadBindingSource;
        /// <summary>
        /// The vw proveedores binding source
        /// </summary>
        private System.Windows.Forms.BindingSource vwProveedoresBindingSource;
        /// <summary>
        /// The text codigo
        /// </summary>
        private System.Windows.Forms.TextBox txtCodigo;
        /// <summary>
        /// The text nombre
        /// </summary>
        private System.Windows.Forms.TextBox txtNombre;
        /// <summary>
        /// The text numero
        /// </summary>
        private System.Windows.Forms.TextBox txtNumero;
        /// <summary>
        /// The text direccion
        /// </summary>
        private System.Windows.Forms.TextBox txtDireccion;
        /// <summary>
        /// The text correo
        /// </summary>
        private System.Windows.Forms.TextBox txtCorreo;
        /// <summary>
        /// The CMB pais
        /// </summary>
        private System.Windows.Forms.ComboBox cmbPais;
        /// <summary>
        /// The CMB ciudad
        /// </summary>
        private System.Windows.Forms.ComboBox cmbCiudad;
        /// <summary>
        /// The proveedores data grid view
        /// </summary>
        private System.Windows.Forms.DataGridView proveedoresDataGridView;
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
        /// The data grid view text box column7
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource tacomaDBDataSetBindingSource1;
        private System.Windows.Forms.BindingSource paisBindingSource1;
        private TacomaDBDataSetTableAdapters.PaisTableAdapter paisTableAdapter;
        private System.Windows.Forms.BindingSource ciudadBindingSource1;
        private TacomaDBDataSetTableAdapters.CiudadTableAdapter ciudadTableAdapter;
        private System.Windows.Forms.BindingSource vwProveedoresBindingSource1;
        private TacomaDBDataSetTableAdapters.VwProveedoresTableAdapter vwProveedoresTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}