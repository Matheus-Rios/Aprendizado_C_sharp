namespace EX002
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
            btnOK = new Button();
            lblMsg1 = new Label();
            lblMsg2 = new Label();
            lblMsg3 = new Label();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(127, 189);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(193, 59);
            btnOK.TabIndex = 0;
            btnOK.Text = "INICIAR";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // lblMsg1
            // 
            lblMsg1.Anchor = AnchorStyles.Left;
            lblMsg1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMsg1.Location = new Point(12, 58);
            lblMsg1.Name = "lblMsg1";
            lblMsg1.RightToLeft = RightToLeft.No;
            lblMsg1.Size = new Size(102, 49);
            lblMsg1.TabIndex = 1;
            lblMsg1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMsg2
            // 
            lblMsg2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMsg2.Location = new Point(120, 57);
            lblMsg2.Name = "lblMsg2";
            lblMsg2.Size = new Size(118, 49);
            lblMsg2.TabIndex = 2;
            lblMsg2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMsg3
            // 
            lblMsg3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMsg3.Location = new Point(244, 57);
            lblMsg3.Name = "lblMsg3";
            lblMsg3.Size = new Size(188, 50);
            lblMsg3.TabIndex = 3;
            lblMsg3.TextAlign = ContentAlignment.MiddleCenter;
            lblMsg3.Click += lblMsg3_Click;
            // 
            // Form1
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 288);
            Controls.Add(lblMsg3);
            Controls.Add(lblMsg2);
            Controls.Add(lblMsg1);
            Controls.Add(btnOK);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Brasil";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOK;
        private Label lblMsg1;
        private Label lblMsg2;
        private Label lblMsg3;
    }
}