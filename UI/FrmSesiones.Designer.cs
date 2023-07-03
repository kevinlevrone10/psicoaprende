namespace SistemaPsicoaprende.UI
{
    partial class FrmSesiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSesiones));
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.grpBoxSesiones = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbtrabajador = new System.Windows.Forms.ComboBox();
            this.cmbfactura = new System.Windows.Forms.ComboBox();
            this.mskcant = new System.Windows.Forms.MaskedTextBox();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.datafecha = new System.Windows.Forms.DateTimePicker();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnListarEstu = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pnlContenedor.SuspendLayout();
            this.grpBoxSesiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.grpBoxSesiones);
            this.pnlContenedor.Controls.Add(this.pnlMenu);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(800, 450);
            this.pnlContenedor.TabIndex = 16;
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenedor_Paint);
            // 
            // grpBoxSesiones
            // 
            this.grpBoxSesiones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxSesiones.BackColor = System.Drawing.Color.Silver;
            this.grpBoxSesiones.Controls.Add(this.dataGridView2);
            this.grpBoxSesiones.Controls.Add(this.dataGridView1);
            this.grpBoxSesiones.Controls.Add(this.label5);
            this.grpBoxSesiones.Controls.Add(this.label4);
            this.grpBoxSesiones.Controls.Add(this.label3);
            this.grpBoxSesiones.Controls.Add(this.label2);
            this.grpBoxSesiones.Controls.Add(this.label1);
            this.grpBoxSesiones.Controls.Add(this.cmbtrabajador);
            this.grpBoxSesiones.Controls.Add(this.cmbfactura);
            this.grpBoxSesiones.Controls.Add(this.mskcant);
            this.grpBoxSesiones.Controls.Add(this.txtcod);
            this.grpBoxSesiones.Controls.Add(this.datafecha);
            this.grpBoxSesiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxSesiones.Location = new System.Drawing.Point(31, 76);
            this.grpBoxSesiones.Name = "grpBoxSesiones";
            this.grpBoxSesiones.Size = new System.Drawing.Size(741, 314);
            this.grpBoxSesiones.TabIndex = 64;
            this.grpBoxSesiones.TabStop = false;
            this.grpBoxSesiones.Text = "Registrar Sesiones";
            this.grpBoxSesiones.Enter += new System.EventHandler(this.grpBoxSesiones_Enter);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificador,
            this.Cod,
            this.estudiante,
            this.Edit2});
            this.dataGridView2.Location = new System.Drawing.Point(392, 158);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(349, 150);
            this.dataGridView2.TabIndex = 75;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Identificador
            // 
            this.Identificador.HeaderText = "Id";
            this.Identificador.Name = "Identificador";
            this.Identificador.Visible = false;
            // 
            // Cod
            // 
            this.Cod.HeaderText = "Codigo";
            this.Cod.Name = "Cod";
            // 
            // estudiante
            // 
            this.estudiante.HeaderText = "Alumno";
            this.estudiante.Name = "estudiante";
            this.estudiante.ReadOnly = true;
            // 
            // Edit2
            // 
            this.Edit2.HeaderText = "Seleccionado";
            this.Edit2.Name = "Edit2";
            this.Edit2.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.codigo,
            this.nombre,
            this.Edit});
            this.dataGridView1.Location = new System.Drawing.Point(20, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(360, 150);
            this.dataGridView1.TabIndex = 65;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Seleccionado";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(520, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 15);
            this.label5.TabIndex = 74;
            this.label5.Text = "Código de la Factura";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(520, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 73;
            this.label4.Text = "Trabajador";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(255, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 72;
            this.label3.Text = "Fehca de la sesión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 15);
            this.label2.TabIndex = 71;
            this.label2.Text = "Cantidad de Horas de la sesión";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(71, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 70;
            this.label1.Text = "Código";
            // 
            // cmbtrabajador
            // 
            this.cmbtrabajador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbtrabajador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtrabajador.FormattingEnabled = true;
            this.cmbtrabajador.Location = new System.Drawing.Point(523, 50);
            this.cmbtrabajador.Name = "cmbtrabajador";
            this.cmbtrabajador.Size = new System.Drawing.Size(137, 24);
            this.cmbtrabajador.TabIndex = 19;
            // 
            // cmbfactura
            // 
            this.cmbfactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbfactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfactura.FormattingEnabled = true;
            this.cmbfactura.Location = new System.Drawing.Point(523, 115);
            this.cmbfactura.Name = "cmbfactura";
            this.cmbfactura.Size = new System.Drawing.Size(137, 24);
            this.cmbfactura.TabIndex = 20;
            // 
            // mskcant
            // 
            this.mskcant.Location = new System.Drawing.Point(29, 115);
            this.mskcant.Mask = "99";
            this.mskcant.Name = "mskcant";
            this.mskcant.Size = new System.Drawing.Size(145, 22);
            this.mskcant.TabIndex = 18;
            this.mskcant.ValidatingType = typeof(int);
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(29, 52);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(145, 22);
            this.txtcod.TabIndex = 16;
            // 
            // datafecha
            // 
            this.datafecha.Location = new System.Drawing.Point(252, 52);
            this.datafecha.Name = "datafecha";
            this.datafecha.Size = new System.Drawing.Size(200, 22);
            this.datafecha.TabIndex = 17;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlMenu.Controls.Add(this.btnListarEstu);
            this.pnlMenu.Controls.Add(this.btnCerrar);
            this.pnlMenu.Controls.Add(this.btnGuardar);
            this.pnlMenu.Controls.Add(this.btnBuscar);
            this.pnlMenu.Controls.Add(this.txtBuscar);
            this.pnlMenu.Location = new System.Drawing.Point(22, 22);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(751, 48);
            this.pnlMenu.TabIndex = 63;
            // 
            // btnListarEstu
            // 
            this.btnListarEstu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnListarEstu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarEstu.Image = ((System.Drawing.Image)(resources.GetObject("btnListarEstu.Image")));
            this.btnListarEstu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarEstu.Location = new System.Drawing.Point(436, 5);
            this.btnListarEstu.Name = "btnListarEstu";
            this.btnListarEstu.Size = new System.Drawing.Size(79, 38);
            this.btnListarEstu.TabIndex = 65;
            this.btnListarEstu.Text = "Listar";
            this.btnListarEstu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListarEstu.UseVisualStyleBackColor = true;
            this.btnListarEstu.Click += new System.EventHandler(this.btnListarEstu_Click);
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
            this.txtBuscar.Location = new System.Drawing.Point(122, 5);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(204, 38);
            this.txtBuscar.TabIndex = 62;
            // 
            // FrmSesiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSesiones";
            this.Text = "FrmSesiones";
            this.Load += new System.EventHandler(this.FrmSesiones_Load);
            this.pnlContenedor.ResumeLayout(false);
            this.grpBoxSesiones.ResumeLayout(false);
            this.grpBoxSesiones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.ComboBox cmbfactura;
        private System.Windows.Forms.ComboBox cmbtrabajador;
        private System.Windows.Forms.MaskedTextBox mskcant;
        private System.Windows.Forms.DateTimePicker datafecha;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox grpBoxSesiones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListarEstu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edit2;
    }
}