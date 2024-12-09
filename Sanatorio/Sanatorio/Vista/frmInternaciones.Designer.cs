namespace Sanatorio.Vista
{
    partial class frmInternaciones
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
			this.dataGridInternacion = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.horaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_paciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_medico = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.id_habitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.motivoInternacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fechaEgreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdbAlta = new System.Windows.Forms.RadioButton();
			this.rdbInternado = new System.Windows.Forms.RadioButton();
			this.btnAlta = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridInternacion)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(224, 25);
			this.label1.TabIndex = 8;
			this.label1.Text = "Listado de Internaciones";
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
			this.btnNuevo.Location = new System.Drawing.Point(26, 525);
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
			// dataGridInternacion
			// 
			this.dataGridInternacion.AllowUserToAddRows = false;
			this.dataGridInternacion.AllowUserToDeleteRows = false;
			this.dataGridInternacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dataGridInternacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(219)))), ((int)(((byte)(183)))));
			this.dataGridInternacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridInternacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dataGridInternacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(89)))), ((int)(((byte)(53)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(89)))), ((int)(((byte)(53)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridInternacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridInternacion.ColumnHeadersHeight = 35;
			this.dataGridInternacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridInternacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fechaIngreso,
            this.horaIngreso,
            this.id_paciente,
            this.id_medico,
            this.id_habitacion,
            this.motivoInternacion,
            this.estado,
            this.fechaEgreso});
			this.dataGridInternacion.EnableHeadersVisualStyles = false;
			this.dataGridInternacion.GridColor = System.Drawing.Color.White;
			this.dataGridInternacion.Location = new System.Drawing.Point(12, 72);
			this.dataGridInternacion.Name = "dataGridInternacion";
			this.dataGridInternacion.ReadOnly = true;
			this.dataGridInternacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataGridInternacion.RowHeadersVisible = false;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(162)))), ((int)(((byte)(103)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(89)))), ((int)(((byte)(53)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			this.dataGridInternacion.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridInternacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridInternacion.Size = new System.Drawing.Size(1009, 376);
			this.dataGridInternacion.TabIndex = 7;
			this.dataGridInternacion.DoubleClick += new System.EventHandler(this.dataGridPaciente_DoubleClick);
			// 
			// id
			// 
			this.id.FillWeight = 120F;
			this.id.HeaderText = "ID";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Width = 40;
			// 
			// fechaIngreso
			// 
			this.fechaIngreso.HeaderText = "Fecha de Ingreso";
			this.fechaIngreso.Name = "fechaIngreso";
			this.fechaIngreso.ReadOnly = true;
			this.fechaIngreso.ToolTipText = "Fecha de Ingreso";
			this.fechaIngreso.Width = 80;
			// 
			// horaIngreso
			// 
			this.horaIngreso.HeaderText = "Hora de Ingreso";
			this.horaIngreso.Name = "horaIngreso";
			this.horaIngreso.ReadOnly = true;
			this.horaIngreso.Width = 70;
			// 
			// id_paciente
			// 
			this.id_paciente.HeaderText = "Paciente";
			this.id_paciente.Name = "id_paciente";
			this.id_paciente.ReadOnly = true;
			this.id_paciente.Width = 150;
			// 
			// id_medico
			// 
			this.id_medico.HeaderText = "Medico";
			this.id_medico.Name = "id_medico";
			this.id_medico.ReadOnly = true;
			this.id_medico.Width = 150;
			// 
			// id_habitacion
			// 
			this.id_habitacion.HeaderText = "Habitación";
			this.id_habitacion.Name = "id_habitacion";
			this.id_habitacion.ReadOnly = true;
			this.id_habitacion.Width = 85;
			// 
			// motivoInternacion
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.motivoInternacion.DefaultCellStyle = dataGridViewCellStyle2;
			this.motivoInternacion.HeaderText = "Motivo de Internación";
			this.motivoInternacion.Name = "motivoInternacion";
			this.motivoInternacion.ReadOnly = true;
			this.motivoInternacion.Width = 150;
			// 
			// estado
			// 
			this.estado.HeaderText = "Estado";
			this.estado.Name = "estado";
			this.estado.ReadOnly = true;
			// 
			// fechaEgreso
			// 
			this.fechaEgreso.HeaderText = "Fecha de Egreso";
			this.fechaEgreso.Name = "fechaEgreso";
			this.fechaEgreso.ReadOnly = true;
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
			this.btnBuscar.Location = new System.Drawing.Point(583, 17);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(133, 34);
			this.btnBuscar.TabIndex = 2;
			this.btnBuscar.Text = "Buscar (F1)";
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// txtBuscar
			// 
			this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(219)))), ((int)(((byte)(183)))));
			this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBuscar.ForeColor = System.Drawing.Color.White;
			this.txtBuscar.Location = new System.Drawing.Point(251, 20);
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
			this.btnEditar.Location = new System.Drawing.Point(197, 526);
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
			this.btnEliminar.Location = new System.Drawing.Point(372, 526);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(144, 34);
			this.btnEliminar.TabIndex = 5;
			this.btnEliminar.Text = "Eliminar (F4)";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(89)))), ((int)(((byte)(53)))));
			this.groupBox1.Controls.Add(this.rdbAlta);
			this.groupBox1.Controls.Add(this.rdbInternado);
			this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
			this.groupBox1.Location = new System.Drawing.Point(717, 517);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(292, 43);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Estado";
			// 
			// rdbAlta
			// 
			this.rdbAlta.AutoSize = true;
			this.rdbAlta.Location = new System.Drawing.Point(169, 17);
			this.rdbAlta.Name = "rdbAlta";
			this.rdbAlta.Size = new System.Drawing.Size(52, 20);
			this.rdbAlta.TabIndex = 1;
			this.rdbAlta.Text = "Alta";
			this.rdbAlta.UseVisualStyleBackColor = true;
			this.rdbAlta.CheckedChanged += new System.EventHandler(this.rdbAlta_CheckedChanged);
			// 
			// rdbInternado
			// 
			this.rdbInternado.AutoSize = true;
			this.rdbInternado.Checked = true;
			this.rdbInternado.Location = new System.Drawing.Point(16, 16);
			this.rdbInternado.Name = "rdbInternado";
			this.rdbInternado.Size = new System.Drawing.Size(88, 20);
			this.rdbInternado.TabIndex = 0;
			this.rdbInternado.TabStop = true;
			this.rdbInternado.Text = "Internado";
			this.rdbInternado.UseVisualStyleBackColor = true;
			this.rdbInternado.CheckedChanged += new System.EventHandler(this.rdbInternado_CheckedChanged);
			// 
			// btnAlta
			// 
			this.btnAlta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(89)))), ((int)(((byte)(53)))));
			this.btnAlta.FlatAppearance.BorderSize = 0;
			this.btnAlta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
			this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAlta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
			this.btnAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAlta.ImageIndex = 0;
			this.btnAlta.Location = new System.Drawing.Point(544, 525);
			this.btnAlta.Name = "btnAlta";
			this.btnAlta.Size = new System.Drawing.Size(144, 34);
			this.btnAlta.TabIndex = 10;
			this.btnAlta.Text = "Alta (F5)";
			this.btnAlta.UseVisualStyleBackColor = false;
			this.btnAlta.Click += new System.EventHandler(this.button1_Click);
			// 
			// frmInternaciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(219)))), ((int)(((byte)(183)))));
			this.ClientSize = new System.Drawing.Size(1050, 600);
			this.Controls.Add(this.btnAlta);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.dataGridInternacion);
			this.Controls.Add(this.lblCerrar);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "frmInternaciones";
			this.Text = "frmPaciente";
			this.Load += new System.EventHandler(this.frmPaciente_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPaciente_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.dataGridInternacion)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.DataGridView dataGridInternacion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdbAlta;
		private System.Windows.Forms.RadioButton rdbInternado;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngreso;
		private System.Windows.Forms.DataGridViewTextBoxColumn horaIngreso;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_paciente;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_medico;
		private System.Windows.Forms.DataGridViewTextBoxColumn id_habitacion;
		private System.Windows.Forms.DataGridViewTextBoxColumn motivoInternacion;
		private System.Windows.Forms.DataGridViewTextBoxColumn estado;
		private System.Windows.Forms.DataGridViewTextBoxColumn fechaEgreso;
		private System.Windows.Forms.Button btnAlta;
	}
}