namespace EX002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            lblMsg1.Text = "MEU ";
            lblMsg2.Text = "BRASIL ";
            lblMsg3.Text = "BRASILEIRO";
            await Task.Delay(1000);
            lblMsg1.BackColor = Color.Blue;
            lblMsg1.ForeColor = Color.White;
            await Task.Delay(1000);
            lblMsg2.BackColor = Color.Yellow;
            lblMsg2.ForeColor = Color.Green;
            await Task.Delay(1000);
            lblMsg3.BackColor = Color.Green;
            lblMsg3.ForeColor = Color.Yellow;
        }

        private void lblMsg3_Click(object sender, EventArgs e)
        {

        }
    }
}