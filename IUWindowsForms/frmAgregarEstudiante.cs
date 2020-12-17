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
            //faltar validaciones
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


        }
    }
}
