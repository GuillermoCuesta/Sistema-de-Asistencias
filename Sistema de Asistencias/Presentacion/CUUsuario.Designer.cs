namespace Sistema_de_Asistencias.Presentacion
{
    partial class CUUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CUUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxBuscarPers = new System.Windows.Forms.TextBox();
            this.panelPaginador = new System.Windows.Forms.Panel();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonGuardarUsuario = new System.Windows.Forms.Button();
            this.buttonGuardarCamUsuario = new System.Windows.Forms.Button();
            this.buttonCambiarEstado = new System.Windows.Forms.Button();
            this.buttonEditarUsuario = new System.Windows.Forms.Button();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxNomApell = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.checkedListBoxPermisos = new System.Windows.Forms.CheckedListBox();
            this.labelPermisos = new System.Windows.Forms.Label();
            this.panelRegistro = new System.Windows.Forms.Panel();
            this.buttonIcono = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBoxIcono = new System.Windows.Forms.PictureBox();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPaginador.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.buttonAgregar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBoxBuscarPers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 100);
            this.panel1.TabIndex = 1;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAgregar.Image = global::Sistema_de_Asistencias.Properties.Resources.agregar_usuario;
            this.buttonAgregar.Location = new System.Drawing.Point(1015, 21);
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
            this.panelPaginador.Controls.Add(this.buttonActualizar);
            this.panelPaginador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPaginador.Location = new System.Drawing.Point(0, 696);
            this.panelPaginador.Name = "panelPaginador";
            this.panelPaginador.Size = new System.Drawing.Size(1152, 58);
            this.panelPaginador.TabIndex = 2;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonActualizar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonActualizar.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonActualizar.Location = new System.Drawing.Point(524, 6);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(105, 34);
            this.buttonActualizar.TabIndex = 2;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = false;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(70, 596);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1082, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(70, 596);
            this.panel4.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightGray;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.buttonGuardarUsuario);
            this.flowLayoutPanel1.Controls.Add(this.buttonGuardarCamUsuario);
            this.flowLayoutPanel1.Controls.Add(this.buttonCambiarEstado);
            this.flowLayoutPanel1.Controls.Add(this.buttonEditarUsuario);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(70, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1012, 40);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // buttonGuardarUsuario
            // 
            this.buttonGuardarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonGuardarUsuario.Location = new System.Drawing.Point(3, 1);
            this.buttonGuardarUsuario.Name = "buttonGuardarUsuario";
            this.buttonGuardarUsuario.Size = new System.Drawing.Size(105, 34);
            this.buttonGuardarUsuario.TabIndex = 0;
            this.buttonGuardarUsuario.Text = "Guardar";
            this.buttonGuardarUsuario.UseVisualStyleBackColor = true;
            this.buttonGuardarUsuario.Visible = false;
            this.buttonGuardarUsuario.Click += new System.EventHandler(this.buttonGuardarUsuario_Click);
            // 
            // buttonGuardarCamUsuario
            // 
            this.buttonGuardarCamUsuario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonGuardarCamUsuario.Location = new System.Drawing.Point(114, 1);
            this.buttonGuardarCamUsuario.Name = "buttonGuardarCamUsuario";
            this.buttonGuardarCamUsuario.Size = new System.Drawing.Size(176, 34);
            this.buttonGuardarCamUsuario.TabIndex = 1;
            this.buttonGuardarCamUsuario.Text = "Guardar Cambios";
            this.buttonGuardarCamUsuario.UseVisualStyleBackColor = true;
            this.buttonGuardarCamUsuario.Visible = false;
            this.buttonGuardarCamUsuario.Click += new System.EventHandler(this.buttonGuardarCamUsuario_Click);
            // 
            // buttonCambiarEstado
            // 
            this.buttonCambiarEstado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCambiarEstado.Location = new System.Drawing.Point(296, 1);
            this.buttonCambiarEstado.Name = "buttonCambiarEstado";
            this.buttonCambiarEstado.Size = new System.Drawing.Size(130, 34);
            this.buttonCambiarEstado.TabIndex = 2;
            this.buttonCambiarEstado.Text = "Cambiar Estado";
            this.buttonCambiarEstado.UseVisualStyleBackColor = true;
            this.buttonCambiarEstado.Click += new System.EventHandler(this.buttonCambiarEstado_Click);
            // 
            // buttonEditarUsuario
            // 
            this.buttonEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEditarUsuario.Location = new System.Drawing.Point(432, 1);
            this.buttonEditarUsuario.Name = "buttonEditarUsuario";
            this.buttonEditarUsuario.Size = new System.Drawing.Size(130, 34);
            this.buttonEditarUsuario.TabIndex = 3;
            this.buttonEditarUsuario.Text = "Editar Usuario";
            this.buttonEditarUsuario.UseVisualStyleBackColor = true;
            this.buttonEditarUsuario.Click += new System.EventHandler(this.buttonEditarUsuario_Click);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsuario.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(498, 58);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(197, 27);
            this.textBoxUsuario.TabIndex = 12;
            // 
            // textBoxNomApell
            // 
            this.textBoxNomApell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNomApell.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomApell.Location = new System.Drawing.Point(498, 17);
            this.textBoxNomApell.Name = "textBoxNomApell";
            this.textBoxNomApell.Size = new System.Drawing.Size(396, 27);
            this.textBoxNomApell.TabIndex = 11;
            // 
            // labelUsuario
            // 
            this.labelUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(394, 58);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(79, 25);
            this.labelUsuario.TabIndex = 10;
            this.labelUsuario.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre y Apellido";
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxContraseña.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseña.Location = new System.Drawing.Point(498, 101);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(197, 27);
            this.textBoxContraseña.TabIndex = 14;
            // 
            // labelContraseña
            // 
            this.labelContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.Location = new System.Drawing.Point(359, 101);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(114, 25);
            this.labelContraseña.TabIndex = 13;
            this.labelContraseña.Text = "Contraseña";
            // 
            // checkedListBoxPermisos
            // 
            this.checkedListBoxPermisos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkedListBoxPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxPermisos.FormattingEnabled = true;
            this.checkedListBoxPermisos.Location = new System.Drawing.Point(498, 146);
            this.checkedListBoxPermisos.Name = "checkedListBoxPermisos";
            this.checkedListBoxPermisos.Size = new System.Drawing.Size(290, 104);
            this.checkedListBoxPermisos.TabIndex = 24;
            // 
            // labelPermisos
            // 
            this.labelPermisos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPermisos.AutoSize = true;
            this.labelPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPermisos.Location = new System.Drawing.Point(374, 146);
            this.labelPermisos.Name = "labelPermisos";
            this.labelPermisos.Size = new System.Drawing.Size(99, 25);
            this.labelPermisos.TabIndex = 25;
            this.labelPermisos.Text = "Permisos:";
            // 
            // panelRegistro
            // 
            this.panelRegistro.BackColor = System.Drawing.Color.Silver;
            this.panelRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRegistro.Controls.Add(this.checkedListBoxPermisos);
            this.panelRegistro.Controls.Add(this.buttonIcono);
            this.panelRegistro.Controls.Add(this.labelPermisos);
            this.panelRegistro.Controls.Add(this.label1);
            this.panelRegistro.Controls.Add(this.labelUsuario);
            this.panelRegistro.Controls.Add(this.panel5);
            this.panelRegistro.Controls.Add(this.pictureBoxIcono);
            this.panelRegistro.Controls.Add(this.textBoxNomApell);
            this.panelRegistro.Controls.Add(this.textBoxUsuario);
            this.panelRegistro.Controls.Add(this.textBoxContraseña);
            this.panelRegistro.Controls.Add(this.labelContraseña);
            this.panelRegistro.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRegistro.Location = new System.Drawing.Point(70, 140);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(1012, 280);
            this.panelRegistro.TabIndex = 27;
            this.panelRegistro.Visible = false;
            // 
            // buttonIcono
            // 
            this.buttonIcono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonIcono.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonIcono.Location = new System.Drawing.Point(26, 227);
            this.buttonIcono.Name = "buttonIcono";
            this.buttonIcono.Size = new System.Drawing.Size(209, 31);
            this.buttonIcono.TabIndex = 22;
            this.buttonIcono.Text = "Seleccionar Icono";
            this.buttonIcono.UseVisualStyleBackColor = true;
            this.buttonIcono.Click += new System.EventHandler(this.buttonIcono_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(204)))));
            this.panel5.Location = new System.Drawing.Point(253, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 316);
            this.panel5.TabIndex = 20;
            // 
            // pictureBoxIcono
            // 
            this.pictureBoxIcono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxIcono.Image = global::Sistema_de_Asistencias.Properties.Resources.usuario2;
            this.pictureBoxIcono.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcono.InitialImage")));
            this.pictureBoxIcono.Location = new System.Drawing.Point(26, 10);
            this.pictureBoxIcono.Name = "pictureBoxIcono";
            this.pictureBoxIcono.Size = new System.Drawing.Size(209, 209);
            this.pictureBoxIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcono.TabIndex = 19;
            this.pictureBoxIcono.TabStop = false;
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.AllowUserToAddRows = false;
            this.dataGridViewUsuarios.AllowUserToDeleteRows = false;
            this.dataGridViewUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsuarios.BackgroundColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsuarios.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(70, 420);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.ReadOnly = true;
            this.dataGridViewUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewUsuarios.RowTemplate.Height = 24;
            this.dataGridViewUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(1012, 276);
            this.dataGridViewUsuarios.TabIndex = 28;
            // 
            // CUUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Controls.Add(this.panelRegistro);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelPaginador);
            this.Controls.Add(this.panel1);
            this.Name = "CUUsuario";
            this.Size = new System.Drawing.Size(1152, 754);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPaginador.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelRegistro.ResumeLayout(false);
            this.panelRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxBuscarPers;
        private System.Windows.Forms.Panel panelPaginador;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonGuardarUsuario;
        private System.Windows.Forms.Button buttonGuardarCamUsuario;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxNomApell;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.CheckedListBox checkedListBoxPermisos;
        private System.Windows.Forms.Label labelPermisos;
        private System.Windows.Forms.Panel panelRegistro;
        private System.Windows.Forms.Button buttonIcono;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBoxIcono;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonCambiarEstado;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.Button buttonEditarUsuario;
    }
}
