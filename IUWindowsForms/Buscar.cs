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
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            //evento load se ejecuta la primera vez que se carga el formulario 
            this.cargarComboEstudiante();
        }
        private void cargarComboEstudiante()
        {
            this.cmbCedula.DataSource = CapaDatos.PersonaDAO.getAll();
            this.cmbCedula.DisplayMember = "estudiante";
            this.cmbCedula.ValueMember = "cedula";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cedula = this.cmbCedula.SelectedValue.ToString();

            CapaDatos.Persona P = new CapaDatos.Persona();
            P = CapaDatos.PersonaDAO.getPersona(cedula);

            //cargar datos en los cuadros de texto
            this.txtCedula.Text = P.Cedula;
            this.txtApellidos.Text = P.Apellidos;
            this.txtNombres.Text = P.Nombres;
            this.cmbSexo.Text = P.Sexo;
            this.dtFechaNacimiento.Value = Convert.ToDateTime(P.fechaNacimiento);
            this.txtEstatura.Text = P.estatura.ToString();
            this.txtPeso.Text = P.Peso.ToString();
            this.txtCorreo.Text = P.Correo;


        }
    }
}
