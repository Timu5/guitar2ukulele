namespace guitar2ukulele
{
    partial class MainForm
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
            this.guitarTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.ukuleleTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // guitarTextBox
            // 
            this.guitarTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guitarTextBox.Location = new System.Drawing.Point(12, 12);
            this.guitarTextBox.Multiline = true;
            this.guitarTextBox.Name = "guitarTextBox";
            this.guitarTextBox.Size = new System.Drawing.Size(703, 177);
            this.guitarTextBox.TabIndex = 0;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(639, 195);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // ukuleleTextBox
            // 
            this.ukuleleTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ukuleleTextBox.Location = new System.Drawing.Point(12, 224);
            this.ukuleleTextBox.Multiline = true;
            this.ukuleleTextBox.Name = "ukuleleTextBox";
            this.ukuleleTextBox.Size = new System.Drawing.Size(703, 177);
            this.ukuleleTextBox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 413);
            this.Controls.Add(this.ukuleleTextBox);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.guitarTextBox);
            this.Name = "MainForm";
            this.Text = "Guitar to Ukulele";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox guitarTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox ukuleleTextBox;
    }
}

