// ***********************************************************************
// Assembly         : Tacoma_ProyectoDesarrollo
// Author           : pepit
// Created          : 11-24-2019
//
// Last Modified By : pepit
// Last Modified On : 12-13-2019
// ***********************************************************************
// <copyright file="Clientes.cs" company="">
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

namespace Tacoma_ProyectoDesarrollo
{
    /// <summary>
    /// Class Clientes.
    /// Implements the <see cref="System.Windows.Forms.Form" />
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class Clientes : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Clientes"/> class.
        /// </summary>
        public Clientes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the Label1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Load event of the Clientes control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.Pais1' Puede moverla o quitarla según sea necesario.
            this.pais1TableAdapter.Fill(this.tacomaDBDataSet.Pais1);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.Ciudad1' Puede moverla o quitarla según sea necesario.
            this.ciudad1TableAdapter.Fill(this.tacomaDBDataSet.Ciudad1);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.VwCliente1' Puede moverla o quitarla según sea necesario.
            this.vwCliente1TableAdapter.Fill(this.tacomaDBDataSet.VwCliente1);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.Ciudad' Puede moverla o quitarla según sea necesario.
            this.ciudadTableAdapter.Fill(this.tacomaDBDataSet.Ciudad);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.tacomaDBDataSet.Cliente);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.Pais' Puede moverla o quitarla según sea necesario.
            this.paisTableAdapter.Fill(this.tacomaDBDataSet.Pais);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.VwCliente' Puede moverla o quitarla según sea necesario.
            this.vwClienteTableAdapter.Fill(this.tacomaDBDataSet.VwCliente);
            // TODO: esta línea de código carga datos en la tabla 'tacomaDBDataSet.VwEmpleado' Puede moverla o quitarla según sea necesario.
            //this.vwEmpleadoTableAdapter.Fill(this.tacomaDBDataSet.VwEmpleado);
            CargarData();

            if(txtRTN.Text == "")
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
            SqlCommand com = new SqlCommand("SELECT * FROM VwCliente", ba.cone);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            vwClienteDataGridView.DataSource = dt;
            vwCliente1BindingSource.DataSource = dt;
        }
        /// <summary>
        /// Cargars the ciudades.
        /// </summary>
        /// <param name="Pais">The pais.</param>
        public void CargarCiudades(String Pais)
        {

            BaseDeDatos ba = new BaseDeDatos();
            ba.Conectar();
            SqlCommand com = new SqlCommand("Select a.Ciudad_codigo,a.Ciudad_Nombre from Ciudad a " +
                "inner join Pais b on a.Pais_Codigo = b.Pais_Codigo where b.Pais_Nombre = @pais", ba.cone);
            com.Parameters.AddWithValue("@pais", Pais);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ba.Cerrar();

            cmbCiudad.ValueMember = "Ciudad_codigo";
            cmbCiudad.DisplayMember = "Ciudad_Nombre";
            cmbCiudad.DataSource = dt;
        }
        /// <summary>
        /// Handles the Click event of the BtnAñadir control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            this.vwClienteDataGridView.Enabled = false;
            this.CargarData();
            this.vwCliente1BindingSource.AddNew();
            btnAñadir.Enabled = false;
            btnGuardarCli.Enabled = true;
            panel1.Enabled = true;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            this.txtRTN.Enabled = true;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the CmbCiudad control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorCiudad.Clear();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the CmbPais control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorPais.Clear();
            if (cmbPais.Text.ToString() != null)
            {
                string codPai = cmbPais.Text.ToString();
                this.CargarCiudades(codPai);
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnGuardarCli control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnGuardarCli_Click(object sender, EventArgs e)
        {
            ClienteMetodos cm = new ClienteMetodos();
            cm.ValidarTelefono(txtTel.Text);
            cm.ValidarRTN(txtRTN.Text);
            EmpleadosMetodos emp = new EmpleadosMetodos();

            if(txtPersona.Text =="" || txtPersona.TextLength < 8 || txtPersona.Text.StartsWith(" "))
            {
                errorPersona.SetError(txtPersona, "Error. 8 caracteres minimo");
            }
            if (txtRTN.Text == "" || (txtRTN.TextLength != 14))
            {
                errorRTN.SetError(txtRTN, "Ingrese RTN valido");
            }
            else
                if (emp.VerificarDepar(this.txtRTN.Text.Substring(0, 2)) == 0)
            {
                errorRTN.SetError(txtRTN, "El RTN no existe depar");
            }
            else
                 if (emp.VerificarMuni(this.txtRTN.Text.Substring(0, 2), this.txtRTN.Text.Substring(2, 2)) == 0)
            {
                errorRTN.SetError(txtRTN, "El RTN no existe municipio");
            }
            else
                if (int.Parse(this.txtRTN.Text.Substring(4, 4)) > int.Parse(DateTime.Now.Year.ToString()) ||
                int.Parse(this.txtRTN.Text.Substring(4, 4)) <= 1890)
            {
                errorRTN.SetError(txtRTN, "El RTN no existe años ");
            }

            if (txtRTN.Text.Length < 14)
            {
                errorRTN.SetError(txtRTN, "Ingrese un RTN valido. 14 caracteres permitidos.");
            }
            if (txtRTN.Text == "")
            {
                errorRTN.SetError(txtRTN, "Campo obligatorio.");
            }
            if (txtNombre.Text == "" || txtNombre.Text.StartsWith(" "))
            {
                errorNombre.SetError(txtNombre, "Campo obligatorio.");
            }
            if(txtNombre.TextLength<3)
            {
                errorNombre.SetError(txtNombre, "Minimo 3 caracteres.");
            }
            if (txtDirecc.Text == "" || txtDirecc.Text.StartsWith(" "))
            {
                errorDireccion.SetError(txtDirecc, "Campo obligatorio.");
            }
            if(txtDirecc.TextLength<8)
            {
                errorDireccion.SetError(txtDirecc, "Minimo 8 caracteres.");
            }
            if (txtNombre.TextLength < 5)
            {
                errorNombre.SetError(txtNombre, "Se necesitan al menos 5 letras");
            }

            if (txtTel.Text!=""&& txtTel.TextLength!=8)
            {
                errorTelefono.SetError(txtTel, "Telefono Invalido");
            }
            else
                if (txtTel.Text.StartsWith("1") || txtTel.Text.StartsWith("4")
                || txtTel.Text.StartsWith("5") || txtTel.Text.StartsWith("6")
                || txtTel.Text.StartsWith("0") || txtTel.Text.Equals("00000000"))
            {
                errorTelefono.SetError(txtTel, "Telefono invalido hola");
            }
            if (cmbPais.Text == "")
            {
                errorPais.SetError(cmbPais, "Campo Obligatorio");
            }
            if(cmbCiudad.Text=="")
            {
                errorCiudad.SetError(cmbCiudad, "Campo Obligatorio");
            }

            if (txtNombre.TextLength < 5)
            {
                MessageBox.Show("Se necesitan mas de 5 caracteres", "Error en nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CompartirDatos.codRTN == 1)
            {
                MessageBox.Show("El RTN " + txtRTN.Text + " ya esta registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (CompartirDatos.codT == 1)
            {
                MessageBox.Show("El numero " + txtTel.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtRTN.Text.Length < 14 || txtRTN.Text == "" || txtNombre.Text == "" || txtNombre.Text.StartsWith(" ") || txtDirecc.Text == ""
                || txtDirecc.Text.StartsWith(" ") || cmbPais.Text == "" || cmbCiudad.Text == "" || txtRTN.Text == "" || (txtRTN.TextLength != 14) ||
               emp.VerificarDepar(this.txtRTN.Text.Substring(0, 2)) == 0 || txtDirecc.TextLength < 8||
               emp.VerificarMuni(this.txtRTN.Text.Substring(0, 2), this.txtRTN.Text.Substring(2, 2)) == 0 ||
               int.Parse(this.txtRTN.Text.Substring(4, 4)) > int.Parse(DateTime.Now.Year.ToString()) ||
                int.Parse(this.txtRTN.Text.Substring(4, 4)) <= 1890 ||
                txtNombre.TextLength < 3 || txtTel.Text != "" && txtTel.TextLength != 8 ||
                 txtTel.Text.StartsWith("0") || txtTel.Text.Equals("00000000")||
                 txtTel.Text.StartsWith("1") || txtTel.Text.StartsWith("4")
                || txtTel.Text.StartsWith("5") || txtTel.Text.StartsWith("6") || txtNombre.TextLength < 8
               || txtPersona.Text == "" || txtPersona.TextLength < 8 || txtPersona.Text.StartsWith(" ")

               )
            {
                MessageBox.Show("Datos incorrectos o incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ClienteMetodos cli = new ClienteMetodos();
                cli.Añadir_Cliente(txtRTN.Text, txtNombre.Text, txtDirecc.Text, txtTel.Text, int.Parse(cmbCiudad.SelectedValue.ToString()),txtPersona.Text);
                this.vwClienteDataGridView.Refresh();
                this.CargarData();
                btnAñadir.Enabled = true;
                btnModificar.Enabled = true;
                btnGuardarCli.Enabled = false;
                btnCancelar.Enabled = false;
                panel1.Enabled = false;
                this.vwClienteDataGridView.Enabled = true;
            }

        }

        /// <summary>
        /// Handles the TextChanged event of the TxtRTN control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TxtRTN_TextChanged(object sender, EventArgs e)
        {
            errorRTN.Clear();
        }

        /// <summary>
        /// Handles the TextChanged event of the TxtNombre control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TxtNombre_TextChanged(object sender, EventArgs e)
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
        /// Handles the KeyPress event of the TxtRTN control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TxtRTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the KeyPress event of the TxtNombre control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) )
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
            if ( char.IsControl(e.KeyChar)  || char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        /// <summary>
        /// Handles the Click event of the BtnModificar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnAñadir.Enabled = false;
            btnGuardarCli.Enabled = false;
            btnGuardarCam.Enabled = true;
            btnCancelar.Enabled = true;
            panel1.Enabled = true;
            txtRTN.Enabled = false;
            label2.Text = txtRTN.Text;
            label3.Text = txtTel.Text;
        }

        /// <summary>
        /// Handles the Click event of the BtnGuardarCam control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnGuardarCam_Click(object sender, EventArgs e)
        {
            ClienteMetodos cm = new ClienteMetodos();
            cm.ModificarTelefono(int.Parse(txtTel.Text));
            cm.ModificarRTN(txtRTN.Text);
            EmpleadosMetodos emp = new EmpleadosMetodos();

            if (txtPersona.Text == "" || txtPersona.TextLength < 8 || txtPersona.Text.StartsWith(" "))
            {
                errorPersona.SetError(txtPersona, "Error. 8 caracteres minimo");
            }

            if (txtRTN.Text == "" || (txtRTN.TextLength != 14))
            {
                errorRTN.SetError(txtRTN, "Ingrese RTN valido");
            }
            else
               if (emp.VerificarDepar(this.txtRTN.Text.Substring(0, 2)) == 0)
            {
                errorRTN.SetError(txtRTN, "El RTN no existe depar");
            }
            else
                if (emp.VerificarMuni(this.txtRTN.Text.Substring(0, 2), this.txtRTN.Text.Substring(2, 2)) == 0)
            {
                errorRTN.SetError(txtRTN, "El RTN no existe municipio");
            }
            else
               if (int.Parse(this.txtRTN.Text.Substring(4, 4)) > int.Parse(DateTime.Now.Year.ToString()) ||
               int.Parse(this.txtRTN.Text.Substring(4, 4)) <= 1890)
            {
                errorRTN.SetError(txtRTN, "El RTN no existe años ");
            }

            if (txtRTN.Text.Length < 14)
            {
                errorRTN.SetError(txtRTN, "Ingrese un RTN valido. 14 caracteres permitidos.");
            }
            if (txtRTN.Text == "")
            {
                errorRTN.SetError(txtRTN, "Campo obligatorio.");
            }
            if (txtNombre.Text == "" || txtNombre.Text.StartsWith(" "))
            {
                errorNombre.SetError(txtNombre, "Campo obligatorio.");
            }
            if (txtNombre.TextLength < 3)
            {
                errorNombre.SetError(txtNombre, "Minimo 3 caracteres.");
            }
            if (txtDirecc.Text == "" || txtDirecc.Text.StartsWith(" "))
            {
                errorDireccion.SetError(txtDirecc, "Campo obligatorio.");
            }
            if (txtDirecc.TextLength < 8)
            {
                errorDireccion.SetError(txtDirecc, "Minimo 8 caracteres.");
            }
            if (txtNombre.TextLength < 5)
            {
                errorNombre.SetError(txtNombre, "Se necesitan al menos 5 letras");
            }

            if (txtTel.Text != "" && txtTel.TextLength != 8)
            {
                errorTelefono.SetError(txtTel, "Telefono Invalido");
            }
            else
                if (txtTel.Text.StartsWith("1") || txtTel.Text.StartsWith("4")
                || txtTel.Text.StartsWith("5") || txtTel.Text.StartsWith("6")
                || txtTel.Text.StartsWith("0") || txtTel.Text.Equals("00000000"))
            {
                errorTelefono.SetError(txtTel, "Telefono invalido hola");
            }
            if (cmbPais.Text == "")
            {
                errorPais.SetError(cmbPais, "Campo Obligatorio");
            }
            if (cmbCiudad.Text == "")
            {
                errorCiudad.SetError(cmbCiudad, "Campo Obligatorio");
            }

            if(txtNombre.TextLength < 5)
            {
                MessageBox.Show("Se necesitan mas de 5 caracteres", "Error en nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtRTN.Text != label2.Text)
            {
                if (CompartirDatos.sumRTN >= 1)
                {
                    MessageBox.Show("El RTN " + txtRTN.Text + " ya esta registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtRTN.Text.Length < 14 || txtRTN.Text == "" || txtNombre.Text == "" || txtNombre.Text.StartsWith(" ") || txtDirecc.Text == ""
                        || txtDirecc.Text.StartsWith(" ") || cmbPais.Text == "" || cmbCiudad.Text == "" || txtRTN.Text == "" || (txtRTN.TextLength != 14) ||
                        emp.VerificarDepar(this.txtRTN.Text.Substring(0, 2)) == 0 ||
                        emp.VerificarMuni(this.txtRTN.Text.Substring(0, 2), this.txtRTN.Text.Substring(2, 2)) == 0 ||
                        int.Parse(this.txtRTN.Text.Substring(4, 4)) > int.Parse(DateTime.Now.Year.ToString()) ||
                        int.Parse(this.txtRTN.Text.Substring(4, 4)) <= 1890 ||
                        txtNombre.TextLength < 3 || txtTel.Text != "" && txtTel.TextLength != 8 ||
                        txtTel.Text.StartsWith("0") || txtTel.Text.Equals("00000000") ||
                        txtTel.Text.StartsWith("1") || txtTel.Text.StartsWith("4")
                        || txtTel.Text.StartsWith("5") || txtTel.Text.StartsWith("6")
                        || txtPersona.Text == "" || txtPersona.TextLength < 8 || txtPersona.Text.StartsWith(" ") || txtNombre.TextLength < 8)
                {
                    MessageBox.Show("Datos incorrectos o incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (txtTel.Text != label3.Text)
            {
                if (CompartirDatos.sumTelCli >= 1)
                {
                    MessageBox.Show("El numero " + txtTel.Text + " ya le pertenece a alguien", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtRTN.Text.Length < 14 || txtRTN.Text == "" || txtNombre.Text == "" || txtNombre.Text.StartsWith(" ") || txtDirecc.Text == ""
                    || txtDirecc.Text.StartsWith(" ") || cmbPais.Text == "" || cmbCiudad.Text == "" || txtRTN.Text == "" || (txtRTN.TextLength != 14) ||
                   emp.VerificarDepar(this.txtRTN.Text.Substring(0, 2)) == 0 ||
                   emp.VerificarMuni(this.txtRTN.Text.Substring(0, 2), this.txtRTN.Text.Substring(2, 2)) == 0 ||
                   int.Parse(this.txtRTN.Text.Substring(4, 4)) > int.Parse(DateTime.Now.Year.ToString()) ||
                    int.Parse(this.txtRTN.Text.Substring(4, 4)) <= 1890 ||
                    txtNombre.TextLength < 3 || txtTel.Text != "" && txtTel.TextLength != 8 ||
                     txtTel.Text.StartsWith("0") || txtTel.Text.Equals("00000000") ||
                     txtTel.Text.StartsWith("1") || txtTel.Text.StartsWith("4")
                    || txtTel.Text.StartsWith("5") || txtTel.Text.StartsWith("6")
                    || txtPersona.Text == "" || txtPersona.TextLength < 8 || txtPersona.Text.StartsWith(" ") || txtNombre.TextLength < 8)
                {
                    MessageBox.Show("Datos incorrectos o incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(label3.Text == txtTel.Text)
            {
                if (txtRTN.Text.Length < 14 || txtRTN.Text == "" || txtNombre.Text == "" || txtNombre.Text.StartsWith(" ") || txtDirecc.Text == ""
        || txtDirecc.Text.StartsWith(" ") || cmbPais.Text == "" || cmbCiudad.Text == "" || txtRTN.Text == "" || (txtRTN.TextLength != 14) ||
       emp.VerificarDepar(this.txtRTN.Text.Substring(0, 2)) == 0 ||
       emp.VerificarMuni(this.txtRTN.Text.Substring(0, 2), this.txtRTN.Text.Substring(2, 2)) == 0 ||
       int.Parse(this.txtRTN.Text.Substring(4, 4)) > int.Parse(DateTime.Now.Year.ToString()) ||
        int.Parse(this.txtRTN.Text.Substring(4, 4)) <= 1890 ||
        txtNombre.TextLength < 3 || txtTel.Text != "" && txtTel.TextLength != 8 ||
         txtTel.Text.StartsWith("0") || txtTel.Text.Equals("00000000") ||
         txtTel.Text.StartsWith("1") || txtTel.Text.StartsWith("4")
        || txtTel.Text.StartsWith("5") || txtTel.Text.StartsWith("6")
        || txtPersona.Text == "" || txtPersona.TextLength < 8 || txtPersona.Text.StartsWith(" ") || txtNombre.TextLength < 8)
                {
                    MessageBox.Show("Datos incorrectos o incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            {
                try
                {
                    ClienteMetodos cli = new ClienteMetodos();
                    cli.Actualizar_Cliente(txtRTN.Text, txtNombre.Text, txtDirecc.Text, txtTel.Text, int.Parse(cmbCiudad.SelectedValue.ToString()), txtPersona.Text);
                    this.vwClienteDataGridView.Refresh();
                    this.CargarData();
                    btnAñadir.Enabled = true;
                    btnModificar.Enabled = true;
                    btnGuardarCli.Enabled = false;
                    panel1.Enabled = false;
                    btnGuardarCam.Enabled = false;
                    btnCancelar.Enabled = false;
                }
                catch (SqlException)
                {
                    MessageBox.Show("El RTN Ingresado ya fue ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.vwCliente1BindingSource.CancelEdit();
            this.CargarData();
            btnGuardarCli.Enabled = false;
            btnAñadir.Enabled = true;
            btnGuardarCam.Enabled = false;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = false;
            panel1.Enabled = false;
            this.txtRTN.Clear();
            this.txtTel.Clear();
            this.txtDirecc.Clear();
            this.txtNombre.Clear();
            this.cmbCiudad.Text = "";
            this.cmbPais.Text = "";
        }

        /// <summary>
        /// Handles the Click event of the BtnBuscar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbBusqueda.Text == "Codigo")
            {
                try
                {
                    BuscarPorCodigo(this.txtBuscar.Text);
                    this.btnAñadir.Enabled = false;
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Ingrese un codigo de empleado valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

            if (cmbBusqueda.Text == "Nombre")
            {
                try
                {
                    BuscarPorNombre(this.txtBuscar.Text);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Ingrese un nombre valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
           
        }
        /// <summary>
        /// Buscars the por codigo.
        /// </summary>
        /// <param name="rtn">The RTN.</param>
        public void BuscarPorCodigo(string rtn)
        {
            try
            {
                BaseDeDatos ba = new BaseDeDatos();
                ba.Conectar();
                SqlCommand com = new SqlCommand("SELECT * FROM VwCliente WHERE [RTN] =@rtn   ", ba.cone);
                com.Parameters.AddWithValue("@rtn", rtn);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.vwClienteDataGridView.DataSource = dt;
                this.vwCliente1BindingSource.DataSource = dt;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Ingrese un RTN correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


                SqlCommand com = new SqlCommand("SELECT * FROM VwCliente WHERE [Nombre] like '%'+@nom+'%'   ", ba.cone);
                com.Parameters.AddWithValue("@nom", nom);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.vwClienteDataGridView.DataSource = dt;
                this.vwCliente1BindingSource.DataSource = dt;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Debe ingresar nombre de cliente valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        /// Handles the SelectedIndexChanged event of the CmbBusqueda control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CmbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbBusqueda.Text == "Todos los clientes")
            {
                this.txtBuscar.Clear();
                this.txtBuscar.Enabled = false;
                this.btnBuscar.Enabled = false;
                this.CargarData();
            }
            else
            {
                this.txtBuscar.Enabled = true;
                this.btnBuscar.Enabled = true;
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the TxtBuscar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.cmbBusqueda.Text == "Codigo")
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

                if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
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
        /// Handles the CellClick event of the VwClienteDataGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void VwClienteDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           txtRTN.Text = vwClienteDataGridView.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = vwClienteDataGridView.CurrentRow.Cells[1].Value.ToString();
            txtDirecc.Text= vwClienteDataGridView.CurrentRow.Cells[2].Value.ToString();
            txtTel.Text = vwClienteDataGridView.CurrentRow.Cells[3].Value.ToString();
            //cmbPais.Text = "";
            cmbCiudad.Text = vwClienteDataGridView.CurrentRow.Cells[4].Value.ToString();
            cmbPais.Text = vwClienteDataGridView.CurrentRow.Cells[5].Value.ToString();
            txtPersona.Text = vwClienteDataGridView.CurrentRow.Cells[6].Value.ToString();
        }

        /// <summary>
        /// Handles the CellContentClick event of the vwClienteDataGridView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void vwClienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the direcciónLabel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void direcciónLabel_Click(object sender, EventArgs e)
        {

        }

        private void txtDirecc_TextChanged_1(object sender, EventArgs e)
        {
            errorDireccion.Clear();
        }

        private void TxtPersona_TextChanged(object sender, EventArgs e)
        {
            errorPersona.Clear();
        }

        private void TxtPersona_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
