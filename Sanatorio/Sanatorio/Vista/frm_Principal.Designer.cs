namespace Sanatorio
{
    partial class frm_Principal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            this.panelMenuVertical = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.listaImagenes = new System.Windows.Forms.ImageList(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInternacion = new System.Windows.Forms.Button();
            this.btnMedico = new System.Windows.Forms.Button();
            this.btnPaciente = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelMenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuVertical
            // 
            this.panelMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(89)))), ((int)(((byte)(53)))));
            this.panelMenuVertical.Controls.Add(this.button5);
            this.panelMenuVertical.Controls.Add(this.button4);
            this.panelMenuVertical.Controls.Add(this.button3);
            this.panelMenuVertical.Controls.Add(this.button2);
            this.panelMenuVertical.Controls.Add(this.button1);
            this.panelMenuVertical.Controls.Add(this.btnInternacion);
            this.panelMenuVertical.Controls.Add(this.btnMedico);
            this.panelMenuVertical.Controls.Add(this.btnPaciente);
            this.panelMenuVertical.Controls.Add(this.pictureBox2);
            this.panelMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuVertical.Location = new System.Drawing.Point(0, 0);
            this.panelMenuVertical.Name = "panelMenuVertical";
            this.panelMenuVertical.Size = new System.Drawing.Size(250, 650);
            this.panelMenuVertical.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.ImageIndex = 5;
            this.button5.ImageList = this.listaImagenes;
            this.button5.Location = new System.Drawing.Point(1, 598);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 40);
            this.button5.TabIndex = 8;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listaImagenes
            // 
            this.listaImagenes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listaImagenes.ImageStream")));
            this.listaImagenes.TransparentColor = System.Drawing.Color.Transparent;
            this.listaImagenes.Images.SetKeyName(0, "pacientes.png");
            this.listaImagenes.Images.SetKeyName(1, "medicos.png");
            this.listaImagenes.Images.SetKeyName(2, "internaciones.png");
            this.listaImagenes.Images.SetKeyName(3, "registroClinico.png");
            this.listaImagenes.Images.SetKeyName(4, "habitacion.png");
            this.listaImagenes.Images.SetKeyName(5, "salir.png");
            this.listaImagenes.Images.SetKeyName(6, "obrasocial.png");
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageIndex = 4;
            this.button4.ImageList = this.listaImagenes;
            this.button4.Location = new System.Drawing.Point(3, 476);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 40);
            this.button4.TabIndex = 7;
            this.button4.Text = "Tipo Habitación";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 6;
            this.button3.ImageList = this.listaImagenes;
            this.button3.Location = new System.Drawing.Point(0, 418);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "Obra Social";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 4;
            this.button2.ImageList = this.listaImagenes;
            this.button2.Location = new System.Drawing.Point(0, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Habitación";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 3;
            this.button1.ImageList = this.listaImagenes;
            this.button1.Location = new System.Drawing.Point(0, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Registro Clinico";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnInternacion
            // 
            this.btnInternacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInternacion.FlatAppearance.BorderSize = 0;
            this.btnInternacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
            this.btnInternacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInternacion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInternacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
            this.btnInternacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInternacion.ImageIndex = 2;
            this.btnInternacion.ImageList = this.listaImagenes;
            this.btnInternacion.Location = new System.Drawing.Point(1, 238);
            this.btnInternacion.Name = "btnInternacion";
            this.btnInternacion.Size = new System.Drawing.Size(250, 40);
            this.btnInternacion.TabIndex = 3;
            this.btnInternacion.Text = "Internación";
            this.btnInternacion.UseVisualStyleBackColor = true;
            // 
            // btnMedico
            // 
            this.btnMedico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedico.FlatAppearance.BorderSize = 0;
            this.btnMedico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
            this.btnMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedico.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
            this.btnMedico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedico.ImageIndex = 1;
            this.btnMedico.ImageList = this.listaImagenes;
            this.btnMedico.Location = new System.Drawing.Point(3, 168);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(250, 40);
            this.btnMedico.TabIndex = 2;
            this.btnMedico.Text = "Medicos";
            this.btnMedico.UseVisualStyleBackColor = true;
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // btnPaciente
            // 
            this.btnPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaciente.FlatAppearance.BorderSize = 0;
            this.btnPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(158)))), ((int)(((byte)(92)))));
            this.btnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaciente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaciente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
            this.btnPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaciente.ImageIndex = 0;
            this.btnPaciente.ImageList = this.listaImagenes;
            this.btnPaciente.Location = new System.Drawing.Point(3, 92);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(250, 40);
            this.btnPaciente.TabIndex = 1;
            this.btnPaciente.Text = "Pacientes ";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(244, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(162)))), ((int)(((byte)(103)))));
            this.panelBarraTitulo.Controls.Add(this.pictureBox1);
            this.panelBarraTitulo.Controls.Add(this.pictureBoxCerrar);
            this.panelBarraTitulo.Controls.Add(this.pictureBoxMenu);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(250, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1050, 50);
            this.panelBarraTitulo.TabIndex = 1;
            this.panelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(991, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBoxCerrar
            // 
            this.pictureBoxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCerrar.Image")));
            this.pictureBoxCerrar.Location = new System.Drawing.Point(1022, 3);
            this.pictureBoxCerrar.Name = "pictureBoxCerrar";
            this.pictureBoxCerrar.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCerrar.TabIndex = 1;
            this.pictureBoxCerrar.TabStop = false;
            this.pictureBoxCerrar.Click += new System.EventHandler(this.pictureBoxCerrar_Click);
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(162)))), ((int)(((byte)(103)))));
            this.pictureBoxMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMenu.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMenu.Image")));
            this.pictureBoxMenu.Location = new System.Drawing.Point(6, 8);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMenu.TabIndex = 0;
            this.pictureBoxMenu.TabStop = false;
            this.pictureBoxMenu.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(219)))), ((int)(((byte)(183)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 50);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1050, 600);
            this.panelContenedor.TabIndex = 2;
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.ControlBox = false;
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.panelMenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sanatorio Santa Rita";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Principal_KeyDown);
            this.panelMenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuVertical;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ImageList listaImagenes;
        private System.Windows.Forms.PictureBox pictureBoxCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnInternacion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
	}
}

