namespace Presentacion
{
    partial class FrmCarga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarga));
            this.PgbCarga = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.iTalk_ProgressIndicator1 = new iTalk.iTalk_ProgressIndicator();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PgbCarga
            // 
            this.PgbCarga.Location = new System.Drawing.Point(14, 194);
            this.PgbCarga.Name = "PgbCarga";
            this.PgbCarga.Size = new System.Drawing.Size(387, 18);
            this.PgbCarga.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "...";
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
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PgbCarga);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.iTalk_ProgressIndicator1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 258);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.AAEAAQAAAAAAAAR9AAAAJGNiNDkyOWQyLTJiNGEtNDJkYS04YWM1LWUzNWI0NWI3N2IzMg;
            this.pictureBox1.Location = new System.Drawing.Point(14, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cargando...Espere un Momento";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Presentacion.Properties.Resources.sdcsdgfs;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(357, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 39);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // iTalk_ProgressIndicator1
            // 
            this.iTalk_ProgressIndicator1.Location = new System.Drawing.Point(163, 84);
            this.iTalk_ProgressIndicator1.MinimumSize = new System.Drawing.Size(80, 80);
            this.iTalk_ProgressIndicator1.Name = "iTalk_ProgressIndicator1";
            this.iTalk_ProgressIndicator1.P_AnimationColor = System.Drawing.Color.DimGray;
            this.iTalk_ProgressIndicator1.P_AnimationSpeed = 100;
            this.iTalk_ProgressIndicator1.P_BaseColor = System.Drawing.Color.DarkGray;
            this.iTalk_ProgressIndicator1.Size = new System.Drawing.Size(80, 80);
            this.iTalk_ProgressIndicator1.TabIndex = 0;
            this.iTalk_ProgressIndicator1.Text = "iTalk_ProgressIndicator1";
            // 
            // FrmCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(434, 286);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk.iTalk_ProgressIndicator iTalk_ProgressIndicator1;
        private System.Windows.Forms.ProgressBar PgbCarga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}