namespace BMI
{
    partial class Form1
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
            this.mass = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.Label();
            this.mass_text_box = new System.Windows.Forms.TextBox();
            this.height_taext_box = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mass
            // 
            this.mass.AutoSize = true;
            this.mass.Location = new System.Drawing.Point(8, 72);
            this.mass.Name = "mass";
            this.mass.Size = new System.Drawing.Size(79, 17);
            this.mass.TabIndex = 0;
            this.mass.Text = "Masa ciała:";
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Location = new System.Drawing.Point(16, 144);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(52, 17);
            this.height.TabIndex = 1;
            this.height.Text = "Wzrost";
            // 
            // mass_text_box
            // 
            this.mass_text_box.Location = new System.Drawing.Point(88, 72);
            this.mass_text_box.Name = "mass_text_box";
            this.mass_text_box.Size = new System.Drawing.Size(100, 22);
            this.mass_text_box.TabIndex = 3;
            // 
            // height_taext_box
            // 
            this.height_taext_box.Location = new System.Drawing.Point(88, 144);
            this.height_taext_box.Name = "height_taext_box";
            this.height_taext_box.Size = new System.Drawing.Size(100, 22);
            this.height_taext_box.TabIndex = 4;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(200, 64);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 152);
            this.calculate.TabIndex = 6;
            this.calculate.Text = "Oblicz";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.height_taext_box);
            this.Controls.Add(this.mass_text_box);
            this.Controls.Add(this.height);
            this.Controls.Add(this.mass);
            this.Name = "Form1";
            this.Text = "BMI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mass;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.TextBox mass_text_box;
        private System.Windows.Forms.TextBox height_taext_box;
        private System.Windows.Forms.Button calculate;
    }
}

