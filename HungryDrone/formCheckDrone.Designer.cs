namespace HungryDrone
{
    partial class formCheckDrone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCheckDrone));
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLat = new System.Windows.Forms.Label();
            this.lbLong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbVel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAlt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Latitud";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(12, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 632);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Longitud";
            // 
            // lbLat
            // 
            this.lbLat.AutoSize = true;
            this.lbLat.Location = new System.Drawing.Point(290, 86);
            this.lbLat.Name = "lbLat";
            this.lbLat.Size = new System.Drawing.Size(51, 17);
            this.lbLat.TabIndex = 1;
            this.lbLat.Text = "Latitud";
            // 
            // lbLong
            // 
            this.lbLong.AutoSize = true;
            this.lbLong.Location = new System.Drawing.Point(290, 150);
            this.lbLong.Name = "lbLong";
            this.lbLong.Size = new System.Drawing.Size(63, 17);
            this.lbLong.TabIndex = 1;
            this.lbLong.Text = "Longitud";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Velocidad";
            // 
            // lbVel
            // 
            this.lbVel.AutoSize = true;
            this.lbVel.Location = new System.Drawing.Point(290, 214);
            this.lbVel.Name = "lbVel";
            this.lbVel.Size = new System.Drawing.Size(70, 17);
            this.lbVel.TabIndex = 1;
            this.lbVel.Text = "Velocidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Altura";
            // 
            // lbAlt
            // 
            this.lbAlt.AutoSize = true;
            this.lbAlt.Location = new System.Drawing.Point(290, 277);
            this.lbAlt.Name = "lbAlt";
            this.lbAlt.Size = new System.Drawing.Size(45, 17);
            this.lbAlt.TabIndex = 1;
            this.lbAlt.Text = "Altura";
            // 
            // formCheckDrone
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1212, 704);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbAlt);
            this.Controls.Add(this.lbVel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbLong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLat);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formCheckDrone";
            this.Text = "Drone Control (Administrators Only)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbLat;
        private System.Windows.Forms.Label lbLong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbVel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbAlt;
    }
}