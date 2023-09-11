namespace M01A08B
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
            lbl = new Label();
            txtNome = new TextBox();
            btnOk = new Button();
            lblMsg = new Label();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.Location = new Point(12, 9);
            lbl.Name = "lbl";
            lbl.Size = new Size(210, 26);
            lbl.TabIndex = 0;
            lbl.Text = "Qual é o Seu nome? ";
            lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(228, 12);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(222, 23);
            txtNome.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(387, 71);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(63, 37);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // lblMsg
            // 
            lblMsg.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMsg.Location = new Point(12, 173);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(438, 38);
            lblMsg.TabIndex = 3;
            lblMsg.Text = "Mensagem";
            lblMsg.Visible = false;
            // 
            // Form1
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 217);
            Controls.Add(lblMsg);
            Controls.Add(btnOk);
            Controls.Add(txtNome);
            Controls.Add(lbl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private TextBox txtNome;
        private Button btnOk;
        private Label lblMsg;
    }
}