namespace PNG
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
            resultTextBox = new TextBox();
            btnPing = new Button();
            txtIP = new TextBox();
            btnEmail = new Button();
            SuspendLayout();
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(23, 41);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(522, 129);
            resultTextBox.TabIndex = 5;
            // 
            // btnPing
            // 
            btnPing.Location = new Point(213, 11);
            btnPing.Name = "btnPing";
            btnPing.Size = new Size(332, 23);
            btnPing.TabIndex = 4;
            btnPing.Text = "Ping";
            btnPing.UseVisualStyleBackColor = true;
            btnPing.Click += btnPing_Click;
            // 
            // txtIP
            // 
            txtIP.Location = new Point(23, 12);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(184, 23);
            txtIP.TabIndex = 3;
            // 
            // btnEmail
            // 
            btnEmail.Location = new Point(685, 12);
            btnEmail.Name = "btnEmail";
            btnEmail.Size = new Size(112, 23);
            btnEmail.TabIndex = 6;
            btnEmail.Text = "Get IP for Email ";
            btnEmail.UseVisualStyleBackColor = true;
            btnEmail.Click += btnEmail_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 180);
            Controls.Add(btnEmail);
            Controls.Add(resultTextBox);
            Controls.Add(btnPing);
            Controls.Add(txtIP);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox resultTextBox;
        private Button btnPing;
        private TextBox txtIP;
        private Button btnEmail;
    }
}