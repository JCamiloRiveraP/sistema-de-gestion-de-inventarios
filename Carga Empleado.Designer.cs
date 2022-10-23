namespace Presentacion
{
    partial class Carga_Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carga_Empleado));
            this.PgbCargaEmplea = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iTalk_ProgressIndicator1 = new iTalk.iTalk_ProgressIndicator();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PgbCargaEmplea
            // 
            this.PgbCargaEmplea.Location = new System.Drawing.Point(12, 195);
            this.PgbCargaEmplea.Name = "PgbCargaEmplea";
            this.PgbCargaEmplea.Size = new System.Drawing.Size(411, 23);
            this.PgbCargaEmplea.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Salir);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iTalk_ProgressIndicator1);
            this.panel1.Controls.Add(this.PgbCargaEmplea);
            this.panel1.Location = new System.Drawing.Point(13, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 262);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.AAEAAQAAAAAAAAR9AAAAJGNiNDkyOWQyLTJiNGEtNDJkYS04YWM1LWUzNWI0NWI3N2IzMg;
            this.pictureBox1.Location = new System.Drawing.Point(12, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Salir
            // 
            this.Salir.BackgroundImage = global::Presentacion.Properties.Resources.sdcsdgfs;
            this.Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Salir.Location = new System.Drawing.Point(349, 16);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(49, 40);
            this.Salir.TabIndex = 4;
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cargando..Espere un Momento ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "...";
            // 
            // iTalk_ProgressIndicator1
            // 
            this.iTalk_ProgressIndicator1.Location = new System.Drawing.Point(176, 82);
            this.iTalk_ProgressIndicator1.MinimumSize = new System.Drawing.Size(80, 80);
            this.iTalk_ProgressIndicator1.Name = "iTalk_ProgressIndicator1";
            this.iTalk_ProgressIndicator1.P_AnimationColor = System.Drawing.Color.DimGray;
            this.iTalk_ProgressIndicator1.P_AnimationSpeed = 100;
            this.iTalk_ProgressIndicator1.P_BaseColor = System.Drawing.Color.DarkGray;
            this.iTalk_ProgressIndicator1.Size = new System.Drawing.Size(80, 80);
            this.iTalk_ProgressIndicator1.TabIndex = 0;
            this.iTalk_ProgressIndicator1.Text = "iTalk_ProgressIndicator1";
            // 
            // Carga_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(463, 303);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Carga_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga_Empleado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk.iTalk_ProgressIndicator iTalk_ProgressIndicator1;
        private System.Windows.Forms.ProgressBar PgbCargaEmplea;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Timer timer1;

    }
}