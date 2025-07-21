namespace Ventas_SHIVAC
{
    partial class FrmActualizarClientes
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cmbResEstCliente = new System.Windows.Forms.ComboBox();
            this.cmbResNumRep = new System.Windows.Forms.ComboBox();
            this.nudResLimCred = new System.Windows.Forms.NumericUpDown();
            this.lblEstadoClie = new System.Windows.Forms.Label();
            this.lblLimCred = new System.Windows.Forms.Label();
            this.lblNumRep = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.cmbResEmp = new System.Windows.Forms.ComboBox();
            this.cmbResNivelClie = new System.Windows.Forms.ComboBox();
            this.lblNivel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudResLimCred)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(127, 247);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(162, 23);
            this.btnActualizar.TabIndex = 22;
            this.btnActualizar.Text = "Actualizar Cliente";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cmbResEstCliente
            // 
            this.cmbResEstCliente.FormattingEnabled = true;
            this.cmbResEstCliente.Location = new System.Drawing.Point(205, 162);
            this.cmbResEstCliente.Name = "cmbResEstCliente";
            this.cmbResEstCliente.Size = new System.Drawing.Size(121, 21);
            this.cmbResEstCliente.TabIndex = 21;
            // 
            // cmbResNumRep
            // 
            this.cmbResNumRep.FormattingEnabled = true;
            this.cmbResNumRep.Location = new System.Drawing.Point(205, 84);
            this.cmbResNumRep.Name = "cmbResNumRep";
            this.cmbResNumRep.Size = new System.Drawing.Size(121, 21);
            this.cmbResNumRep.TabIndex = 20;
            // 
            // nudResLimCred
            // 
            this.nudResLimCred.DecimalPlaces = 2;
            this.nudResLimCred.Location = new System.Drawing.Point(205, 130);
            this.nudResLimCred.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudResLimCred.Name = "nudResLimCred";
            this.nudResLimCred.Size = new System.Drawing.Size(120, 20);
            this.nudResLimCred.TabIndex = 19;
            this.nudResLimCred.ThousandsSeparator = true;
            // 
            // lblEstadoClie
            // 
            this.lblEstadoClie.AutoSize = true;
            this.lblEstadoClie.Location = new System.Drawing.Point(51, 171);
            this.lblEstadoClie.Name = "lblEstadoClie";
            this.lblEstadoClie.Size = new System.Drawing.Size(93, 13);
            this.lblEstadoClie.TabIndex = 17;
            this.lblEstadoClie.Text = "Estado de Cliente:";
            // 
            // lblLimCred
            // 
            this.lblLimCred.AutoSize = true;
            this.lblLimCred.Location = new System.Drawing.Point(51, 132);
            this.lblLimCred.Name = "lblLimCred";
            this.lblLimCred.Size = new System.Drawing.Size(90, 13);
            this.lblLimCred.TabIndex = 16;
            this.lblLimCred.Text = "Límite de Crédito:";
            // 
            // lblNumRep
            // 
            this.lblNumRep.AutoSize = true;
            this.lblNumRep.Location = new System.Drawing.Point(51, 93);
            this.lblNumRep.Name = "lblNumRep";
            this.lblNumRep.Size = new System.Drawing.Size(132, 13);
            this.lblNumRep.TabIndex = 15;
            this.lblNumRep.Text = "Representante del Cliente:";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(51, 53);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(51, 13);
            this.lblEmpresa.TabIndex = 14;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // cmbResEmp
            // 
            this.cmbResEmp.FormattingEnabled = true;
            this.cmbResEmp.Location = new System.Drawing.Point(205, 50);
            this.cmbResEmp.Name = "cmbResEmp";
            this.cmbResEmp.Size = new System.Drawing.Size(121, 21);
            this.cmbResEmp.TabIndex = 23;
            this.cmbResEmp.SelectedIndexChanged += new System.EventHandler(this.cmbResEmp_SelectedIndexChanged);
            // 
            // cmbResNivelClie
            // 
            this.cmbResNivelClie.FormattingEnabled = true;
            this.cmbResNivelClie.Location = new System.Drawing.Point(205, 201);
            this.cmbResNivelClie.Name = "cmbResNivelClie";
            this.cmbResNivelClie.Size = new System.Drawing.Size(121, 21);
            this.cmbResNivelClie.TabIndex = 25;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(51, 204);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(84, 13);
            this.lblNivel.TabIndex = 24;
            this.lblNivel.Text = "Nivel de Cliente:";
            // 
            // FrmActualizarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 323);
            this.Controls.Add(this.cmbResNivelClie);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.cmbResEmp);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.cmbResEstCliente);
            this.Controls.Add(this.cmbResNumRep);
            this.Controls.Add(this.nudResLimCred);
            this.Controls.Add(this.lblEstadoClie);
            this.Controls.Add(this.lblLimCred);
            this.Controls.Add(this.lblNumRep);
            this.Controls.Add(this.lblEmpresa);
            this.Name = "FrmActualizarClientes";
            this.Text = "FrmActualizarClientes";
            this.Load += new System.EventHandler(this.FrmActualizarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudResLimCred)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cmbResEstCliente;
        private System.Windows.Forms.ComboBox cmbResNumRep;
        private System.Windows.Forms.NumericUpDown nudResLimCred;
        private System.Windows.Forms.Label lblEstadoClie;
        private System.Windows.Forms.Label lblLimCred;
        private System.Windows.Forms.Label lblNumRep;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.ComboBox cmbResEmp;
        private System.Windows.Forms.ComboBox cmbResNivelClie;
        private System.Windows.Forms.Label lblNivel;
    }
}