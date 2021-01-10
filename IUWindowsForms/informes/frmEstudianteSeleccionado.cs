using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUWindowsForms.informes
{
    public partial class frmEstudianteSeleccionado : Form
    {
        public frmEstudianteSeleccionado()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerInforme_Click(object sender, EventArgs e)
        {
            informes.frmInformeEstudianteMostrar frm1 = new frmInformeEstudianteMostrar(this.cmbCedula.SelectedValue.ToString());
            frm1.Show();
        }

        private void frmEstudianteSeleccionado_Load(object sender, EventArgs e)
        {
            this.cmbCedula.DataSource = CapaDatos.PersonaDAO.getAll();
            this.cmbCedula.DisplayMember = "estudiante";
            this.cmbCedula.ValueMember = "cedula";
        }
    }
}
