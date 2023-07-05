namespace simulacion_parcial_._Wform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            inicializarcontroles();
        }

        private void inicializarcontroles()
        {
            txtAltura.Clear();
            txtRadio.Clear();
            txtRadio.Focus();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (validardatos())
            {
                var radio = double.Parse(txtRadio.Text);
                var altura = double.Parse(txtAltura.Text);
                DataGridViewRow r = construirfila();
                setearfila(r, radio, altura);
                Agregarfila(r);
                MessageBox.Show("Registro agregado", "mensaje",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);

                inicializarcontroles();
            }
        }

        private void Agregarfila(DataGridViewRow r)
        {
            dgvConos.Rows.Add(r);
        }

        private void setearfila(DataGridViewRow r, double radio, double altura)
        {
            double generatriz= CalcularGeneratriz(radio, altura);
            r.Cells[colradio.Index].Value = radio;
            r.Cells[colaltura.Index].Value = altura;
            r.Cells[colgeneratriz.Index].Value = generatriz;
            r.Cells[colarea.Index].Value = CalcualrArea(radio,generatriz);
            r.Cells[colvolumen.Index].Value = CalcularVolumen(radio, altura,generatriz);

        }

        private DataGridViewRow construirfila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvConos);
            return r;
        }

        private bool validardatos()
        {
            bool esValido = true;
            errorProvider1.Clear();
            return esValido;
        }
        private double CalcularVolumen(double radio, double altura, double generatriz)
        {
            return (Math.PI * Math.Pow(radio, 2) * altura) / 3;
        }

        private double CalcualrArea(double radio, double generatriz)
        {
            return Math.PI * radio + (radio + generatriz);
        }

        private double CalcularGeneratriz(double radio, double altura)
        {
            return Math.Sqrt(Math.Pow(radio, 2) + Math.Pow(altura, 2));
        }

        private void dgvConos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}