namespace Sistema_de_Asistencias.Presentacion
{
    partial class CURegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CURegistro));
            this.panelRegistro = new System.Windows.Forms.Panel();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.comboBoxCargo = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonGuardarPersonal = new System.Windows.Forms.Button();
            this.buttonGuardarCamPersonal = new System.Windows.Forms.Button();
            this.comboBoxPais = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSueldo = new System.Windows.Forms.TextBox();
            this.textBoxIdent = new System.Windows.Forms.TextBox();
            this.textBoxNomApell = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            this.buttonAddCargo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.buttonTomarFoto = new System.Windows.Forms.Button();
            this.panelRegistro.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRegistro
            // 
            this.panelRegistro.BackColor = System.Drawing.Color.Silver;
            this.panelRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRegistro.Controls.Add(this.buttonTomarFoto);
            this.panelRegistro.Controls.Add(this.comboBoxEstado);
            this.panelRegistro.Controls.Add(this.panel1);
            this.panelRegistro.Controls.Add(this.pictureBoxUsuario);
            this.panelRegistro.Controls.Add(this.textBoxCodigo);
            this.panelRegistro.Controls.Add(this.labelCodigo);
            this.panelRegistro.Controls.Add(this.labelEstado);
            this.panelRegistro.Controls.Add(this.comboBoxCargo);
            this.panelRegistro.Controls.Add(this.buttonVolver);
            this.panelRegistro.Controls.Add(this.flowLayoutPanel1);
            this.panelRegistro.Controls.Add(this.buttonAddCargo);
            this.panelRegistro.Controls.Add(this.comboBoxPais);
            this.panelRegistro.Controls.Add(this.label5);
            this.panelRegistro.Controls.Add(this.textBoxSueldo);
            this.panelRegistro.Controls.Add(this.textBoxIdent);
            this.panelRegistro.Controls.Add(this.textBoxNomApell);
            this.panelRegistro.Controls.Add(this.label4);
            this.panelRegistro.Controls.Add(this.label3);
            this.panelRegistro.Controls.Add(this.label2);
            this.panelRegistro.Controls.Add(this.label1);
            this.panelRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRegistro.Location = new System.Drawing.Point(0, 0);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(1023, 316);
            this.panelRegistro.TabIndex = 6;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCodigo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigo.Location = new System.Drawing.Point(631, 251);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(52, 27);
            this.textBoxCodigo.TabIndex = 18;
            // 
            // labelCodigo
            // 
            this.labelCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(540, 251);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(75, 25);
            this.labelCodigo.TabIndex = 17;
            this.labelCodigo.Text = "Codigo";
            // 
            // labelEstado
            // 
            this.labelEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(307, 251);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(73, 25);
            this.labelEstado.TabIndex = 15;
            this.labelEstado.Text = "Estado";
            // 
            // comboBoxCargo
            // 
            this.comboBoxCargo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCargo.FormattingEnabled = true;
            this.comboBoxCargo.Location = new System.Drawing.Point(485, 152);
            this.comboBoxCargo.Name = "comboBoxCargo";
            this.comboBoxCargo.Size = new System.Drawing.Size(240, 33);
            this.comboBoxCargo.TabIndex = 14;
            this.comboBoxCargo.SelectionChangeCommitted += new System.EventHandler(this.comboBoxCargo_SelectionChangeCommitted);
            this.comboBoxCargo.TextChanged += new System.EventHandler(this.comboBoxCargo_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Controls.Add(this.buttonGuardarPersonal);
            this.flowLayoutPanel1.Controls.Add(this.buttonGuardarCamPersonal);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(720, 261);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(298, 45);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // buttonGuardarPersonal
            // 
            this.buttonGuardarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonGuardarPersonal.Location = new System.Drawing.Point(3, 3);
            this.buttonGuardarPersonal.Name = "buttonGuardarPersonal";
            this.buttonGuardarPersonal.Size = new System.Drawing.Size(105, 34);
            this.buttonGuardarPersonal.TabIndex = 0;
            this.buttonGuardarPersonal.Text = "Guardar";
            this.buttonGuardarPersonal.UseVisualStyleBackColor = true;
            this.buttonGuardarPersonal.Click += new System.EventHandler(this.buttonGuardarPersonal_Click);
            // 
            // buttonGuardarCamPersonal
            // 
            this.buttonGuardarCamPersonal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonGuardarCamPersonal.Location = new System.Drawing.Point(114, 3);
            this.buttonGuardarCamPersonal.Name = "buttonGuardarCamPersonal";
            this.buttonGuardarCamPersonal.Size = new System.Drawing.Size(176, 34);
            this.buttonGuardarCamPersonal.TabIndex = 1;
            this.buttonGuardarCamPersonal.Text = "Guardar Cambios";
            this.buttonGuardarCamPersonal.UseVisualStyleBackColor = true;
            this.buttonGuardarCamPersonal.Click += new System.EventHandler(this.buttonGuardarCamPersonal_Click);
            // 
            // comboBoxPais
            // 
            this.comboBoxPais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxPais.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPais.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPais.FormattingEnabled = true;
            this.comboBoxPais.Location = new System.Drawing.Point(486, 101);
            this.comboBoxPais.Name = "comboBoxPais";
            this.comboBoxPais.Size = new System.Drawing.Size(240, 33);
            this.comboBoxPais.Sorted = true;
            this.comboBoxPais.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cargo";
            // 
            // textBoxSueldo
            // 
            this.textBoxSueldo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSueldo.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSueldo.Location = new System.Drawing.Point(485, 204);
            this.textBoxSueldo.Name = "textBoxSueldo";
            this.textBoxSueldo.Size = new System.Drawing.Size(163, 27);
            this.textBoxSueldo.TabIndex = 7;
            this.textBoxSueldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSueldo_KeyPress);
            // 
            // textBoxIdent
            // 
            this.textBoxIdent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxIdent.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdent.Location = new System.Drawing.Point(485, 57);
            this.textBoxIdent.Name = "textBoxIdent";
            this.textBoxIdent.Size = new System.Drawing.Size(197, 27);
            this.textBoxIdent.TabIndex = 5;
            // 
            // textBoxNomApell
            // 
            this.textBoxNomApell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNomApell.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomApell.Location = new System.Drawing.Point(485, 16);
            this.textBoxNomApell.Name = "textBoxNomApell";
            this.textBoxNomApell.Size = new System.Drawing.Size(472, 27);
            this.textBoxNomApell.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sueldo por Hora";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pais";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificacion";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre y Apellido";
            // 
            // buttonVolver
            // 
            this.buttonVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonVolver.Image = global::Sistema_de_Asistencias.Properties.Resources.cerrar;
            this.buttonVolver.Location = new System.Drawing.Point(976, 0);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(45, 41);
            this.buttonVolver.TabIndex = 13;
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // pictureBoxUsuario
            // 
            this.pictureBoxUsuario.Image = global::Sistema_de_Asistencias.Properties.Resources.usuario2;
            this.pictureBoxUsuario.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsuario.InitialImage")));
            this.pictureBoxUsuario.Location = new System.Drawing.Point(26, 10);
            this.pictureBoxUsuario.Name = "pictureBoxUsuario";
            this.pictureBoxUsuario.Size = new System.Drawing.Size(209, 260);
            this.pictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUsuario.TabIndex = 19;
            this.pictureBoxUsuario.TabStop = false;
            // 
            // buttonAddCargo
            // 
            this.buttonAddCargo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddCargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddCargo.FlatAppearance.BorderSize = 0;
            this.buttonAddCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCargo.Image = global::Sistema_de_Asistencias.Properties.Resources.boton_agregar;
            this.buttonAddCargo.Location = new System.Drawing.Point(826, 147);
            this.buttonAddCargo.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddCargo.Name = "buttonAddCargo";
            this.buttonAddCargo.Size = new System.Drawing.Size(45, 44);
            this.buttonAddCargo.TabIndex = 11;
            this.buttonAddCargo.UseVisualStyleBackColor = true;
            this.buttonAddCargo.Click += new System.EventHandler(this.buttonAddCargo_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.panel1.Location = new System.Drawing.Point(253, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 316);
            this.panel1.TabIndex = 20;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Activo",
            "Eliminado"});
            this.comboBoxEstado.Location = new System.Drawing.Point(386, 251);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(133, 33);
            this.comboBoxEstado.TabIndex = 21;
            // 
            // buttonTomarFoto
            // 
            this.buttonTomarFoto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonTomarFoto.Location = new System.Drawing.Point(69, 279);
            this.buttonTomarFoto.Name = "buttonTomarFoto";
            this.buttonTomarFoto.Size = new System.Drawing.Size(119, 27);
            this.buttonTomarFoto.TabIndex = 22;
            this.buttonTomarFoto.Text = "Tomar Foto";
            this.buttonTomarFoto.UseVisualStyleBackColor = true;
            this.buttonTomarFoto.Click += new System.EventHandler(this.buttonTomarFoto_Click);
            // 
            // CURegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.buttonVolver;
            this.ClientSize = new System.Drawing.Size(1023, 316);
            this.Controls.Add(this.panelRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CURegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CURegistro";
            this.Load += new System.EventHandler(this.CURegistro_Load);
            this.panelRegistro.ResumeLayout(false);
            this.panelRegistro.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRegistro;
        private System.Windows.Forms.ComboBox comboBoxCargo;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonGuardarPersonal;
        private System.Windows.Forms.Button buttonGuardarCamPersonal;
        private System.Windows.Forms.Button buttonAddCargo;
        private System.Windows.Forms.ComboBox comboBoxPais;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSueldo;
        private System.Windows.Forms.TextBox textBoxIdent;
        private System.Windows.Forms.TextBox textBoxNomApell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.PictureBox pictureBoxUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Button buttonTomarFoto;
    }
}