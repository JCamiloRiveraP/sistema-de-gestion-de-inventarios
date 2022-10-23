namespace Presentacion
{
    partial class FrmFacturaVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturaVenta));
            this.TxtIva = new System.Windows.Forms.TextBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.LblIva = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnConultar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtIva
            // 
            this.TxtIva.Location = new System.Drawing.Point(288, 128);
            this.TxtIva.Name = "TxtIva";
            this.TxtIva.Size = new System.Drawing.Size(122, 20);
            this.TxtIva.TabIndex = 61;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(288, 91);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(122, 20);
            this.TxtTotal.TabIndex = 60;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(83, 131);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(122, 20);
            this.TxtNombre.TabIndex = 58;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(83, 96);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(122, 20);
            this.TxtCodigo.TabIndex = 57;
            // 
            // LblIva
            // 
            this.LblIva.AutoSize = true;
            this.LblIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIva.ForeColor = System.Drawing.Color.Black;
            this.LblIva.Location = new System.Drawing.Point(226, 131);
            this.LblIva.Name = "LblIva";
            this.LblIva.Size = new System.Drawing.Size(25, 13);
            this.LblIva.TabIndex = 54;
            this.LblIva.Text = "Iva";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.Black;
            this.LblTotal.Location = new System.Drawing.Point(226, 98);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(36, 13);
            this.LblTotal.TabIndex = 53;
            this.LblTotal.Text = "Total";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.Black;
            this.LblFecha.Location = new System.Drawing.Point(21, 169);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(42, 13);
            this.LblFecha.TabIndex = 52;
            this.LblFecha.Text = "Fecha";
            this.LblFecha.Click += new System.EventHandler(this.LblFecha_Click);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.Black;
            this.LblNombre.Location = new System.Drawing.Point(21, 131);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(50, 13);
            this.LblNombre.TabIndex = 51;
            this.LblNombre.Text = "Nombre";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.ForeColor = System.Drawing.Color.Black;
            this.LblCodigo.Location = new System.Drawing.Point(21, 96);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(46, 13);
            this.LblCodigo.TabIndex = 50;
            this.LblCodigo.Text = "Codigo";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(83, 162);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(200, 20);
            this.DtpFecha.TabIndex = 69;
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.Location = new System.Drawing.Point(3, 3);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(60, 30);
            this.BtnMenu.TabIndex = 70;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnAgregar);
            this.panel1.Controls.Add(this.BtnConultar);
            this.panel1.Controls.Add(this.BtnEliminar);
            this.panel1.Controls.Add(this.BtnActualizar);
            this.panel1.Controls.Add(this.DtpFecha);
            this.panel1.Controls.Add(this.LblCodigo);
            this.panel1.Controls.Add(this.LblNombre);
            this.panel1.Controls.Add(this.LblFecha);
            this.panel1.Controls.Add(this.BtnMenu);
            this.panel1.Controls.Add(this.LblTotal);
            this.panel1.Controls.Add(this.LblIva);
            this.panel1.Controls.Add(this.TxtCodigo);
            this.panel1.Controls.Add(this.TxtIva);
            this.panel1.Controls.Add(this.TxtNombre);
            this.panel1.Controls.Add(this.TxtTotal);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 261);
            this.panel1.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 38);
            this.label1.TabIndex = 75;
            this.label1.Text = "Factura de Venta";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(312, 208);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(69, 29);
            this.BtnAgregar.TabIndex = 71;
            this.BtnAgregar.Text = "&Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // BtnConultar
            // 
            this.BtnConultar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnConultar.FlatAppearance.BorderSize = 0;
            this.BtnConultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnConultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConultar.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnConultar.Location = new System.Drawing.Point(54, 208);
            this.BtnConultar.Name = "BtnConultar";
            this.BtnConultar.Size = new System.Drawing.Size(81, 29);
            this.BtnConultar.TabIndex = 72;
            this.BtnConultar.Text = "&Consultar";
            this.BtnConultar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(141, 208);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(72, 29);
            this.BtnEliminar.TabIndex = 74;
            this.BtnEliminar.Text = "&Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnActualizar.FlatAppearance.BorderSize = 0;
            this.BtnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.Location = new System.Drawing.Point(219, 208);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(87, 29);
            this.BtnActualizar.TabIndex = 73;
            this.BtnActualizar.Text = "&Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // FrmFacturaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(451, 321);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFacturaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura_de_Venta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIva;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label LblIva;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnConultar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;

    }
}