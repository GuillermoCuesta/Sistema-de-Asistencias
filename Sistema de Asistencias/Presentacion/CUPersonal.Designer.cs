namespace Sistema_de_Asistencias.Presentacion
{
    partial class CUPersonal
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CUPersonal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxBuscarPers = new System.Windows.Forms.TextBox();
            this.panelPaginador = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelPagina = new System.Windows.Forms.Label();
            this.labelNumerador = new System.Windows.Forms.Label();
            this.labelDe = new System.Windows.Forms.Label();
            this.labelDenominador = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonPrimeraPg = new System.Windows.Forms.Button();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.buttonAdelante = new System.Windows.Forms.Button();
            this.buttonUltima = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPaginador.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.buttonMostrar);
            this.panel1.Controls.Add(this.buttonAgregar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBoxBuscarPers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 100);
            this.panel1.TabIndex = 0;
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMostrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonMostrar.Location = new System.Drawing.Point(559, 44);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(105, 34);
            this.buttonMostrar.TabIndex = 3;
            this.buttonMostrar.Text = "Mostrar";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAgregar.Image = global::Sistema_de_Asistencias.Properties.Resources.agregar_usuario;
            this.buttonAgregar.Location = new System.Drawing.Point(976, 21);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(67, 57);
            this.buttonAgregar.TabIndex = 2;
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_de_Asistencias.Properties.Resources.buscar;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(397, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBoxBuscarPers
            // 
            this.textBoxBuscarPers.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarPers.Location = new System.Drawing.Point(70, 46);
            this.textBoxBuscarPers.Name = "textBoxBuscarPers";
            this.textBoxBuscarPers.Size = new System.Drawing.Size(321, 27);
            this.textBoxBuscarPers.TabIndex = 0;
            // 
            // panelPaginador
            // 
            this.panelPaginador.Controls.Add(this.flowLayoutPanel3);
            this.panelPaginador.Controls.Add(this.flowLayoutPanel2);
            this.panelPaginador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPaginador.Location = new System.Drawing.Point(0, 620);
            this.panelPaginador.Name = "panelPaginador";
            this.panelPaginador.Size = new System.Drawing.Size(1113, 100);
            this.panelPaginador.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.labelPagina);
            this.flowLayoutPanel3.Controls.Add(this.labelNumerador);
            this.flowLayoutPanel3.Controls.Add(this.labelDe);
            this.flowLayoutPanel3.Controls.Add(this.labelDenominador);
            this.flowLayoutPanel3.Enabled = false;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(410, 22);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(264, 26);
            this.flowLayoutPanel3.TabIndex = 1;
            this.flowLayoutPanel3.WrapContents = false;
            // 
            // labelPagina
            // 
            this.labelPagina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPagina.Location = new System.Drawing.Point(3, 0);
            this.labelPagina.Name = "labelPagina";
            this.labelPagina.Size = new System.Drawing.Size(69, 23);
            this.labelPagina.TabIndex = 0;
            this.labelPagina.Text = "Pagina";
            // 
            // labelNumerador
            // 
            this.labelNumerador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNumerador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumerador.Location = new System.Drawing.Point(78, 0);
            this.labelNumerador.Name = "labelNumerador";
            this.labelNumerador.Size = new System.Drawing.Size(62, 23);
            this.labelNumerador.TabIndex = 1;
            this.labelNumerador.Text = "0";
            this.labelNumerador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDe
            // 
            this.labelDe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDe.Location = new System.Drawing.Point(146, 0);
            this.labelDe.Name = "labelDe";
            this.labelDe.Size = new System.Drawing.Size(44, 23);
            this.labelDe.TabIndex = 2;
            this.labelDe.Text = "de";
            // 
            // labelDenominador
            // 
            this.labelDenominador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDenominador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDenominador.Location = new System.Drawing.Point(196, 0);
            this.labelDenominador.Name = "labelDenominador";
            this.labelDenominador.Size = new System.Drawing.Size(65, 23);
            this.labelDenominador.TabIndex = 3;
            this.labelDenominador.Text = "0";
            this.labelDenominador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.Controls.Add(this.buttonPrimeraPg);
            this.flowLayoutPanel2.Controls.Add(this.buttonAtras);
            this.flowLayoutPanel2.Controls.Add(this.buttonAdelante);
            this.flowLayoutPanel2.Controls.Add(this.buttonUltima);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(374, 54);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(328, 41);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // buttonPrimeraPg
            // 
            this.buttonPrimeraPg.Image = global::Sistema_de_Asistencias.Properties.Resources.primera;
            this.buttonPrimeraPg.Location = new System.Drawing.Point(3, 3);
            this.buttonPrimeraPg.Name = "buttonPrimeraPg";
            this.buttonPrimeraPg.Size = new System.Drawing.Size(75, 29);
            this.buttonPrimeraPg.TabIndex = 0;
            this.buttonPrimeraPg.UseVisualStyleBackColor = true;
            // 
            // buttonAtras
            // 
            this.buttonAtras.Image = global::Sistema_de_Asistencias.Properties.Resources.izquierda;
            this.buttonAtras.Location = new System.Drawing.Point(84, 3);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(75, 29);
            this.buttonAtras.TabIndex = 1;
            this.buttonAtras.UseVisualStyleBackColor = true;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // buttonAdelante
            // 
            this.buttonAdelante.Image = global::Sistema_de_Asistencias.Properties.Resources.derecha;
            this.buttonAdelante.Location = new System.Drawing.Point(165, 3);
            this.buttonAdelante.Name = "buttonAdelante";
            this.buttonAdelante.Size = new System.Drawing.Size(75, 29);
            this.buttonAdelante.TabIndex = 2;
            this.buttonAdelante.UseVisualStyleBackColor = true;
            this.buttonAdelante.Click += new System.EventHandler(this.buttonAdelante_Click);
            // 
            // buttonUltima
            // 
            this.buttonUltima.Image = global::Sistema_de_Asistencias.Properties.Resources.ultima;
            this.buttonUltima.Location = new System.Drawing.Point(246, 3);
            this.buttonUltima.Name = "buttonUltima";
            this.buttonUltima.Size = new System.Drawing.Size(75, 29);
            this.buttonUltima.TabIndex = 3;
            this.buttonUltima.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(70, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(973, 485);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(70, 520);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1043, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(70, 520);
            this.panel4.TabIndex = 4;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(3, 3);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 32);
            this.buttonEliminar.TabIndex = 5;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(84, 3);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(74, 32);
            this.buttonEditar.TabIndex = 6;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightGray;
            this.flowLayoutPanel1.Controls.Add(this.buttonEliminar);
            this.flowLayoutPanel1.Controls.Add(this.buttonEditar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(70, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(973, 35);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CUPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelPaginador);
            this.Controls.Add(this.panel1);
            this.Name = "CUPersonal";
            this.Size = new System.Drawing.Size(1113, 720);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPaginador.ResumeLayout(false);
            this.panelPaginador.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPaginador;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxBuscarPers;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonPrimeraPg;
        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.Button buttonAdelante;
        private System.Windows.Forms.Button buttonUltima;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label labelPagina;
        private System.Windows.Forms.Label labelNumerador;
        private System.Windows.Forms.Label labelDe;
        private System.Windows.Forms.Label labelDenominador;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
    }
}
