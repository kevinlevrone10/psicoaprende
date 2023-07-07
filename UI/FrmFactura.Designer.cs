namespace SistemaPsicoaprende.UI
{
    partial class FrmFactura
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
            this.txtcant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbmod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtest = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CostoSesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadSesiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEmitir = new System.Windows.Forms.Button();
            this.Btncal = new System.Windows.Forms.Button();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcant
            // 
            this.txtcant.Location = new System.Drawing.Point(189, 89);
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(100, 20);
            this.txtcant.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "cantidad sesiones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "costo sesion";
            // 
            // txtcost
            // 
            this.txtcost.Location = new System.Drawing.Point(189, 125);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(100, 20);
            this.txtcost.TabIndex = 3;
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(189, 167);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(200, 20);
            this.Fecha.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "fecha factura";
            // 
            // cmbmod
            // 
            this.cmbmod.FormattingEnabled = true;
            this.cmbmod.Location = new System.Drawing.Point(189, 213);
            this.cmbmod.Name = "cmbmod";
            this.cmbmod.Size = new System.Drawing.Size(121, 21);
            this.cmbmod.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "modalidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Alumno";
            // 
            // txtest
            // 
            this.txtest.Location = new System.Drawing.Point(189, 251);
            this.txtest.Name = "txtest";
            this.txtest.ReadOnly = true;
            this.txtest.Size = new System.Drawing.Size(100, 20);
            this.txtest.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CostoSesion,
            this.CantidadSesiones,
            this.CostoFinal});
            this.dataGridView1.Location = new System.Drawing.Point(400, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(336, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CostoSesion
            // 
            this.CostoSesion.HeaderText = "Costo";
            this.CostoSesion.Name = "CostoSesion";
            this.CostoSesion.ReadOnly = true;
            // 
            // CantidadSesiones
            // 
            this.CantidadSesiones.HeaderText = "cantidad";
            this.CantidadSesiones.Name = "CantidadSesiones";
            this.CantidadSesiones.ReadOnly = true;
            // 
            // CostoFinal
            // 
            this.CostoFinal.HeaderText = "Total";
            this.CostoFinal.Name = "CostoFinal";
            this.CostoFinal.ReadOnly = true;
            // 
            // BtnEmitir
            // 
            this.BtnEmitir.Location = new System.Drawing.Point(104, 313);
            this.BtnEmitir.Name = "BtnEmitir";
            this.BtnEmitir.Size = new System.Drawing.Size(124, 23);
            this.BtnEmitir.TabIndex = 11;
            this.BtnEmitir.Text = "Emitir factura";
            this.BtnEmitir.UseVisualStyleBackColor = true;
            this.BtnEmitir.Click += new System.EventHandler(this.BtnEmitir_Click);
            // 
            // Btncal
            // 
            this.Btncal.Location = new System.Drawing.Point(506, 360);
            this.Btncal.Name = "Btncal";
            this.Btncal.Size = new System.Drawing.Size(121, 23);
            this.Btncal.TabIndex = 12;
            this.Btncal.Text = "Calcular total";
            this.Btncal.UseVisualStyleBackColor = true;
            this.Btncal.Click += new System.EventHandler(this.Btncal_Click);
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(379, 25);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(100, 20);
            this.txtcod.TabIndex = 13;
            this.txtcod.TextChanged += new System.EventHandler(this.txtcod_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Digite codigo alumno";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(43, 25);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 15;
            this.txtid.Visible = false;
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.Btncal);
            this.Controls.Add(this.BtnEmitir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbmod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.txtcost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcant);
            this.Name = "FrmFactura";
            this.Text = "FrmFactura";
            this.Load += new System.EventHandler(this.FrmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbmod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtest;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnEmitir;
        private System.Windows.Forms.Button Btncal;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoSesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadSesiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoFinal;
    }
}