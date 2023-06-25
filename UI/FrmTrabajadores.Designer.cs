namespace SistemaPsicoaprende.UI
{
    partial class FrmTrabajadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrabajadores));
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.grbRegistrarTraba = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbmunicipio = new System.Windows.Forms.ComboBox();
            this.cmbdepartamento = new System.Windows.Forms.ComboBox();
            this.cmbprofesion = new System.Windows.Forms.ComboBox();
            this.Msktel = new System.Windows.Forms.MaskedTextBox();
            this.txtdom = new System.Windows.Forms.TextBox();
            this.txtape = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnListarTraba = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlContenedor.SuspendLayout();
            this.grbRegistrarTraba.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.grbRegistrarTraba);
            this.pnlContenedor.Controls.Add(this.pnlMenu);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(800, 450);
            this.pnlContenedor.TabIndex = 0;
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenedor_Paint);
            // 
            // grbRegistrarTraba
            // 
            this.grbRegistrarTraba.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbRegistrarTraba.BackColor = System.Drawing.Color.Silver;
            this.grbRegistrarTraba.Controls.Add(this.label8);
            this.grbRegistrarTraba.Controls.Add(this.label7);
            this.grbRegistrarTraba.Controls.Add(this.label6);
            this.grbRegistrarTraba.Controls.Add(this.cmbmunicipio);
            this.grbRegistrarTraba.Controls.Add(this.cmbdepartamento);
            this.grbRegistrarTraba.Controls.Add(this.cmbprofesion);
            this.grbRegistrarTraba.Controls.Add(this.Msktel);
            this.grbRegistrarTraba.Controls.Add(this.txtdom);
            this.grbRegistrarTraba.Controls.Add(this.txtape);
            this.grbRegistrarTraba.Controls.Add(this.txtnom);
            this.grbRegistrarTraba.Controls.Add(this.label5);
            this.grbRegistrarTraba.Controls.Add(this.label4);
            this.grbRegistrarTraba.Controls.Add(this.label3);
            this.grbRegistrarTraba.Controls.Add(this.label2);
            this.grbRegistrarTraba.Controls.Add(this.label1);
            this.grbRegistrarTraba.Controls.Add(this.txtcod);
            this.grbRegistrarTraba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRegistrarTraba.Location = new System.Drawing.Point(25, 87);
            this.grbRegistrarTraba.Name = "grbRegistrarTraba";
            this.grbRegistrarTraba.Size = new System.Drawing.Size(747, 309);
            this.grbRegistrarTraba.TabIndex = 64;
            this.grbRegistrarTraba.TabStop = false;
            this.grbRegistrarTraba.Text = "Registrar Trabajador";
            this.grbRegistrarTraba.Enter += new System.EventHandler(this.grbRegistrarTraba_Enter);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(419, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 69;
            this.label8.Text = "Municipio";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(419, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 68;
            this.label7.Text = "Departamento";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(419, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 67;
            this.label6.Text = "Profesion";
            // 
            // cmbmunicipio
            // 
            this.cmbmunicipio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbmunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmunicipio.FormattingEnabled = true;
            this.cmbmunicipio.Location = new System.Drawing.Point(422, 184);
            this.cmbmunicipio.Name = "cmbmunicipio";
            this.cmbmunicipio.Size = new System.Drawing.Size(121, 24);
            this.cmbmunicipio.TabIndex = 66;
            // 
            // cmbdepartamento
            // 
            this.cmbdepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbdepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdepartamento.FormattingEnabled = true;
            this.cmbdepartamento.Location = new System.Drawing.Point(422, 134);
            this.cmbdepartamento.Name = "cmbdepartamento";
            this.cmbdepartamento.Size = new System.Drawing.Size(121, 24);
            this.cmbdepartamento.TabIndex = 65;
            // 
            // cmbprofesion
            // 
            this.cmbprofesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbprofesion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbprofesion.FormattingEnabled = true;
            this.cmbprofesion.Location = new System.Drawing.Point(422, 87);
            this.cmbprofesion.Name = "cmbprofesion";
            this.cmbprofesion.Size = new System.Drawing.Size(121, 24);
            this.cmbprofesion.TabIndex = 64;
            // 
            // Msktel
            // 
            this.Msktel.Location = new System.Drawing.Point(205, 208);
            this.Msktel.Mask = "0000-0000";
            this.Msktel.Name = "Msktel";
            this.Msktel.Size = new System.Drawing.Size(100, 22);
            this.Msktel.TabIndex = 63;
            // 
            // txtdom
            // 
            this.txtdom.Location = new System.Drawing.Point(205, 164);
            this.txtdom.Name = "txtdom";
            this.txtdom.Size = new System.Drawing.Size(100, 22);
            this.txtdom.TabIndex = 62;
            // 
            // txtape
            // 
            this.txtape.Location = new System.Drawing.Point(205, 125);
            this.txtape.Name = "txtape";
            this.txtape.Size = new System.Drawing.Size(100, 22);
            this.txtape.TabIndex = 61;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(205, 88);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(100, 22);
            this.txtnom.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 59;
            this.label5.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 58;
            this.label4.Text = "Domicilio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 57;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 56;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 55;
            this.label1.Text = "Código";
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(205, 45);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(100, 22);
            this.txtcod.TabIndex = 54;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlMenu.Controls.Add(this.btnListarTraba);
            this.pnlMenu.Controls.Add(this.btnCerrar);
            this.pnlMenu.Controls.Add(this.btnBuscar);
            this.pnlMenu.Controls.Add(this.txtBuscar);
            this.pnlMenu.Controls.Add(this.btnGuardar);
            this.pnlMenu.Location = new System.Drawing.Point(22, 12);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(751, 48);
            this.pnlMenu.TabIndex = 63;
            // 
            // btnListarTraba
            // 
            this.btnListarTraba.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnListarTraba.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarTraba.Image = ((System.Drawing.Image)(resources.GetObject("btnListarTraba.Image")));
            this.btnListarTraba.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarTraba.Location = new System.Drawing.Point(425, 5);
            this.btnListarTraba.Name = "btnListarTraba";
            this.btnListarTraba.Size = new System.Drawing.Size(79, 38);
            this.btnListarTraba.TabIndex = 65;
            this.btnListarTraba.Text = "Listar";
            this.btnListarTraba.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListarTraba.UseVisualStyleBackColor = true;
            this.btnListarTraba.Click += new System.EventHandler(this.btnListarTraba_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            // FrmTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContenedor);
            this.Name = "FrmTrabajadores";
            this.Text = "FrmTrabajador";
            this.Load += new System.EventHandler(this.FrmTrabajador_Load);
            this.pnlContenedor.ResumeLayout(false);
            this.grbRegistrarTraba.ResumeLayout(false);
            this.grbRegistrarTraba.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnListarTraba;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox grbRegistrarTraba;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbmunicipio;
        private System.Windows.Forms.ComboBox cmbdepartamento;
        private System.Windows.Forms.ComboBox cmbprofesion;
        private System.Windows.Forms.MaskedTextBox Msktel;
        private System.Windows.Forms.TextBox txtdom;
        private System.Windows.Forms.TextBox txtape;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcod;
    }
}