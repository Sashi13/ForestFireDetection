using System.Drawing;

namespace Firebase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Temperature_lbl = new System.Windows.Forms.Label();
            this.Humdity_lbl = new System.Windows.Forms.Label();
            this.Moisture_lbl = new System.Windows.Forms.Label();
            this.Rain_lbl = new System.Windows.Forms.Label();
            this.tmp_label = new System.Windows.Forms.Label();
            this.hmd_label = new System.Windows.Forms.Label();
            this.aq_label = new System.Windows.Forms.Label();
            this.rm_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Temperature_lbl
            // 
            this.Temperature_lbl.AutoSize = true;
            this.Temperature_lbl.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Temperature_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Temperature_lbl.Location = new System.Drawing.Point(236, 61);
            this.Temperature_lbl.Name = "Temperature_lbl";
            this.Temperature_lbl.Size = new System.Drawing.Size(177, 31);
            this.Temperature_lbl.TabIndex = 3;
            this.Temperature_lbl.Text = "Temperature:";
            this.Temperature_lbl.BackColor = System.Drawing.Color.Transparent;
            // 
            // Humdity_lbl
            // 
            this.Humdity_lbl.AutoSize = true;
            this.Humdity_lbl.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Humdity_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Humdity_lbl.Location = new System.Drawing.Point(238, 150);
            this.Humdity_lbl.Name = "Humdity_lbl";
            this.Humdity_lbl.Size = new System.Drawing.Size(135, 31);
            this.Humdity_lbl.TabIndex = 3;
            this.Humdity_lbl.Text = "Humidity: ";
            this.Humdity_lbl.BackColor = System.Drawing.Color.Transparent;
            // 
            // Moisture_lbl
            // 
            this.Moisture_lbl.AutoSize = true;
            this.Moisture_lbl.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Moisture_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Moisture_lbl.Location = new System.Drawing.Point(238, 244);
            this.Moisture_lbl.Name = "Moisture_lbl";
            this.Moisture_lbl.Size = new System.Drawing.Size(154, 31);
            this.Moisture_lbl.TabIndex = 3;
            this.Moisture_lbl.Text = "Air Quality: ";
            this.Moisture_lbl.BackColor = System.Drawing.Color.Transparent;
            // 
            // Rain_lbl
            // 
            this.Rain_lbl.AutoSize = true;
            this.Rain_lbl.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Rain_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Rain_lbl.Location = new System.Drawing.Point(236, 340);
            this.Rain_lbl.Name = "Rain_lbl";
            this.Rain_lbl.Size = new System.Drawing.Size(182, 31);
            this.Rain_lbl.TabIndex = 5;
            this.Rain_lbl.Text = "Rain monitor: ";
            this.Rain_lbl.BackColor = System.Drawing.Color.Transparent;
            // 
            // tmp_label
            // 
            this.tmp_label.AutoSize = true;
            this.tmp_label.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tmp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tmp_label.Location = new System.Drawing.Point(478, 61);
            this.tmp_label.Name = "tmp_label";
            this.tmp_label.Size = new System.Drawing.Size(29, 31);
            this.tmp_label.TabIndex = 3;
            this.tmp_label.Text = "0";
            this.tmp_label.BackColor = System.Drawing.Color.Transparent;
            // 
            // hmd_label
            // 
            this.hmd_label.AutoSize = true;
            this.hmd_label.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.hmd_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.hmd_label.Location = new System.Drawing.Point(478, 150);
            this.hmd_label.Name = "hmd_label";
            this.hmd_label.Size = new System.Drawing.Size(29, 31);
            this.hmd_label.TabIndex = 3;
            this.hmd_label.Text = "0";
            this.hmd_label.BackColor = System.Drawing.Color.Transparent;
            // 
            // aq_label
            // 
            this.aq_label.AutoSize = true;
            this.aq_label.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.aq_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.aq_label.Location = new System.Drawing.Point(478, 244);
            this.aq_label.Name = "aq_label";
            this.aq_label.Size = new System.Drawing.Size(84, 31);
            this.aq_label.TabIndex = 3;
            this.aq_label.Text = "NULL";
            this.aq_label.BackColor = System.Drawing.Color.Transparent;
            // 
            // rm_label
            // 
            this.rm_label.AutoSize = true;
            this.rm_label.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rm_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.rm_label.Location = new System.Drawing.Point(478, 340);
            this.rm_label.Name = "rm_label";
            this.rm_label.Size = new System.Drawing.Size(84, 31);
            this.rm_label.TabIndex = 5;
            this.rm_label.Text = "NULL";
            this.rm_label.BackColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 493);
            this.Controls.Add(this.rm_label);
            this.Controls.Add(this.Rain_lbl);
            this.Controls.Add(this.aq_label);
            this.Controls.Add(this.Moisture_lbl);
            this.Controls.Add(this.hmd_label);
            this.Controls.Add(this.Humdity_lbl);
            this.Controls.Add(this.tmp_label);
            this.Controls.Add(this.Temperature_lbl);
            this.MaximumSize = new System.Drawing.Size(800, 532);
            this.MinimumSize = new System.Drawing.Size(800, 532);
            this.Name = "Forest Monitoring System";
            this.Text = "Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Temperature_lbl;
        private System.Windows.Forms.Label Humdity_lbl;
        private System.Windows.Forms.Label Moisture_lbl;
        private System.Windows.Forms.Label Rain_lbl;
        private System.Windows.Forms.Label tmp_label;
        private System.Windows.Forms.Label hmd_label;
        private System.Windows.Forms.Label aq_label;
        private System.Windows.Forms.Label rm_label;
    }
}

