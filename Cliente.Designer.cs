namespace Presentacion
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.TxTTelefon = new System.Windows.Forms.TextBox();
            this.TxTDirecci = new System.Windows.Forms.TextBox();
            this.TxtApeliido = new System.Windows.Forms.TextBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.TxTC_C = new System.Windows.Forms.TextBox();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblCedula = new System.Windows.Forms.Label();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnIngresa = new System.Windows.Forms.Button();
            this.BtnColsultar = new System.Windows.Forms.Button();
            this.BtnElimi = new System.Windows.Forms.Button();
            this.BtnActualiza = new System.Windows.Forms.Button();
            this.rapitiendas_Tabla_Sql = new Presentacion.Rapitiendas_Tabla_Sql();
            this.rapitiendasDataSet = new Presentacion.RapitiendasDataSet();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClienteTable = new Presentacion.RapitiendasDataSetTableAdapters.ClienteTableAdapter();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TablaCliente = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rapitiendas_Tabla_Sql)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapitiendasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // TxTTelefon
            // 
            this.TxTTelefon.Location = new System.Drawing.Point(97, 172);
            this.TxTTelefon.Name = "TxTTelefon";
            this.TxTTelefon.Size = new System.Drawing.Size(127, 20);
            this.TxTTelefon.TabIndex = 40;
            // 
            // TxTDirecci
            // 
            this.TxTDirecci.Location = new System.Drawing.Point(97, 143);
            this.TxTDirecci.Name = "TxTDirecci";
            this.TxTDirecci.Size = new System.Drawing.Size(127, 20);
            this.TxTDirecci.TabIndex = 39;
            // 
            // TxtApeliido
            // 
            this.TxtApeliido.Location = new System.Drawing.Point(97, 117);
            this.TxtApeliido.Name = "TxtApeliido";
            this.TxtApeliido.Size = new System.Drawing.Size(127, 20);
            this.TxtApeliido.TabIndex = 38;
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(97, 90);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(127, 20);
            this.TxtNom.TabIndex = 37;
            // 
            // TxTC_C
            // 
            this.TxTC_C.Location = new System.Drawing.Point(97, 64);
            this.TxTC_C.Name = "TxTC_C";
            this.TxTC_C.Size = new System.Drawing.Size(127, 20);
            this.TxTC_C.TabIndex = 36;
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblTelefono.Location = new System.Drawing.Point(26, 179);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(57, 13);
            this.LblTelefono.TabIndex = 29;
            this.LblTelefono.Text = "Telefono";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDireccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblDireccion.Location = new System.Drawing.Point(26, 150);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(61, 13);
            this.LblDireccion.TabIndex = 28;
            this.LblDireccion.Text = "Direccion";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblApellido.Location = new System.Drawing.Point(26, 124);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(52, 13);
            this.LblApellido.TabIndex = 27;
            this.LblApellido.Text = "Apellido";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblNombre.Location = new System.Drawing.Point(26, 97);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(50, 13);
            this.LblNombre.TabIndex = 26;
            this.LblNombre.Text = "Nombre";
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCedula.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblCedula.Location = new System.Drawing.Point(26, 71);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(46, 13);
            this.LblCedula.TabIndex = 25;
            this.LblCedula.Text = "Cedula";
            this.LblCedula.Click += new System.EventHandler(this.LblCedula_Click);
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
            this.BtnMenu.Size = new System.Drawing.Size(49, 34);
            this.BtnMenu.TabIndex = 51;
            this.BtnMenu.Text = "Menu";
            this.BtnMenu.UseVisualStyleBackColor = false;
            this.BtnMenu.Click += new System.EventHandler(this.BtnMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnIngresa);
            this.panel1.Controls.Add(this.BtnColsultar);
            this.panel1.Controls.Add(this.BtnElimi);
            this.panel1.Controls.Add(this.BtnActualiza);
            this.panel1.Controls.Add(this.TxTDirecci);
            this.panel1.Controls.Add(this.LblCedula);
            this.panel1.Controls.Add(this.LblNombre);
            this.panel1.Controls.Add(this.LblApellido);
            this.panel1.Controls.Add(this.BtnMenu);
            this.panel1.Controls.Add(this.LblDireccion);
            this.panel1.Controls.Add(this.LblTelefono);
            this.panel1.Controls.Add(this.TxTTelefon);
            this.panel1.Controls.Add(this.TxTC_C);
            this.panel1.Controls.Add(this.TxtNom);
            this.panel1.Controls.Add(this.TxtApeliido);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 229);
            this.panel1.TabIndex = 59;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 38);
            this.label1.TabIndex = 65;
            this.label1.Text = "Cliente";
            // 
            // BtnIngresa
            // 
            this.BtnIngresa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnIngresa.FlatAppearance.BorderSize = 0;
            this.BtnIngresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnIngresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresa.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresa.Location = new System.Drawing.Point(262, 55);
            this.BtnIngresa.Name = "BtnIngresa";
            this.BtnIngresa.Size = new System.Drawing.Size(69, 29);
            this.BtnIngresa.TabIndex = 61;
            this.BtnIngresa.Text = "&Agregar";
            this.BtnIngresa.UseVisualStyleBackColor = false;
            this.BtnIngresa.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnColsultar
            // 
            this.BtnColsultar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnColsultar.FlatAppearance.BorderSize = 0;
            this.BtnColsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnColsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnColsultar.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnColsultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnColsultar.Location = new System.Drawing.Point(262, 97);
            this.BtnColsultar.Name = "BtnColsultar";
            this.BtnColsultar.Size = new System.Drawing.Size(76, 29);
            this.BtnColsultar.TabIndex = 62;
            this.BtnColsultar.Text = "&Consultar";
            this.BtnColsultar.UseVisualStyleBackColor = false;
            this.BtnColsultar.Click += new System.EventHandler(this.BtnColsultar_Click);
            // 
            // BtnElimi
            // 
            this.BtnElimi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnElimi.FlatAppearance.BorderSize = 0;
            this.BtnElimi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnElimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnElimi.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnElimi.Location = new System.Drawing.Point(262, 189);
            this.BtnElimi.Name = "BtnElimi";
            this.BtnElimi.Size = new System.Drawing.Size(72, 29);
            this.BtnElimi.TabIndex = 64;
            this.BtnElimi.Text = "&Eliminar";
            this.BtnElimi.UseVisualStyleBackColor = false;
            this.BtnElimi.Click += new System.EventHandler(this.BtnElimi_Click);
            // 
            // BtnActualiza
            // 
            this.BtnActualiza.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnActualiza.FlatAppearance.BorderSize = 0;
            this.BtnActualiza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnActualiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualiza.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualiza.Location = new System.Drawing.Point(262, 143);
            this.BtnActualiza.Name = "BtnActualiza";
            this.BtnActualiza.Size = new System.Drawing.Size(76, 29);
            this.BtnActualiza.TabIndex = 63;
            this.BtnActualiza.Text = "&Actualizar";
            this.BtnActualiza.UseVisualStyleBackColor = false;
            this.BtnActualiza.Click += new System.EventHandler(this.BtnActualiza_Click);
            // 
            // rapitiendas_Tabla_Sql
            // 
            this.rapitiendas_Tabla_Sql.DataSetName = "Rapitiendas_Tabla_Sql";
            this.rapitiendas_Tabla_Sql.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rapitiendasDataSet
            // 
            this.rapitiendasDataSet.DataSetName = "RapitiendasDataSet";
            this.rapitiendasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.rapitiendasDataSet;
            // 
            // ClienteTable
            // 
            this.ClienteTable.ClearBeforeFill = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "Cedula";
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TablaCliente
            // 
            this.TablaCliente.AllowUserToOrderColumns = true;
            this.TablaCliente.AutoGenerateColumns = false;
            this.TablaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedulaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn});
            this.TablaCliente.DataSource = this.clienteBindingSource;
            this.TablaCliente.Location = new System.Drawing.Point(12, 247);
            this.TablaCliente.Name = "TablaCliente";
            this.TablaCliente.Size = new System.Drawing.Size(364, 71);
            this.TablaCliente.TabIndex = 60;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(388, 322);
            this.Controls.Add(this.TablaCliente);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rapitiendas_Tabla_Sql)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapitiendasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxTTelefon;
        private System.Windows.Forms.TextBox TxTDirecci;
        private System.Windows.Forms.TextBox TxtApeliido;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.TextBox TxTC_C;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCedula;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnIngresa;
        private System.Windows.Forms.Button BtnColsultar;
        private System.Windows.Forms.Button BtnElimi;
        private System.Windows.Forms.Button BtnActualiza;
        private Rapitiendas_Tabla_Sql rapitiendas_Tabla_Sql;
        private RapitiendasDataSet rapitiendasDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private RapitiendasDataSetTableAdapters.ClienteTableAdapter ClienteTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView TablaCliente;
    }
}