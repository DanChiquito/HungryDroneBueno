﻿namespace HungryDrone
{
    partial class HomePage
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.btnMenu = new System.Windows.Forms.Button();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.horaFeha = new System.Windows.Forms.Timer(this.components);
            this.ptbOpen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbClosed = new System.Windows.Forms.PictureBox();
            this.btnMenuLat = new System.Windows.Forms.PictureBox();
            this.btnMinim = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelMenuLat = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnMenu2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClosed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuLat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelMenuLat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(156, 585);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(120, 39);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Ir al menú";
            this.btnMenu.UseVisualStyleBackColor = false;
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.btnMenuLat);
            this.panel3.Controls.Add(this.btnMinim);
            this.panel3.Controls.Add(this.btnCerrar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 53);
            this.panel3.TabIndex = 7;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.Black;
            this.panelContenedor.Controls.Add(this.ptbOpen);
            this.panelContenedor.Controls.Add(this.label);
            this.panelContenedor.Controls.Add(this.label1);
            this.panelContenedor.Controls.Add(this.lbFecha);
            this.panelContenedor.Controls.Add(this.lbHora);
            this.panelContenedor.Controls.Add(this.ptbClosed);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(200, 53);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(450, 497);
            this.panelContenedor.TabIndex = 8;
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.DarkGray;
            this.label.Location = new System.Drawing.Point(158, 146);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(149, 57);
            this.label.TabIndex = 11;
            this.label.Text = "Horario de servicio:\r\n6:00 am - 11:00 pm";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFecha
            // 
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.White;
            this.lbFecha.Location = new System.Drawing.Point(23, 45);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(411, 26);
            this.lbFecha.TabIndex = 9;
            this.lbFecha.Text = "Fecha";
            this.lbFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbHora
            // 
            this.lbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.ForeColor = System.Drawing.Color.White;
            this.lbHora.Location = new System.Drawing.Point(25, 71);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(409, 55);
            this.lbHora.TabIndex = 9;
            this.lbHora.Text = "Hora";
            this.lbHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // horaFeha
            // 
            this.horaFeha.Enabled = true;
            this.horaFeha.Tick += new System.EventHandler(this.horaFeha_Tick);
            // 
            // ptbOpen
            // 
            this.ptbOpen.Image = global::HungryDrone.Properties.Resources.open;
            this.ptbOpen.Location = new System.Drawing.Point(161, 242);
            this.ptbOpen.Name = "ptbOpen";
            this.ptbOpen.Size = new System.Drawing.Size(128, 128);
            this.ptbOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbOpen.TabIndex = 14;
            this.ptbOpen.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Image = global::HungryDrone.Properties.Resources.original;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(308, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hungry Drone 2018";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbClosed
            // 
            this.ptbClosed.Image = global::HungryDrone.Properties.Resources.closed;
            this.ptbClosed.Location = new System.Drawing.Point(161, 242);
            this.ptbClosed.Name = "ptbClosed";
            this.ptbClosed.Size = new System.Drawing.Size(128, 128);
            this.ptbClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbClosed.TabIndex = 0;
            this.ptbClosed.TabStop = false;
            // 
            // btnMenuLat
            // 
            this.btnMenuLat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuLat.Enabled = false;
            this.btnMenuLat.Image = global::HungryDrone.Properties.Resources.btnmenu;
            this.btnMenuLat.Location = new System.Drawing.Point(6, 12);
            this.btnMenuLat.Name = "btnMenuLat";
            this.btnMenuLat.Size = new System.Drawing.Size(32, 27);
            this.btnMenuLat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenuLat.TabIndex = 10;
            this.btnMenuLat.TabStop = false;
            this.btnMenuLat.Click += new System.EventHandler(this.btnMenuLat_Click);
            // 
            // btnMinim
            // 
            this.btnMinim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinim.Image = global::HungryDrone.Properties.Resources.btnmin;
            this.btnMinim.Location = new System.Drawing.Point(364, 12);
            this.btnMinim.Name = "btnMinim";
            this.btnMinim.Size = new System.Drawing.Size(32, 27);
            this.btnMinim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinim.TabIndex = 9;
            this.btnMinim.TabStop = false;
            this.btnMinim.Click += new System.EventHandler(this.btnMinim_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = global::HungryDrone.Properties.Resources.btncerrar2;
            this.btnCerrar.Location = new System.Drawing.Point(402, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 27);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelMenuLat
            // 
            this.panelMenuLat.BackgroundImage = global::HungryDrone.Properties.Resources.madera_oscura;
            this.panelMenuLat.Controls.Add(this.btnInicio);
            this.panelMenuLat.Controls.Add(this.btnAdmin);
            this.panelMenuLat.Controls.Add(this.btnMenu2);
            this.panelMenuLat.Controls.Add(this.pictureBox1);
            this.panelMenuLat.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLat.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLat.Name = "panelMenuLat";
            this.panelMenuLat.Size = new System.Drawing.Size(200, 550);
            this.panelMenuLat.TabIndex = 6;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.Transparent;
            this.btnInicio.Image = global::HungryDrone.Properties.Resources.ubi4;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(22, 139);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(178, 35);
            this.btnInicio.TabIndex = 8;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(22, 342);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(222, 35);
            this.btnAdmin.TabIndex = 7;
            this.btnAdmin.Text = "ADMINISTRADOR";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnMenu2
            // 
            this.btnMenu2.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu2.FlatAppearance.BorderSize = 0;
            this.btnMenu2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenu2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btnMenu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu2.ForeColor = System.Drawing.Color.Transparent;
            this.btnMenu2.Image = global::HungryDrone.Properties.Resources.cubierts;
            this.btnMenu2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu2.Location = new System.Drawing.Point(22, 245);
            this.btnMenu2.Name = "btnMenu2";
            this.btnMenu2.Size = new System.Drawing.Size(178, 35);
            this.btnMenu2.TabIndex = 6;
            this.btnMenu2.Text = "MENU";
            this.btnMenu2.UseVisualStyleBackColor = false;
            this.btnMenu2.Click += new System.EventHandler(this.btnMenu2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HungryDrone.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 550);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelMenuLat);
            this.Controls.Add(this.btnMenu);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HUNGRY DRONE";
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClosed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuLat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelMenuLat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.ErrorProvider errorProv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMenuLat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox btnMinim;
        private System.Windows.Forms.PictureBox btnMenuLat;
        private System.Windows.Forms.Button btnMenu2;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Timer horaFeha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox ptbClosed;
        private System.Windows.Forms.PictureBox ptbOpen;
    }
}

