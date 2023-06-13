namespace SistemaPsicoaprende.UI
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pnlMenuLateral = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnSesiones = new System.Windows.Forms.Button();
            this.btnTrabajadores = new System.Windows.Forms.Button();
            this.btnEstudiantes = new System.Windows.Forms.Button();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir2 = new System.Windows.Forms.Button();
            this.lblSesionUsuario = new System.Windows.Forms.Label();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlMenuLateral.SuspendLayout();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Controls.Add(this.pictureBox2);
            this.pnlContenedor.Controls.Add(this.lblHora);
            this.pnlContenedor.Controls.Add(this.lblFecha);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(225, 60);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(859, 564);
            this.pnlContenedor.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(58, 153);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(765, 330);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHora.Location = new System.Drawing.Point(401, 23);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(126, 46);
            this.lblHora.TabIndex = 9;
            this.lblHora.Text = "label1";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.SlateGray;
            this.lblFecha.Location = new System.Drawing.Point(290, 87);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(86, 31);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "label2";
            // 
            // pnlMenuLateral
            // 
            this.pnlMenuLateral.AutoScroll = true;
            this.pnlMenuLateral.BackColor = System.Drawing.Color.White;
            this.pnlMenuLateral.Controls.Add(this.btnSalir);
            this.pnlMenuLateral.Controls.Add(this.btnSesiones);
            this.pnlMenuLateral.Controls.Add(this.btnTrabajadores);
            this.pnlMenuLateral.Controls.Add(this.btnEstudiantes);
            this.pnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuLateral.Location = new System.Drawing.Point(0, 60);
            this.pnlMenuLateral.Name = "pnlMenuLateral";
            this.pnlMenuLateral.Size = new System.Drawing.Size(225, 564);
            this.pnlMenuLateral.TabIndex = 10;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(0, 531);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(225, 33);
            this.btnSalir.TabIndex = 43;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnSesiones
            // 
            this.btnSesiones.BackColor = System.Drawing.Color.Gold;
            this.btnSesiones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSesiones.FlatAppearance.BorderSize = 0;
            this.btnSesiones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSesiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSesiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSesiones.ForeColor = System.Drawing.Color.White;
            this.btnSesiones.Location = new System.Drawing.Point(0, 75);
            this.btnSesiones.Name = "btnSesiones";
            this.btnSesiones.Size = new System.Drawing.Size(225, 33);
            this.btnSesiones.TabIndex = 33;
            this.btnSesiones.Text = "Sesiones";
            this.btnSesiones.UseVisualStyleBackColor = false;
            this.btnSesiones.Click += new System.EventHandler(this.btnSesiones_Click);
            // 
            // btnTrabajadores
            // 
            this.btnTrabajadores.BackColor = System.Drawing.Color.DarkBlue;
            this.btnTrabajadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrabajadores.FlatAppearance.BorderSize = 0;
            this.btnTrabajadores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnTrabajadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrabajadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrabajadores.ForeColor = System.Drawing.Color.White;
            this.btnTrabajadores.Location = new System.Drawing.Point(0, 34);
            this.btnTrabajadores.Name = "btnTrabajadores";
            this.btnTrabajadores.Size = new System.Drawing.Size(225, 41);
            this.btnTrabajadores.TabIndex = 31;
            this.btnTrabajadores.Text = "Trabajadores";
            this.btnTrabajadores.UseVisualStyleBackColor = false;
            this.btnTrabajadores.Click += new System.EventHandler(this.btnTrabajadores_Click);
            // 
            // btnEstudiantes
            // 
            this.btnEstudiantes.BackColor = System.Drawing.Color.Red;
            this.btnEstudiantes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstudiantes.FlatAppearance.BorderSize = 0;
            this.btnEstudiantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstudiantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiantes.ForeColor = System.Drawing.Color.White;
            this.btnEstudiantes.Location = new System.Drawing.Point(0, 0);
            this.btnEstudiantes.Name = "btnEstudiantes";
            this.btnEstudiantes.Size = new System.Drawing.Size(225, 34);
            this.btnEstudiantes.TabIndex = 29;
            this.btnEstudiantes.Text = "Estudiantes";
            this.btnEstudiantes.UseVisualStyleBackColor = false;
            this.btnEstudiantes.Click += new System.EventHandler(this.btnEstudiantes_Click);
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.Controls.Add(this.pictureBox1);
            this.pnlSuperior.Controls.Add(this.btnSalir2);
            this.pnlSuperior.Controls.Add(this.lblSesionUsuario);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(1084, 60);
            this.pnlSuperior.TabIndex = 11;
            this.pnlSuperior.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSuperior_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir2
            // 
            this.btnSalir2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir2.BackColor = System.Drawing.Color.White;
            this.btnSalir2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir2.FlatAppearance.BorderSize = 0;
            this.btnSalir2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSalir2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnSalir2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir2.ForeColor = System.Drawing.Color.Black;
            this.btnSalir2.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir2.Image")));
            this.btnSalir2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir2.Location = new System.Drawing.Point(1019, 3);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(62, 39);
            this.btnSalir2.TabIndex = 10;
            this.btnSalir2.Text = "Salir";
            this.btnSalir2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir2.UseVisualStyleBackColor = false;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir2_Click);
            // 
            // lblSesionUsuario
            // 
            this.lblSesionUsuario.AutoSize = true;
            this.lblSesionUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSesionUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblSesionUsuario.Location = new System.Drawing.Point(53, 13);
            this.lblSesionUsuario.Name = "lblSesionUsuario";
            this.lblSesionUsuario.Size = new System.Drawing.Size(72, 22);
            this.lblSesionUsuario.TabIndex = 8;
            this.lblSesionUsuario.Text = "Usuario";
            // 
            // Tiempo
            // 
            this.Tiempo.Enabled = true;
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 624);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlMenuLateral);
            this.Controls.Add(this.pnlSuperior);
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInicio";
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlMenuLateral.ResumeLayout(false);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel pnlMenuLateral;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSesiones;
        private System.Windows.Forms.Button btnTrabajadores;
        private System.Windows.Forms.Button btnEstudiantes;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir2;
        private System.Windows.Forms.Label lblSesionUsuario;
        private System.Windows.Forms.Timer Tiempo;
    }
}