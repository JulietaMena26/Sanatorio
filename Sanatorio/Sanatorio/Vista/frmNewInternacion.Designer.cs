namespace Sanatorio.Vista
{
	partial class frmNewInternacion
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dateTimePickerFechIngreso = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtDiagnostico = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.cmbMedico = new System.Windows.Forms.ComboBox();
			this.txtPaciente = new System.Windows.Forms.TextBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtMotivo = new System.Windows.Forms.TextBox();
			this.chcDeuda = new System.Windows.Forms.CheckBox();
			this.cmbEstado = new System.Windows.Forms.ComboBox();
			this.dateTimePickerFechaAlta = new System.Windows.Forms.DateTimePicker();
			this.label12 = new System.Windows.Forms.Label();
			this.cmbHabitacion = new System.Windows.Forms.ComboBox();
			this.dateTimePickerHoraIngreso = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerHoraAlta = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 16);
			this.label1.TabIndex = 15;
			this.label1.Text = "IDInternacion:";
			// 
			// txtId
			// 
			this.txtId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtId.Location = new System.Drawing.Point(139, 6);
			this.txtId.Name = "txtId";
			this.txtId.ReadOnly = true;
			this.txtId.Size = new System.Drawing.Size(137, 23);
			this.txtId.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(12, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 16);
			this.label2.TabIndex = 17;
			this.label2.Text = "Hora Ingreso:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(15, 126);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 16);
			this.label3.TabIndex = 18;
			this.label3.Text = "Medico:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(15, 166);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 16);
			this.label4.TabIndex = 19;
			this.label4.Text = "Paciente:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(9, 238);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(132, 16);
			this.label5.TabIndex = 21;
			this.label5.Text = "Motivo Internación:";
			// 
			// dateTimePickerFechIngreso
			// 
			this.dateTimePickerFechIngreso.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePickerFechIngreso.Location = new System.Drawing.Point(139, 46);
			this.dateTimePickerFechIngreso.Name = "dateTimePickerFechIngreso";
			this.dateTimePickerFechIngreso.Size = new System.Drawing.Size(276, 23);
			this.dateTimePickerFechIngreso.TabIndex = 2;
			this.dateTimePickerFechIngreso.ValueChanged += new System.EventHandler(this.dateTimePickerFechaNaci_ValueChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(46, 328);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 16);
			this.label6.TabIndex = 22;
			this.label6.Text = "Diagnostico:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(63, 412);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(54, 16);
			this.label7.TabIndex = 23;
			this.label7.Text = "Deuda:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(15, 51);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(102, 16);
			this.label8.TabIndex = 16;
			this.label8.Text = "Fecha Ingreso:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(61, 446);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(54, 16);
			this.label9.TabIndex = 24;
			this.label9.Text = "Estado:";
			// 
			// txtDiagnostico
			// 
			this.txtDiagnostico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDiagnostico.Location = new System.Drawing.Point(140, 328);
			this.txtDiagnostico.MaxLength = 255;
			this.txtDiagnostico.Multiline = true;
			this.txtDiagnostico.Name = "txtDiagnostico";
			this.txtDiagnostico.Size = new System.Drawing.Size(295, 77);
			this.txtDiagnostico.TabIndex = 8;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(34, 477);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(81, 16);
			this.label10.TabIndex = 25;
			this.label10.Text = "Fecha Alta:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(42, 520);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(73, 16);
			this.label11.TabIndex = 26;
			this.label11.Text = "Hora Alta:";
			// 
			// btnGuardar
			// 
			this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(89)))), ((int)(((byte)(53)))));
			this.btnGuardar.FlatAppearance.BorderSize = 0;
			this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
			this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.ImageIndex = 0;
			this.btnGuardar.Location = new System.Drawing.Point(37, 552);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(144, 34);
			this.btnGuardar.TabIndex = 13;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(89)))), ((int)(((byte)(53)))));
			this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancelar.FlatAppearance.BorderSize = 0;
			this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.ImageIndex = 0;
			this.btnCancelar.Location = new System.Drawing.Point(227, 552);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(144, 34);
			this.btnCancelar.TabIndex = 14;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// cmbMedico
			// 
			this.cmbMedico.FormattingEnabled = true;
			this.cmbMedico.Location = new System.Drawing.Point(139, 121);
			this.cmbMedico.Name = "cmbMedico";
			this.cmbMedico.Size = new System.Drawing.Size(276, 21);
			this.cmbMedico.TabIndex = 4;
			this.cmbMedico.Text = "-- Seleccionar el Medico --";
			// 
			// txtPaciente
			// 
			this.txtPaciente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPaciente.Location = new System.Drawing.Point(139, 163);
			this.txtPaciente.MaxLength = 50;
			this.txtPaciente.Name = "txtPaciente";
			this.txtPaciente.ReadOnly = true;
			this.txtPaciente.Size = new System.Drawing.Size(168, 23);
			this.txtPaciente.TabIndex = 26;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(89)))), ((int)(((byte)(53)))));
			this.btnBuscar.FlatAppearance.BorderSize = 0;
			this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
			this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuscar.ImageIndex = 0;
			this.btnBuscar.Location = new System.Drawing.Point(331, 163);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(84, 23);
			this.btnBuscar.TabIndex = 5;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// txtMotivo
			// 
			this.txtMotivo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMotivo.Location = new System.Drawing.Point(140, 238);
			this.txtMotivo.MaxLength = 255;
			this.txtMotivo.Multiline = true;
			this.txtMotivo.Name = "txtMotivo";
			this.txtMotivo.Size = new System.Drawing.Size(295, 76);
			this.txtMotivo.TabIndex = 7;
			// 
			// chcDeuda
			// 
			this.chcDeuda.AutoSize = true;
			this.chcDeuda.Location = new System.Drawing.Point(140, 414);
			this.chcDeuda.Name = "chcDeuda";
			this.chcDeuda.Size = new System.Drawing.Size(15, 14);
			this.chcDeuda.TabIndex = 9;
			this.chcDeuda.UseVisualStyleBackColor = true;
			// 
			// cmbEstado
			// 
			this.cmbEstado.FormattingEnabled = true;
			this.cmbEstado.Items.AddRange(new object[] {
            "Internación",
            "Alta"});
			this.cmbEstado.Location = new System.Drawing.Point(139, 441);
			this.cmbEstado.Name = "cmbEstado";
			this.cmbEstado.Size = new System.Drawing.Size(123, 21);
			this.cmbEstado.TabIndex = 10;
			// 
			// dateTimePickerFechaAlta
			// 
			this.dateTimePickerFechaAlta.Enabled = false;
			this.dateTimePickerFechaAlta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePickerFechaAlta.Location = new System.Drawing.Point(139, 477);
			this.dateTimePickerFechaAlta.Name = "dateTimePickerFechaAlta";
			this.dateTimePickerFechaAlta.Size = new System.Drawing.Size(276, 23);
			this.dateTimePickerFechaAlta.TabIndex = 11;
			this.dateTimePickerFechaAlta.ValueChanged += new System.EventHandler(this.dateTimePickerFechaAlta_ValueChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Black;
			this.label12.Location = new System.Drawing.Point(15, 203);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(83, 16);
			this.label12.TabIndex = 20;
			this.label12.Text = "Habitación:";
			// 
			// cmbHabitacion
			// 
			this.cmbHabitacion.FormattingEnabled = true;
			this.cmbHabitacion.Location = new System.Drawing.Point(139, 198);
			this.cmbHabitacion.Name = "cmbHabitacion";
			this.cmbHabitacion.Size = new System.Drawing.Size(276, 21);
			this.cmbHabitacion.TabIndex = 6;
			this.cmbHabitacion.Text = "-- Seleccione la Habitación --";
			// 
			// dateTimePickerHoraIngreso
			// 
			this.dateTimePickerHoraIngreso.CustomFormat = "HH:mm";
			this.dateTimePickerHoraIngreso.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.dateTimePickerHoraIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerHoraIngreso.Location = new System.Drawing.Point(140, 86);
			this.dateTimePickerHoraIngreso.Name = "dateTimePickerHoraIngreso";
			this.dateTimePickerHoraIngreso.ShowUpDown = true;
			this.dateTimePickerHoraIngreso.Size = new System.Drawing.Size(94, 23);
			this.dateTimePickerHoraIngreso.TabIndex = 27;
			this.dateTimePickerHoraIngreso.Value = new System.DateTime(2024, 12, 5, 4, 0, 0, 0);
			// 
			// dateTimePickerHoraAlta
			// 
			this.dateTimePickerHoraAlta.CustomFormat = "HH:mm";
			this.dateTimePickerHoraAlta.Enabled = false;
			this.dateTimePickerHoraAlta.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.dateTimePickerHoraAlta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerHoraAlta.Location = new System.Drawing.Point(140, 515);
			this.dateTimePickerHoraAlta.Name = "dateTimePickerHoraAlta";
			this.dateTimePickerHoraAlta.ShowUpDown = true;
			this.dateTimePickerHoraAlta.Size = new System.Drawing.Size(94, 23);
			this.dateTimePickerHoraAlta.TabIndex = 28;
			this.dateTimePickerHoraAlta.Value = new System.DateTime(2024, 12, 5, 4, 0, 0, 0);
			// 
			// frmNewInternacion
			// 
			this.AcceptButton = this.btnGuardar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(219)))), ((int)(((byte)(183)))));
			this.CancelButton = this.btnCancelar;
			this.ClientSize = new System.Drawing.Size(447, 598);
			this.Controls.Add(this.dateTimePickerHoraAlta);
			this.Controls.Add(this.dateTimePickerHoraIngreso);
			this.Controls.Add(this.cmbHabitacion);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.dateTimePickerFechaAlta);
			this.Controls.Add(this.cmbEstado);
			this.Controls.Add(this.chcDeuda);
			this.Controls.Add(this.txtMotivo);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtPaciente);
			this.Controls.Add(this.cmbMedico);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtDiagnostico);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dateTimePickerFechIngreso);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "frmNewInternacion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Internación";
			this.Load += new System.EventHandler(this.frmNew_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnCancelar;
		public System.Windows.Forms.TextBox txtId;
		public System.Windows.Forms.DateTimePicker dateTimePickerFechIngreso;
		public System.Windows.Forms.TextBox txtDiagnostico;
		private System.Windows.Forms.ComboBox cmbMedico;
		public System.Windows.Forms.TextBox txtPaciente;
		private System.Windows.Forms.Button btnBuscar;
		public System.Windows.Forms.TextBox txtMotivo;
		private System.Windows.Forms.CheckBox chcDeuda;
		private System.Windows.Forms.ComboBox cmbEstado;
		public System.Windows.Forms.DateTimePicker dateTimePickerFechaAlta;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox cmbHabitacion;
		private System.Windows.Forms.DateTimePicker dateTimePickerHoraIngreso;
		public System.Windows.Forms.DateTimePicker dateTimePickerHoraAlta;
	}
}