// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 11-24-2019
//
// Last Modified By : pepit
// Last Modified On : 11-23-2019
// ***********************************************************************
// <copyright file="Empleados.Designer.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class Empleados.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class Empleados
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
            System.Windows.Forms.Label nombre_completoLabel;
            System.Windows.Forms.Label direccion_de_residenciaLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label correoLabel;
            System.Windows.Forms.Label departamentoLabel;
            System.Windows.Forms.Label puestoLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label rol_de_sistemaLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label contraseñaLabel;
            System.Windows.Forms.Label codigo_de_empleadoLabel;
            System.Windows.Forms.Label lblConfCont;
            this.label1 = new System.Windows.Forms.Label();
            this.vwEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tacomaDBDataSet = new Tacoma_ProyectoDesarrollo.TacomaDBDataSet();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtDirecc = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.cmbDepar = new System.Windows.Forms.ComboBox();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tacomaDBDataSet1 = new Tacoma_ProyectoDesarrollo.TacomaDBDataSet();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tacomaDBDataSet2 = new Tacoma_ProyectoDesarrollo.TacomaDBDataSet();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.estadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbRolSis = new System.Windows.Forms.ComboBox();
            this.rolSistemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtConfirCon = new System.Windows.Forms.TextBox();
            this.txtCodEmple = new System.Windows.Forms.TextBox();
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDireccion = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCorreo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDepar = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPuesto = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEstado = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorRol = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbBusqueda = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.vwEmpleadoTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.VwEmpleadoTableAdapter();
            this.tableAdapterManager = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.TableAdapterManager();
            this.departamentoTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.DepartamentoTableAdapter();
            this.proveedoresProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedores_ProductosTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.Proveedores_ProductosTableAdapter();
            this.rolesDepartamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roles_DepartamentosTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.Roles_DepartamentosTableAdapter();
            this.rolesTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.RolesTableAdapter();
            this.estadoTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.EstadoTableAdapter();
            this.rol_SistemaTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.Rol_SistemaTableAdapter();
            this.ErrorUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorContra = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorComfirContra = new System.Windows.Forms.ErrorProvider(this.components);
            this.vwEmpleadoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorCodEmpleado = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            nombre_completoLabel = new System.Windows.Forms.Label();
            direccion_de_residenciaLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            correoLabel = new System.Windows.Forms.Label();
            departamentoLabel = new System.Windows.Forms.Label();
            puestoLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            rol_de_sistemaLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            contraseñaLabel = new System.Windows.Forms.Label();
            codigo_de_empleadoLabel = new System.Windows.Forms.Label();
            lblConfCont = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vwEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolSistemaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDepar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesDepartamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorContra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorComfirContra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwEmpleadoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre_completoLabel
            // 
            nombre_completoLabel.AutoSize = true;
            nombre_completoLabel.Location = new System.Drawing.Point(49, 52);
            nombre_completoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombre_completoLabel.Name = "nombre_completoLabel";
            nombre_completoLabel.Size = new System.Drawing.Size(123, 17);
            nombre_completoLabel.TabIndex = 4;
            nombre_completoLabel.Text = "Nombre completo:";
            // 
            // direccion_de_residenciaLabel
            // 
            direccion_de_residenciaLabel.AutoSize = true;
            direccion_de_residenciaLabel.Location = new System.Drawing.Point(49, 84);
            direccion_de_residenciaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            direccion_de_residenciaLabel.Name = "direccion_de_residenciaLabel";
            direccion_de_residenciaLabel.Size = new System.Drawing.Size(160, 17);
            direccion_de_residenciaLabel.TabIndex = 6;
            direccion_de_residenciaLabel.Text = "Direccion de residencia:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(49, 116);
            telefonoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(68, 17);
            telefonoLabel.TabIndex = 8;
            telefonoLabel.Text = "Telefono:";
            // 
            // correoLabel
            // 
            correoLabel.AutoSize = true;
            correoLabel.Location = new System.Drawing.Point(49, 148);
            correoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            correoLabel.Name = "correoLabel";
            correoLabel.Size = new System.Drawing.Size(55, 17);
            correoLabel.TabIndex = 10;
            correoLabel.Text = "Correo:";
            // 
            // departamentoLabel
            // 
            departamentoLabel.AutoSize = true;
            departamentoLabel.Location = new System.Drawing.Point(49, 180);
            departamentoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            departamentoLabel.Name = "departamentoLabel";
            departamentoLabel.Size = new System.Drawing.Size(102, 17);
            departamentoLabel.TabIndex = 12;
            departamentoLabel.Text = "Departamento:";
            // 
            // puestoLabel
            // 
            puestoLabel.AutoSize = true;
            puestoLabel.Location = new System.Drawing.Point(49, 213);
            puestoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            puestoLabel.Name = "puestoLabel";
            puestoLabel.Size = new System.Drawing.Size(56, 17);
            puestoLabel.TabIndex = 14;
            puestoLabel.Text = "Puesto:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(49, 246);
            estadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(56, 17);
            estadoLabel.TabIndex = 16;
            estadoLabel.Text = "Estado:";
            // 
            // rol_de_sistemaLabel
            // 
            rol_de_sistemaLabel.AutoSize = true;
            rol_de_sistemaLabel.Location = new System.Drawing.Point(49, 279);
            rol_de_sistemaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rol_de_sistemaLabel.Name = "rol_de_sistemaLabel";
            rol_de_sistemaLabel.Size = new System.Drawing.Size(105, 17);
            rol_de_sistemaLabel.TabIndex = 18;
            rol_de_sistemaLabel.Text = "Rol de sistema:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(49, 313);
            usuarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(61, 17);
            usuarioLabel.TabIndex = 20;
            usuarioLabel.Text = "Usuario:";
            // 
            // contraseñaLabel
            // 
            contraseñaLabel.AutoSize = true;
            contraseñaLabel.Location = new System.Drawing.Point(49, 345);
            contraseñaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            contraseñaLabel.Name = "contraseñaLabel";
            contraseñaLabel.Size = new System.Drawing.Size(85, 17);
            contraseñaLabel.TabIndex = 22;
            contraseñaLabel.Text = "Contraseña:";
            // 
            // codigo_de_empleadoLabel
            // 
            codigo_de_empleadoLabel.AutoSize = true;
            codigo_de_empleadoLabel.Location = new System.Drawing.Point(49, 20);
            codigo_de_empleadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codigo_de_empleadoLabel.Name = "codigo_de_empleadoLabel";
            codigo_de_empleadoLabel.Size = new System.Drawing.Size(142, 17);
            codigo_de_empleadoLabel.TabIndex = 2;
            codigo_de_empleadoLabel.Text = "Codigo de empleado:";
            // 
            // lblConfCont
            // 
            lblConfCont.AutoSize = true;
            lblConfCont.Location = new System.Drawing.Point(49, 375);
            lblConfCont.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblConfCont.Name = "lblConfCont";
            lblConfCont.Size = new System.Drawing.Size(148, 17);
            lblConfCont.TabIndex = 23;
            lblConfCont.Text = "Confirmar contraseña:";
            lblConfCont.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(372, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleados";
            // 
            // vwEmpleadoBindingSource
            // 
            this.vwEmpleadoBindingSource.DataMember = "VwEmpleado";
            this.vwEmpleadoBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // tacomaDBDataSet
            // 
            this.tacomaDBDataSet.DataSetName = "TacomaDBDataSet";
            this.tacomaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNom
            // 
            this.txtNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwEmpleadoBindingSource, "Nombre completo", true));
            this.txtNom.Location = new System.Drawing.Point(219, 48);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtNom.MaxLength = 50;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(160, 22);
            this.txtNom.TabIndex = 0;
            this.txtNom.TextChanged += new System.EventHandler(this.TxtNom_TextChanged);
            this.txtNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNom_KeyPress);
            // 
            // txtDirecc
            // 
            this.txtDirecc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwEmpleadoBindingSource, "Direccion de residencia", true));
            this.txtDirecc.Location = new System.Drawing.Point(219, 80);
            this.txtDirecc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDirecc.MaxLength = 50;
            this.txtDirecc.Name = "txtDirecc";
            this.txtDirecc.Size = new System.Drawing.Size(160, 22);
            this.txtDirecc.TabIndex = 1;
            this.txtDirecc.TextChanged += new System.EventHandler(this.TxtDirecc_TextChanged);
            this.txtDirecc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDirecc_KeyPress);
            // 
            // txtTel
            // 
            this.txtTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwEmpleadoBindingSource, "Telefono", true));
            this.txtTel.Location = new System.Drawing.Point(219, 112);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTel.MaxLength = 8;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(160, 22);
            this.txtTel.TabIndex = 2;
            this.txtTel.TextChanged += new System.EventHandler(this.TxtTel_TextChanged);
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTel_KeyPress);
            // 
            // txtCorreo
            // 
            this.txtCorreo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwEmpleadoBindingSource, "Correo", true));
            this.txtCorreo.Location = new System.Drawing.Point(219, 144);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(160, 22);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.TextChanged += new System.EventHandler(this.TxtCorreo_TextChanged);
            this.txtCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCorreo_Validating);
            // 
            // cmbDepar
            // 
            this.cmbDepar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwEmpleadoBindingSource, "Departamento", true));
            this.cmbDepar.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vwEmpleadoBindingSource, "Departamento", true));
            this.cmbDepar.DataSource = this.departamentoBindingSource;
            this.cmbDepar.DisplayMember = "Departamento_Descripcion";
            this.cmbDepar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepar.FormattingEnabled = true;
            this.cmbDepar.Location = new System.Drawing.Point(219, 176);
            this.cmbDepar.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDepar.Name = "cmbDepar";
            this.cmbDepar.Size = new System.Drawing.Size(160, 24);
            this.cmbDepar.TabIndex = 4;
            this.cmbDepar.ValueMember = "Departamento_ID";
            this.cmbDepar.SelectedIndexChanged += new System.EventHandler(this.DepartamentoComboBox_SelectedIndexChanged);
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataMember = "Departamento";
            this.departamentoBindingSource.DataSource = this.tacomaDBDataSet1;
            // 
            // tacomaDBDataSet1
            // 
            this.tacomaDBDataSet1.DataSetName = "TacomaDBDataSet";
            this.tacomaDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwEmpleadoBindingSource, "Puesto", true));
            this.cmbPuesto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vwEmpleadoBindingSource, "Puesto", true));
            this.cmbPuesto.DataSource = this.rolesBindingSource;
            this.cmbPuesto.DisplayMember = "Rol_Descripcion";
            this.cmbPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Location = new System.Drawing.Point(219, 209);
            this.cmbPuesto.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(160, 24);
            this.cmbPuesto.TabIndex = 5;
            this.cmbPuesto.ValueMember = "Rol_Codigo";
            this.cmbPuesto.SelectedIndexChanged += new System.EventHandler(this.CmbPuesto_SelectedIndexChanged);
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.tacomaDBDataSet2;
            // 
            // tacomaDBDataSet2
            // 
            this.tacomaDBDataSet2.DataSetName = "TacomaDBDataSet";
            this.tacomaDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwEmpleadoBindingSource, "Estado", true));
            this.cmbEstado.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vwEmpleadoBindingSource, "Estado", true));
            this.cmbEstado.DataSource = this.estadoBindingSource;
            this.cmbEstado.DisplayMember = "Estado_Descripcion";
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(219, 242);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(160, 24);
            this.cmbEstado.TabIndex = 6;
            this.cmbEstado.ValueMember = "Estado_Cod";
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.CmbEstado_SelectedIndexChanged);
            // 
            // estadoBindingSource
            // 
            this.estadoBindingSource.DataMember = "Estado";
            this.estadoBindingSource.DataSource = this.tacomaDBDataSet2;
            // 
            // cmbRolSis
            // 
            this.cmbRolSis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwEmpleadoBindingSource, "Rol de sistema", true));
            this.cmbRolSis.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vwEmpleadoBindingSource, "Rol de sistema", true));
            this.cmbRolSis.DataSource = this.rolSistemaBindingSource;
            this.cmbRolSis.DisplayMember = "Descripcion_RS";
            this.cmbRolSis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRolSis.FormattingEnabled = true;
            this.cmbRolSis.Location = new System.Drawing.Point(219, 276);
            this.cmbRolSis.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRolSis.Name = "cmbRolSis";
            this.cmbRolSis.Size = new System.Drawing.Size(160, 24);
            this.cmbRolSis.TabIndex = 7;
            this.cmbRolSis.ValueMember = "Codigo_RS";
            this.cmbRolSis.SelectedIndexChanged += new System.EventHandler(this.CmbRolSis_SelectedIndexChanged);
            // 
            // rolSistemaBindingSource
            // 
            this.rolSistemaBindingSource.DataMember = "Rol_Sistema";
            this.rolSistemaBindingSource.DataSource = this.tacomaDBDataSet2;
            // 
            // txtUsuario
            // 
            this.txtUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwEmpleadoBindingSource, "Usuario", true));
            this.txtUsuario.Location = new System.Drawing.Point(219, 309);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(160, 22);
            this.txtUsuario.TabIndex = 8;
            this.txtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuario_KeyPress);
            // 
            // txtContra
            // 
            this.txtContra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwEmpleadoBindingSource, "Contraseña", true));
            this.txtContra.Location = new System.Drawing.Point(219, 341);
            this.txtContra.Margin = new System.Windows.Forms.Padding(4);
            this.txtContra.MaxLength = 20;
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(160, 22);
            this.txtContra.TabIndex = 9;
            this.txtContra.TextChanged += new System.EventHandler(this.TxtContra_TextChanged);
            this.txtContra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContra_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtConfirCon);
            this.panel1.Controls.Add(lblConfCont);
            this.panel1.Controls.Add(this.txtCodEmple);
            this.panel1.Controls.Add(codigo_de_empleadoLabel);
            this.panel1.Controls.Add(this.txtContra);
            this.panel1.Controls.Add(contraseñaLabel);
            this.panel1.Controls.Add(nombre_completoLabel);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.txtNom);
            this.panel1.Controls.Add(usuarioLabel);
            this.panel1.Controls.Add(direccion_de_residenciaLabel);
            this.panel1.Controls.Add(this.cmbRolSis);
            this.panel1.Controls.Add(this.txtDirecc);
            this.panel1.Controls.Add(rol_de_sistemaLabel);
            this.panel1.Controls.Add(telefonoLabel);
            this.panel1.Controls.Add(this.cmbEstado);
            this.panel1.Controls.Add(this.txtTel);
            this.panel1.Controls.Add(estadoLabel);
            this.panel1.Controls.Add(correoLabel);
            this.panel1.Controls.Add(this.cmbPuesto);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(puestoLabel);
            this.panel1.Controls.Add(departamentoLabel);
            this.panel1.Controls.Add(this.cmbDepar);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(701, 103);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 404);
            this.panel1.TabIndex = 24;
            // 
            // txtConfirCon
            // 
            this.txtConfirCon.Location = new System.Drawing.Point(219, 372);
            this.txtConfirCon.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirCon.Name = "txtConfirCon";
            this.txtConfirCon.Size = new System.Drawing.Size(160, 22);
            this.txtConfirCon.TabIndex = 24;
            this.txtConfirCon.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.txtConfirCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtConfirCon_KeyPress);
            // 
            // txtCodEmple
            // 
            this.txtCodEmple.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vwEmpleadoBindingSource, "Codigo de empleado", true));
            this.txtCodEmple.Location = new System.Drawing.Point(219, 16);
            this.txtCodEmple.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodEmple.MaxLength = 13;
            this.txtCodEmple.Name = "txtCodEmple";
            this.txtCodEmple.Size = new System.Drawing.Size(160, 22);
            this.txtCodEmple.TabIndex = 0;
            this.txtCodEmple.TextChanged += new System.EventHandler(this.TxtCodEmple_TextChanged);
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
            // errorCorreo
            // 
            this.errorCorreo.ContainerControl = this;
            // 
            // errorDepar
            // 
            this.errorDepar.ContainerControl = this;
            // 
            // errorPuesto
            // 
            this.errorPuesto.ContainerControl = this;
            // 
            // errorEstado
            // 
            this.errorEstado.ContainerControl = this;
            // 
            // errorRol
            // 
            this.errorRol.ContainerControl = this;
            // 
            // cmbBusqueda
            // 
            this.cmbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusqueda.FormattingEnabled = true;
            this.cmbBusqueda.Items.AddRange(new object[] {
            "Codigo",
            "Nombre",
            "Todos los empleados"});
            this.cmbBusqueda.Location = new System.Drawing.Point(29, 103);
            this.cmbBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Size = new System.Drawing.Size(121, 24);
            this.cmbBusqueda.TabIndex = 30;
            this.cmbBusqueda.SelectedIndexChanged += new System.EventHandler(this.CmbBusqueda_SelectedIndexChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(161, 103);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(395, 22);
            this.txtBuscar.TabIndex = 31;
            this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(565, 101);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(29, 479);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(83, 28);
            this.btnAñadir.TabIndex = 25;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.BtnAñadir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(311, 479);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 26;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(120, 479);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(183, 28);
            this.btnAceptar.TabIndex = 27;
            this.btnAceptar.Text = "Guardar nuevo empleado";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Enabled = false;
            this.btnguardar.Location = new System.Drawing.Point(412, 479);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(145, 28);
            this.btnguardar.TabIndex = 28;
            this.btnguardar.Text = "Guardar cambios";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.Btnguardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(565, 479);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // vwEmpleadoTableAdapter
            // 
            this.vwEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Ciudad1TableAdapter = null;
            this.tableAdapterManager.CiudadTableAdapter = null;
            this.tableAdapterManager.Cliente1TableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            this.tableAdapterManager.PaisTableAdapter = null;
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
            // departamentoTableAdapter
            // 
            this.departamentoTableAdapter.ClearBeforeFill = true;
            // 
            // proveedoresProductosBindingSource
            // 
            this.proveedoresProductosBindingSource.DataMember = "Proveedores/Productos";
            this.proveedoresProductosBindingSource.DataSource = this.tacomaDBDataSet2;
            // 
            // proveedores_ProductosTableAdapter
            // 
            this.proveedores_ProductosTableAdapter.ClearBeforeFill = true;
            // 
            // rolesDepartamentosBindingSource
            // 
            this.rolesDepartamentosBindingSource.DataMember = "Roles_Departamentos";
            this.rolesDepartamentosBindingSource.DataSource = this.tacomaDBDataSet2;
            // 
            // roles_DepartamentosTableAdapter
            // 
            this.roles_DepartamentosTableAdapter.ClearBeforeFill = true;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // estadoTableAdapter
            // 
            this.estadoTableAdapter.ClearBeforeFill = true;
            // 
            // rol_SistemaTableAdapter
            // 
            this.rol_SistemaTableAdapter.ClearBeforeFill = true;
            // 
            // ErrorUsuario
            // 
            this.ErrorUsuario.ContainerControl = this;
            // 
            // ErrorContra
            // 
            this.ErrorContra.ContainerControl = this;
            // 
            // ErrorComfirContra
            // 
            this.ErrorComfirContra.ContainerControl = this;
            // 
            // vwEmpleadoDataGridView
            // 
            this.vwEmpleadoDataGridView.AllowUserToAddRows = false;
            this.vwEmpleadoDataGridView.AllowUserToDeleteRows = false;
            this.vwEmpleadoDataGridView.AutoGenerateColumns = false;
            this.vwEmpleadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vwEmpleadoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.vwEmpleadoDataGridView.DataSource = this.vwEmpleadoBindingSource;
            this.vwEmpleadoDataGridView.Location = new System.Drawing.Point(29, 155);
            this.vwEmpleadoDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vwEmpleadoDataGridView.Name = "vwEmpleadoDataGridView";
            this.vwEmpleadoDataGridView.ReadOnly = true;
            this.vwEmpleadoDataGridView.RowHeadersWidth = 51;
            this.vwEmpleadoDataGridView.RowTemplate.Height = 24;
            this.vwEmpleadoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vwEmpleadoDataGridView.Size = new System.Drawing.Size(636, 310);
            this.vwEmpleadoDataGridView.TabIndex = 32;
            this.vwEmpleadoDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vwEmpleadoDataGridView_CellClick);
            this.vwEmpleadoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vwEmpleadoDataGridView_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo de empleado";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo de empleado";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre Completo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre Completo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Direccion de residencia";
            this.dataGridViewTextBoxColumn4.HeaderText = "Direccion de residencia";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Correo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Correo";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Departamento";
            this.dataGridViewTextBoxColumn7.HeaderText = "Departamento";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Puesto";
            this.dataGridViewTextBoxColumn8.HeaderText = "Puesto";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn9.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Rol de sistema";
            this.dataGridViewTextBoxColumn10.HeaderText = "Rol de sistema";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Usuario";
            this.dataGridViewTextBoxColumn11.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Contraseña";
            this.dataGridViewTextBoxColumn12.HeaderText = "Contraseña";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // errorCodEmpleado
            // 
            this.errorCodEmpleado.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(975, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1027, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1079, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vwEmpleadoDataGridView);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cmbBusqueda);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vwEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolSistemaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDepar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesDepartamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorContra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorComfirContra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwEmpleadoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodEmpleado)).EndInit();
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
        /// The data grid view text box column2
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        /// <summary>
        /// The text nom
        /// </summary>
        private System.Windows.Forms.TextBox txtNom;
        /// <summary>
        /// The text direcc
        /// </summary>
        private System.Windows.Forms.TextBox txtDirecc;
        /// <summary>
        /// The text tel
        /// </summary>
        private System.Windows.Forms.TextBox txtTel;
        /// <summary>
        /// The text correo
        /// </summary>
        private System.Windows.Forms.TextBox txtCorreo;
        /// <summary>
        /// The CMB depar
        /// </summary>
        private System.Windows.Forms.ComboBox cmbDepar;
        /// <summary>
        /// The CMB puesto
        /// </summary>
        private System.Windows.Forms.ComboBox cmbPuesto;
        /// <summary>
        /// The CMB estado
        /// </summary>
        private System.Windows.Forms.ComboBox cmbEstado;
        /// <summary>
        /// The CMB rol sis
        /// </summary>
        private System.Windows.Forms.ComboBox cmbRolSis;
        /// <summary>
        /// The text usuario
        /// </summary>
        private System.Windows.Forms.TextBox txtUsuario;
        /// <summary>
        /// The text contra
        /// </summary>
        private System.Windows.Forms.TextBox txtContra;
        /// <summary>
        /// The departamento table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.DepartamentoTableAdapter departamentoTableAdapter;
        /// <summary>
        /// The tacoma database data set1
        /// </summary>
        private TacomaDBDataSet tacomaDBDataSet1;
        /// <summary>
        /// The departamento binding source
        /// </summary>
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        /// <summary>
        /// The tacoma database data set2
        /// </summary>
        private TacomaDBDataSet tacomaDBDataSet2;
        /// <summary>
        /// The proveedores productos binding source
        /// </summary>
        private System.Windows.Forms.BindingSource proveedoresProductosBindingSource;
        /// <summary>
        /// The proveedores productos table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.Proveedores_ProductosTableAdapter proveedores_ProductosTableAdapter;
        /// <summary>
        /// The roles departamentos binding source
        /// </summary>
        private System.Windows.Forms.BindingSource rolesDepartamentosBindingSource;
        /// <summary>
        /// The roles departamentos table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.Roles_DepartamentosTableAdapter roles_DepartamentosTableAdapter;
        /// <summary>
        /// The roles binding source
        /// </summary>
        private System.Windows.Forms.BindingSource rolesBindingSource;
        /// <summary>
        /// The roles table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.RolesTableAdapter rolesTableAdapter;
        /// <summary>
        /// The estado binding source
        /// </summary>
        private System.Windows.Forms.BindingSource estadoBindingSource;
        /// <summary>
        /// The estado table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.EstadoTableAdapter estadoTableAdapter;
        /// <summary>
        /// The rol sistema binding source
        /// </summary>
        private System.Windows.Forms.BindingSource rolSistemaBindingSource;
        /// <summary>
        /// The rol sistema table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.Rol_SistemaTableAdapter rol_SistemaTableAdapter;
        /// <summary>
        /// The panel1
        /// </summary>
        private System.Windows.Forms.Panel panel1;
        /// <summary>
        /// The text cod emple
        /// </summary>
        private System.Windows.Forms.TextBox txtCodEmple;
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
        /// The error correo
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorCorreo;
        /// <summary>
        /// The error depar
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorDepar;
        /// <summary>
        /// The error puesto
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorPuesto;
        /// <summary>
        /// The error estado
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorEstado;
        /// <summary>
        /// The error rol
        /// </summary>
        private System.Windows.Forms.ErrorProvider errorRol;
        /// <summary>
        /// The CMB busqueda
        /// </summary>
        private System.Windows.Forms.ComboBox cmbBusqueda;
        /// <summary>
        /// The BTN buscar
        /// </summary>
        private System.Windows.Forms.Button btnBuscar;
        /// <summary>
        /// The text buscar
        /// </summary>
        private System.Windows.Forms.TextBox txtBuscar;
        /// <summary>
        /// The BTN cancelar
        /// </summary>
        private System.Windows.Forms.Button btnCancelar;
        /// <summary>
        /// The btnguardar
        /// </summary>
        private System.Windows.Forms.Button btnguardar;
        /// <summary>
        /// The BTN aceptar
        /// </summary>
        private System.Windows.Forms.Button btnAceptar;
        /// <summary>
        /// The BTN modificar
        /// </summary>
        private System.Windows.Forms.Button btnModificar;
        /// <summary>
        /// The BTN añadir
        /// </summary>
        private System.Windows.Forms.Button btnAñadir;
        /// <summary>
        /// The text confir con
        /// </summary>
        private System.Windows.Forms.TextBox txtConfirCon;
        /// <summary>
        /// The error usuario
        /// </summary>
        private System.Windows.Forms.ErrorProvider ErrorUsuario;
        /// <summary>
        /// The error contra
        /// </summary>
        private System.Windows.Forms.ErrorProvider ErrorContra;
        /// <summary>
        /// The error comfir contra
        /// </summary>
        private System.Windows.Forms.ErrorProvider ErrorComfirContra;
        private System.Windows.Forms.DataGridView vwEmpleadoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.ErrorProvider errorCodEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}