using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjPromedioTresCalificaciones
{
    public partial class frmRegistroCalificaciones : Form
    {
        public frmRegistroCalificaciones()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Capturando datos
            string nombreEstudiante = txtEstudiante.Text;
            int nota1 = int.Parse(txtNota1.Text);
            int nota2 = int.Parse(txtNota2.Text);
            int nota3 = int.Parse(txtNota3.Text);

            int[] calificaciones = new int[3];
            calificaciones[0] = nota1;
            calificaciones[1] = nota2;
            calificaciones[2] = nota3;

            Calificaciones objC = new Calificaciones(nombreEstudiante, calificaciones);

            // Imprimiendo datos
            ListViewItem fila = new ListViewItem(nombreEstudiante);
            fila.SubItems.Add(nota1.ToString());
            fila.SubItems.Add(nota2.ToString());
            fila.SubItems.Add(nota3.ToString());
            fila.SubItems.Add(objC.ObtenerPromedio().ToString("0.00"));
            lvRegistro.Items.Add(fila);

            Limpiar();

        }

        private void Limpiar()
        {
            txtEstudiante.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtEstudiante.Focus();
        }
    }
}
