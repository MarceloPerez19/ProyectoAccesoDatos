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
    public partial class frmListadoEstudiante : Form
    {
        public frmListadoEstudiante()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            this.cargarGrid();
        }

        private void cargarGrid()
        {
            this.DataGridViewEstuddiante.DataSource = CapaDatos.PersonaDAO.getAll();
        }

        private void DataGridViewEstuddiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //verificar si se hizo clic en el link eliminar
            if(this.DataGridViewEstuddiante.Columns[e.ColumnIndex].Name=="linkEliminar")
            {
                //MessageBox.Show("Clic eliminar");
                //recupera la cedula de la fila actual 
                int fila = e.RowIndex;
                String cedula = DataGridViewEstuddiante["cedula", fila].Value.ToString();
                String estudiante= DataGridViewEstuddiante["estudiante", fila].Value.ToString();
                //MessageBox.Show("cedula actual : " + cedula);

                DialogResult dr = MessageBox.Show("Estas segur@ que sedea eliminar el registro de "+ estudiante + " ? ", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    return; //abandonar
                }
                
                int x = CapaDatos.PersonaDAO.eliminar(cedula);
                if (x > 0)
                {
                    this.cargarGrid();
                    MessageBox.Show("Registro borrado con exito");
                }
                else
                    MessageBox.Show("No se pudo eliminar el registro");

            }
            else if(this.DataGridViewEstuddiante.Columns[e.ColumnIndex].Name == "linkActualizar")
            {
                //MessageBox.Show("Clic actualizar");
                //recupero la cedula
                int fila = e.RowIndex;
                String cedula = DataGridViewEstuddiante["cedula", fila].Value.ToString();
                
                //abrir el formulario
                frmActualizar frm1 = new frmActualizar(cedula);
                frm1.ShowDialog();
            }
            this.cargarGrid();





        }
    }
}
