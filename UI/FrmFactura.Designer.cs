﻿namespace SistemaPsicoaprende.UI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFactura));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnListarEstu = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpBoxCalculo = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CostoSesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadSesiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpGenerales = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodfac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.cmbmod = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtest = new System.Windows.Forms.TextBox();
            this.grpBoxEmisionFact = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlMenu.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpBoxCalculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpGenerales.SuspendLayout();
            this.grpBoxEmisionFact.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlMenu.Controls.Add(this.btnListarEstu);
            this.pnlMenu.Controls.Add(this.btnBuscar);
            this.pnlMenu.Controls.Add(this.txtBuscar);
            this.pnlMenu.Controls.Add(this.btnCalcular);
            this.pnlMenu.Controls.Add(this.btnCerrar);
            this.pnlMenu.Controls.Add(this.btnGuardar);
            this.pnlMenu.Location = new System.Drawing.Point(31, 12);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(747, 53);
            this.pnlMenu.TabIndex = 63;
            // 
            // btnListarEstu
            // 
            this.btnListarEstu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnListarEstu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarEstu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarEstu.Image = ((System.Drawing.Image)(resources.GetObject("btnListarEstu.Image")));
            this.btnListarEstu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarEstu.Location = new System.Drawing.Point(439, 9);
            this.btnListarEstu.Name = "btnListarEstu";
            this.btnListarEstu.Size = new System.Drawing.Size(79, 38);
            this.btnListarEstu.TabIndex = 68;
            this.btnListarEstu.Text = "Listar";
            this.btnListarEstu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListarEstu.UseVisualStyleBackColor = true;
            this.btnListarEstu.Click += new System.EventHandler(this.btnListarEstu_Click);
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
            this.btnBuscar.Location = new System.Drawing.Point(6, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(89, 38);
            this.btnBuscar.TabIndex = 67;
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
            this.txtBuscar.Location = new System.Drawing.Point(116, 10);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(196, 38);
            this.txtBuscar.TabIndex = 66;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(538, 9);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(98, 38);
            this.btnCalcular.TabIndex = 65;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(330, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(94, 37);
            this.btnCerrar.TabIndex = 64;
            this.btnCerrar.Text = "Cancelar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(653, 9);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 38);
            this.btnGuardar.TabIndex = 61;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.groupBox1);
            this.pnlContenedor.Controls.Add(this.pnlMenu);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(800, 450);
            this.pnlContenedor.TabIndex = 67;
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenedor_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpBoxCalculo);
            this.groupBox1.Controls.Add(this.grpGenerales);
            this.groupBox1.Controls.Add(this.grpBoxEmisionFact);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 329);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Factura";
            // 
            // grpBoxCalculo
            // 
            this.grpBoxCalculo.BackColor = System.Drawing.Color.Silver;
            this.grpBoxCalculo.Controls.Add(this.dataGridView1);
            this.grpBoxCalculo.Location = new System.Drawing.Point(410, 34);
            this.grpBoxCalculo.Name = "grpBoxCalculo";
            this.grpBoxCalculo.Size = new System.Drawing.Size(351, 203);
            this.grpBoxCalculo.TabIndex = 68;
            this.grpBoxCalculo.TabStop = false;
            this.grpBoxCalculo.Text = "Costo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CostoSesion,
            this.CantidadSesiones,
            this.CostoFinal});
            this.dataGridView1.Location = new System.Drawing.Point(6, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(336, 150);
            this.dataGridView1.TabIndex = 10;
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
            // grpGenerales
            // 
            this.grpGenerales.BackColor = System.Drawing.Color.Silver;
            this.grpGenerales.Controls.Add(this.label1);
            this.grpGenerales.Controls.Add(this.txtcodfac);
            this.grpGenerales.Controls.Add(this.label5);
            this.grpGenerales.Controls.Add(this.label4);
            this.grpGenerales.Controls.Add(this.label7);
            this.grpGenerales.Controls.Add(this.txtcant);
            this.grpGenerales.Controls.Add(this.cmbmod);
            this.grpGenerales.Controls.Add(this.txtid);
            this.grpGenerales.Controls.Add(this.txtcod);
            this.grpGenerales.Controls.Add(this.txtcost);
            this.grpGenerales.Controls.Add(this.label2);
            this.grpGenerales.Controls.Add(this.txtest);
            this.grpGenerales.Location = new System.Drawing.Point(6, 32);
            this.grpGenerales.Name = "grpGenerales";
            this.grpGenerales.Size = new System.Drawing.Size(394, 205);
            this.grpGenerales.TabIndex = 67;
            this.grpGenerales.TabStop = false;
            this.grpGenerales.Text = "Asignación de las Sesones";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(211, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 15);
            this.label1.TabIndex = 76;
            this.label1.Text = "Cantidad de Sesiones";
            // 
            // txtcodfac
            // 
            this.txtcodfac.Location = new System.Drawing.Point(214, 21);
            this.txtcodfac.Name = "txtcodfac";
            this.txtcodfac.Size = new System.Drawing.Size(100, 22);
            this.txtcodfac.TabIndex = 68;
            this.txtcodfac.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(10, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 15);
            this.label5.TabIndex = 75;
            this.label5.Text = "Digite el Código del Alumno";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 74;
            this.label4.Text = "Alumno";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(211, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 73;
            this.label7.Text = "Modalidad";
            // 
            // txtcant
            // 
            this.txtcant.Location = new System.Drawing.Point(214, 179);
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(121, 22);
            this.txtcant.TabIndex = 0;
            // 
            // cmbmod
            // 
            this.cmbmod.FormattingEnabled = true;
            this.cmbmod.Location = new System.Drawing.Point(214, 115);
            this.cmbmod.Name = "cmbmod";
            this.cmbmod.Size = new System.Drawing.Size(121, 24);
            this.cmbmod.TabIndex = 6;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(214, 49);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 15;
            this.txtid.Visible = false;
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(13, 49);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(183, 22);
            this.txtcod.TabIndex = 13;
            this.txtcod.TextChanged += new System.EventHandler(this.txtcod_TextChanged_1);
            // 
            // txtcost
            // 
            this.txtcost.Location = new System.Drawing.Point(13, 178);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(100, 22);
            this.txtcost.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Costo de la  sesión";
            // 
            // txtest
            // 
            this.txtest.Location = new System.Drawing.Point(13, 115);
            this.txtest.Name = "txtest";
            this.txtest.ReadOnly = true;
            this.txtest.Size = new System.Drawing.Size(166, 22);
            this.txtest.TabIndex = 9;
            // 
            // grpBoxEmisionFact
            // 
            this.grpBoxEmisionFact.BackColor = System.Drawing.Color.Silver;
            this.grpBoxEmisionFact.Controls.Add(this.label3);
            this.grpBoxEmisionFact.Controls.Add(this.Fecha);
            this.grpBoxEmisionFact.Location = new System.Drawing.Point(220, 261);
            this.grpBoxEmisionFact.Name = "grpBoxEmisionFact";
            this.grpBoxEmisionFact.Size = new System.Drawing.Size(394, 62);
            this.grpBoxEmisionFact.TabIndex = 66;
            this.grpBoxEmisionFact.TabStop = false;
            this.grpBoxEmisionFact.Text = "Emisión de la Factura";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 75;
            this.label3.Text = "Fecha de Emisón";
            // 
            // Fecha
            // 
            this.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fecha.Location = new System.Drawing.Point(147, 30);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(125, 22);
            this.Fecha.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContenedor);
            this.Name = "FrmFactura";
            this.Text = "FrmFactura";
            this.Load += new System.EventHandler(this.FrmFactura_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlContenedor.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grpBoxCalculo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpGenerales.ResumeLayout(false);
            this.grpGenerales.PerformLayout();
            this.grpBoxEmisionFact.ResumeLayout(false);
            this.grpBoxEmisionFact.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnListarEstu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpBoxCalculo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoSesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadSesiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoFinal;
        private System.Windows.Forms.GroupBox grpGenerales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodfac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.ComboBox cmbmod;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtest;
        private System.Windows.Forms.GroupBox grpBoxEmisionFact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Fecha;
    }
}