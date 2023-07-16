namespace SistemaPsicoaprende.UI
{
    partial class FrmEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstudiantes));
            this.grpBoxEstu = new System.Windows.Forms.GroupBox();
            this.grpBoxEstado = new System.Windows.Forms.GroupBox();
            this.txteva = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grpBoxTutor = new System.Windows.Forms.GroupBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBoxUbicacion = new System.Windows.Forms.GroupBox();
            this.cmbMunicipio = new System.Windows.Forms.ComboBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grpBoxDatosAcademicos = new System.Windows.Forms.GroupBox();
            this.txtgrad = new System.Windows.Forms.TextBox();
            this.txtcol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpBoxDatosEstu = new System.Windows.Forms.GroupBox();
            this.txtape = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimeFechaAL = new System.Windows.Forms.DateTimePicker();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnListarEstu = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtcod1 = new System.Windows.Forms.TextBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.grpBoxEstu.SuspendLayout();
            this.grpBoxEstado.SuspendLayout();
            this.grpBoxTutor.SuspendLayout();
            this.grpBoxUbicacion.SuspendLayout();
            this.grpBoxDatosAcademicos.SuspendLayout();
            this.grpBoxDatosEstu.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxEstu
            // 
            this.grpBoxEstu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxEstu.BackColor = System.Drawing.Color.White;
            this.grpBoxEstu.Controls.Add(this.grpBoxEstado);
            this.grpBoxEstu.Controls.Add(this.grpBoxTutor);
            this.grpBoxEstu.Controls.Add(this.grpBoxUbicacion);
            this.grpBoxEstu.Controls.Add(this.grpBoxDatosAcademicos);
            this.grpBoxEstu.Controls.Add(this.grpBoxDatosEstu);
            this.grpBoxEstu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxEstu.ForeColor = System.Drawing.Color.Black;
            this.grpBoxEstu.Location = new System.Drawing.Point(25, 74);
            this.grpBoxEstu.Name = "grpBoxEstu";
            this.grpBoxEstu.Size = new System.Drawing.Size(749, 364);
            this.grpBoxEstu.TabIndex = 61;
            this.grpBoxEstu.TabStop = false;
            this.grpBoxEstu.Text = "Resgistrar Estudiante";
            this.grpBoxEstu.Enter += new System.EventHandler(this.grpBoxEstu_Enter);
            // 
            // grpBoxEstado
            // 
            this.grpBoxEstado.BackColor = System.Drawing.Color.Silver;
            this.grpBoxEstado.Controls.Add(this.txteva);
            this.grpBoxEstado.Controls.Add(this.label9);
            this.grpBoxEstado.Location = new System.Drawing.Point(528, 231);
            this.grpBoxEstado.Name = "grpBoxEstado";
            this.grpBoxEstado.Size = new System.Drawing.Size(208, 127);
            this.grpBoxEstado.TabIndex = 73;
            this.grpBoxEstado.TabStop = false;
            this.grpBoxEstado.Text = "Estado";
            // 
            // txteva
            // 
            this.txteva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txteva.Location = new System.Drawing.Point(6, 41);
            this.txteva.Multiline = true;
            this.txteva.Name = "txteva";
            this.txteva.Size = new System.Drawing.Size(194, 69);
            this.txteva.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 15);
            this.label9.TabIndex = 77;
            this.label9.Text = "Evaluacion";
            // 
            // grpBoxTutor
            // 
            this.grpBoxTutor.BackColor = System.Drawing.Color.Silver;
            this.grpBoxTutor.Controls.Add(this.txttel);
            this.grpBoxTutor.Controls.Add(this.label5);
            this.grpBoxTutor.Controls.Add(this.txtres);
            this.grpBoxTutor.Controls.Add(this.label6);
            this.grpBoxTutor.Controls.Add(this.txtdom);
            this.grpBoxTutor.Controls.Add(this.label2);
            this.grpBoxTutor.Location = new System.Drawing.Point(9, 231);
            this.grpBoxTutor.Name = "grpBoxTutor";
            this.grpBoxTutor.Size = new System.Drawing.Size(513, 127);
            this.grpBoxTutor.TabIndex = 84;
            this.grpBoxTutor.TabStop = false;
            this.grpBoxTutor.Text = "Datos Tutor";
            // 
            // txttel
            // 
            this.txttel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txttel.Location = new System.Drawing.Point(9, 88);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(152, 22);
            this.txttel.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 73;
            this.label5.Text = "Teléfono";
            // 
            // txtres
            // 
            this.txtres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtres.Location = new System.Drawing.Point(9, 42);
            this.txtres.Name = "txtres";
            this.txtres.Size = new System.Drawing.Size(152, 22);
            this.txtres.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 15);
            this.label6.TabIndex = 74;
            this.label6.Text = "Nombre y Apellido";
            // 
            // txtdom
            // 
            this.txtdom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdom.Location = new System.Drawing.Point(184, 41);
            this.txtdom.Multiline = true;
            this.txtdom.Name = "txtdom";
            this.txtdom.Size = new System.Drawing.Size(320, 69);
            this.txtdom.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(181, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 70;
            this.label2.Text = "Domicilio";
            // 
            // grpBoxUbicacion
            // 
            this.grpBoxUbicacion.BackColor = System.Drawing.Color.Silver;
            this.grpBoxUbicacion.Controls.Add(this.cmbMunicipio);
            this.grpBoxUbicacion.Controls.Add(this.cmbDepartamento);
            this.grpBoxUbicacion.Controls.Add(this.label10);
            this.grpBoxUbicacion.Controls.Add(this.label11);
            this.grpBoxUbicacion.Location = new System.Drawing.Point(527, 33);
            this.grpBoxUbicacion.Name = "grpBoxUbicacion";
            this.grpBoxUbicacion.Size = new System.Drawing.Size(209, 180);
            this.grpBoxUbicacion.TabIndex = 83;
            this.grpBoxUbicacion.TabStop = false;
            this.grpBoxUbicacion.Text = "Ubicación";
            // 
            // cmbMunicipio
            // 
            this.cmbMunicipio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMunicipio.FormattingEnabled = true;
            this.cmbMunicipio.Location = new System.Drawing.Point(7, 96);
            this.cmbMunicipio.Name = "cmbMunicipio";
            this.cmbMunicipio.Size = new System.Drawing.Size(194, 24);
            this.cmbMunicipio.TabIndex = 67;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(7, 51);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(194, 24);
            this.cmbDepartamento.TabIndex = 68;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(4, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 15);
            this.label10.TabIndex = 78;
            this.label10.Text = "Departamento";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(4, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 79;
            this.label11.Text = "Municipio";
            // 
            // grpBoxDatosAcademicos
            // 
            this.grpBoxDatosAcademicos.BackColor = System.Drawing.Color.Silver;
            this.grpBoxDatosAcademicos.Controls.Add(this.txtgrad);
            this.grpBoxDatosAcademicos.Controls.Add(this.txtcol);
            this.grpBoxDatosAcademicos.Controls.Add(this.label3);
            this.grpBoxDatosAcademicos.Controls.Add(this.label4);
            this.grpBoxDatosAcademicos.Location = new System.Drawing.Point(304, 33);
            this.grpBoxDatosAcademicos.Name = "grpBoxDatosAcademicos";
            this.grpBoxDatosAcademicos.Size = new System.Drawing.Size(217, 180);
            this.grpBoxDatosAcademicos.TabIndex = 82;
            this.grpBoxDatosAcademicos.TabStop = false;
            this.grpBoxDatosAcademicos.Text = "Datos Académicos";
            // 
            // txtgrad
            // 
            this.txtgrad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtgrad.Location = new System.Drawing.Point(12, 96);
            this.txtgrad.Name = "txtgrad";
            this.txtgrad.Size = new System.Drawing.Size(100, 22);
            this.txtgrad.TabIndex = 58;
            // 
            // txtcol
            // 
            this.txtcol.Location = new System.Drawing.Point(9, 53);
            this.txtcol.Name = "txtcol";
            this.txtcol.Size = new System.Drawing.Size(200, 22);
            this.txtcol.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 71;
            this.label3.Text = "Grado";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 72;
            this.label4.Text = "Colegio";
            // 
            // grpBoxDatosEstu
            // 
            this.grpBoxDatosEstu.BackColor = System.Drawing.Color.Silver;
            this.grpBoxDatosEstu.Controls.Add(this.txtape);
            this.grpBoxDatosEstu.Controls.Add(this.label12);
            this.grpBoxDatosEstu.Controls.Add(this.txtname);
            this.grpBoxDatosEstu.Controls.Add(this.label7);
            this.grpBoxDatosEstu.Controls.Add(this.label8);
            this.grpBoxDatosEstu.Controls.Add(this.dateTimeFechaAL);
            this.grpBoxDatosEstu.Location = new System.Drawing.Point(9, 33);
            this.grpBoxDatosEstu.Name = "grpBoxDatosEstu";
            this.grpBoxDatosEstu.Size = new System.Drawing.Size(289, 180);
            this.grpBoxDatosEstu.TabIndex = 81;
            this.grpBoxDatosEstu.TabStop = false;
            this.grpBoxDatosEstu.Text = "Datos del Estudiante";
            // 
            // txtape
            // 
            this.txtape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtape.Location = new System.Drawing.Point(13, 96);
            this.txtape.Name = "txtape";
            this.txtape.Size = new System.Drawing.Size(166, 22);
            this.txtape.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(14, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 15);
            this.label12.TabIndex = 80;
            this.label12.Text = "Fecha de Nacimiento";
            // 
            // txtname
            // 
            this.txtname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtname.Location = new System.Drawing.Point(13, 53);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(166, 22);
            this.txtname.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(14, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 75;
            this.label7.Text = "Apellido";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(11, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 76;
            this.label8.Text = "Nombre";
            // 
            // dateTimeFechaAL
            // 
            this.dateTimeFechaAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimeFechaAL.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaAL.Location = new System.Drawing.Point(13, 152);
            this.dateTimeFechaAL.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dateTimeFechaAL.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dateTimeFechaAL.Name = "dateTimeFechaAL";
            this.dateTimeFechaAL.Size = new System.Drawing.Size(123, 22);
            this.dateTimeFechaAL.TabIndex = 65;
            this.dateTimeFechaAL.Value = new System.DateTime(2023, 7, 15, 0, 0, 0, 0);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlMenu.Controls.Add(this.btnListarEstu);
            this.pnlMenu.Controls.Add(this.btnCerrar);
            this.pnlMenu.Controls.Add(this.btnBuscar);
            this.pnlMenu.Controls.Add(this.txtBuscar);
            this.pnlMenu.Controls.Add(this.btnGuardar);
            this.pnlMenu.Location = new System.Drawing.Point(25, 20);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(751, 48);
            this.pnlMenu.TabIndex = 62;
            // 
            // btnListarEstu
            // 
            this.btnListarEstu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnListarEstu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarEstu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarEstu.Image = ((System.Drawing.Image)(resources.GetObject("btnListarEstu.Image")));
            this.btnListarEstu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarEstu.Location = new System.Drawing.Point(425, 5);
            this.btnListarEstu.Name = "btnListarEstu";
            this.btnListarEstu.Size = new System.Drawing.Size(79, 38);
            this.btnListarEstu.TabIndex = 65;
            this.btnListarEstu.Text = "Listar";
            this.btnListarEstu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListarEstu.UseVisualStyleBackColor = true;
            this.btnListarEstu.Click += new System.EventHandler(this.btnListarEstu_Click_1);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(647, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(89, 37);
            this.btnCerrar.TabIndex = 64;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(9, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(89, 38);
            this.btnBuscar.TabIndex = 63;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBuscar.Location = new System.Drawing.Point(119, 6);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(204, 38);
            this.txtBuscar.TabIndex = 62;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(532, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 38);
            this.btnGuardar.TabIndex = 61;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtcod1
            // 
            this.txtcod1.Location = new System.Drawing.Point(3, 107);
            this.txtcod1.Name = "txtcod1";
            this.txtcod1.Size = new System.Drawing.Size(19, 20);
            this.txtcod1.TabIndex = 63;
            this.txtcod1.Visible = false;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Controls.Add(this.txtcod1);
            this.pnlContenedor.Controls.Add(this.pnlMenu);
            this.pnlContenedor.Controls.Add(this.grpBoxEstu);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(800, 450);
            this.pnlContenedor.TabIndex = 0;
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenedor_Paint);
            // 
            // FrmEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstudiantes";
            this.Text = "FrmEstudiante";
            this.Load += new System.EventHandler(this.FrmEstudiante_Load);
            this.grpBoxEstu.ResumeLayout(false);
            this.grpBoxEstado.ResumeLayout(false);
            this.grpBoxEstado.PerformLayout();
            this.grpBoxTutor.ResumeLayout(false);
            this.grpBoxTutor.PerformLayout();
            this.grpBoxUbicacion.ResumeLayout(false);
            this.grpBoxUbicacion.PerformLayout();
            this.grpBoxDatosAcademicos.ResumeLayout(false);
            this.grpBoxDatosAcademicos.PerformLayout();
            this.grpBoxDatosEstu.ResumeLayout(false);
            this.grpBoxDatosEstu.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxEstu;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.ComboBox cmbMunicipio;
        private System.Windows.Forms.DateTimePicker dateTimeFechaAL;
        private System.Windows.Forms.TextBox txteva;
        private System.Windows.Forms.TextBox txtdom;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtres;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtcol;
        private System.Windows.Forms.TextBox txtgrad;
        private System.Windows.Forms.TextBox txtape;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnListarEstu;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtcod1;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.GroupBox grpBoxDatosEstu;
        private System.Windows.Forms.GroupBox grpBoxDatosAcademicos;
        private System.Windows.Forms.GroupBox grpBoxEstado;
        private System.Windows.Forms.GroupBox grpBoxTutor;
        private System.Windows.Forms.GroupBox grpBoxUbicacion;
    }
}