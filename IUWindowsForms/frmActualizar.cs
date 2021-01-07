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
            MessageBox.Show("La cedula es : " + this.mCedula);
        }
    }
}
