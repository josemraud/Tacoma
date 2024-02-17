// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 11-24-2019
//
// Last Modified By : pepit
// Last Modified On : 12-11-2019
// ***********************************************************************
// <copyright file="Empleados.cs" company="">
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
using System.Text.RegularExpressions;

namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class Empleados.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Empleados : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Empleados"/> class.
        /// </summary>
        public Empleados()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the Empleados control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Empleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet2.Rol_Sistema' Puede moverla o quitarla según sea necesario.
            this.rol_SistemaTableAdapter.Fill(this.tacomaDBDataSet2.Rol_Sistema);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet2.Estado' Puede moverla o quitarla según sea necesario.
            this.estadoTableAdapter.Fill(this.tacomaDBDataSet2.Estado);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet2.Roles' Puede moverla o quitarla según sea necesario.
            this.rolesTableAdapter.Fill(this.tacomaDBDataSet2.Roles);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet2.Roles_Departamentos' Puede moverla o quitarla según sea necesario.
            this.roles_DepartamentosTableAdapter.Fill(this.tacomaDBDataSet2.Roles_Departamentos);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet2._Proveedores_Productos' Puede moverla o quitarla según sea necesario.
            this.proveedores_ProductosTableAdapter.Fill(this.tacomaDBDataSet2._Proveedores_Productos);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet1.Departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.tacomaDBDataSet1.Departamento);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.VwEmpleado' Puede moverla o quitarla según sea necesario.
            //this.vwEmpleadoTableAdapter.Fill(this.tacomaDBDataSet.VwEmpleado);
            CargarData();

            if (txtCodEmple.Text == "")
            {
                btnModificar.Enabled = false;
            }
            else
            {
                btnModificar.Enabled = true;
            }
        }
        /// <summary>
        /// Cargars the data.
        /// </summary>
        public void CargarData()
        {
            BaseDeDatos ba = new BaseDeDatos();
            ba.Conectar();
            SqlCommand com = new SqlCommand("SELECT * FROM VwEmpleado", ba.cone);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            vwEmpleadoDataGridView.DataSource = dt;
            vwEmpleadoBindingSource.DataSource = dt;
        }
        /// <summary>
        /// Cargars the puestos.
        /// </summary>
        /// <param name="Depar">The depar.</param>
        public void CargarPuestos(String Depar)
        {

            BaseDeDatos ba = new BaseDeDatos();
            ba.Conectar();
            SqlCommand com = new SqlCommand("SELECT Rol_Codigo, Rol_Descripcion FROM Roles a INNER JOIN Roles_Departamentos b on a.Rol_Codigo=b.Rol_ID " +
                "JOIN Departamento c on b.Departamento_ID=c.Departamento_ID where c.Departamento_Descripcion = @Departamento", ba.cone);
            com.Parameters.AddWithValue("@Departamento", Depar);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbPuesto.ValueMember = "Rol_Codigo";
            cmbPuesto.DisplayMember = "Rol_Descripcion";
            cmbPuesto.DataSource = dt;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the DepartamentoComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DepartamentoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorDepar.Clear();
            if (cmbDepar.Text.ToString() != null)
            {
                string depar = cmbDepar.Text.ToString();
                this.CargarPuestos(depar);
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnAñadir control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            this.CargarData();
            this.vwEmpleadoBindingSource.AddNew();
            btnAñadir.Enabled = false;
            btnAceptar.Enabled = true;
            panel1.Enabled = true;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            this.txtContra.Clear();
            this.txtCorreo.Clear();
            this.txtDirecc.Clear();
            this.txtNom.Clear();
            this.txtTel.Clear();
            this.txtUsuario.Clear();
            vwEmpleadoDataGridView.Enabled = true;
            txtCodEmple.Enabled = true;
            

        }

        /// <summary>
        /// Handles the Click event of the BtnAceptar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            EmpleadosMetodos emp = new EmpleadosMetodos();
            emp.ValidarCorreo(txtCorreo.Text);
            emp.ValidarTelefono(txtTel.Text);
            emp.ValidarUsuario(txtUsuario.Text);


           
            if(txtCodEmple.Text == "" || (txtCodEmple.TextLength != 13))
            {
                errorCodEmpleado.SetError(txtCodEmple, "Ingrese un codigo de empleado valido");
            }
            else
                if(emp.VerificarDepar(this.txtCodEmple.Text.Substring(0, 2)) == 0)
                {
                 errorCodEmpleado.SetError(txtCodEmple, "El numero de identidad no existe depar");
                 }
                 else
                 if(emp.VerificarMuni(this.txtCodEmple.Text.Substring(0, 2), this.txtCodEmple.Text.Substring(2, 2))==0)
                {
                errorCodEmpleado.SetError(txtCodEmple, "El numero de identidad no existe municipio");
                }
            else
                if(int.Parse(this.txtCodEmple.Text.Substring(4, 4))>int.Parse(DateTime.Now.Year.ToString())|| 
                int.Parse(this.txtCodEmple.Text.Substring(4, 4))<=1890)
                {
                errorCodEmpleado.SetError(txtCodEmple, "El numero de identidad no existe años ");
                }
            if (txtNom.Text == "" || txtNom.Text.StartsWith(" "))
            {
                errorNombre.SetError(txtNom, "Campo Obligatorio");
            }
            if (txtNom.TextLength < 3)
            {
                errorNombre.SetError(txtNom, "Minimo 3 caracteres.");
            }
            if (txtDirecc.Text == "" || txtDirecc.Text.StartsWith(" "))
            {
                errorDireccion.SetError(txtDirecc, "Campo Obligatorio");
            }
            if (txtTel.Text == "")
            {
                errorTelefono.SetError(txtTel, "Campo Obligatorio");
            }
            if (txtDirecc.TextLength < 8)
            {
                errorDireccion.SetError(txtDirecc, "Minimo 8 caracteres");
            }
            if (txtTel.TextLength < 8)
            {
                errorTelefono.SetError(txtTel, "Ingresar un numero de telefono valido");
            }
            if (txtCorreo.Text == "1    ")
            {

            }
            if (cmbDepar.Text == "")
            {
                errorDepar.SetError(cmbDepar, "Campo Obligatorio");
            }
            if (cmbPuesto.Text == "")
            {
                errorPuesto.SetError(cmbPuesto, "Campo Obligatorio");
            }
            if (cmbRolSis.Text == "")
            {
                errorRol.SetError(cmbRolSis, "Campo Obligatorio");
            }
            if (cmbEstado.Text == "")
            {
                errorEstado.SetError(cmbEstado, "Campo Obligatorio");
            }

            if(cmbRolSis.Text == "Ninguno")
            {
                if(txtNom.TextLength < 6)
                {
                    MessageBox.Show("Se necesitan 6 letras o mas", "Error en nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (CompartirDatos.codU == 1)
                {
                    MessageBox.Show("El usuario " + txtUsuario.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (CompartirDatos.codC == 1)
                {
                    MessageBox.Show("El correo " + txtCorreo.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (CompartirDatos.codT == 1)
                {
                    MessageBox.Show("El numero " + txtTel.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtNom.Text == "" || txtDirecc.Text == "" || txtTel.Text == "" || txtTel.TextLength < 8 || cmbDepar.Text == "" || cmbPuesto.Text == "" ||
                    cmbRolSis.Text == "" || cmbEstado.Text == "" || txtCodEmple.Text == "" || (txtCodEmple.TextLength != 13)|| emp.VerificarDepar(this.txtCodEmple.Text.Substring(0, 2)) == 0
                     || emp.VerificarMuni(this.txtCodEmple.Text.Substring(0, 2), this.txtCodEmple.Text.Substring(2, 2)) == 0 ||
                     int.Parse(this.txtCodEmple.Text.Substring(4, 4)) > int.Parse(DateTime.Now.Year.ToString())
                     || int.Parse(this.txtCodEmple.Text.Substring(4, 4)) <=1890
                     || txtNom.Text.StartsWith(" ")|| txtNom.TextLength < 3 || txtDirecc.Text.StartsWith(" ")||
                     txtDirecc.TextLength < 8 

                     )
                {
                    MessageBox.Show("Datos Incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    //EmpleadosMetodos emp = new EmpleadosMetodos();
                    emp.AñadirEmpleadoSU(this.txtCodEmple.Text,this.txtNom.Text, this.txtDirecc.Text, this.txtTel.Text, (int)this.cmbDepar.SelectedValue,
                       (int)this.cmbEstado.SelectedValue, (int)this.cmbRolSis.SelectedValue,
                        this.txtCorreo.Text, (int)this.cmbPuesto.SelectedValue);

                    this.vwEmpleadoDataGridView.Refresh();
                    this.CargarData();
                    btnAñadir.Enabled = true;
                    btnModificar.Enabled = true;
                    btnAceptar.Enabled = false;
                    btnCancelar.Enabled = false;
                    panel1.Enabled = false;
                    txtConfirCon.Clear();
                }
            }
            else if (cmbRolSis.Text != "Ninguno")
            {
                if (txtUsuario.Text != "" && txtContra.Text == "")
                {
                    ErrorUsuario.SetError(txtUsuario, "Campo Obligatorio");
                }
                if (txtContra.Text != "" && txtUsuario.Text == "")
                {
                    ErrorContra.SetError(txtContra, "Campo Obligatorio");
                }
                if (txtUsuario.Text != "" && (txtContra.Text != txtConfirCon.Text))
                {
                    ErrorComfirContra.SetError(txtConfirCon, "Las contraseñas no coinciden");
                }

                if (txtNom.TextLength < 6)
                {
                    MessageBox.Show("Se necesitan 6 letras o mas", "Error en nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (CompartirDatos.codU == 1)
                {
                    MessageBox.Show("El usuario " + txtUsuario.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (CompartirDatos.codC == 1)
                {
                    MessageBox.Show("El correo " + txtCorreo.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (CompartirDatos.codT == 1)
                {
                    MessageBox.Show("El numero " + txtTel.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtNom.Text == "" || txtDirecc.Text == "" || txtTel.Text == "" || txtTel.TextLength < 8 || cmbDepar.Text == "" || cmbPuesto.Text == "" ||
                    cmbRolSis.Text == "" || cmbEstado.Text == "" || txtUsuario.Text != "" && txtContra.Text == "" || txtContra.Text != "" && txtUsuario.Text == ""
                    || txtUsuario.Text != "" && (txtContra.Text != txtConfirCon.Text)||
                    (txtCodEmple.TextLength != 13) || emp.VerificarDepar(this.txtCodEmple.Text.Substring(0, 2)) == 0
                     || emp.VerificarMuni(this.txtCodEmple.Text.Substring(0, 2), this.txtCodEmple.Text.Substring(2, 2)) == 0 ||
                     int.Parse(this.txtCodEmple.Text.Substring(4, 4)) > int.Parse(DateTime.Now.Year.ToString())
                     || int.Parse(this.txtCodEmple.Text.Substring(4, 4)) <= 1890 || txtNom.Text.StartsWith(" ") || txtNom.TextLength < 3 || txtDirecc.Text.StartsWith(" ") ||
                     txtDirecc.TextLength < 8 || this.txtContra.TextLength < 8
                    )
                {
                    MessageBox.Show("Datos Incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    //EmpleadosMetodos emp = new EmpleadosMetodos();
                    emp.AñadirEmpleado(this.txtCodEmple.Text,this.txtNom.Text, this.txtDirecc.Text, this.txtTel.Text, (int)this.cmbDepar.SelectedValue,
                        this.txtUsuario.Text, this.txtContra.Text, (int)this.cmbEstado.SelectedValue, (int)this.cmbRolSis.SelectedValue,
                        this.txtCorreo.Text, (int)this.cmbPuesto.SelectedValue);

                    this.vwEmpleadoDataGridView.Refresh();
                    this.CargarData();
                    btnAñadir.Enabled = true;
                    btnModificar.Enabled = true;
                    btnAceptar.Enabled = false;
                    btnCancelar.Enabled = false;
                    panel1.Enabled = false;
                    txtConfirCon.Clear();
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnModificar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            label2.Text = txtCorreo.Text;
            label3.Text = txtTel.Text;
            label4.Text = txtUsuario.Text;

            vwEmpleadoDataGridView.Enabled = false; //Pepeeeeeeeeee Hola wey :) ..... Te quiero wey <3...
            btnModificar.Enabled = false;
            btnAñadir.Enabled = false;
            btnAceptar.Enabled = false;
            btnguardar.Enabled = true;
            btnCancelar.Enabled = true;
            panel1.Enabled = true;
            txtConfirCon.Clear();
            txtCodEmple.Enabled = false;


        }

        public void ActualizarCU()
        {
            EmpleadosMetodos emp = new EmpleadosMetodos();
            emp.ActualizarEmpleado(this.txtCodEmple.Text, this.txtNom.Text, this.txtDirecc.Text, this.txtTel.Text, (int)this.cmbDepar.SelectedValue,
                        this.txtUsuario.Text, this.txtContra.Text, (int)this.cmbEstado.SelectedValue, (int)this.cmbRolSis.SelectedValue,
                        this.txtCorreo.Text, (int)this.cmbPuesto.SelectedValue);


            this.vwEmpleadoDataGridView.Refresh();
            this.CargarData();

            btnAñadir.Enabled = true;
            btnModificar.Enabled = true;
            btnAceptar.Enabled = false;
            panel1.Enabled = false;
            btnguardar.Enabled = false;
            btnCancelar.Enabled = false;
            txtConfirCon.Clear();
        }

        public void ActualizarSU()
        {
            EmpleadosMetodos emp = new EmpleadosMetodos();
            emp.ActualizarEmpleadoSU(this.txtCodEmple.Text, this.txtNom.Text, this.txtDirecc.Text, this.txtTel.Text, (int)this.cmbDepar.SelectedValue,
                        (int)this.cmbEstado.SelectedValue, (int)this.cmbRolSis.SelectedValue,
                        this.txtCorreo.Text, (int)this.cmbPuesto.SelectedValue);


            this.vwEmpleadoDataGridView.Refresh();
            this.CargarData();

            btnAñadir.Enabled = true;
            btnModificar.Enabled = true;
            btnAceptar.Enabled = false;
            panel1.Enabled = false;
            btnguardar.Enabled = false;
            btnCancelar.Enabled = false;
            txtConfirCon.Clear();
        }

        /// <summary>
        /// Handles the Click event of the Btnguardar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Btnguardar_Click(object sender, EventArgs e)
        {
            EmpleadosMetodos emp = new EmpleadosMetodos();
            emp.ModificarCorreo(txtCorreo.Text);
            emp.ModificarTelefono(int.Parse(txtTel.Text));
            emp.ModificarUsuario(txtUsuario.Text);

            if (txtNom.Text == ""||txtNom.Text.StartsWith(" "))
            {
                errorNombre.SetError(txtNom, "Campo Obligatorio");
            }
            if(txtNom.TextLength<3)
            {
                errorNombre.SetError(txtNom, "Minimo 3 caracteres.");
            }
            if (txtDirecc.Text == "" || txtDirecc.Text.StartsWith(" "))
            {
                errorDireccion.SetError(txtDirecc, "Campo Obligatorio");
            }
            if(txtDirecc.TextLength<8)
            {
                errorDireccion.SetError(txtDirecc, "Minimo 8 caracteres");
            }
            if (txtTel.Text == "")
            {
                errorTelefono.SetError(txtTel, "Campo Obligatorio");
            }
            if (txtTel.TextLength < 8)
            {
                errorTelefono.SetError(txtTel, "Ingresar un numero de telefono valido");
            }
            if (txtCorreo.Text == "1")
            {

            }

            if (txtNom.TextLength < 6)
            {
                MessageBox.Show("Se necesitan 6 letras o mas", "Error en nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else if (cmbRolSis.Text == "Ninguno")
            {
                if (label3.Text != txtTel.Text)
                {
                    if (CompartirDatos.sumTelEmp >= 1)
                    {
                        MessageBox.Show("El numero " + txtTel.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtNom.Text == "" || txtDirecc.Text == "" || txtTel.Text == "" || txtTel.TextLength < 8)
                    {
                        MessageBox.Show("Datos Incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        ActualizarSU();
                }
                else if (label2.Text != txtCorreo.Text)
                {
                    if (CompartirDatos.sumCorEmp >= 1)
                    {
                        MessageBox.Show("El correo " + txtCorreo.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtNom.Text == "" || txtDirecc.Text == "" || txtTel.Text == "" || txtTel.TextLength < 8)
                    {
                        MessageBox.Show("Datos Incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ActualizarSU();
                }
                else if(label2.Text != txtCorreo.Text && label3.Text != txtTel.Text)
                {
                    if (CompartirDatos.sumTelEmp >= 1)
                    {
                        MessageBox.Show("El numero " + txtTel.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (CompartirDatos.sumCorEmp >= 1)
                    {
                        MessageBox.Show("El correo " + txtCorreo.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtNom.Text == "" || txtDirecc.Text == "" || txtTel.Text == "" || txtTel.TextLength < 8)
                    {
                        MessageBox.Show("Datos Incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ActualizarSU();
                }
                else if (txtNom.Text == "" || txtDirecc.Text == "" || txtTel.Text == "" || txtTel.TextLength < 8)
                {
                    MessageBox.Show("Datos Incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ActualizarSU();
                }
            }
            else if (cmbRolSis.Text != "Ninguna")
            {
                if (txtUsuario.Text != "" && txtContra.Text == "")
                {
                    ErrorContra.SetError(txtContra, "Campo Obligatorio");
                    ErrorComfirContra.SetError(txtConfirCon, "Campo Obligatorio");
                }
                if (txtContra.Text != "" && txtUsuario.Text == "" && txtConfirCon.Text == "")
                {
                    ErrorUsuario.SetError(txtUsuario, "Campo Obligatorio");
                    ErrorComfirContra.SetError(txtConfirCon, "Campo Obligatorio");
                }
                if (txtUsuario.Text != "" && (txtContra.Text != txtConfirCon.Text))
                {
                    ErrorComfirContra.SetError(txtConfirCon, "Las contraseñas no coinciden");
                }
                if (txtConfirCon.Text != "" && (txtUsuario.Text == ""))
                {
                    ErrorUsuario.SetError(txtUsuario, "Campo Obligatorio");

                }
                else
                {
                    if (txtConfirCon.Text != "" && (txtContra.Text == ""))
                    {
                        ErrorContra.SetError(txtContra, "Campo Obligatorio");
                    }
                }

                if (label4.Text != txtUsuario.Text && label2.Text == txtCorreo.Text && label3.Text == txtTel.Text)
                {
                    if (CompartirDatos.sumUser >= 1)
                    {
                        MessageBox.Show("El usuario " + txtUsuario.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtNom.Text == "" || txtDirecc.Text == "" || txtTel.Text == "" || txtTel.TextLength < 8 ||
                   txtUsuario.Text != "" && txtContra.Text == "" || txtContra.Text != "" && txtUsuario.Text == ""
                   || txtUsuario.Text != "" && (txtContra.Text != txtConfirCon.Text) ||
                   txtConfirCon.Text != "" && (txtUsuario.Text == "") || txtConfirCon.Text != "" && (txtContra.Text == "") || this.txtContra.TextLength < 8)
                    {
                        MessageBox.Show("Datos Incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        ActualizarCU();
                }
                else if (label3.Text != txtTel.Text && label4.Text == txtUsuario.Text && label2.Text == txtCorreo.Text)
                {
                    if (CompartirDatos.sumTelEmp >= 1)
                    {
                        MessageBox.Show("El numero " + txtTel.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtNom.Text == "" || txtDirecc.Text == "" || txtTel.Text == "" || txtTel.TextLength < 8 ||
                    txtUsuario.Text != "" && txtContra.Text == "" || txtContra.Text != "" && txtUsuario.Text == ""
                    || txtUsuario.Text != "" && (txtContra.Text != txtConfirCon.Text) ||
                    txtConfirCon.Text != "" && (txtUsuario.Text == "") || txtConfirCon.Text != "" && (txtContra.Text == "") || this.txtContra.TextLength < 8)
                    {
                        MessageBox.Show("Datos Incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        ActualizarCU();
                }
                else if (label2.Text != txtCorreo.Text && label4.Text == txtUsuario.Text && label3.Text == txtTel.Text)
                {
                    if (CompartirDatos.sumCorEmp >= 1)
                    {
                        MessageBox.Show("El correo " + txtCorreo.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else  if (txtNom.Text == "" || txtDirecc.Text == "" || txtTel.Text == "" || txtTel.TextLength < 8 ||
                    txtUsuario.Text != "" && txtContra.Text == "" || txtContra.Text != "" && txtUsuario.Text == ""
                    || txtUsuario.Text != "" && (txtContra.Text != txtConfirCon.Text) ||
                    txtConfirCon.Text != "" && (txtUsuario.Text == "") || txtConfirCon.Text != "" && (txtContra.Text == "") || this.txtContra.TextLength < 8)
                    {
                        MessageBox.Show("Datos Incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        ActualizarCU();
                }
                else if(label2.Text != txtCorreo.Text && label3.Text != txtTel.Text && label4.Text == txtUsuario.Text)
                {
                    if (CompartirDatos.sumTelEmp >= 1)
                    {
                        MessageBox.Show("El numero " + txtTel.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if(CompartirDatos.sumCorEmp >= 1)
                    {
                        MessageBox.Show("El correo " + txtCorreo.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtNom.Text == "" || txtDirecc.Text == "" || txtTel.Text == "" || txtTel.TextLength < 8 ||
                   txtUsuario.Text != "" && txtContra.Text == "" || txtContra.Text != "" && txtUsuario.Text == ""
                   || txtUsuario.Text != "" && (txtContra.Text != txtConfirCon.Text) ||
                   txtConfirCon.Text != "" && (txtUsuario.Text == "") || txtConfirCon.Text != "" && (txtContra.Text == "") || this.txtContra.TextLength < 8)
                    {
                        MessageBox.Show("Datos Incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        ActualizarCU();
                }
                else if(label2.Text != txtCorreo.Text && label4.Text != txtUsuario.Text && label3.Text == txtTel.Text)
                {
                    if (CompartirDatos.sumUser >= 1)
                    {
                        MessageBox.Show("El usuario " + txtUsuario.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (CompartirDatos.sumCorEmp >= 1)
                    {
                        MessageBox.Show("El correo " + txtCorreo.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtNom.Text == "" || txtDirecc.Text == "" || txtTel.Text == "" || txtTel.TextLength < 8 ||
                   txtUsuario.Text != "" && txtContra.Text == "" || txtContra.Text != "" && txtUsuario.Text == ""
                   || txtUsuario.Text != "" && (txtContra.Text != txtConfirCon.Text) ||
                   txtConfirCon.Text != "" && (txtUsuario.Text == "") || txtConfirCon.Text != "" && (txtContra.Text == "") || this.txtContra.TextLength < 8)
                    {
                        MessageBox.Show("Datos Incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        ActualizarCU();
                }
                else if(label3.Text != txtTel.Text  && label4.Text != txtUsuario.Text && label2.Text == txtCorreo.Text)
                {
                    if (CompartirDatos.sumTelEmp >= 1)
                    {
                        MessageBox.Show("El numero " + txtTel.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (CompartirDatos.sumUser >= 1)
                    {
                        MessageBox.Show("El usuario " + txtUsuario.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txtNom.Text == "" || txtDirecc.Text == "" || txtTel.Text == "" || txtTel.TextLength < 8 ||
                   txtUsuario.Text != "" && txtContra.Text == "" || txtContra.Text != "" && txtUsuario.Text == ""
                   || txtUsuario.Text != "" && (txtContra.Text != txtConfirCon.Text) ||
                   txtConfirCon.Text != "" && (txtUsuario.Text == "") || txtConfirCon.Text != "" && (txtContra.Text == "") || this.txtContra.TextLength < 8)
                    {
                        MessageBox.Show("Datos Incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        ActualizarCU();
                }
                else if(label2.Text != txtCorreo.Text && label3.Text != txtTel.Text && label4.Text != txtUsuario.Text)
                {
                    if (CompartirDatos.sumTelEmp >= 1)
                    {
                        MessageBox.Show("El numero " + txtTel.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (CompartirDatos.sumUser >= 1)
                    {
                        MessageBox.Show("El usuario " + txtUsuario.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (CompartirDatos.sumCorEmp >= 1)
                    {
                        MessageBox.Show("El correo " + txtCorreo.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }       
                    else if (txtNom.Text == "" || txtDirecc.Text == "" || txtTel.Text == "" || txtTel.TextLength < 8 ||
                   txtUsuario.Text != "" && txtContra.Text == "" || txtContra.Text != "" && txtUsuario.Text == ""
                   || txtUsuario.Text != "" && (txtContra.Text != txtConfirCon.Text) ||
                   txtConfirCon.Text != "" && (txtUsuario.Text == "") || txtConfirCon.Text != "" && (txtContra.Text == "") || this.txtContra.TextLength < 8)
                    {
                        MessageBox.Show("Datos Incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        ActualizarCU();
                }
                else if (txtNom.Text == "" || txtDirecc.Text == "" || txtTel.Text == "" || txtTel.TextLength < 8 ||
                    txtUsuario.Text != "" && txtContra.Text == "" || txtContra.Text != "" && txtUsuario.Text == ""
                    || txtUsuario.Text != "" && (txtContra.Text != txtConfirCon.Text) ||
                    txtConfirCon.Text != "" && (txtUsuario.Text == "") || txtConfirCon.Text != "" && (txtContra.Text == "") || this.txtContra.TextLength < 8)
                {
                    MessageBox.Show("Datos Incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                        ActualizarCU();
                }
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the TxtNom control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TxtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the KeyPress event of the TxtDirecc control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TxtDirecc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the KeyPress event of the TxtTel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TxtTel_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the TextChanged event of the TxtNom control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TxtNom_TextChanged(object sender, EventArgs e)
        {
            errorNombre.Clear();
        }

        /// <summary>
        /// Handles the TextChanged event of the TxtDirecc control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TxtDirecc_TextChanged(object sender, EventArgs e)
        {
            errorDireccion.Clear();
        }

        /// <summary>
        /// Handles the TextChanged event of the TxtTel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TxtTel_TextChanged(object sender, EventArgs e)
        {
            errorTelefono.Clear();
        }

        /// <summary>
        /// Handles the TextChanged event of the TxtCorreo control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TxtCorreo_TextChanged(object sender, EventArgs e)
        {
            errorCorreo.Clear();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the CmbPuesto control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CmbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorPuesto.Clear();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the CmbEstado control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorEstado.Clear();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the CmbRolSis control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CmbRolSis_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorRol.Clear();
            if (cmbRolSis.Text == "Ninguno")
            {
                txtContra.Enabled = false;
                txtUsuario.Enabled = false;
                txtConfirCon.Enabled = false;
            }
            else
            {
                txtContra.Enabled = true;
                txtUsuario.Enabled = true;
                txtConfirCon.Enabled = true;
            }
        }

        /// <summary>
        /// Handles the CellContentClick event of the VwEmpleadoDataGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void VwEmpleadoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Handles the Validating event of the TxtCorreo control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="CancelEventArgs"/> instance containing the event data.</param>
        private void TxtCorreo_Validating(object sender, CancelEventArgs e)
        {
            Regex email = new Regex(@"^[a-zA-Z][[\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (txtCorreo.Text.Length > 0)
            {
                if (!email.IsMatch(txtCorreo.Text))
                {
                    MessageBox.Show("Email invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCorreo.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnCancelar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            vwEmpleadoBindingSource.CancelEdit();
            this.CargarData();
            btnAceptar.Enabled = false;
            btnAñadir.Enabled = true;
            btnguardar.Enabled = false;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = false;
            txtConfirCon.Clear();
            this.txtContra.Clear();
            this.txtCorreo.Clear();
            this.txtDirecc.Clear();
            this.txtNom.Clear();
            this.txtTel.Clear();
            this.txtUsuario.Clear();
            this.txtCodEmple.Clear();
            this.cmbDepar.Text = "";
            this.cmbEstado.Text = "";
            this.cmbPuesto.Text = "";
            this.cmbRolSis.Text = "";
            panel1.Enabled = false;
        }

        /// <summary>
        /// Handles the Click event of the BtnBuscar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if(cmbBusqueda.Text=="Codigo")
            {
                try
                {
                    BuscarPorCodigo((this.txtBuscar.Text));
                    this.btnAñadir.Enabled = false;
                }
                catch(System.FormatException)
                {
                    MessageBox.Show("Ingrese un codigo de empleado valido","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                
               
            }

            if(cmbBusqueda.Text=="Nombre")
            {
                try { 
                BuscarPorNombre(this.txtBuscar.Text);
                }
                catch(System.FormatException)
                {
                    MessageBox.Show("Ingrese un nombre valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        /// <summary>
        /// Buscars the por codigo.
        /// </summary>
        /// <param name="cod">The cod.</param>
        public void BuscarPorCodigo(string cod )
        {
            try { 
            BaseDeDatos ba = new BaseDeDatos();
            ba.Conectar();
            SqlCommand com = new SqlCommand("SELECT * FROM VwEmpleado WHERE [Codigo de empleado] =@cod   ", ba.cone);
            com.Parameters.AddWithValue("@cod", cod);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            vwEmpleadoDataGridView.DataSource = dt;
                vwEmpleadoBindingSource.DataSource = dt;
            }
            catch(System.FormatException)
            {
                MessageBox.Show("Ingrese un nombre correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Buscars the por nombre.
        /// </summary>
        /// <param name="nom">The nom.</param>
        public void BuscarPorNombre(String nom)
        {
            BaseDeDatos ba = new BaseDeDatos();
            ba.Conectar();
            try
            {

            
             SqlCommand com = new SqlCommand("SELECT * FROM VwEmpleado WHERE [Nombre completo] LIKE '%'+@nom+'%'   ", ba.cone);
             com.Parameters.AddWithValue("@nom", nom);
             SqlDataAdapter da = new SqlDataAdapter(com);
             DataTable dt = new DataTable();
             da.Fill(dt);
             vwEmpleadoDataGridView.DataSource = dt;
                vwEmpleadoBindingSource.DataSource = dt;
            }
            catch(System.FormatException )
            {
                MessageBox.Show("Debe ingresar un codigo de empleado valido", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the CmbBusqueda control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CmbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbBusqueda.Text == "Todos los empleados") 
            {
                this.txtBuscar.Clear();
                this.txtBuscar.Enabled = false;
                this.btnBuscar.Enabled = false;
                this.CargarData();
              }
            else
            {
                this.txtBuscar.Enabled = true;
                this.btnBuscar.Enabled = true ;
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the TxtBuscar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(this.cmbBusqueda.Text== "Codigo")
            {
                if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    e.Handled = true;
            }
            else
            {
               
               if( char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = false;
                }
               else
                {
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// Handles the CellClick event of the VwEmpleadoDataGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void vwEmpleadoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtCodEmple.Text = vwEmpleadoDataGridView.CurrentRow.Cells[0].Value.ToString();
            this.txtNom.Text = vwEmpleadoDataGridView.CurrentRow.Cells[1].Value.ToString();
            this.txtDirecc.Text = vwEmpleadoDataGridView.CurrentRow.Cells[2].Value.ToString();
            this.txtTel.Text= vwEmpleadoDataGridView.CurrentRow.Cells[3].Value.ToString();
            this.txtCorreo.Text = vwEmpleadoDataGridView.CurrentRow.Cells[4].Value.ToString();
            this.cmbDepar.Text = vwEmpleadoDataGridView.CurrentRow.Cells[5].Value.ToString();
            this.cmbPuesto.Text = vwEmpleadoDataGridView.CurrentRow.Cells[6].Value.ToString();
            this.cmbEstado.Text = vwEmpleadoDataGridView.CurrentRow.Cells[7].Value.ToString();
            this.cmbRolSis.Text = vwEmpleadoDataGridView.CurrentRow.Cells[8].Value.ToString();
            this.txtUsuario.Text = vwEmpleadoDataGridView.CurrentRow.Cells[9].Value.ToString();
            this.txtContra.Text = vwEmpleadoDataGridView.CurrentRow.Cells[10].Value.ToString();

        }
        

        /// <summary>
        /// Handles the TextChanged event of the TxtBuscar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Handles the Click event of the Label2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the TextChanged event of the TxtUsuario control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            ErrorUsuario.Clear();

        }

        /// <summary>
        /// Handles the TextChanged event of the TxtContra control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TxtContra_TextChanged(object sender, EventArgs e)
        {
            ErrorContra.Clear();
        }

        /// <summary>
        /// Handles the TextChanged event of the TextBox1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            ErrorComfirContra.Clear();
        }

        private void vwEmpleadoDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.txtCodEmple.Text = vwEmpleadoDataGridView.CurrentRow.Cells[0].Value.ToString();
            this.txtNom.Text = vwEmpleadoDataGridView.CurrentRow.Cells[1].Value.ToString();
            this.txtDirecc.Text = vwEmpleadoDataGridView.CurrentRow.Cells[2].Value.ToString();
            this.txtTel.Text = vwEmpleadoDataGridView.CurrentRow.Cells[3].Value.ToString();
            this.txtCorreo.Text = vwEmpleadoDataGridView.CurrentRow.Cells[4].Value.ToString();
            this.cmbDepar.Text = vwEmpleadoDataGridView.CurrentRow.Cells[5].Value.ToString();
            this.cmbPuesto.Text = vwEmpleadoDataGridView.CurrentRow.Cells[6].Value.ToString();
            this.cmbEstado.Text = vwEmpleadoDataGridView.CurrentRow.Cells[7].Value.ToString();
            this.cmbRolSis.Text = vwEmpleadoDataGridView.CurrentRow.Cells[8].Value.ToString();
            this.txtUsuario.Text = vwEmpleadoDataGridView.CurrentRow.Cells[9].Value.ToString();
            this.txtContra.Text = vwEmpleadoDataGridView.CurrentRow.Cells[10].Value.ToString();

        }

        private void TxtCodEmple_TextChanged(object sender, EventArgs e)
        {
            errorCodEmpleado.Clear();
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)||char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void TxtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void TxtConfirCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
    }
}
