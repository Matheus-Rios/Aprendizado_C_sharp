namespace EX004
{
    partial class Form1
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
            txtNum = new TextBox();
            btnOk = new Button();
            lblValor = new Label();
            lblInteiro = new Label();
            lblArre = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(271, 34);
            label1.TabIndex = 0;
            label1.Text = "Digite um número Real";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(283, 20);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(70, 23);
            txtNum.TabIndex = 1;
            txtNum.TextChanged += textBox1_TextChanged;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(384, 12);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(74, 31);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // lblValor
            // 
            lblValor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblValor.Location = new Point(19, 97);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(334, 32);
            lblValor.TabIndex = 3;
            lblValor.Visible = false;
            // 
            // lblInteiro
            // 
            lblInteiro.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblInteiro.Location = new Point(19, 179);
            lblInteiro.Name = "lblInteiro";
            lblInteiro.Size = new Size(264, 28);
            lblInteiro.TabIndex = 4;
            lblInteiro.Visible = false;
            // 
            // lblArre
            // 
            lblArre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblArre.Location = new Point(19, 255);
            lblArre.Name = "lblArre";
            lblArre.Size = new Size(264, 32);
            lblArre.TabIndex = 5;
            lblArre.Visible = false;
            // 
            // Form1
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 450);
            Controls.Add(lblArre);
            Controls.Add(lblInteiro);
            Controls.Add(lblValor);
            Controls.Add(btnOk);
            Controls.Add(txtNum);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNum;
        private Button btnOk;
        private Label lblValor;
        private Label lblInteiro;
        private Label lblArre;
    }
}