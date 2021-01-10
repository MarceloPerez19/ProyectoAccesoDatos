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
    public partial class frmInformeEstudianteMostrar : Form
    {
        private string mCedula;
        public frmInformeEstudianteMostrar(String cedula)
        {
            InitializeComponent();
            mCedula = cedula;
        }

        private void frmInformeEstudianteMostrar_Load(object sender, EventArgs e)
        {
            this.personas1TableAdapter.FillxCedula(this.dsEstudiante.Personas1, mCedula);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
