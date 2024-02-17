// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 12-13-2019
//
// Last Modified By : pepit
// Last Modified On : 12-13-2019
// ***********************************************************************
// <copyright file="HIstorial de Ventas.designer.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class HIstorial_de_Ventas.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class HIstorial_de_Ventas
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
            this.tacomaDBDataSet = new Tacoma_ProyectoDesarrollo.TacomaDBDataSet();
            this.vwFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwFacturaTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.VwFacturaTableAdapter();
            this.tableAdapterManager = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.TableAdapterManager();
            this.historialFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historialDetallesFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historialDetallesFacturaTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.HistorialDetallesFacturaTableAdapter();
            this.historialFacturasTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.HistorialFacturasTableAdapter();
            this.vwFacturaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vwDetalleFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwDetalleFacturaTableAdapter = new Tacoma_ProyectoDesarrollo.TacomaDBDataSetTableAdapters.VwDetalleFacturaTableAdapter();
            this.historialDetallesFacturaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialDetallesFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFacturaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDetalleFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialDetallesFacturaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tacomaDBDataSet
            // 
            this.tacomaDBDataSet.DataSetName = "TacomaDBDataSet";
            this.tacomaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwFacturaBindingSource
            // 
            this.vwFacturaBindingSource.DataMember = "VwFactura";
            this.vwFacturaBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // vwFacturaTableAdapter
            // 
            this.vwFacturaTableAdapter.ClearBeforeFill = true;
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
            // historialFacturasBindingSource
            // 
            this.historialFacturasBindingSource.DataMember = "HistorialFacturas";
            this.historialFacturasBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // historialDetallesFacturaBindingSource
            // 
            this.historialDetallesFacturaBindingSource.DataMember = "HistorialDetallesFactura";
            this.historialDetallesFacturaBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // historialDetallesFacturaTableAdapter
            // 
            this.historialDetallesFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // historialFacturasTableAdapter
            // 
            this.historialFacturasTableAdapter.ClearBeforeFill = true;
            // 
            // vwFacturaDataGridView
            // 
            this.vwFacturaDataGridView.AllowUserToAddRows = false;
            this.vwFacturaDataGridView.AllowUserToDeleteRows = false;
            this.vwFacturaDataGridView.AutoGenerateColumns = false;
            this.vwFacturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vwFacturaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.vwFacturaDataGridView.DataSource = this.vwFacturaBindingSource;
            this.vwFacturaDataGridView.Location = new System.Drawing.Point(157, 31);
            this.vwFacturaDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vwFacturaDataGridView.Name = "vwFacturaDataGridView";
            this.vwFacturaDataGridView.ReadOnly = true;
            this.vwFacturaDataGridView.RowHeadersWidth = 51;
            this.vwFacturaDataGridView.Size = new System.Drawing.Size(857, 271);
            this.vwFacturaDataGridView.TabIndex = 0;
            this.vwFacturaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vwFacturaDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Factura";
            this.dataGridViewTextBoxColumn1.HeaderText = "Factura";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Empleado";
            this.dataGridViewTextBoxColumn3.HeaderText = "Empleado";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Tipo de pago";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tipo de pago";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ISV";
            this.dataGridViewTextBoxColumn5.HeaderText = "ISV";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn6.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // vwDetalleFacturaBindingSource
            // 
            this.vwDetalleFacturaBindingSource.DataMember = "VwDetalleFactura";
            this.vwDetalleFacturaBindingSource.DataSource = this.tacomaDBDataSet;
            // 
            // vwDetalleFacturaTableAdapter
            // 
            this.vwDetalleFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // historialDetallesFacturaDataGridView
            // 
            this.historialDetallesFacturaDataGridView.AllowUserToAddRows = false;
            this.historialDetallesFacturaDataGridView.AllowUserToDeleteRows = false;
            this.historialDetallesFacturaDataGridView.AutoGenerateColumns = false;
            this.historialDetallesFacturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historialDetallesFacturaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.historialDetallesFacturaDataGridView.DataSource = this.historialDetallesFacturaBindingSource;
            this.historialDetallesFacturaDataGridView.Location = new System.Drawing.Point(289, 309);
            this.historialDetallesFacturaDataGridView.Name = "historialDetallesFacturaDataGridView";
            this.historialDetallesFacturaDataGridView.ReadOnly = true;
            this.historialDetallesFacturaDataGridView.RowHeadersWidth = 51;
            this.historialDetallesFacturaDataGridView.RowTemplate.Height = 24;
            this.historialDetallesFacturaDataGridView.Size = new System.Drawing.Size(545, 220);
            this.historialDetallesFacturaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Factura";
            this.dataGridViewTextBoxColumn7.HeaderText = "Factura";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Producto";
            this.dataGridViewTextBoxColumn8.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn9.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Precio Unitario";
            this.dataGridViewTextBoxColumn10.HeaderText = "Precio Unitario";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // HIstorial_de_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 734);
            this.Controls.Add(this.historialDetallesFacturaDataGridView);
            this.Controls.Add(this.vwFacturaDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HIstorial_de_Ventas";
            this.Text = "HIstorial_de_Ventas";
            this.Load += new System.EventHandler(this.HIstorial_de_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tacomaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialDetallesFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwFacturaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwDetalleFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historialDetallesFacturaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        /// <summary>
        /// The tacoma database data set
        /// </summary>
        private TacomaDBDataSet tacomaDBDataSet;
        /// <summary>
        /// The vw factura binding source
        /// </summary>
        private System.Windows.Forms.BindingSource vwFacturaBindingSource;
        /// <summary>
        /// The vw factura table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.VwFacturaTableAdapter vwFacturaTableAdapter;
        /// <summary>
        /// The table adapter manager
        /// </summary>
        private TacomaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        /// <summary>
        /// The historial facturas binding source
        /// </summary>
        private System.Windows.Forms.BindingSource historialFacturasBindingSource;
        /// <summary>
        /// The historial detalles factura binding source
        /// </summary>
        private System.Windows.Forms.BindingSource historialDetallesFacturaBindingSource;
        /// <summary>
        /// The historial detalles factura table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.HistorialDetallesFacturaTableAdapter historialDetallesFacturaTableAdapter;
        /// <summary>
        /// The historial facturas table adapter
        /// </summary>
        private TacomaDBDataSetTableAdapters.HistorialFacturasTableAdapter historialFacturasTableAdapter;
        private System.Windows.Forms.DataGridView vwFacturaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource vwDetalleFacturaBindingSource;
        private TacomaDBDataSetTableAdapters.VwDetalleFacturaTableAdapter vwDetalleFacturaTableAdapter;
        private System.Windows.Forms.DataGridView historialDetallesFacturaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}