namespace Presentacion
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblContrasena = new System.Windows.Forms.Label();
            this.LblSalir = new System.Windows.Forms.Button();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblIngresar = new System.Windows.Forms.Button();
            this.CbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.LblTipoUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.ForeColor = System.Drawing.Color.White;
            this.LblUsuario.Location = new System.Drawing.Point(70, 76);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(50, 13);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Text = "Usuario";
            // 
            // LblContrasena
            // 
            this.LblContrasena.AutoSize = true;
            this.LblContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContrasena.ForeColor = System.Drawing.Color.White;
            this.LblContrasena.Location = new System.Drawing.Point(63, 112);
            this.LblContrasena.Name = "LblContrasena";
            this.LblContrasena.Size = new System.Drawing.Size(71, 13);
            this.LblContrasena.TabIndex = 1;
            this.LblContrasena.Text = "Contraseña";
            // 
            // LblSalir
            // 
            this.LblSalir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LblSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblSalir.ImageKey = "(ninguno)";
            this.LblSalir.Location = new System.Drawing.Point(207, 178);
            this.LblSalir.Name = "LblSalir";
            this.LblSalir.Size = new System.Drawing.Size(75, 30);
            this.LblSalir.TabIndex = 3;
            this.LblSalir.Text = "&Salir";
            this.LblSalir.UseVisualStyleBackColor = false;
            this.LblSalir.Click += new System.EventHandler(this.LblSalir_Click);
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.Location = new System.Drawing.Point(140, 105);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.Size = new System.Drawing.Size(100, 20);
            this.TxtContrasena.TabIndex = 4;
            this.TxtContrasena.UseSystemPasswordChar = true;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(140, 69);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(100, 20);
            this.TxtUsuario.TabIndex = 5;
            this.TxtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            // 
            // LblIngresar
            // 
            this.LblIngresar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LblIngresar.ForeColor = System.Drawing.Color.Black;
            this.LblIngresar.Location = new System.Drawing.Point(73, 178);
            this.LblIngresar.Name = "LblIngresar";
            this.LblIngresar.Size = new System.Drawing.Size(75, 30);
            this.LblIngresar.TabIndex = 2;
            this.LblIngresar.Text = "Ingresar";
            this.LblIngresar.UseVisualStyleBackColor = false;
            this.LblIngresar.Click += new System.EventHandler(this.LblIngresar_Click);
            // 
            // CbTipoUsuario
            // 
            this.CbTipoUsuario.AutoCompleteCustomSource.AddRange(new string[] {
            "Administrador",
            "Empleado",
            "Proveedor",
            "Cliente"});
            this.CbTipoUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.CbTipoUsuario.FormattingEnabled = true;
            this.CbTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.CbTipoUsuario.Location = new System.Drawing.Point(140, 141);
            this.CbTipoUsuario.Name = "CbTipoUsuario";
            this.CbTipoUsuario.Size = new System.Drawing.Size(121, 21);
            this.CbTipoUsuario.TabIndex = 7;
            // 
            // LblTipoUsuario
            // 
            this.LblTipoUsuario.AutoSize = true;
            this.LblTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoUsuario.ForeColor = System.Drawing.Color.White;
            this.LblTipoUsuario.Location = new System.Drawing.Point(37, 149);
            this.LblTipoUsuario.Name = "LblTipoUsuario";
            this.LblTipoUsuario.Size = new System.Drawing.Size(97, 13);
            this.LblTipoUsuario.TabIndex = 8;
            this.LblTipoUsuario.Text = "Tipo de Usuario";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(338, 273);
            this.Controls.Add(this.LblTipoUsuario);
            this.Controls.Add(this.CbTipoUsuario);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.TxtContrasena);
            this.Controls.Add(this.LblSalir);
            this.Controls.Add(this.LblIngresar);
            this.Controls.Add(this.LblContrasena);
            this.Controls.Add(this.LblUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblContrasena;
        private System.Windows.Forms.Button LblIngresar;
        private System.Windows.Forms.Button LblSalir;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.ComboBox CbTipoUsuario;
        private System.Windows.Forms.Label LblTipoUsuario;
    }
}