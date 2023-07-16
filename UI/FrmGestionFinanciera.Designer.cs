namespace SistemaPsicoaprende.UI
{
    partial class FrmGestionFinanciera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionFinanciera));
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnNomina = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.pnlContenedor.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.White;
            this.pnlContenedor.Controls.Add(this.pnlMenu);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(800, 450);
            this.pnlContenedor.TabIndex = 48;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Silver;
            this.pnlMenu.Controls.Add(this.btnCerrar);
            this.pnlMenu.Controls.Add(this.btnNomina);
            this.pnlMenu.Controls.Add(this.btnFactura);
            this.pnlMenu.Location = new System.Drawing.Point(275, 118);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(264, 245);
            this.pnlMenu.TabIndex = 50;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(89, 205);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(89, 37);
            this.btnCerrar.TabIndex = 65;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnNomina
            // 
            this.btnNomina.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNomina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNomina.FlatAppearance.BorderSize = 0;
            this.btnNomina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnNomina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNomina.ForeColor = System.Drawing.Color.White;
            this.btnNomina.Image = ((System.Drawing.Image)(resources.GetObject("btnNomina.Image")));
            this.btnNomina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNomina.Location = new System.Drawing.Point(18, 127);
            this.btnNomina.Name = "btnNomina";
            this.btnNomina.Size = new System.Drawing.Size(225, 53);
            this.btnNomina.TabIndex = 49;
            this.btnNomina.Text = "Nómina";
            this.btnNomina.UseVisualStyleBackColor = false;
            this.btnNomina.Click += new System.EventHandler(this.btnNomina_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFactura.FlatAppearance.BorderSize = 0;
            this.btnFactura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactura.ForeColor = System.Drawing.Color.White;
            this.btnFactura.Image = ((System.Drawing.Image)(resources.GetObject("btnFactura.Image")));
            this.btnFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFactura.Location = new System.Drawing.Point(18, 41);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(225, 53);
            this.btnFactura.TabIndex = 48;
            this.btnFactura.Text = "Factura";
            this.btnFactura.UseVisualStyleBackColor = false;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // FrmGestionFinanciera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContenedor);
            this.Name = "FrmGestionFinanciera";
            this.Text = "FrmGestionFinanciera";
            this.pnlContenedor.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Button btnNomina;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnCerrar;
    }
}