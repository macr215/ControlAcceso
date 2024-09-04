namespace ControlAcceso
{
    partial class FrmUsuario
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
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.ListView2 = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListView1 = new System.Windows.Forms.ListView();
            this.Privilegios = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnquitar = new System.Windows.Forms.Button();
            this.btnAgrgar = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtcontraseña2 = new System.Windows.Forms.TextBox();
            this.txtnombrecuenta = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.GroupBox4.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.Button3);
            this.GroupBox4.Controls.Add(this.btnGuardar);
            this.GroupBox4.Controls.Add(this.Button4);
            this.GroupBox4.Location = new System.Drawing.Point(5, 462);
            this.GroupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox4.Size = new System.Drawing.Size(977, 69);
            this.GroupBox4.TabIndex = 30;
            this.GroupBox4.TabStop = false;
            // 
            // Button3
            // 
            this.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button3.Location = new System.Drawing.Point(796, 18);
            this.Button3.Margin = new System.Windows.Forms.Padding(4);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(159, 43);
            this.Button3.TabIndex = 2;
            this.Button3.Text = "&Cancelar";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(423, 18);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(159, 42);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Button4
            // 
            this.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button4.Location = new System.Drawing.Point(16, 18);
            this.Button4.Margin = new System.Windows.Forms.Padding(4);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(159, 42);
            this.Button4.TabIndex = 0;
            this.Button4.Text = "&Nuevo";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // ListView2
            // 
            this.ListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2});
            this.ListView2.Enabled = false;
            this.ListView2.FullRowSelect = true;
            this.ListView2.GridLines = true;
            this.ListView2.Location = new System.Drawing.Point(4, 4);
            this.ListView2.Margin = new System.Windows.Forms.Padding(4);
            this.ListView2.MultiSelect = false;
            this.ListView2.Name = "ListView2";
            this.ListView2.Size = new System.Drawing.Size(426, 240);
            this.ListView2.TabIndex = 13;
            this.ListView2.UseCompatibleStateImageBehavior = false;
            this.ListView2.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Privilegios Asignados";
            this.ColumnHeader1.Width = 338;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Codigo";
            this.ColumnHeader2.Width = 78;
            // 
            // ListView1
            // 
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Privilegios,
            this.codigo});
            this.ListView1.Enabled = false;
            this.ListView1.FullRowSelect = true;
            this.ListView1.GridLines = true;
            this.ListView1.Location = new System.Drawing.Point(4, 4);
            this.ListView1.Margin = new System.Windows.Forms.Padding(4);
            this.ListView1.MultiSelect = false;
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(429, 235);
            this.ListView1.TabIndex = 12;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // Privilegios
            // 
            this.Privilegios.Text = "Privilegios";
            this.Privilegios.Width = 342;
            // 
            // codigo
            // 
            this.codigo.Text = "Codigo";
            this.codigo.Width = 69;
            // 
            // btnquitar
            // 
            this.btnquitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquitar.Location = new System.Drawing.Point(453, 332);
            this.btnquitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnquitar.Name = "btnquitar";
            this.btnquitar.Size = new System.Drawing.Size(84, 46);
            this.btnquitar.TabIndex = 27;
            this.btnquitar.Text = "<";
            this.btnquitar.UseVisualStyleBackColor = true;
            this.btnquitar.Click += new System.EventHandler(this.btnquitar_Click);
            // 
            // btnAgrgar
            // 
            this.btnAgrgar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgrgar.Location = new System.Drawing.Point(453, 283);
            this.btnAgrgar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgrgar.Name = "btnAgrgar";
            this.btnAgrgar.Size = new System.Drawing.Size(84, 41);
            this.btnAgrgar.TabIndex = 26;
            this.btnAgrgar.Text = ">";
            this.btnAgrgar.UseVisualStyleBackColor = true;
            this.btnAgrgar.Click += new System.EventHandler(this.btnAgrgar_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.kryptonLabel4);
            this.GroupBox1.Controls.Add(this.kryptonLabel3);
            this.GroupBox1.Controls.Add(this.kryptonLabel2);
            this.GroupBox1.Controls.Add(this.kryptonLabel1);
            this.GroupBox1.Controls.Add(this.txtNombres);
            this.GroupBox1.Controls.Add(this.txtcontraseña2);
            this.GroupBox1.Controls.Add(this.txtnombrecuenta);
            this.GroupBox1.Controls.Add(this.txtcontraseña);
            this.GroupBox1.Enabled = false;
            this.GroupBox1.Location = new System.Drawing.Point(4, 28);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(990, 146);
            this.GroupBox1.TabIndex = 24;
            this.GroupBox1.TabStop = false;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel4.Location = new System.Drawing.Point(18, 109);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(149, 24);
            this.kryptonLabel4.TabIndex = 34;
            this.kryptonLabel4.Values.Text = "Repita constraseña";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel3.Location = new System.Drawing.Point(18, 79);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(93, 24);
            this.kryptonLabel3.TabIndex = 33;
            this.kryptonLabel3.Values.Text = "Contraseña";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(18, 51);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(131, 24);
            this.kryptonLabel2.TabIndex = 32;
            this.kryptonLabel2.Values.Text = "Nombre Usuario";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(17, 22);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(164, 24);
            this.kryptonLabel1.TabIndex = 31;
            this.kryptonLabel1.Values.Text = "Apellidos Y Nombres";
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.Location = new System.Drawing.Point(193, 23);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(525, 22);
            this.txtNombres.TabIndex = 1;
            // 
            // txtcontraseña2
            // 
            this.txtcontraseña2.Location = new System.Drawing.Point(193, 111);
            this.txtcontraseña2.Margin = new System.Windows.Forms.Padding(4);
            this.txtcontraseña2.Name = "txtcontraseña2";
            this.txtcontraseña2.Size = new System.Drawing.Size(220, 22);
            this.txtcontraseña2.TabIndex = 6;
            this.txtcontraseña2.UseSystemPasswordChar = true;
            // 
            // txtnombrecuenta
            // 
            this.txtnombrecuenta.Location = new System.Drawing.Point(193, 51);
            this.txtnombrecuenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombrecuenta.Name = "txtnombrecuenta";
            this.txtnombrecuenta.Size = new System.Drawing.Size(220, 22);
            this.txtnombrecuenta.TabIndex = 2;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(193, 81);
            this.txtcontraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(220, 22);
            this.txtcontraseña.TabIndex = 4;
            this.txtcontraseña.UseSystemPasswordChar = true;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonListItem;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(5, 181);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.ListView1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(441, 277);
            this.kryptonGroupBox1.TabIndex = 35;
            this.kryptonGroupBox1.Values.Heading = "Lista de Privilegios";
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label6.Location = new System.Drawing.Point(0, 0);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(994, 29);
            this.Label6.TabIndex = 25;
            this.Label6.Text = "INGRESO DE NUEVO USUARIO";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonListItem;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(544, 176);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.ListView2);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(438, 282);
            this.kryptonGroupBox2.TabIndex = 36;
            this.kryptonGroupBox2.Values.Heading = "Privilegios Asignados";
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 549);
            this.Controls.Add(this.kryptonGroupBox2);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.btnquitar);
            this.Controls.Add(this.btnAgrgar);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.GroupBox1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.ListView ListView2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ListView ListView1;
        internal System.Windows.Forms.ColumnHeader Privilegios;
        internal System.Windows.Forms.ColumnHeader codigo;
        internal System.Windows.Forms.Button btnquitar;
        internal System.Windows.Forms.Button btnAgrgar;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtNombres;
        internal System.Windows.Forms.TextBox txtcontraseña2;
        internal System.Windows.Forms.TextBox txtnombrecuenta;
        internal System.Windows.Forms.TextBox txtcontraseña;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        internal System.Windows.Forms.Label Label6;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
    }
}