namespace ControlAreaVolumen
{
    public partial class frmControlAreaVolumen : Form
    {
        public frmControlAreaVolumen()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Capturando los valores
            double altura = double.Parse(txtAltura.Text);
            double diametro = double.Parse(txtDiametro.Text);

            // Realizando los c·lculos
            double radio = diametro / 2;
            double area = (2 * Math.PI * radio) * (radio + altura);
            double volumen = Math.PI * Math.Pow(radio, 2) * altura;

            // Mostrando los resultados en el cuadro de texto
            txtR.Text = "** RESUMEN DE VOLUMEN Y ¡REAS";
            txtR.Text += "\r\nVALOR ALTURA: " + altura.ToString("0.00");
            txtR.Text += "\r\nVALOR DI¡METRO: " + diametro.ToString("0.00");
            txtR.Text += "\r\n--------------------------------------";
            txtR.Text += "\r\nRADIO: " + radio.ToString("0.00");
            txtR.Text += "\r\n¡REA: " + area.ToString("0.00");
            txtR.Text += "\r\nVOLUMEN: " + volumen.ToString("0.00");
        }
    }
}