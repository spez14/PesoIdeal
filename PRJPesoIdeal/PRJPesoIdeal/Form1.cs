namespace PRJPesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Double Altura = 0, PesoIdeal = 0;
                Altura = double.Parse(txtAltura.Text);
                if (cmbSexo.Text == "Feminino")
                {
                    PesoIdeal = (62.7 * Altura) - 44.7;
                    MessageBox.Show(txtNome.Text + " seu peso ideal é: " + Math.Round(PesoIdeal, 2).ToString() + " Kg",
                        "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cmbSexo.Text == "Masculino")
                {
                    PesoIdeal = (72.7 * Altura) - 58;
                    MessageBox.Show(txtNome.Text + " seu peso ideal é: " + Math.Round(PesoIdeal, 2).ToString() + " Kg",
                        "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Escolha o sexo", "Peso Ideal", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Verifique os valores informados", "Peso Ideal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtAltura.Clear();
            cmbSexo.Text = "";
            txtNome.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}