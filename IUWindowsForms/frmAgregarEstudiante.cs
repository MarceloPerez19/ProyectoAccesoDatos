using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUWindowsForms
{
    public partial class frmAgregarEstudiante : Form
    {
        public frmAgregarEstudiante()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CapaDatos.Persona persona = new CapaDatos.Persona();
                persona.Cedula = this.txtCedula.Text;
                persona.Apellidos = this.txtApellido.Text;
                persona.Nombres = this.txtNombre.Text;
                persona.Sexo = this.cmbSexo.Text;
                persona.fechaNacimiento = tdFechaNacimiento.Value;
                persona.Correo = this.txtCorreo.Text;
                persona.estatura = int.Parse(this.txtEstatura.Text);
                persona.Peso = Decimal.Parse(this.txtPeso.Text);

                int x = CapaDatos.PersonaDAO.crear(persona);
                if (x > 0)
                    MessageBox.Show("Persona agregado con exito");
                else
                    MessageBox.Show("No se pudo agregar el registro....");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            if(this.txtCedula.Text.Length==0)
            {
                MessageBox.Show("Ingresa la cedula");
                this.txtCedula.Focus();
                return;
            }
            if (this.txtApellido.Text.Length == 0)
            {
                MessageBox.Show("Ingresa el apellido");
                this.txtApellido.Focus();
                return;
            }
            if (this.txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Ingresa el nombre");
                this.txtNombre.Focus();
                return;
            }
            if (this.cmbSexo.Text.Length == 0)
            {
                MessageBox.Show("Ingresa el sexo");
                this.cmbSexo.Focus();
                return;
            }
            if (this.txtCorreo.Text.Length == 0)
            {
                MessageBox.Show("Ingresa el correo");
                this.txtCorreo.Focus();
                return;
            }
            if (this.txtEstatura.Text.Length == 0)
            {
                MessageBox.Show("Ingresa la estatura");
                this.txtEstatura.Focus();
                return;
            }
            if (this.txtPeso.Text.Length == 0)
            {
                MessageBox.Show("Ingresa el peso");
                this.txtPeso.Focus();
                return;
            }
            /*//faltar validaciones
            CapaDatos.Persona persona = new CapaDatos.Persona();
            persona.Cedula = this.txtCedula.Text;
            persona.Apellidos = this.txtApellido.Text;
            persona.Nombres = this.txtNombre.Text;
            persona.Sexo = this.cmbSexo.Text;
            persona.fechaNacimiento = tdFechaNacimiento.Value;
            persona.Correo = this.txtCorreo.Text;
            persona.estatura = int.Parse(this.txtEstatura.Text);
            persona.Peso = Decimal.Parse(this.txtPeso.Text);

            int x = CapaDatos.PersonaDAO.crear(persona);
            if (x > 0)
                MessageBox.Show("Persona agregado con exito");
            else
                MessageBox.Show("No se pudo agregar el registro....");*/


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
