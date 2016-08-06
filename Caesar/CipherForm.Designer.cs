namespace Caesar
{
    partial class CipherForm
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
            this.decryptButton = new System.Windows.Forms.Button();
            this.outBox = new System.Windows.Forms.TextBox();
            this.plaintextBox = new System.Windows.Forms.TextBox();
            this.textLabel = new System.Windows.Forms.Label();
            this.shiftLabel = new System.Windows.Forms.Label();
            this.ciphertextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(13, 317);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(193, 54);
            this.decryptButton.TabIndex = 0;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // outBox
            // 
            this.outBox.Location = new System.Drawing.Point(230, 29);
            this.outBox.Multiline = true;
            this.outBox.Name = "outBox";
            this.outBox.ReadOnly = true;
            this.outBox.Size = new System.Drawing.Size(701, 428);
            this.outBox.TabIndex = 1;
            // 
            // plaintextBox
            // 
            this.plaintextBox.Location = new System.Drawing.Point(13, 122);
            this.plaintextBox.Name = "plaintextBox";
            this.plaintextBox.Size = new System.Drawing.Size(193, 22);
            this.plaintextBox.TabIndex = 2;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(13, 99);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(68, 17);
            this.textLabel.TabIndex = 3;
            this.textLabel.Text = "Enter text";
            // 
            // shiftLabel
            // 
            this.shiftLabel.AutoSize = true;
            this.shiftLabel.Location = new System.Drawing.Point(227, 9);
            this.shiftLabel.Name = "shiftLabel";
            this.shiftLabel.Size = new System.Drawing.Size(36, 17);
            this.shiftLabel.TabIndex = 4;
            this.shiftLabel.Text = "Shift";
            // 
            // ciphertextLabel
            // 
            this.ciphertextLabel.AutoSize = true;
            this.ciphertextLabel.Location = new System.Drawing.Point(294, 9);
            this.ciphertextLabel.Name = "ciphertextLabel";
            this.ciphertextLabel.Size = new System.Drawing.Size(51, 17);
            this.ciphertextLabel.TabIndex = 5;
            this.ciphertextLabel.Text = "Output";
            // 
            // CipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 469);
            this.Controls.Add(this.ciphertextLabel);
            this.Controls.Add(this.shiftLabel);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.plaintextBox);
            this.Controls.Add(this.outBox);
            this.Controls.Add(this.decryptButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CipherForm";
            this.Text = "Caesar cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.TextBox outBox;
        private System.Windows.Forms.TextBox plaintextBox;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label shiftLabel;
        private System.Windows.Forms.Label ciphertextLabel;
    }
}

