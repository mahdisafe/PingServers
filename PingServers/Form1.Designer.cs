namespace PingServers
{
    partial class FRm_Ping
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
            txtIP = new TextBox();
            btnPing = new Button();
            resultTextBox = new TextBox();
            SuspendLayout();
            // 
            // txtIP
            // 
            txtIP.Location = new Point(12, 12);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(504, 23);
            txtIP.TabIndex = 0;
            // 
            // btnPing
            // 
            btnPing.Location = new Point(522, 12);
            btnPing.Name = "btnPing";
            btnPing.Size = new Size(75, 23);
            btnPing.TabIndex = 1;
            btnPing.Text = "Ping";
            btnPing.UseVisualStyleBackColor = true;
            btnPing.Click += btnPing_Click;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(12, 41);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(776, 397);
            resultTextBox.TabIndex = 2;
            // 
            // FRm_Ping
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultTextBox);
            Controls.Add(btnPing);
            Controls.Add(txtIP);
            Name = "FRm_Ping";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIP;
        private Button btnPing;
        private TextBox resultTextBox;
    }
}