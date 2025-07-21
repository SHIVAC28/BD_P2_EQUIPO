namespace Ventas_SHIVAC
{
    partial class FrmAltaClientes
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
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblNumRep = new System.Windows.Forms.Label();
            this.lblLimCred = new System.Windows.Forms.Label();
            this.lblNivelClie = new System.Windows.Forms.Label();
            this.nudLimCred = new System.Windows.Forms.NumericUpDown();
            this.cmbNumRep = new System.Windows.Forms.ComboBox();
            this.cmbNivelCliente = new System.Windows.Forms.ComboBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimCred)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(52, 56);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(51, 13);
            this.lblEmpresa.TabIndex = 1;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // lblNumRep
            // 
            this.lblNumRep.AutoSize = true;
            this.lblNumRep.Location = new System.Drawing.Point(52, 96);
            this.lblNumRep.Name = "lblNumRep";
            this.lblNumRep.Size = new System.Drawing.Size(132, 13);
            this.lblNumRep.TabIndex = 2;
            this.lblNumRep.Text = "Representante del Cliente:";
            // 
            // lblLimCred
            // 
            this.lblLimCred.AutoSize = true;
            this.lblLimCred.Location = new System.Drawing.Point(52, 135);
            this.lblLimCred.Name = "lblLimCred";
            this.lblLimCred.Size = new System.Drawing.Size(90, 13);
            this.lblLimCred.TabIndex = 3;
            this.lblLimCred.Text = "Límite de Crédito:";
            // 
            // lblNivelClie
            // 
            this.lblNivelClie.AutoSize = true;
            this.lblNivelClie.Location = new System.Drawing.Point(52, 174);
            this.lblNivelClie.Name = "lblNivelClie";
            this.lblNivelClie.Size = new System.Drawing.Size(84, 13);
            this.lblNivelClie.TabIndex = 4;
            this.lblNivelClie.Text = "Nivel de Cliente:";
            // 
            // nudLimCred
            // 
            this.nudLimCred.DecimalPlaces = 2;
            this.nudLimCred.Location = new System.Drawing.Point(206, 133);
            this.nudLimCred.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudLimCred.Name = "nudLimCred";
            this.nudLimCred.Size = new System.Drawing.Size(120, 20);
            this.nudLimCred.TabIndex = 10;
            this.nudLimCred.ThousandsSeparator = true;
            // 
            // cmbNumRep
            // 
            this.cmbNumRep.FormattingEnabled = true;
            this.cmbNumRep.Location = new System.Drawing.Point(206, 87);
            this.cmbNumRep.Name = "cmbNumRep";
            this.cmbNumRep.Size = new System.Drawing.Size(121, 21);
            this.cmbNumRep.TabIndex = 11;
            // 
            // cmbNivelCliente
            // 
            this.cmbNivelCliente.FormattingEnabled = true;
            this.cmbNivelCliente.Location = new System.Drawing.Point(206, 165);
            this.cmbNivelCliente.Name = "cmbNivelCliente";
            this.cmbNivelCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbNivelCliente.TabIndex = 12;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(130, 237);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(162, 23);
            this.btnInsertar.TabIndex = 13;
            this.btnInsertar.Text = "Insertar Cliente";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(206, 49);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(170, 20);
            this.txtEmpresa.TabIndex = 6;
            // 
            // FrmAltaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 314);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.cmbNivelCliente);
            this.Controls.Add(this.cmbNumRep);
            this.Controls.Add(this.nudLimCred);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.lblNivelClie);
            this.Controls.Add(this.lblLimCred);
            this.Controls.Add(this.lblNumRep);
            this.Controls.Add(this.lblEmpresa);
            this.Name = "FrmAltaClientes";
            this.Text = "FrmAltaClientes";
            this.Load += new System.EventHandler(this.FrmAltaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudLimCred)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblNumRep;
        private System.Windows.Forms.Label lblLimCred;
        private System.Windows.Forms.Label lblNivelClie;
        private System.Windows.Forms.NumericUpDown nudLimCred;
        private System.Windows.Forms.ComboBox cmbNumRep;
        private System.Windows.Forms.ComboBox cmbNivelCliente;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtEmpresa;
    }
}