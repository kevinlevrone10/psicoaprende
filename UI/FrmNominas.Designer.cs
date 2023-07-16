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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerPagoDesde
            // 
            this.dateTimePickerPagoDesde.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerPagoDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPagoDesde.Location = new System.Drawing.Point(46, 53);
            this.dateTimePickerPagoDesde.Name = "dateTimePickerPagoDesde";
            this.dateTimePickerPagoDesde.Size = new System.Drawing.Size(97, 20);
            this.dateTimePickerPagoDesde.TabIndex = 0;
            // 
            // dateTimePickerPagoHasta
            // 
            this.dateTimePickerPagoHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPagoHasta.Location = new System.Drawing.Point(277, 53);
            this.dateTimePickerPagoHasta.Name = "dateTimePickerPagoHasta";
            this.dateTimePickerPagoHasta.Size = new System.Drawing.Size(96, 20);
            this.dateTimePickerPagoHasta.TabIndex = 1;
            // 
            // dateTimePickerFechaPago
            // 
            this.dateTimePickerFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaPago.Location = new System.Drawing.Point(507, 53);
            this.dateTimePickerFechaPago.Name = "dateTimePickerFechaPago";
            this.dateTimePickerFechaPago.Size = new System.Drawing.Size(105, 20);
            this.dateTimePickerFechaPago.TabIndex = 2;
            // 
            // txtcost
            // 
            this.txtcost.Location = new System.Drawing.Point(158, 126);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(100, 20);
            this.txtcost.TabIndex = 3;
            // 
            // txtvia
            // 
            this.txtvia.Location = new System.Drawing.Point(289, 126);
            this.txtvia.Name = "txtvia";
            this.txtvia.Size = new System.Drawing.Size(100, 20);
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
            this.dataGridView1.Location = new System.Drawing.Point(96, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(536, 193);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "generar calculos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(277, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Generar Nomina";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "costo por hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "viaticos";
            // 
            // txttol
            // 
            this.txttol.Location = new System.Drawing.Point(512, 351);
            this.txttol.Name = "txttol";
            this.txttol.ReadOnly = true;
            this.txttol.Size = new System.Drawing.Size(100, 20);
            this.txttol.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total a pagar";
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.label6);
            this.pnlContenedor.Controls.Add(this.label5);
            this.pnlContenedor.Controls.Add(this.label4);
            this.pnlContenedor.Controls.Add(this.dateTimePickerFechaPago);
            this.pnlContenedor.Controls.Add(this.label3);
            this.pnlContenedor.Controls.Add(this.dateTimePickerPagoDesde);
            this.pnlContenedor.Controls.Add(this.txttol);
            this.pnlContenedor.Controls.Add(this.dateTimePickerPagoHasta);
            this.pnlContenedor.Controls.Add(this.button2);
            this.pnlContenedor.Controls.Add(this.label2);
            this.pnlContenedor.Controls.Add(this.dataGridView1);
            this.pnlContenedor.Controls.Add(this.button1);
            this.pnlContenedor.Controls.Add(this.label1);
            this.pnlContenedor.Controls.Add(this.txtcost);
            this.pnlContenedor.Controls.Add(this.txtvia);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(800, 450);
            this.pnlContenedor.TabIndex = 13;
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenedor_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fecha de Emision";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "hasta la fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "desde la fecha";
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
            this.pnlContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerPagoDesde;
        private System.Windows.Forms.DateTimePicker dateTimePickerPagoHasta;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaPago;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.TextBox txtvia;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttol;
        private System.Windows.Forms.DataGridViewTextBoxColumn trabajador;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn viatico;
        private System.Windows.Forms.DataGridViewTextBoxColumn salario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}