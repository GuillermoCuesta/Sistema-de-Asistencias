namespace Sistema_de_Asistencias.Presentacion
{
    partial class CUCargo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCargo = new System.Windows.Forms.Panel();
            this.buttonRegresarCargo = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonGuardarCarg = new System.Windows.Forms.Button();
            this.buttonGuardarCCarg = new System.Windows.Forms.Button();
            this.textBoxCargoNew = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSueldoNew = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ListadoCargos = new System.Windows.Forms.DataGridView();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.panelCargo.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCargo
            // 
            this.panelCargo.BackColor = System.Drawing.Color.LightGray;
            this.panelCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCargo.Controls.Add(this.buttonRegresarCargo);
            this.panelCargo.Controls.Add(this.flowLayoutPanel4);
            this.panelCargo.Controls.Add(this.textBoxCargoNew);
            this.panelCargo.Controls.Add(this.label6);
            this.panelCargo.Controls.Add(this.textBoxSueldoNew);
            this.panelCargo.Controls.Add(this.label7);
            this.panelCargo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCargo.Location = new System.Drawing.Point(0, 0);
            this.panelCargo.Name = "panelCargo";
            this.panelCargo.Size = new System.Drawing.Size(532, 335);
            this.panelCargo.TabIndex = 7;
            // 
            // buttonRegresarCargo
            // 
            this.buttonRegresarCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRegresarCargo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonRegresarCargo.Image = global::Sistema_de_Asistencias.Properties.Resources.girar_a_la_izquierda;
            this.buttonRegresarCargo.Location = new System.Drawing.Point(494, 3);
            this.buttonRegresarCargo.Name = "buttonRegresarCargo";
            this.buttonRegresarCargo.Size = new System.Drawing.Size(34, 33);
            this.buttonRegresarCargo.TabIndex = 20;
            this.buttonRegresarCargo.UseVisualStyleBackColor = true;
            this.buttonRegresarCargo.Click += new System.EventHandler(this.buttonRegresarCargo_Click_1);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel4.Controls.Add(this.buttonGuardarCarg);
            this.flowLayoutPanel4.Controls.Add(this.buttonGuardarCCarg);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(121, 215);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(298, 45);
            this.flowLayoutPanel4.TabIndex = 19;
            // 
            // buttonGuardarCarg
            // 
            this.buttonGuardarCarg.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonGuardarCarg.Location = new System.Drawing.Point(3, 3);
            this.buttonGuardarCarg.Name = "buttonGuardarCarg";
            this.buttonGuardarCarg.Size = new System.Drawing.Size(105, 34);
            this.buttonGuardarCarg.TabIndex = 3;
            this.buttonGuardarCarg.Text = "Guardar";
            this.buttonGuardarCarg.UseVisualStyleBackColor = true;
            this.buttonGuardarCarg.Click += new System.EventHandler(this.buttonGuardarCarg_Click);
            // 
            // buttonGuardarCCarg
            // 
            this.buttonGuardarCCarg.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonGuardarCCarg.Location = new System.Drawing.Point(114, 3);
            this.buttonGuardarCCarg.Name = "buttonGuardarCCarg";
            this.buttonGuardarCCarg.Size = new System.Drawing.Size(176, 34);
            this.buttonGuardarCCarg.TabIndex = 4;
            this.buttonGuardarCCarg.Text = "Guardar Cambios";
            this.buttonGuardarCCarg.UseVisualStyleBackColor = true;
            this.buttonGuardarCCarg.Click += new System.EventHandler(this.buttonGuardarCCarg_Click);
            // 
            // textBoxCargoNew
            // 
            this.textBoxCargoNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCargoNew.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCargoNew.Location = new System.Drawing.Point(192, 99);
            this.textBoxCargoNew.Name = "textBoxCargoNew";
            this.textBoxCargoNew.Size = new System.Drawing.Size(326, 27);
            this.textBoxCargoNew.TabIndex = 1;
            this.textBoxCargoNew.TextChanged += new System.EventHandler(this.textBoxCargoNew_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cargo";
            // 
            // textBoxSueldoNew
            // 
            this.textBoxSueldoNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSueldoNew.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSueldoNew.Location = new System.Drawing.Point(192, 141);
            this.textBoxSueldoNew.Name = "textBoxSueldoNew";
            this.textBoxSueldoNew.Size = new System.Drawing.Size(163, 27);
            this.textBoxSueldoNew.TabIndex = 2;
            this.textBoxSueldoNew.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSueldoNew_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sueldo por Hora";
            // 
            // ListadoCargos
            // 
            this.ListadoCargos.AllowUserToDeleteRows = false;
            this.ListadoCargos.AllowUserToResizeRows = false;
            this.ListadoCargos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.ListadoCargos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListadoCargos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ListadoCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoCargos.Dock = System.Windows.Forms.DockStyle.Right;
            this.ListadoCargos.Location = new System.Drawing.Point(538, 0);
            this.ListadoCargos.Name = "ListadoCargos";
            this.ListadoCargos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ListadoCargos.RowHeadersVisible = false;
            this.ListadoCargos.RowHeadersWidth = 10;
            this.ListadoCargos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ListadoCargos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.ListadoCargos.RowTemplate.Height = 24;
            this.ListadoCargos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ListadoCargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListadoCargos.Size = new System.Drawing.Size(267, 335);
            this.ListadoCargos.TabIndex = 8;
            this.ListadoCargos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListadoCargos_CellClick);
            // 
            // CUCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.CancelButton = this.buttonRegresarCargo;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(805, 335);
            this.Controls.Add(this.ListadoCargos);
            this.Controls.Add(this.panelCargo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "CUCargo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir Cargo";
            this.Load += new System.EventHandler(this.CUCargo_Load);
            this.panelCargo.ResumeLayout(false);
            this.panelCargo.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoCargos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCargo;
        private System.Windows.Forms.Button buttonRegresarCargo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button buttonGuardarCarg;
        private System.Windows.Forms.Button buttonGuardarCCarg;
        private System.Windows.Forms.TextBox textBoxCargoNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSueldoNew;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView ListadoCargos;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    }
}