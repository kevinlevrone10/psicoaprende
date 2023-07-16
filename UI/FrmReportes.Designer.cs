namespace SistemaPsicoaprende
{
    partial class FrmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnReportNomina = new System.Windows.Forms.Button();
            this.btnReportFactura = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Silver;
            this.pnlMenu.Controls.Add(this.btnCerrar);
            this.pnlMenu.Controls.Add(this.btnReportNomina);
            this.pnlMenu.Controls.Add(this.btnReportFactura);
            this.pnlMenu.Location = new System.Drawing.Point(275, 118);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(264, 245);
            this.pnlMenu.TabIndex = 51;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(89, 187);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(89, 37);
            this.btnCerrar.TabIndex = 65;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnReportNomina
            // 
            this.btnReportNomina.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReportNomina.FlatAppearance.BorderSize = 0;
            this.btnReportNomina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnReportNomina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportNomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportNomina.ForeColor = System.Drawing.Color.White;
            this.btnReportNomina.Image = ((System.Drawing.Image)(resources.GetObject("btnReportNomina.Image")));
            this.btnReportNomina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportNomina.Location = new System.Drawing.Point(18, 117);
            this.btnReportNomina.Name = "btnReportNomina";
            this.btnReportNomina.Size = new System.Drawing.Size(225, 53);
            this.btnReportNomina.TabIndex = 49;
            this.btnReportNomina.Text = "   Reporte de Nómina";
            this.btnReportNomina.UseVisualStyleBackColor = false;
            this.btnReportNomina.Click += new System.EventHandler(this.btnReportNomina_Click);
            // 
            // btnReportFactura
            // 
            this.btnReportFactura.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReportFactura.FlatAppearance.BorderSize = 0;
            this.btnReportFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnReportFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportFactura.ForeColor = System.Drawing.Color.White;
            this.btnReportFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnReportFactura.Image")));
            this.btnReportFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportFactura.Location = new System.Drawing.Point(18, 41);
            this.btnReportFactura.Name = "btnReportFactura";
            this.btnReportFactura.Size = new System.Drawing.Size(225, 53);
            this.btnReportFactura.TabIndex = 48;
            this.btnReportFactura.Text = "   Reporte de Factura";
            this.btnReportFactura.UseVisualStyleBackColor = false;
            this.btnReportFactura.Click += new System.EventHandler(this.btnReportFactura_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Controls.Add(this.pnlMenu);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(800, 450);
            this.pnlContenedor.TabIndex = 52;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContenedor);
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.pnlMenu.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnReportNomina;
        private System.Windows.Forms.Button btnReportFactura;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}