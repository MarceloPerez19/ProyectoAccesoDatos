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
    public partial class frmActualizar : Form
    {
        private String mCedula;

        public frmActualizar(String cedula)
        {
            InitializeComponent();
            //el parametro cedula se recibe como parametro en el constructor de la clase 
            this.mCedula = cedula;
        }

        private void frmActualizar_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("La cedula es : " + this.mCedula);
            this.txtCedula.Text = mCedula;
            CapaDatos.Persona persona = new CapaDatos.Persona();

            persona = CapaDatos.PersonaDAO.getPersona(mCedula);
            this.txtApellido.Text = persona.Apellidos;
            this.txtNombre.Text = persona.Nombres;
            this.txtCorreo.Text = persona.Correo;
            this.cmbSexo.Text = persona.Sexo;
            this.txtEstatura.Text = persona.estatura.ToString();
            this.txtPeso.Text = persona.Peso.ToString();
            this.tdFechaNacimiento.Value = persona.fechaNacimiento;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        


        private void toolStripButton1Guardar_Click(object sender, EventArgs e)
        {
            if(this.mCedula.Length>0)
            {
                CapaDatos.Persona persona = new CapaDatos.Persona();
                persona.Cedula = mCedula;
                persona.Apellidos = this.txtApellido.Text;
                persona.Nombres = this.txtNombre.Text;
                persona.Correo = this.txtCorreo.Text;
                persona.Sexo = this.cmbSexo.Text;
                persona.estatura = int.Parse(this.txtEstatura.Text);
                persona.Peso = Decimal.Parse(this.txtPeso.Text);
                persona.fechaNacimiento = tdFechaNacimiento.Value;
                
                int x=CapaDatos.PersonaDAO.actualizar(persona);
               
                if (x > 0)
                {
                    MessageBox.Show("Registro actualizado");
                }
                else
                    MessageBox.Show("No se actualizo el registro");
            }


        }
    }
}
