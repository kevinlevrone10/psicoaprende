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
            this.button2 = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbfactura = new System.Windows.Forms.ComboBox();
            this.cmbtrabajador = new System.Windows.Forms.ComboBox();
            this.mskcant = new System.Windows.Forms.MaskedTextBox();
            this.datafecha = new System.Windows.Forms.DateTimePicker();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(97, 131);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbfactura
            // 
            this.cmbfactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfactura.FormattingEnabled = true;
            this.cmbfactura.Location = new System.Drawing.Point(583, 233);
            this.cmbfactura.Name = "cmbfactura";
            this.cmbfactura.Size = new System.Drawing.Size(121, 21);
            this.cmbfactura.TabIndex = 12;
            // 
            // cmbtrabajador
            // 
            this.cmbtrabajador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtrabajador.FormattingEnabled = true;
            this.cmbtrabajador.Location = new System.Drawing.Point(583, 181);
            this.cmbtrabajador.Name = "cmbtrabajador";
            this.cmbtrabajador.Size = new System.Drawing.Size(121, 21);
            this.cmbtrabajador.TabIndex = 11;
            // 
            // mskcant
            // 
            this.mskcant.Location = new System.Drawing.Point(284, 297);
            this.mskcant.Mask = "99";
            this.mskcant.Name = "mskcant";
            this.mskcant.Size = new System.Drawing.Size(100, 20);
            this.mskcant.TabIndex = 10;
            this.mskcant.ValidatingType = typeof(int);
            // 
            // datafecha
            // 
            this.datafecha.Location = new System.Drawing.Point(284, 244);
            this.datafecha.Name = "datafecha";
            this.datafecha.Size = new System.Drawing.Size(200, 20);
            this.datafecha.TabIndex = 9;
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(284, 182);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(100, 20);
            this.txtcod.TabIndex = 8;
            // 
            // FrmSesiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbfactura);
            this.Controls.Add(this.cmbtrabajador);
            this.Controls.Add(this.mskcant);
            this.Controls.Add(this.datafecha);
            this.Controls.Add(this.txtcod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSesiones";
            this.Text = "FrmSesiones";
            this.Load += new System.EventHandler(this.FrmSesiones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbfactura;
        private System.Windows.Forms.ComboBox cmbtrabajador;
        private System.Windows.Forms.MaskedTextBox mskcant;
        private System.Windows.Forms.DateTimePicker datafecha;
        private System.Windows.Forms.TextBox txtcod;
    }
}