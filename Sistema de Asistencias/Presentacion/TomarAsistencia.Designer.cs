namespace Sistema_de_Asistencias.Presentacion
{
    partial class TomarAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TomarAsistencia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelObser = new System.Windows.Forms.Label();
            this.textBoxObservaciones = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelF = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.labelRegistroAsis = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxIdentAsis = new System.Windows.Forms.TextBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labelNombre);
            this.panel1.Controls.Add(this.labelObser);
            this.panel1.Controls.Add(this.textBoxObservaciones);
            this.panel1.Controls.Add(this.buttonBuscar);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.buttonConfirmar);
            this.panel1.Controls.Add(this.labelRegistroAsis);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBoxIdentAsis);
            this.panel1.Controls.Add(this.labelEstado);
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(221, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 834);
            this.panel1.TabIndex = 0;
            // 
            // labelNombre
            // 
            this.labelNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNombre.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.Black;
            this.labelNombre.Location = new System.Drawing.Point(94, 244);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(3);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(365, 35);
            this.labelNombre.TabIndex = 8;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelObser
            // 
            this.labelObser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelObser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelObser.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObser.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelObser.Location = new System.Drawing.Point(108, 513);
            this.labelObser.Margin = new System.Windows.Forms.Padding(10);
            this.labelObser.Name = "labelObser";
            this.labelObser.Padding = new System.Windows.Forms.Padding(10);
            this.labelObser.Size = new System.Drawing.Size(351, 60);
            this.labelObser.TabIndex = 8;
            this.labelObser.Text = "Observaciones";
            this.labelObser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxObservaciones
            // 
            this.textBoxObservaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxObservaciones.Location = new System.Drawing.Point(94, 581);
            this.textBoxObservaciones.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxObservaciones.Multiline = true;
            this.textBoxObservaciones.Name = "textBoxObservaciones";
            this.textBoxObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxObservaciones.Size = new System.Drawing.Size(380, 162);
            this.textBoxObservaciones.TabIndex = 4;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBuscar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonBuscar.Location = new System.Drawing.Point(358, 297);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(101, 38);
            this.buttonBuscar.TabIndex = 13;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelF, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelHora, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelFecha, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelH, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(108, 400);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(339, 100);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // labelF
            // 
            this.labelF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelF.AutoSize = true;
            this.labelF.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.labelF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelF.ForeColor = System.Drawing.Color.Black;
            this.labelF.Location = new System.Drawing.Point(32, 9);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(105, 31);
            this.labelF.TabIndex = 5;
            this.labelF.Text = "Fecha :";
            this.labelF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHora
            // 
            this.labelHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHora.AutoSize = true;
            this.labelHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHora.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelHora.Location = new System.Drawing.Point(216, 57);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(75, 35);
            this.labelHora.TabIndex = 7;
            this.labelHora.Text = "hora";
            this.labelHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFecha
            // 
            this.labelFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFecha.AutoSize = true;
            this.labelFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFecha.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelFecha.Location = new System.Drawing.Point(210, 7);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(88, 35);
            this.labelFecha.TabIndex = 6;
            this.labelFecha.Text = "fecha";
            this.labelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelH
            // 
            this.labelH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelH.AutoSize = true;
            this.labelH.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.labelH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelH.ForeColor = System.Drawing.Color.Black;
            this.labelH.Location = new System.Drawing.Point(40, 59);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(88, 31);
            this.labelH.TabIndex = 4;
            this.labelH.Text = "Hora :";
            this.labelH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.buttonConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonConfirmar.Location = new System.Drawing.Point(177, 756);
            this.buttonConfirmar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(201, 54);
            this.buttonConfirmar.TabIndex = 9;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonConfirmar.UseVisualStyleBackColor = false;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // labelRegistroAsis
            // 
            this.labelRegistroAsis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelRegistroAsis.AutoSize = true;
            this.labelRegistroAsis.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelRegistroAsis.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistroAsis.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.labelRegistroAsis.Location = new System.Drawing.Point(127, 189);
            this.labelRegistroAsis.Name = "labelRegistroAsis";
            this.labelRegistroAsis.Size = new System.Drawing.Size(304, 33);
            this.labelRegistroAsis.TabIndex = 1;
            this.labelRegistroAsis.Text = "Registro de Asistencia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(191, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxIdentAsis
            // 
            this.textBoxIdentAsis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxIdentAsis.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdentAsis.ForeColor = System.Drawing.Color.Gray;
            this.textBoxIdentAsis.Location = new System.Drawing.Point(94, 297);
            this.textBoxIdentAsis.Name = "textBoxIdentAsis";
            this.textBoxIdentAsis.Size = new System.Drawing.Size(260, 38);
            this.textBoxIdentAsis.TabIndex = 2;
            this.textBoxIdentAsis.Text = "Identificacion";
            this.textBoxIdentAsis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelEstado
            // 
            this.labelEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEstado.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.labelEstado.Location = new System.Drawing.Point(127, 354);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(304, 33);
            this.labelEstado.TabIndex = 9;
            this.labelEstado.Text = "---------------";
            this.labelEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1027, 38);
            this.panel2.TabIndex = 1;
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // TomarAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1027, 884);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "TomarAsistencia";
            this.Text = "Tomar Asistencia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxIdentAsis;
        private System.Windows.Forms.Label labelRegistroAsis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxObservaciones;
        private System.Windows.Forms.Label labelF;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelObser;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonBuscar;
    }
}