namespace Presentacion
{
    partial class FrmEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleado));
            this.LblFechaNacim = new System.Windows.Forms.Label();
            this.LblBarrio = new System.Windows.Forms.Label();
            this.LblCorreoEletro = new System.Windows.Forms.Label();
            this.DtpFechaNacim = new System.Windows.Forms.DateTimePicker();
            this.TxtBarrio = new System.Windows.Forms.TextBox();
            this.TxtCorreoElec = new System.Windows.Forms.TextBox();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnConultar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.LblCedula = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblFechaNacim
            // 
            this.LblFechaNacim.AutoSize = true;
            this.LblFechaNacim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaNacim.ForeColor = System.Drawing.Color.Black;
            this.LblFechaNacim.Location = new System.Drawing.Point(221, 87);
            this.LblFechaNacim.Name = "LblFechaNacim";
            this.LblFechaNacim.Size = new System.Drawing.Size(107, 13);
            this.LblFechaNacim.TabIndex = 5;
            this.LblFechaNacim.Text = "Fecha nacimiento";
            // 
            // LblBarrio
            // 
            this.LblBarrio.AutoSize = true;
            this.LblBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBarrio.ForeColor = System.Drawing.Color.Black;
            this.LblBarrio.Location = new System.Drawing.Point(221, 130);
            this.LblBarrio.Name = "LblBarrio";
            this.LblBarrio.Size = new System.Drawing.Size(40, 13);
            this.LblBarrio.TabIndex = 6;
            this.LblBarrio.Text = "Barrio";
            // 
            // LblCorreoEletro
            // 
            this.LblCorreoEletro.AutoSize = true;
            this.LblCorreoEletro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCorreoEletro.ForeColor = System.Drawing.Color.Black;
            this.LblCorreoEletro.Location = new System.Drawing.Point(221, 167);
            this.LblCorreoEletro.Name = "LblCorreoEletro";
            this.LblCorreoEletro.Size = new System.Drawing.Size(112, 13);
            this.LblCorreoEletro.TabIndex = 7;
            this.LblCorreoEletro.Text = "Correo Electronico";
            // 
            // DtpFechaNacim
            // 
            this.DtpFechaNacim.Location = new System.Drawing.Point(344, 81);
            this.DtpFechaNacim.Name = "DtpFechaNacim";
            this.DtpFechaNacim.Size = new System.Drawing.Size(200, 20);
            this.DtpFechaNacim.TabIndex = 10;
            // 
            // TxtBarrio
            // 
            this.TxtBarrio.Location = new System.Drawing.Point(344, 123);
            this.TxtBarrio.Name = "TxtBarrio";
            this.TxtBarrio.Size = new System.Drawing.Size(100, 20);
            this.TxtBarrio.TabIndex = 16;
            this.TxtBarrio.TextChanged += new System.EventHandler(this.TxtBarrio_TextChanged);
            // 
            // TxtCorreoElec
            // 
            this.TxtCorreoElec.Location = new System.Drawing.Point(344, 160);
            this.TxtCorreoElec.Name = "TxtCorreoElec";
            this.TxtCorreoElec.Size = new System.Drawing.Size(100, 20);
            this.TxtCorreoElec.TabIndex = 17;
            // 
            // BtnMenu
            // 
            this.BtnMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMenu.Location = new System.Drawing.Point(3, 3);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(54, 23);
            this.BtnMenu.TabIndex = 51;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(184, 241);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(72, 29);
            this.BtnEliminar.TabIndex = 60;
            this.BtnEliminar.Text = "&Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnActualizar.FlatAppearance.BorderSize = 0;
            this.BtnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.Location = new System.Drawing.Point(262, 241);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(87, 29);
            this.BtnActualizar.TabIndex = 59;
            this.BtnActualizar.Text = "&Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnConultar
            // 
            this.BtnConultar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnConultar.FlatAppearance.BorderSize = 0;
            this.BtnConultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnConultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConultar.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnConultar.Location = new System.Drawing.Point(97, 241);
            this.BtnConultar.Name = "BtnConultar";
            this.BtnConultar.Size = new System.Drawing.Size(81, 29);
            this.BtnConultar.TabIndex = 58;
            this.BtnConultar.Text = "&Consultar";
            this.BtnConultar.UseVisualStyleBackColor = false;
            this.BtnConultar.Click += new System.EventHandler(this.BtnConultar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(355, 241);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(69, 29);
            this.BtnAgregar.TabIndex = 57;
            this.BtnAgregar.Text = "&Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCedula.ForeColor = System.Drawing.Color.Black;
            this.LblCedula.Location = new System.Drawing.Point(31, 94);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(46, 13);
            this.LblCedula.TabIndex = 0;
            this.LblCedula.Text = "Cedula";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.Black;
            this.LblNombre.Location = new System.Drawing.Point(27, 130);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(50, 13);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.ForeColor = System.Drawing.Color.Black;
            this.LblApellido.Location = new System.Drawing.Point(25, 167);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(52, 13);
            this.LblApellido.TabIndex = 2;
            this.LblApellido.Text = "Apellido";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.ForeColor = System.Drawing.Color.Black;
            this.LblDireccion.Location = new System.Drawing.Point(221, 198);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(61, 13);
            this.LblDireccion.TabIndex = 3;
            this.LblDireccion.Text = "Direccion";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono.ForeColor = System.Drawing.Color.Black;
            this.LblTelefono.Location = new System.Drawing.Point(20, 198);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(57, 13);
            this.LblTelefono.TabIndex = 4;
            this.LblTelefono.Text = "Telefono";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(83, 87);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(102, 20);
            this.TxtCedula.TabIndex = 11;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(83, 160);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(102, 20);
            this.TxtNombre.TabIndex = 12;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(83, 195);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(102, 20);
            this.TxtApellido.TabIndex = 13;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(344, 191);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(102, 20);
            this.TxtDireccion.TabIndex = 14;
            this.TxtDireccion.TextChanged += new System.EventHandler(this.TxtDireccion_TextChanged);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(83, 123);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(102, 20);
            this.TxtTelefono.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxtDireccion);
            this.panel1.Controls.Add(this.BtnAgregar);
            this.panel1.Controls.Add(this.BtnConultar);
            this.panel1.Controls.Add(this.BtnEliminar);
            this.panel1.Controls.Add(this.LblCedula);
            this.panel1.Controls.Add(this.BtnMenu);
            this.panel1.Controls.Add(this.BtnActualizar);
            this.panel1.Controls.Add(this.LblNombre);
            this.panel1.Controls.Add(this.LblApellido);
            this.panel1.Controls.Add(this.LblDireccion);
            this.panel1.Controls.Add(this.LblTelefono);
            this.panel1.Controls.Add(this.LblBarrio);
            this.panel1.Controls.Add(this.TxtCorreoElec);
            this.panel1.Controls.Add(this.TxtCedula);
            this.panel1.Controls.Add(this.TxtBarrio);
            this.panel1.Controls.Add(this.DtpFechaNacim);
            this.panel1.Controls.Add(this.TxtNombre);
            this.panel1.Controls.Add(this.LblCorreoEletro);
            this.panel1.Controls.Add(this.TxtTelefono);
            this.panel1.Controls.Add(this.TxtApellido);
            this.panel1.Controls.Add(this.LblFechaNacim);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 297);
            this.panel1.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 38);
            this.label1.TabIndex = 61;
            this.label1.Text = "Empleado";
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(575, 374);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblFechaNacim;
        private System.Windows.Forms.Label LblBarrio;
        private System.Windows.Forms.Label LblCorreoEletro;
        private System.Windows.Forms.DateTimePicker DtpFechaNacim;
        private System.Windows.Forms.TextBox TxtBarrio;
        private System.Windows.Forms.TextBox TxtCorreoElec;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnConultar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label LblCedula;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;

    }
}