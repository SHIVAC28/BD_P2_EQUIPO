namespace Ventas_SHIVAC
{
    partial class FrmActualizarProducto
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
            this.lblDes = new System.Windows.Forms.Label();
            this.lblPrec = new System.Windows.Forms.Label();
            this.lblExs = new System.Windows.Forms.Label();
            this.lblEst = new System.Windows.Forms.Label();
            this.cmbIdFab = new System.Windows.Forms.ComboBox();
            this.cbmIdProd = new System.Windows.Forms.ComboBox();
            this.lblResDesc = new System.Windows.Forms.Label();
            this.lblResPrec = new System.Windows.Forms.Label();
            this.lblResExis = new System.Windows.Forms.Label();
            this.btnDesc = new System.Windows.Forms.Button();
            this.lblResEst = new System.Windows.Forms.Label();
            this.cmbResEst = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblIdFab
            // 
            this.lblIdFab.AutoSize = true;
            this.lblIdFab.Location = new System.Drawing.Point(80, 59);
            this.lblIdFab.Name = "lblIdFab";
            this.lblIdFab.Size = new System.Drawing.Size(110, 13);
            this.lblIdFab.TabIndex = 0;
            this.lblIdFab.Text = "Clave del Frabricante:";
            // 
            // lblIdProd
            // 
            this.lblIdProd.AutoSize = true;
            this.lblIdProd.Location = new System.Drawing.Point(80, 87);
            this.lblIdProd.Name = "lblIdProd";
            this.lblIdProd.Size = new System.Drawing.Size(99, 13);
            this.lblIdProd.TabIndex = 1;
            this.lblIdProd.Text = "Clave del producto:";
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Location = new System.Drawing.Point(80, 116);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(66, 13);
            this.lblDes.TabIndex = 2;
            this.lblDes.Text = "Descripción:";
            // 
            // lblPrec
            // 
            this.lblPrec.AutoSize = true;
            this.lblPrec.Location = new System.Drawing.Point(80, 143);
            this.lblPrec.Name = "lblPrec";
            this.lblPrec.Size = new System.Drawing.Size(40, 13);
            this.lblPrec.TabIndex = 3;
            this.lblPrec.Text = "Precio:";
            // 
            // lblExs
            // 
            this.lblExs.AutoSize = true;
            this.lblExs.Location = new System.Drawing.Point(80, 170);
            this.lblExs.Name = "lblExs";
            this.lblExs.Size = new System.Drawing.Size(63, 13);
            this.lblExs.TabIndex = 4;
            this.lblExs.Text = "Existencias:";
            // 
            // lblEst
            // 
            this.lblEst.AutoSize = true;
            this.lblEst.Location = new System.Drawing.Point(80, 201);
            this.lblEst.Name = "lblEst";
            this.lblEst.Size = new System.Drawing.Size(43, 13);
            this.lblEst.TabIndex = 5;
            this.lblEst.Text = "Estado:";
            // 
            // cmbIdFab
            // 
            this.cmbIdFab.FormattingEnabled = true;
            this.cmbIdFab.Location = new System.Drawing.Point(197, 59);
            this.cmbIdFab.Name = "cmbIdFab";
            this.cmbIdFab.Size = new System.Drawing.Size(121, 21);
            this.cmbIdFab.TabIndex = 6;
            this.cmbIdFab.SelectedIndexChanged += new System.EventHandler(this.cmbIdFab_SelectedIndexChanged);
            // 
            // cbmIdProd
            // 
            this.cbmIdProd.FormattingEnabled = true;
            this.cbmIdProd.Location = new System.Drawing.Point(197, 87);
            this.cbmIdProd.Name = "cbmIdProd";
            this.cbmIdProd.Size = new System.Drawing.Size(121, 21);
            this.cbmIdProd.TabIndex = 7;
            this.cbmIdProd.SelectedIndexChanged += new System.EventHandler(this.cbmIdProd_SelectedIndexChanged);
            // 
            // lblResDesc
            // 
            this.lblResDesc.AutoSize = true;
            this.lblResDesc.Location = new System.Drawing.Point(197, 116);
            this.lblResDesc.Name = "lblResDesc";
            this.lblResDesc.Size = new System.Drawing.Size(17, 13);
            this.lblResDesc.TabIndex = 8;
            this.lblResDesc.Text = "\"\"";
            // 
            // lblResPrec
            // 
            this.lblResPrec.AutoSize = true;
            this.lblResPrec.Location = new System.Drawing.Point(197, 143);
            this.lblResPrec.Name = "lblResPrec";
            this.lblResPrec.Size = new System.Drawing.Size(17, 13);
            this.lblResPrec.TabIndex = 9;
            this.lblResPrec.Text = "\"\"";
            // 
            // lblResExis
            // 
            this.lblResExis.AutoSize = true;
            this.lblResExis.Location = new System.Drawing.Point(197, 171);
            this.lblResExis.Name = "lblResExis";
            this.lblResExis.Size = new System.Drawing.Size(17, 13);
            this.lblResExis.TabIndex = 10;
            this.lblResExis.Text = "\"\"";
            // 
            // btnDesc
            // 
            this.btnDesc.Location = new System.Drawing.Point(154, 252);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(141, 23);
            this.btnDesc.TabIndex = 12;
            this.btnDesc.Text = "CAMBIAR ESTADO";
            this.btnDesc.UseVisualStyleBackColor = true;
            this.btnDesc.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResEst
            // 
            this.lblResEst.AutoSize = true;
            this.lblResEst.Location = new System.Drawing.Point(197, 208);
            this.lblResEst.Name = "lblResEst";
            this.lblResEst.Size = new System.Drawing.Size(17, 13);
            this.lblResEst.TabIndex = 14;
            this.lblResEst.Text = "\"\"";
            // 
            // cmbResEst
            // 
            this.cmbResEst.FormattingEnabled = true;
            this.cmbResEst.Location = new System.Drawing.Point(319, 201);
            this.cmbResEst.Name = "cmbResEst";
            this.cmbResEst.Size = new System.Drawing.Size(121, 21);
            this.cmbResEst.TabIndex = 13;
            // 
            // FrmActualizarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 313);
            this.Controls.Add(this.lblResEst);
            this.Controls.Add(this.cmbResEst);
            this.Controls.Add(this.btnDesc);
            this.Controls.Add(this.lblResExis);
            this.Controls.Add(this.lblResPrec);
            this.Controls.Add(this.lblResDesc);
            this.Controls.Add(this.cbmIdProd);
            this.Controls.Add(this.cmbIdFab);
            this.Controls.Add(this.lblEst);
            this.Controls.Add(this.lblExs);
            this.Controls.Add(this.lblPrec);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.lblIdProd);
            this.Controls.Add(this.lblIdFab);
            this.Name = "FrmActualizarProducto";
            this.Text = "la";
            this.Load += new System.EventHandler(this.FrmActualizarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdFab;
        private System.Windows.Forms.Label lblIdProd;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblPrec;
        private System.Windows.Forms.Label lblExs;
        private System.Windows.Forms.Label lblEst;
        private System.Windows.Forms.ComboBox cmbIdFab;
        private System.Windows.Forms.ComboBox cbmIdProd;
        private System.Windows.Forms.Label lblResDesc;
        private System.Windows.Forms.Label lblResPrec;
        private System.Windows.Forms.Label lblResExis;
        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.Label lblResEst;
        private System.Windows.Forms.ComboBox cmbResEst;
    }
}