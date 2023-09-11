namespace M01A12B
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
            btnOk = new Button();
            lblMsg = new Label();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(149, 110);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(130, 49);
            btnOk.TabIndex = 0;
            btnOk.Text = "Mostrar";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Location = new Point(149, 55);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(66, 15);
            lblMsg.TabIndex = 1;
            lblMsg.Text = "Mensagem";
            lblMsg.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMsg);
            Controls.Add(btnOk);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private Label lblMsg;
    }
}