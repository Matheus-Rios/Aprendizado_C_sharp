namespace M01A08F
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
            lblMsg = new Label();
            txtNum = new TextBox();
            btnOk = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 13);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite um número:";
            label1.Click += label1_Click;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Location = new Point(11, 220);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(66, 15);
            lblMsg.TabIndex = 1;
            lblMsg.Text = "Mensagem";
            lblMsg.Visible = false;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(124, 5);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(52, 23);
            txtNum.TabIndex = 2;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(113, 74);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(109, 49);
            btnOk.TabIndex = 3;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // Form1
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 266);
            Controls.Add(btnOk);
            Controls.Add(txtNum);
            Controls.Add(lblMsg);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblMsg;
        private TextBox txtNum;
        private Button btnOk;
    }
}