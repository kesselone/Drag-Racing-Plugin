namespace SpeedAndDistance
{
    partial class fom_rename
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
            this.Okbutton = new System.Windows.Forms.Button();
            this.textBoxR6 = new System.Windows.Forms.TextBox();
            this.textBoxR7 = new System.Windows.Forms.TextBox();
            this.textBoxR8 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Okbutton
            // 
            this.Okbutton.Location = new System.Drawing.Point(118, 35);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(100, 23);
            this.Okbutton.TabIndex = 0;
            this.Okbutton.Text = "OK";
            this.Okbutton.UseVisualStyleBackColor = true;
            this.Okbutton.Click += new System.EventHandler(this.Okbutton_Click);
            // 
            // textBoxR6
            // 
            this.textBoxR6.Location = new System.Drawing.Point(12, 12);
            this.textBoxR6.Name = "textBoxR6";
            this.textBoxR6.Size = new System.Drawing.Size(100, 20);
            this.textBoxR6.TabIndex = 1;
            // 
            // textBoxR7
            // 
            this.textBoxR7.Location = new System.Drawing.Point(12, 38);
            this.textBoxR7.Name = "textBoxR7";
            this.textBoxR7.Size = new System.Drawing.Size(100, 20);
            this.textBoxR7.TabIndex = 2;
            // 
            // textBoxR8
            // 
            this.textBoxR8.Location = new System.Drawing.Point(118, 12);
            this.textBoxR8.Name = "textBoxR8";
            this.textBoxR8.Size = new System.Drawing.Size(100, 20);
            this.textBoxR8.TabIndex = 3;
            // 
            // fom_rename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 67);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxR8);
            this.Controls.Add(this.textBoxR7);
            this.Controls.Add(this.textBoxR6);
            this.Controls.Add(this.Okbutton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fom_rename";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Rename Button";
            this.Load += new System.EventHandler(this.fom_rename_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Okbutton;
        private System.Windows.Forms.TextBox textBoxR6;
        private System.Windows.Forms.TextBox textBoxR7;
        private System.Windows.Forms.TextBox textBoxR8;
    }
}