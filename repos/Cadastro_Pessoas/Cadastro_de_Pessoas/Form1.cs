namespace Cadastro_de_Pessoas
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cad = new(txtNome.Text,txtCpf.Text,txtData.Text);
            MessageBox.Show(cad.mensagem);
        }
    }
}