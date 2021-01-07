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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.txtCedula.Text.Length == 0)//si la cedula esta vacia
            {
                MessageBox.Show("No hay cedula seleccionada");
                return; //abandonar
            }
            CapaDatos.Persona persona = new CapaDatos.Persona();
            persona.Cedula = this.txtCedula.Text;
            persona.Apellidos = this.txtApellidos.Text;
            persona.Nombres = this.txtNombres.Text;
            persona.Sexo = this.cmbSexo.Text;
            persona.Correo = this.txtCorreo.Text;
            persona.estatura = int.Parse(this.txtEstatura.Text);
            persona.Peso = Decimal.Parse(this.txtPeso.Text);
            persona.fechaNacimiento = dtFechaNacimiento.Value;

            int x=CapaDatos.PersonaDAO.actualizar(persona);
            if (x > 0)
            {
                this.cargarComboEstudiante(); //refresque el cuadro combinado de estudiantes
                MessageBox.Show("Registro actualizado con exito");
            }
            else
                MessageBox.Show("No se pudo actualizar el registro");
        }

        private void btb_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Estas seguro que sedea eliminar este registro?","Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr==DialogResult.No)
            {
                return; //abandonar
            }
            int x=CapaDatos.PersonaDAO.eliminar(this.txtCedula.Text);
            if(x>0)
            {
                this.encerar();
                this.cargarComboEstudiante();
                MessageBox.Show("Registro eliminado con exito");
            }
            else
            {
                MessageBox.Show("No se puedo borrar el registro");
            }

        }

        private void encerar()
        {
            this.txtCedula.Text = " ";
            this.txtApellidos.Text = " ";
            this.txtNombres.Text = " ";
            this.txtCorreo.Text = " ";
            this.txtNombres.Text = "0";
            this.txtPeso.Text = "0";
            this.cmbSexo.Text = "M";
        }

        private void cmbCedula_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
