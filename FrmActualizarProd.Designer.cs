namespace Ventas_SHIVAC
{
    partial class FrmActualizarProd
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
            this.lblIdFab = new System.Windows.Forms.Label();
            this.lblIdProd = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPrec = new System.Windows.Forms.Label();
            this.lblExis = new System.Windows.Forms.Label();
            this.lblEst = new System.Windows.Forms.Label();
            this.cmbResIdFab = new System.Windows.Forms.ComboBox();
            this.cmbResIdProd = new System.Windows.Forms.ComboBox();
            this.txtResDesc = new System.Windows.Forms.TextBox();
            this.nudResPrec = new System.Windows.Forms.NumericUpDown();
            this.nudResExis = new System.Windows.Forms.NumericUpDown();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cmbResEst = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudResPrec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResExis)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdFab
            // 
            this.lblIdFab.AutoSize = true;
            this.lblIdFab.Location = new System.Drawing.Point(63, 64);
            this.lblIdFab.Name = "lblIdFab";
            this.lblIdFab.Size = new System.Drawing.Size(107, 13);
            this.lblIdFab.TabIndex = 0;
            this.lblIdFab.Text = "Clave del Fabricante:";
            // 
            // lblIdProd
            // 
            this.lblIdProd.AutoSize = true;
            this.lblIdProd.Location = new System.Drawing.Point(63, 100);
            this.lblIdProd.Name = "lblIdProd";
            this.lblIdProd.Size = new System.Drawing.Size(100, 13);
            this.lblIdProd.TabIndex = 1;
            this.lblIdProd.Text = "Clave del Producto:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(65, 135);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(61, 13);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Decripción:";
            // 
            // lblPrec
            // 
            this.lblPrec.AutoSize = true;
            this.lblPrec.Location = new System.Drawing.Point(63, 174);
            this.lblPrec.Name = "lblPrec";
            this.lblPrec.Size = new System.Drawing.Size(40, 13);
            this.lblPrec.TabIndex = 3;
            this.lblPrec.Text = "Precio:";
            // 
            // lblExis
            // 
            this.lblExis.AutoSize = true;
            this.lblExis.Location = new System.Drawing.Point(63, 207);
            this.lblExis.Name = "lblExis";
            this.lblExis.Size = new System.Drawing.Size(63, 13);
            this.lblExis.TabIndex = 4;
            this.lblExis.Text = "Existencias:";
            // 
            // lblEst
            // 
            this.lblEst.AutoSize = true;
            this.lblEst.Location = new System.Drawing.Point(63, 243);
            this.lblEst.Name = "lblEst";
            this.lblEst.Size = new System.Drawing.Size(43, 13);
            this.lblEst.TabIndex = 5;
            this.lblEst.Text = "Estado:";
            // 
            // cmbResIdFab
            // 
            this.cmbResIdFab.FormattingEnabled = true;
            this.cmbResIdFab.Location = new System.Drawing.Point(207, 61);
            this.cmbResIdFab.Name = "cmbResIdFab";
            this.cmbResIdFab.Size = new System.Drawing.Size(121, 21);
            this.cmbResIdFab.TabIndex = 6;
            this.cmbResIdFab.SelectedIndexChanged += new System.EventHandler(this.cmbResIdFab_SelectedIndexChanged);
            // 
            // cmbResIdProd
            // 
            this.cmbResIdProd.FormattingEnabled = true;
            this.cmbResIdProd.Location = new System.Drawing.Point(207, 100);
            this.cmbResIdProd.Name = "cmbResIdProd";
            this.cmbResIdProd.Size = new System.Drawing.Size(121, 21);
            this.cmbResIdProd.TabIndex = 7;
            this.cmbResIdProd.SelectedIndexChanged += new System.EventHandler(this.cmbResIdProd_SelectedIndexChanged);
            // 
            // txtResDesc
            // 
            this.txtResDesc.Location = new System.Drawing.Point(207, 135);
            this.txtResDesc.Name = "txtResDesc";
            this.txtResDesc.Size = new System.Drawing.Size(121, 20);
            this.txtResDesc.TabIndex = 8;
            // 
            // nudResPrec
            // 
            this.nudResPrec.DecimalPlaces = 2;
            this.nudResPrec.Location = new System.Drawing.Point(207, 174);
            this.nudResPrec.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudResPrec.Name = "nudResPrec";
            this.nudResPrec.Size = new System.Drawing.Size(120, 20);
            this.nudResPrec.TabIndex = 9;
            this.nudResPrec.ThousandsSeparator = true;
            this.nudResPrec.ValueChanged += new System.EventHandler(this.nudResPrec_ValueChanged);
            // 
            // nudResExis
            // 
            this.nudResExis.Location = new System.Drawing.Point(207, 207);
            this.nudResExis.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudResExis.Name = "nudResExis";
            this.nudResExis.Size = new System.Drawing.Size(120, 20);
            this.nudResExis.TabIndex = 10;
            this.nudResExis.ThousandsSeparator = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(117, 295);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(139, 23);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar Registro";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cmbResEst
            // 
            this.cmbResEst.FormattingEnabled = true;
            this.cmbResEst.Location = new System.Drawing.Point(207, 240);
            this.cmbResEst.Name = "cmbResEst";
            this.cmbResEst.Size = new System.Drawing.Size(121, 21);
            this.cmbResEst.TabIndex = 13;
            // 
            // FrmActualizarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 361);
            this.Controls.Add(this.cmbResEst);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.nudResExis);
            this.Controls.Add(this.nudResPrec);
            this.Controls.Add(this.txtResDesc);
            this.Controls.Add(this.cmbResIdProd);
            this.Controls.Add(this.cmbResIdFab);
            this.Controls.Add(this.lblEst);
            this.Controls.Add(this.lblExis);
            this.Controls.Add(this.lblPrec);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblIdProd);
            this.Controls.Add(this.lblIdFab);
            this.Name = "FrmActualizarProd";
            this.Text = "FrmActualizarProd";
            this.Load += new System.EventHandler(this.FrmActualizarProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudResPrec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResExis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdFab;
        private System.Windows.Forms.Label lblIdProd;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblPrec;
        private System.Windows.Forms.Label lblExis;
        private System.Windows.Forms.Label lblEst;
        private System.Windows.Forms.ComboBox cmbResIdFab;
        private System.Windows.Forms.ComboBox cmbResIdProd;
        private System.Windows.Forms.TextBox txtResDesc;
        private System.Windows.Forms.NumericUpDown nudResPrec;
        private System.Windows.Forms.NumericUpDown nudResExis;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cmbResEst;
    }
}