namespace HungryDrone
{
    partial class formInicio
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
            this.components = new System.ComponentModel.Container();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.btnGuardarDatos = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(82, 137);
            this.gMapControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(283, 222);
            this.gMapControl1.TabIndex = 8;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(151, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese su ubicación";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(151, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingrese su nombre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNombre.Location = new System.Drawing.Point(82, 75);
            this.txtbNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(283, 24);
            this.txtbNombre.TabIndex = 7;
            // 
            // btnGuardarDatos
            // 
            this.btnGuardarDatos.BackColor = System.Drawing.Color.DarkRed;
            this.btnGuardarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarDatos.ForeColor = System.Drawing.Color.White;
            this.btnGuardarDatos.Location = new System.Drawing.Point(82, 366);
            this.btnGuardarDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardarDatos.Name = "btnGuardarDatos";
            this.btnGuardarDatos.Size = new System.Drawing.Size(283, 25);
            this.btnGuardarDatos.TabIndex = 9;
            this.btnGuardarDatos.Text = "Guardar Datos";
            this.btnGuardarDatos.UseVisualStyleBackColor = false;
            this.btnGuardarDatos.Click += new System.EventHandler(this.btnGuardarDatos_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // formInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(449, 421);
            this.Controls.Add(this.btnGuardarDatos);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formInicio";
            this.Text = "formInicio";
            this.Load += new System.EventHandler(this.formInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Button btnGuardarDatos;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}