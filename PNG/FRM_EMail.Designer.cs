namespace PNG
{
    partial class FRM_EMail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            resultTextBox = new TextBox();
            btnPing = new Button();
            txtEmailAddress = new TextBox();
            SuspendLayout();
            // 
            // resultTextBox
            // 
            resultTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            resultTextBox.ForeColor = Color.Green;
            resultTextBox.Location = new Point(12, 35);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(745, 164);
            resultTextBox.TabIndex = 8;
            resultTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // btnPing
            // 
            btnPing.Location = new Point(251, 5);
            btnPing.Name = "btnPing";
            btnPing.Size = new Size(506, 23);
            btnPing.TabIndex = 7;
            btnPing.Text = "Ping";
            btnPing.UseVisualStyleBackColor = true;
            btnPing.Click += btnPing_Click;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Location = new Point(12, 6);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(242, 23);
            txtEmailAddress.TabIndex = 6;
            // 
            // FRM_EMail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 204);
            Controls.Add(resultTextBox);
            Controls.Add(btnPing);
            Controls.Add(txtEmailAddress);
            Name = "FRM_EMail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FRM_EMail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox resultTextBox;
        private Button btnPing;
        private TextBox txtEmailAddress;
    }
}