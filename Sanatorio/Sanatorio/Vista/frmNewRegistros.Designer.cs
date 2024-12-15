namespace Sanatorio.Vista
{
    partial class frmNewRegistros
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
			this.txtMotivo = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.txtMedico = new System.Windows.Forms.TextBox();
			this.txtPaciente = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.dateTimePickerFechaNaci = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtproxima_visita = new System.Windows.Forms.DateTimePicker();
			this.txtObservacion = new System.Windows.Forms.TextBox();
			this.txttratamiento = new System.Windows.Forms.TextBox();
			this.txtdiagnostico = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnBuscarPaciente = new System.Windows.Forms.Button();
			this.btnBuscarMedico = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtMotivo
			// 
			this.txtMotivo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMotivo.Location = new System.Drawing.Point(122, 225);
			this.txtMotivo.MaxLength = 255;
			this.txtMotivo.Multiline = true;
			this.txtMotivo.Name = "txtMotivo";
			this.txtMotivo.Size = new System.Drawing.Size(324, 71);
			this.txtMotivo.TabIndex = 5;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePicker1.Location = new System.Drawing.Point(122, 189);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(83, 23);
			this.dateTimePicker1.TabIndex = 4;
			// 
			// txtMedico
			// 
			this.txtMedico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMedico.Location = new System.Drawing.Point(122, 102);
			this.txtMedico.Name = "txtMedico";
			this.txtMedico.ReadOnly = true;
			this.txtMedico.Size = new System.Drawing.Size(216, 23);
			this.txtMedico.TabIndex = 70;
			// 
			// txtPaciente
			// 
			this.txtPaciente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPaciente.Location = new System.Drawing.Point(122, 65);
			this.txtPaciente.Name = "txtPaciente";
			this.txtPaciente.ReadOnly = true;
			this.txtPaciente.Size = new System.Drawing.Size(216, 23);
			this.txtPaciente.TabIndex = 69;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(27, 65);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(67, 16);
			this.label8.TabIndex = 13;
			this.label8.Text = "Paciente:";
			// 
			// dateTimePickerFechaNaci
			// 
			this.dateTimePickerFechaNaci.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePickerFechaNaci.Location = new System.Drawing.Point(122, 147);
			this.dateTimePickerFechaNaci.Name = "dateTimePickerFechaNaci";
			this.dateTimePickerFechaNaci.Size = new System.Drawing.Size(276, 23);
			this.dateTimePickerFechaNaci.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(23, 225);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 16);
			this.label5.TabIndex = 17;
			this.label5.Text = "Motivo:\r\n";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(35, 189);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 16);
			this.label4.TabIndex = 16;
			this.label4.Text = "Hora:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(35, 147);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 16);
			this.label3.TabIndex = 15;
			this.label3.Text = "Fecha:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(27, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 16);
			this.label2.TabIndex = 14;
			this.label2.Text = "Medico:";
			// 
			// txtId
			// 
			this.txtId.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtId.Location = new System.Drawing.Point(122, 20);
			this.txtId.Name = "txtId";
			this.txtId.ReadOnly = true;
			this.txtId.Size = new System.Drawing.Size(137, 23);
			this.txtId.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(12, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 16);
			this.label1.TabIndex = 12;
			this.label1.Text = "IDRegsitros:";
			// 
			// txtproxima_visita
			// 
			this.txtproxima_visita.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtproxima_visita.Location = new System.Drawing.Point(122, 511);
			this.txtproxima_visita.Name = "txtproxima_visita";
			this.txtproxima_visita.Size = new System.Drawing.Size(271, 23);
			this.txtproxima_visita.TabIndex = 8;
			// 
			// txtObservacion
			// 
			this.txtObservacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtObservacion.Location = new System.Drawing.Point(122, 559);
			this.txtObservacion.MaxLength = 255;
			this.txtObservacion.Multiline = true;
			this.txtObservacion.Name = "txtObservacion";
			this.txtObservacion.Size = new System.Drawing.Size(324, 71);
			this.txtObservacion.TabIndex = 9;
			// 
			// txttratamiento
			// 
			this.txttratamiento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttratamiento.Location = new System.Drawing.Point(122, 318);
			this.txttratamiento.MaxLength = 255;
			this.txttratamiento.Multiline = true;
			this.txttratamiento.Name = "txttratamiento";
			this.txttratamiento.Size = new System.Drawing.Size(324, 71);
			this.txttratamiento.TabIndex = 6;
			// 
			// txtdiagnostico
			// 
			this.txtdiagnostico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtdiagnostico.Location = new System.Drawing.Point(122, 416);
			this.txtdiagnostico.MaxLength = 255;
			this.txtdiagnostico.Multiline = true;
			this.txtdiagnostico.Name = "txtdiagnostico";
			this.txtdiagnostico.Size = new System.Drawing.Size(324, 71);
			this.txtdiagnostico.TabIndex = 7;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(13, 559);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(94, 16);
			this.label10.TabIndex = 21;
			this.label10.Text = "Observación:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(6, 321);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 16);
			this.label9.TabIndex = 18;
			this.label9.Text = "Diagnostico:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(6, 416);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(88, 16);
			this.label7.TabIndex = 19;
			this.label7.Text = "Tratamiento:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(6, 518);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(101, 16);
			this.label6.TabIndex = 20;
			this.label6.Text = "Proxima visita:";
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
			this.btnGuardar.Location = new System.Drawing.Point(61, 655);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(144, 34);
			this.btnGuardar.TabIndex = 10;
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
			this.btnCancelar.Location = new System.Drawing.Point(249, 655);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(144, 34);
			this.btnCancelar.TabIndex = 11;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnBuscarPaciente
			// 
			this.btnBuscarPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBuscarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(89)))), ((int)(((byte)(53)))));
			this.btnBuscarPaciente.FlatAppearance.BorderSize = 0;
			this.btnBuscarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
			this.btnBuscarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscarPaciente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscarPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
			this.btnBuscarPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuscarPaciente.ImageIndex = 0;
			this.btnBuscarPaciente.Location = new System.Drawing.Point(344, 65);
			this.btnBuscarPaciente.Name = "btnBuscarPaciente";
			this.btnBuscarPaciente.Size = new System.Drawing.Size(102, 23);
			this.btnBuscarPaciente.TabIndex = 1;
			this.btnBuscarPaciente.Text = "Buscar Paciente";
			this.btnBuscarPaciente.UseVisualStyleBackColor = false;
			this.btnBuscarPaciente.Click += new System.EventHandler(this.btnBuscarPaciente_Click);
			// 
			// btnBuscarMedico
			// 
			this.btnBuscarMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBuscarMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(89)))), ((int)(((byte)(53)))));
			this.btnBuscarMedico.FlatAppearance.BorderSize = 0;
			this.btnBuscarMedico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
			this.btnBuscarMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscarMedico.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscarMedico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
			this.btnBuscarMedico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuscarMedico.ImageIndex = 0;
			this.btnBuscarMedico.Location = new System.Drawing.Point(344, 102);
			this.btnBuscarMedico.Name = "btnBuscarMedico";
			this.btnBuscarMedico.Size = new System.Drawing.Size(102, 23);
			this.btnBuscarMedico.TabIndex = 2;
			this.btnBuscarMedico.Text = "Buscar Medico";
			this.btnBuscarMedico.UseVisualStyleBackColor = false;
			this.btnBuscarMedico.Click += new System.EventHandler(this.btnBuscarMedico_Click);
			// 
			// frmNewRegistros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(219)))), ((int)(((byte)(183)))));
			this.CancelButton = this.btnCancelar;
			this.ClientSize = new System.Drawing.Size(458, 702);
			this.Controls.Add(this.btnBuscarMedico);
			this.Controls.Add(this.btnBuscarPaciente);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtproxima_visita);
			this.Controls.Add(this.txtObservacion);
			this.Controls.Add(this.txttratamiento);
			this.Controls.Add(this.txtdiagnostico);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtMotivo);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.txtMedico);
			this.Controls.Add(this.txtPaciente);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.dateTimePickerFechaNaci);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "frmNewRegistros";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "registro de Visitas Medicas";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtMotivo;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox txtMedico;
        public System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DateTimePicker dateTimePickerFechaNaci;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker txtproxima_visita;
        public System.Windows.Forms.TextBox txtObservacion;
        public System.Windows.Forms.TextBox txttratamiento;
        public System.Windows.Forms.TextBox txtdiagnostico;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
		public System.Windows.Forms.Button btnBuscarPaciente;
		public System.Windows.Forms.Button btnBuscarMedico;
	}
}