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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Okbutton
            // 
            this.Okbutton.Location = new System.Drawing.Point(346, 213);
            this.Okbutton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(308, 65);
            this.Okbutton.TabIndex = 0;
            this.Okbutton.Text = "OK";
            this.Okbutton.UseVisualStyleBackColor = true;
            this.Okbutton.Click += new System.EventHandler(this.Okbutton_Click);
            // 
            // textBoxR6
            // 
            this.textBoxR6.Location = new System.Drawing.Point(201, 18);
            this.textBoxR6.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBoxR6.Name = "textBoxR6";
            this.textBoxR6.Size = new System.Drawing.Size(308, 44);
            this.textBoxR6.TabIndex = 1;
            // 
            // textBoxR7
            // 
            this.textBoxR7.Location = new System.Drawing.Point(201, 80);
            this.textBoxR7.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBoxR7.Name = "textBoxR7";
            this.textBoxR7.Size = new System.Drawing.Size(308, 44);
            this.textBoxR7.TabIndex = 2;
            // 
            // textBoxR8
            // 
            this.textBoxR8.Location = new System.Drawing.Point(201, 142);
            this.textBoxR8.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBoxR8.Name = "textBoxR8";
            this.textBoxR8.Size = new System.Drawing.Size(308, 44);
            this.textBoxR8.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Relay 6:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 44);
            this.label2.TabIndex = 4;
            this.label2.Text = "Relay 7:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "Relay 8:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(522, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(399, 41);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "disable when speed > 0";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(522, 83);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(399, 41);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "disable when speed > 0";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(522, 145);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(399, 41);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "disable when speed > 0";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // fom_rename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 303);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxR8);
            this.Controls.Add(this.textBoxR7);
            this.Controls.Add(this.textBoxR6);
            this.Controls.Add(this.Okbutton);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}