namespace Ventas_SHIVAC
{
    partial class FrmEstadoClientes
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
            this.LblNivel = new System.Windows.Forms.Label();
            this.LblEstadoClie = new System.Windows.Forms.Label();
            this.LblLimCred = new System.Windows.Forms.Label();
            this.LblNumRep = new System.Windows.Forms.Label();
            this.LblEmpresa = new System.Windows.Forms.Label();
            this.CmbResEmp = new System.Windows.Forms.ComboBox();
            this.LblResEstClie = new System.Windows.Forms.Label();
            this.LblResNivelClie = new System.Windows.Forms.Label();
            this.LblResLimCred = new System.Windows.Forms.Label();
            this.LblResRepClie = new System.Windows.Forms.Label();
            this.btnEliClie = new System.Windows.Forms.Button();
            this.CBActivo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblNivel
            // 
            this.LblNivel.AutoSize = true;
            this.LblNivel.Location = new System.Drawing.Point(57, 200);
            this.LblNivel.Name = "LblNivel";
            this.LblNivel.Size = new System.Drawing.Size(84, 13);
            this.LblNivel.TabIndex = 29;
            this.LblNivel.Text = "Nivel de Cliente:";
            // 
            // LblEstadoClie
            // 
            this.LblEstadoClie.AutoSize = true;
            this.LblEstadoClie.Location = new System.Drawing.Point(57, 167);
            this.LblEstadoClie.Name = "LblEstadoClie";
            this.LblEstadoClie.Size = new System.Drawing.Size(93, 13);
            this.LblEstadoClie.TabIndex = 28;
            this.LblEstadoClie.Text = "Estado de Cliente:";
            // 
            // LblLimCred
            // 
            this.LblLimCred.AutoSize = true;
            this.LblLimCred.Location = new System.Drawing.Point(57, 128);
            this.LblLimCred.Name = "LblLimCred";
            this.LblLimCred.Size = new System.Drawing.Size(90, 13);
            this.LblLimCred.TabIndex = 27;
            this.LblLimCred.Text = "Límite de Crédito:";
            // 
            // LblNumRep
            // 
            this.LblNumRep.AutoSize = true;
            this.LblNumRep.Location = new System.Drawing.Point(57, 89);
            this.LblNumRep.Name = "LblNumRep";
            this.LblNumRep.Size = new System.Drawing.Size(132, 13);
            this.LblNumRep.TabIndex = 26;
            this.LblNumRep.Text = "Representante del Cliente:";
            // 
            // LblEmpresa
            // 
            this.LblEmpresa.AutoSize = true;
            this.LblEmpresa.Location = new System.Drawing.Point(57, 49);
            this.LblEmpresa.Name = "LblEmpresa";
            this.LblEmpresa.Size = new System.Drawing.Size(51, 13);
            this.LblEmpresa.TabIndex = 25;
            this.LblEmpresa.Text = "Empresa:";
            // 
            // CmbResEmp
            // 
            this.CmbResEmp.FormattingEnabled = true;
            this.CmbResEmp.Location = new System.Drawing.Point(217, 49);
            this.CmbResEmp.Name = "CmbResEmp";
            this.CmbResEmp.Size = new System.Drawing.Size(121, 21);
            this.CmbResEmp.TabIndex = 30;
            this.CmbResEmp.SelectedIndexChanged += new System.EventHandler(this.CmbResEmp_SelectedIndexChanged);
            // 
            // LblResEstClie
            // 
            this.LblResEstClie.AutoSize = true;
            this.LblResEstClie.Location = new System.Drawing.Point(214, 167);
            this.LblResEstClie.Name = "LblResEstClie";
            this.LblResEstClie.Size = new System.Drawing.Size(17, 13);
            this.LblResEstClie.TabIndex = 34;
            this.LblResEstClie.Text = "\"\"";
            // 
            // LblResNivelClie
            // 
            this.LblResNivelClie.AutoSize = true;
            this.LblResNivelClie.Location = new System.Drawing.Point(214, 200);
            this.LblResNivelClie.Name = "LblResNivelClie";
            this.LblResNivelClie.Size = new System.Drawing.Size(17, 13);
            this.LblResNivelClie.TabIndex = 33;
            this.LblResNivelClie.Text = "\"\"";
            // 
            // LblResLimCred
            // 
            this.LblResLimCred.AutoSize = true;
            this.LblResLimCred.Location = new System.Drawing.Point(214, 128);
            this.LblResLimCred.Name = "LblResLimCred";
            this.LblResLimCred.Size = new System.Drawing.Size(17, 13);
            this.LblResLimCred.TabIndex = 32;
            this.LblResLimCred.Text = "\"\"";
            this.LblResLimCred.Click += new System.EventHandler(this.LblResPrec_Click);
            // 
            // LblResRepClie
            // 
            this.LblResRepClie.AutoSize = true;
            this.LblResRepClie.Location = new System.Drawing.Point(214, 87);
            this.LblResRepClie.Name = "LblResRepClie";
            this.LblResRepClie.Size = new System.Drawing.Size(17, 13);
            this.LblResRepClie.TabIndex = 31;
            this.LblResRepClie.Text = "\"\"";
            // 
            // btnEliClie
            // 
            this.btnEliClie.Location = new System.Drawing.Point(119, 281);
            this.btnEliClie.Name = "btnEliClie";
            this.btnEliClie.Size = new System.Drawing.Size(141, 23);
            this.btnEliClie.TabIndex = 36;
            this.btnEliClie.Text = "GUARDAR";
            this.btnEliClie.UseVisualStyleBackColor = true;
            this.btnEliClie.Click += new System.EventHandler(this.BtnEliClie_Click);
            // 
            // CBActivo
            // 
            this.CBActivo.AutoSize = true;
            this.CBActivo.Location = new System.Drawing.Point(216, 223);
            this.CBActivo.Name = "CBActivo";
            this.CBActivo.Size = new System.Drawing.Size(15, 14);
            this.CBActivo.TabIndex = 38;
            this.CBActivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Activo:";
            // 
            // FrmEstadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 339);
            this.Controls.Add(this.CBActivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliClie);
            this.Controls.Add(this.LblResEstClie);
            this.Controls.Add(this.LblResNivelClie);
            this.Controls.Add(this.LblResLimCred);
            this.Controls.Add(this.LblResRepClie);
            this.Controls.Add(this.CmbResEmp);
            this.Controls.Add(this.LblNivel);
            this.Controls.Add(this.LblEstadoClie);
            this.Controls.Add(this.LblLimCred);
            this.Controls.Add(this.LblNumRep);
            this.Controls.Add(this.LblEmpresa);
            this.Name = "FrmEstadoClientes";
            this.Text = "FrmEstadoClientes";
            this.Load += new System.EventHandler(this.FrmEliminarClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNivel;
        private System.Windows.Forms.Label LblEstadoClie;
        private System.Windows.Forms.Label LblLimCred;
        private System.Windows.Forms.Label LblNumRep;
        private System.Windows.Forms.Label LblEmpresa;
        private System.Windows.Forms.ComboBox CmbResEmp;
        private System.Windows.Forms.Label LblResEstClie;
        private System.Windows.Forms.Label LblResNivelClie;
        private System.Windows.Forms.Label LblResLimCred;
        private System.Windows.Forms.Label LblResRepClie;
        private System.Windows.Forms.Button btnEliClie;
        private System.Windows.Forms.CheckBox CBActivo;
        private System.Windows.Forms.Label label1;
    }
}