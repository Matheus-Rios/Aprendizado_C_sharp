namespace Cadastro_de_Pessoas
{
    partial class Cadastrar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            txtData = new TextBox();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(100, 29);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(100, 32);
            label2.TabIndex = 1;
            label2.Text = "CPF";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 143);
            label3.Name = "label3";
            label3.Size = new Size(127, 71);
            label3.TabIndex = 2;
            label3.Text = "Data de \r\nNascimento";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(147, 34);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 3;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(147, 97);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(100, 23);
            txtCpf.TabIndex = 4;
            // 
            // txtData
            // 
            txtData.Location = new Point(147, 172);
            txtData.Name = "txtData";
            txtData.Size = new Size(100, 23);
            txtData.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(147, 213);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(100, 23);
            btnCadastrar.TabIndex = 6;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // Cadastrar
            // 
            AcceptButton = btnCadastrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 274);
            Controls.Add(btnCadastrar);
            Controls.Add(txtData);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Cadastrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Pessoas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtCpf;
        private TextBox txtData;
        private Button btnCadastrar;
    }
}