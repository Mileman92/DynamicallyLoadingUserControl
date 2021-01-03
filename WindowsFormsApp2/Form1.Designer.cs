namespace WindowsFormsApp2
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
            this.btnModule1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModule2 = new System.Windows.Forms.Button();
            this.btnModule3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModule1
            // 
            this.btnModule1.Location = new System.Drawing.Point(677, 69);
            this.btnModule1.Name = "btnModule1";
            this.btnModule1.Size = new System.Drawing.Size(75, 23);
            this.btnModule1.TabIndex = 0;
            this.btnModule1.Text = "Module 1";
            this.btnModule1.UseVisualStyleBackColor = true;
            this.btnModule1.Click += new System.EventHandler(this.btnModule1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 319);
            this.panel1.TabIndex = 1;
            // 
            // btnModule2
            // 
            this.btnModule2.Location = new System.Drawing.Point(677, 98);
            this.btnModule2.Name = "btnModule2";
            this.btnModule2.Size = new System.Drawing.Size(75, 23);
            this.btnModule2.TabIndex = 0;
            this.btnModule2.Text = "Module 2";
            this.btnModule2.UseVisualStyleBackColor = true;
            this.btnModule2.Click += new System.EventHandler(this.btnModule2_Click);
            // 
            // btnModule3
            // 
            this.btnModule3.Location = new System.Drawing.Point(677, 127);
            this.btnModule3.Name = "btnModule3";
            this.btnModule3.Size = new System.Drawing.Size(75, 23);
            this.btnModule3.TabIndex = 0;
            this.btnModule3.Text = "Module 3";
            this.btnModule3.UseVisualStyleBackColor = true;
            this.btnModule3.Click += new System.EventHandler(this.btnModule3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnModule3);
            this.Controls.Add(this.btnModule2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnModule1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModule1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnModule2;
        private System.Windows.Forms.Button btnModule3;
        private System.Windows.Forms.Button button1;
    }
}

