﻿namespace Sanatorio.Vista
{
    partial class frmRegistros
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.lblCerrar = new System.Windows.Forms.Label();
			this.dataGridRegsitros = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.diagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.proxima_visita = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idpaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idmedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridRegsitros)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(242, 25);
			this.label1.TabIndex = 8;
			this.label1.Text = "Listado de Registro Clinico";
			// 
			// btnNuevo
			// 
			this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(89)))), ((int)(((byte)(53)))));
			this.btnNuevo.FlatAppearance.BorderSize = 0;
			this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
			this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
			this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNuevo.ImageIndex = 0;
			this.btnNuevo.Location = new System.Drawing.Point(43, 526);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(144, 34);
			this.btnNuevo.TabIndex = 3;
			this.btnNuevo.Text = "Nuevo (F2)";
			this.btnNuevo.UseVisualStyleBackColor = false;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// lblCerrar
			// 
			this.lblCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblCerrar.AutoSize = true;
			this.lblCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(219)))), ((int)(((byte)(183)))));
			this.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblCerrar.Location = new System.Drawing.Point(1028, 4);
			this.lblCerrar.Name = "lblCerrar";
			this.lblCerrar.Size = new System.Drawing.Size(19, 18);
			this.lblCerrar.TabIndex = 7;
			this.lblCerrar.Text = "X";
			this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
			// 
			// dataGridRegsitros
			// 
			this.dataGridRegsitros.AllowUserToAddRows = false;
			this.dataGridRegsitros.AllowUserToDeleteRows = false;
			this.dataGridRegsitros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dataGridRegsitros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(219)))), ((int)(((byte)(183)))));
			this.dataGridRegsitros.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridRegsitros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dataGridRegsitros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(89)))), ((int)(((byte)(53)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(89)))), ((int)(((byte)(53)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridRegsitros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridRegsitros.ColumnHeadersHeight = 30;
			this.dataGridRegsitros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridRegsitros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.paciente,
            this.medico,
            this.fecha,
            this.hora,
            this.motivo,
            this.diagnostico,
            this.tratamiento,
            this.proxima_visita,
            this.observacion,
            this.idpaciente,
            this.idmedico});
			this.dataGridRegsitros.EnableHeadersVisualStyles = false;
			this.dataGridRegsitros.GridColor = System.Drawing.Color.White;
			this.dataGridRegsitros.Location = new System.Drawing.Point(17, 77);
			this.dataGridRegsitros.Name = "dataGridRegsitros";
			this.dataGridRegsitros.ReadOnly = true;
			this.dataGridRegsitros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataGridRegsitros.RowHeadersVisible = false;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(162)))), ((int)(((byte)(103)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(89)))), ((int)(((byte)(53)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			this.dataGridRegsitros.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridRegsitros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridRegsitros.Size = new System.Drawing.Size(1021, 376);
			this.dataGridRegsitros.TabIndex = 7;
			this.dataGridRegsitros.DoubleClick += new System.EventHandler(this.dataGridRegsitros_DoubleClick);
			// 
			// id
			// 
			this.id.HeaderText = "ID";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Width = 35;
			// 
			// paciente
			// 
			this.paciente.HeaderText = "Paciente";
			this.paciente.Name = "paciente";
			this.paciente.ReadOnly = true;
			// 
			// medico
			// 
			this.medico.HeaderText = "Medico";
			this.medico.Name = "medico";
			this.medico.ReadOnly = true;
			// 
			// fecha
			// 
			this.fecha.HeaderText = "Visita";
			this.fecha.Name = "fecha";
			this.fecha.ReadOnly = true;
			this.fecha.ToolTipText = "Fecha de la Ultima Visita";
			this.fecha.Width = 90;
			// 
			// hora
			// 
			this.hora.HeaderText = "Hora";
			this.hora.Name = "hora";
			this.hora.ReadOnly = true;
			this.hora.Width = 60;
			// 
			// motivo
			// 
			this.motivo.HeaderText = "Motivo";
			this.motivo.Name = "motivo";
			this.motivo.ReadOnly = true;
			this.motivo.Width = 120;
			// 
			// diagnostico
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.diagnostico.DefaultCellStyle = dataGridViewCellStyle2;
			this.diagnostico.HeaderText = "Diagnostico";
			this.diagnostico.Name = "diagnostico";
			this.diagnostico.ReadOnly = true;
			// 
			// tratamiento
			// 
			this.tratamiento.HeaderText = "Tratamiento";
			this.tratamiento.Name = "tratamiento";
			this.tratamiento.ReadOnly = true;
			this.tratamiento.Width = 130;
			// 
			// proxima_visita
			// 
			this.proxima_visita.HeaderText = "Prox. Visita";
			this.proxima_visita.Name = "proxima_visita";
			this.proxima_visita.ReadOnly = true;
			this.proxima_visita.ToolTipText = "Proxima Visita";
			// 
			// observacion
			// 
			this.observacion.HeaderText = "Observación";
			this.observacion.Name = "observacion";
			this.observacion.ReadOnly = true;
			// 
			// idpaciente
			// 
			this.idpaciente.HeaderText = "idPaciente";
			this.idpaciente.Name = "idpaciente";
			this.idpaciente.ReadOnly = true;
			this.idpaciente.Visible = false;
			// 
			// idmedico
			// 
			this.idmedico.HeaderText = "idMedico";
			this.idmedico.Name = "idmedico";
			this.idmedico.ReadOnly = true;
			this.idmedico.Visible = false;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(89)))), ((int)(((byte)(53)))));
			this.btnBuscar.FlatAppearance.BorderSize = 0;
			this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
			this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuscar.ImageIndex = 0;
			this.btnBuscar.Location = new System.Drawing.Point(602, 17);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(133, 34);
			this.btnBuscar.TabIndex = 2;
			this.btnBuscar.Text = "Buscar (F11)";
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// txtBuscar
			// 
			this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(219)))), ((int)(((byte)(183)))));
			this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBuscar.ForeColor = System.Drawing.Color.White;
			this.txtBuscar.Location = new System.Drawing.Point(260, 17);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(304, 31);
			this.txtBuscar.TabIndex = 0;
			this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
			this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
			// 
			// btnEditar
			// 
			this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(89)))), ((int)(((byte)(53)))));
			this.btnEditar.FlatAppearance.BorderSize = 0;
			this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
			this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
			this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditar.ImageIndex = 0;
			this.btnEditar.Location = new System.Drawing.Point(251, 526);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(144, 34);
			this.btnEditar.TabIndex = 4;
			this.btnEditar.Text = "Editar (F3)";
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(89)))), ((int)(((byte)(53)))));
			this.btnEliminar.FlatAppearance.BorderSize = 0;
			this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.ImageIndex = 0;
			this.btnEliminar.Location = new System.Drawing.Point(450, 526);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(144, 34);
			this.btnEliminar.TabIndex = 5;
			this.btnEliminar.Text = "Eliminar (F4)";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// frmRegistros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(219)))), ((int)(((byte)(183)))));
			this.ClientSize = new System.Drawing.Size(1050, 600);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.dataGridRegsitros);
			this.Controls.Add(this.lblCerrar);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "frmRegistros";
			this.Text = "frmPaciente";
			this.Load += new System.EventHandler(this.frmRegistros_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRegistros_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.dataGridRegsitros)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.DataGridView dataGridRegsitros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn paciente;
		private System.Windows.Forms.DataGridViewTextBoxColumn medico;
		private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn hora;
		private System.Windows.Forms.DataGridViewTextBoxColumn motivo;
		private System.Windows.Forms.DataGridViewTextBoxColumn diagnostico;
		private System.Windows.Forms.DataGridViewTextBoxColumn tratamiento;
		private System.Windows.Forms.DataGridViewTextBoxColumn proxima_visita;
		private System.Windows.Forms.DataGridViewTextBoxColumn observacion;
		private System.Windows.Forms.DataGridViewTextBoxColumn idpaciente;
		private System.Windows.Forms.DataGridViewTextBoxColumn idmedico;
	}
}