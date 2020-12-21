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
    }
}
