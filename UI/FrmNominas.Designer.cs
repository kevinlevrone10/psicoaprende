namespace SistemaPsicoaprende.UI
{
    partial class FrmNominas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNominas));
            this.dateTimePickerPagoDesde = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerPagoHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaPago = new System.Windows.Forms.DateTimePicker();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.txtvia = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viatico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttol = new System.Windows.Forms.TextBox();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.grpBoxCalculo = new System.Windows.Forms.GroupBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCalcularNom = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGenerarNom = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpBoxFechas = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlContenedor.SuspendLayout();
            this.grpBoxCalculo.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpBoxFechas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerPagoDesde
            // 
            this.dateTimePickerPagoDesde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerPagoDesde.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerPagoDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPagoDesde.Location = new System.Drawing.Point(56, 50);
            this.dateTimePickerPagoDesde.Name = "dateTimePickerPagoDesde";
            this.dateTimePickerPagoDesde.Size = new System.Drawing.Size(97, 21);
            this.dateTimePickerPagoDesde.TabIndex = 0;
            // 
            // dateTimePickerPagoHasta
            // 
            this.dateTimePickerPagoHasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerPagoHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPagoHasta.Location = new System.Drawing.Point(226, 50);
            this.dateTimePickerPagoHasta.Name = "dateTimePickerPagoHasta";
            this.dateTimePickerPagoHasta.Size = new System.Drawing.Size(96, 21);
            this.dateTimePickerPagoHasta.TabIndex = 1;
            // 
            // dateTimePickerFechaPago
            // 
            this.dateTimePickerFechaPago.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaPago.Location = new System.Drawing.Point(379, 50);
            this.dateTimePickerFechaPago.Name = "dateTimePickerFechaPago";
            this.dateTimePickerFechaPago.Size = new System.Drawing.Size(105, 21);
            this.dateTimePickerFechaPago.TabIndex = 2;
            // 
            // txtcost
            // 
            this.txtcost.Location = new System.Drawing.Point(7, 43);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(100, 21);
            this.txtcost.TabIndex = 3;
            // 
            // txtvia
            // 
            this.txtvia.Location = new System.Drawing.Point(7, 91);
            this.txtvia.Name = "txtvia";
            this.txtvia.Size = new System.Drawing.Size(100, 21);
            this.txtvia.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trabajador,
            this.horas,
            this.total,
            this.viatico,
            this.salario});
            this.dataGridView1.Location = new System.Drawing.Point(20, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(536, 223);
            this.dataGridView1.TabIndex = 6;
            // 
            // trabajador
            // 
            this.trabajador.HeaderText = "Trabajadores";
            this.trabajador.Name = "trabajador";
            this.trabajador.ReadOnly = true;
            // 
            // horas
            // 
            this.horas.HeaderText = "Cantidad_Horas";
            this.horas.Name = "horas";
            this.horas.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // viatico
            // 
            this.viatico.HeaderText = "Viaticos";
            this.viatico.Name = "viatico";
            this.viatico.ReadOnly = true;
            // 
            // salario
            // 
            this.salario.HeaderText = "Salario neto";
            this.salario.Name = "salario";
            this.salario.ReadOnly = true;
            // 
            // txttol
            // 
            this.txttol.Location = new System.Drawing.Point(7, 142);
            this.txttol.Name = "txttol";
            this.txttol.ReadOnly = true;
            this.txttol.Size = new System.Drawing.Size(100, 21);
            this.txttol.TabIndex = 11;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.grpBoxCalculo);
            this.pnlContenedor.Controls.Add(this.pnlMenu);
            this.pnlContenedor.Controls.Add(this.groupBox1);
            this.pnlContenedor.Controls.Add(this.grpBoxFechas);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(800, 450);
            this.pnlContenedor.TabIndex = 13;
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenedor_Paint);
            // 
            // grpBoxCalculo
            // 
            this.grpBoxCalculo.BackColor = System.Drawing.Color.Silver;
            this.grpBoxCalculo.Controls.Add(this.dataGridView1);
            this.grpBoxCalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.grpBoxCalculo.Location = new System.Drawing.Point(62, 182);
            this.grpBoxCalculo.Name = "grpBoxCalculo";
            this.grpBoxCalculo.Size = new System.Drawing.Size(574, 256);
            this.grpBoxCalculo.TabIndex = 66;
            this.grpBoxCalculo.TabStop = false;
            this.grpBoxCalculo.Text = "Costo";
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlMenu.Controls.Add(this.btnCalcularNom);
            this.pnlMenu.Controls.Add(this.btnCancelar);
            this.pnlMenu.Controls.Add(this.btnGenerarNom);
            this.pnlMenu.Location = new System.Drawing.Point(205, 12);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(416, 53);
            this.pnlMenu.TabIndex = 64;
            // 
            // btnCalcularNom
            // 
            this.btnCalcularNom.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCalcularNom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcularNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularNom.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcularNom.Image")));
            this.btnCalcularNom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcularNom.Location = new System.Drawing.Point(117, 9);
            this.btnCalcularNom.Name = "btnCalcularNom";
            this.btnCalcularNom.Size = new System.Drawing.Size(146, 38);
            this.btnCalcularNom.TabIndex = 65;
            this.btnCalcularNom.Text = "Cálcular Nómina";
            this.btnCalcularNom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcularNom.UseVisualStyleBackColor = true;
            this.btnCalcularNom.Click += new System.EventHandler(this.btnCalcularNom_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(17, 9);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 37);
            this.btnCancelar.TabIndex = 64;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGenerarNom
            // 
            this.btnGenerarNom.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGenerarNom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarNom.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarNom.Image")));
            this.btnGenerarNom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarNom.Location = new System.Drawing.Point(269, 9);
            this.btnGenerarNom.Name = "btnGenerarNom";
            this.btnGenerarNom.Size = new System.Drawing.Size(142, 38);
            this.btnGenerarNom.TabIndex = 61;
            this.btnGenerarNom.Text = "Generar Nómina";
            this.btnGenerarNom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarNom.UseVisualStyleBackColor = true;
            this.btnGenerarNom.Click += new System.EventHandler(this.btnGenerarNom_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtvia);
            this.groupBox1.Controls.Add(this.txtcost);
            this.groupBox1.Controls.Add(this.txttol);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(659, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 183);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cálculos";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 79;
            this.label2.Text = "Costo por Hora";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 79;
            this.label3.Text = "Viatíco";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 79;
            this.label6.Text = "Total a Pagar";
            // 
            // grpBoxFechas
            // 
            this.grpBoxFechas.BackColor = System.Drawing.Color.Silver;
            this.grpBoxFechas.Controls.Add(this.label5);
            this.grpBoxFechas.Controls.Add(this.label4);
            this.grpBoxFechas.Controls.Add(this.label8);
            this.grpBoxFechas.Controls.Add(this.dateTimePickerPagoHasta);
            this.grpBoxFechas.Controls.Add(this.dateTimePickerPagoDesde);
            this.grpBoxFechas.Controls.Add(this.dateTimePickerFechaPago);
            this.grpBoxFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.grpBoxFechas.Location = new System.Drawing.Point(62, 82);
            this.grpBoxFechas.Name = "grpBoxFechas";
            this.grpBoxFechas.Size = new System.Drawing.Size(574, 83);
            this.grpBoxFechas.TabIndex = 16;
            this.grpBoxFechas.TabStop = false;
            this.grpBoxFechas.Text = "Asginación de Fechas";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(376, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 15);
            this.label5.TabIndex = 79;
            this.label5.Text = "Emisión de la Nómina";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(223, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 78;
            this.label4.Text = "Hasta";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(53, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 77;
            this.label8.Text = "Desde ";
            // 
            // FrmNominas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContenedor);
            this.Name = "FrmNominas";
            this.Text = "FrmNominas";
            this.Load += new System.EventHandler(this.FrmNominas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlContenedor.ResumeLayout(false);
            this.grpBoxCalculo.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBoxFechas.ResumeLayout(false);
            this.grpBoxFechas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerPagoDesde;
        private System.Windows.Forms.DateTimePicker dateTimePickerPagoHasta;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaPago;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.TextBox txtvia;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txttol;
        private System.Windows.Forms.DataGridViewTextBoxColumn trabajador;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn viatico;
        private System.Windows.Forms.DataGridViewTextBoxColumn salario;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpBoxFechas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnCalcularNom;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGenerarNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpBoxCalculo;
    }
}