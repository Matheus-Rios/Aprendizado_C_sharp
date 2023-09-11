namespace EX004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            float n;
            int inteiro;
            int arredondado;

            float.TryParse(txtNum.Text, out n);
            inteiro = (int)n;
            arredondado = Convert.ToInt32(n);

            lblValor.Text = $"Você digitou o valor {n:f3}";
            lblInteiro.Text = $"A parte inteira é {inteiro}";
            lblArre.Text = $"Arredondando, temos {arredondado}";
            lblValor.Visible = true;
            lblInteiro.Visible = true;
            lblArre.Visible = true;
        }
    }
}