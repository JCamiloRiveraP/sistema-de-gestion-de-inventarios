namespace Presentacion
{
    partial class FrmMenuEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuEmpleado));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BtnFacturaVenta = new System.Windows.Forms.Button();
            this.BtnFacturaCompra = new System.Windows.Forms.Button();
            this.BtnProducto = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.BtnEmpleado = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.HoraYDia = new System.Windows.Forms.Label();
            this.LblSalir = new System.Windows.Forms.Button();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 445);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(263, 20);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // BtnFacturaVenta
            // 
            this.BtnFacturaVenta.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnFacturaVenta.FlatAppearance.BorderSize = 0;
            this.BtnFacturaVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnFacturaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturaVenta.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturaVenta.Location = new System.Drawing.Point(3, 182);
            this.BtnFacturaVenta.Name = "BtnFacturaVenta";
            this.BtnFacturaVenta.Size = new System.Drawing.Size(256, 56);
            this.BtnFacturaVenta.TabIndex = 29;
            this.BtnFacturaVenta.Text = "Factura de venta";
            this.BtnFacturaVenta.UseVisualStyleBackColor = false;
            this.BtnFacturaVenta.Click += new System.EventHandler(this.BtnFacturaVenta_Click_1);
            // 
            // BtnFacturaCompra
            // 
            this.BtnFacturaCompra.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnFacturaCompra.FlatAppearance.BorderSize = 0;
            this.BtnFacturaCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnFacturaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacturaCompra.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturaCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFacturaCompra.Location = new System.Drawing.Point(3, 130);
            this.BtnFacturaCompra.Name = "BtnFacturaCompra";
            this.BtnFacturaCompra.Size = new System.Drawing.Size(256, 56);
            this.BtnFacturaCompra.TabIndex = 30;
            this.BtnFacturaCompra.Text = "Factura de compra";
            this.BtnFacturaCompra.UseVisualStyleBackColor = false;
            this.BtnFacturaCompra.Click += new System.EventHandler(this.BtnFacturaCompra_Click);
            // 
            // BtnProducto
            // 
            this.BtnProducto.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnProducto.FlatAppearance.BorderSize = 0;
            this.BtnProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProducto.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProducto.Location = new System.Drawing.Point(3, 235);
            this.BtnProducto.Name = "BtnProducto";
            this.BtnProducto.Size = new System.Drawing.Size(256, 56);
            this.BtnProducto.TabIndex = 31;
            this.BtnProducto.Text = "Producto";
            this.BtnProducto.UseVisualStyleBackColor = false;
            this.BtnProducto.Click += new System.EventHandler(this.BtnProducto_Click_1);
            // 
            // BtnCliente
            // 
            this.BtnCliente.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnCliente.FlatAppearance.BorderSize = 0;
            this.BtnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCliente.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente.Location = new System.Drawing.Point(3, 83);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(256, 51);
            this.BtnCliente.TabIndex = 32;
            this.BtnCliente.Text = "Cliente";
            this.BtnCliente.UseVisualStyleBackColor = false;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // BtnEmpleado
            // 
            this.BtnEmpleado.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnEmpleado.FlatAppearance.BorderSize = 0;
            this.BtnEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpleado.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEmpleado.Location = new System.Drawing.Point(3, 38);
            this.BtnEmpleado.Name = "BtnEmpleado";
            this.BtnEmpleado.Size = new System.Drawing.Size(256, 51);
            this.BtnEmpleado.TabIndex = 33;
            this.BtnEmpleado.Text = "Empleado";
            this.BtnEmpleado.UseVisualStyleBackColor = false;
            this.BtnEmpleado.Click += new System.EventHandler(this.BtnEmpleado_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnProducto);
            this.panel1.Controls.Add(this.BtnEmpleado);
            this.panel1.Controls.Add(this.BtnFacturaVenta);
            this.panel1.Controls.Add(this.BtnCliente);
            this.panel1.Controls.Add(this.BtnFacturaCompra);
            this.panel1.Location = new System.Drawing.Point(10, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 328);
            this.panel1.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.AAEAAQAAAAAAAAR9AAAAJGNiNDkyOWQyLTJiNGEtNDJkYS04YWM1LWUzNWI0NWI3N2IzMg;
            this.pictureBox1.Location = new System.Drawing.Point(10, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(279, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 419);
            this.panel2.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "EMPLEADO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.can_stock_photo_csp40174281;
            this.pictureBox2.Location = new System.Drawing.Point(8, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.HoraYDia);
            this.panel3.Controls.Add(this.LblSalir);
            this.panel3.Controls.Add(this.BtnCerrarSesion);
            this.panel3.Location = new System.Drawing.Point(279, 429);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(410, 46);
            this.panel3.TabIndex = 37;
            // 
            // HoraYDia
            // 
            this.HoraYDia.AutoSize = true;
            this.HoraYDia.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraYDia.Location = new System.Drawing.Point(159, 14);
            this.HoraYDia.Name = "HoraYDia";
            this.HoraYDia.Size = new System.Drawing.Size(94, 21);
            this.HoraYDia.TabIndex = 23;
            this.HoraYDia.Text = "Hora Y Dia";
            this.HoraYDia.Click += new System.EventHandler(this.HoraYDia_Click);
            // 
            // LblSalir
            // 
            this.LblSalir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LblSalir.BackgroundImage = global::Presentacion.Properties.Resources.descarga__1_1;
            this.LblSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LblSalir.FlatAppearance.BorderSize = 0;
            this.LblSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.LblSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblSalir.ImageKey = "(ninguno)";
            this.LblSalir.Location = new System.Drawing.Point(369, 2);
            this.LblSalir.Name = "LblSalir";
            this.LblSalir.Size = new System.Drawing.Size(34, 37);
            this.LblSalir.TabIndex = 22;
            this.LblSalir.UseVisualStyleBackColor = false;
            this.LblSalir.Click += new System.EventHandler(this.LblSalir_Click_1);
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnCerrarSesion.BackgroundImage = global::Presentacion.Properties.Resources.images3;
            this.BtnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.BtnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarSesion.Location = new System.Drawing.Point(6, 1);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(44, 38);
            this.BtnCerrarSesion.TabIndex = 8;
            this.BtnCerrarSesion.UseVisualStyleBackColor = false;
            this.BtnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click_1);
            // 
            // FrmMenuEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(695, 479);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Empleado";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Button BtnFacturaVenta;
        private System.Windows.Forms.Button BtnFacturaCompra;
        public System.Windows.Forms.Button BtnProducto;
        public System.Windows.Forms.Button BtnCliente;
        public System.Windows.Forms.Button BtnEmpleado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label HoraYDia;
        private System.Windows.Forms.Button LblSalir;
        private System.Windows.Forms.Button BtnCerrarSesion;

    }
}