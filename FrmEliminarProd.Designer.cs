namespace Ventas_SHIVAC
{
    partial class FrmEliminarProd
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
            this.lblResEst = new System.Windows.Forms.Label();
            this.btnDesc = new System.Windows.Forms.Button();
            this.lblResExis = new System.Windows.Forms.Label();
            this.lblResPrec = new System.Windows.Forms.Label();
            this.lblResDesc = new System.Windows.Forms.Label();
            this.cbmIdProd = new System.Windows.Forms.ComboBox();
            this.cmbIdFab = new System.Windows.Forms.ComboBox();
            this.lblEst = new System.Windows.Forms.Label();
            this.lblExs = new System.Windows.Forms.Label();
            this.lblPrec = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblIdProd = new System.Windows.Forms.Label();
            this.lblIdFab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResEst
            // 
            this.lblResEst.AutoSize = true;
            this.lblResEst.Location = new System.Drawing.Point(179, 197);
            this.lblResEst.Name = "lblResEst";
            this.lblResEst.Size = new System.Drawing.Size(17, 13);
            this.lblResEst.TabIndex = 28;
            this.lblResEst.Text = "\"\"";
            // 
            // btnDesc
            // 
            this.btnDesc.Location = new System.Drawing.Point(136, 241);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(141, 23);
            this.btnDesc.TabIndex = 26;
            this.btnDesc.Text = "ELIMINAR PRODUCTO";
            this.btnDesc.UseVisualStyleBackColor = true;
            this.btnDesc.Click += new System.EventHandler(this.btnDesc_Click);
            // 
            // lblResExis
            // 
            this.lblResExis.AutoSize = true;
            this.lblResExis.Location = new System.Drawing.Point(179, 160);
            this.lblResExis.Name = "lblResExis";
            this.lblResExis.Size = new System.Drawing.Size(17, 13);
            this.lblResExis.TabIndex = 25;
            this.lblResExis.Text = "\"\"";
            // 
            // lblResPrec
            // 
            this.lblResPrec.AutoSize = true;
            this.lblResPrec.Location = new System.Drawing.Point(179, 132);
            this.lblResPrec.Name = "lblResPrec";
            this.lblResPrec.Size = new System.Drawing.Size(17, 13);
            this.lblResPrec.TabIndex = 24;
            this.lblResPrec.Text = "\"\"";
            // 
            // lblResDesc
            // 
            this.lblResDesc.AutoSize = true;
            this.lblResDesc.Location = new System.Drawing.Point(179, 105);
            this.lblResDesc.Name = "lblResDesc";
            this.lblResDesc.Size = new System.Drawing.Size(17, 13);
            this.lblResDesc.TabIndex = 23;
            this.lblResDesc.Text = "\"\"";
            // 
            // cbmIdProd
            // 
            this.cbmIdProd.FormattingEnabled = true;
            this.cbmIdProd.Location = new System.Drawing.Point(179, 76);
            this.cbmIdProd.Name = "cbmIdProd";
            this.cbmIdProd.Size = new System.Drawing.Size(121, 21);
            this.cbmIdProd.TabIndex = 22;
            this.cbmIdProd.SelectedIndexChanged += new System.EventHandler(this.cbmIdProd_SelectedIndexChanged);
            // 
            // cmbIdFab
            // 
            this.cmbIdFab.FormattingEnabled = true;
            this.cmbIdFab.Location = new System.Drawing.Point(179, 48);
            this.cmbIdFab.Name = "cmbIdFab";
            this.cmbIdFab.Size = new System.Drawing.Size(121, 21);
            this.cmbIdFab.TabIndex = 21;
            this.cmbIdFab.SelectedIndexChanged += new System.EventHandler(this.cmbIdFab_SelectedIndexChanged);
            // 
            // lblEst
            // 
            this.lblEst.AutoSize = true;
            this.lblEst.Location = new System.Drawing.Point(62, 190);
            this.lblEst.Name = "lblEst";
            this.lblEst.Size = new System.Drawing.Size(43, 13);
            this.lblEst.TabIndex = 20;
            this.lblEst.Text = "Estado:";
            // 
            // lblExs
            // 
            this.lblExs.AutoSize = true;
            this.lblExs.Location = new System.Drawing.Point(62, 159);
            this.lblExs.Name = "lblExs";
            this.lblExs.Size = new System.Drawing.Size(63, 13);
            this.lblExs.TabIndex = 19;
            this.lblExs.Text = "Existencias:";
            // 
            // lblPrec
            // 
            this.lblPrec.AutoSize = true;
            this.lblPrec.Location = new System.Drawing.Point(62, 132);
            this.lblPrec.Name = "lblPrec";
            this.lblPrec.Size = new System.Drawing.Size(40, 13);
            this.lblPrec.TabIndex = 18;
            this.lblPrec.Text = "Precio:";
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Location = new System.Drawing.Point(62, 105);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(66, 13);
            this.lblDes.TabIndex = 17;
            this.lblDes.Text = "Descripción:";
            // 
            // lblIdProd
            // 
            this.lblIdProd.AutoSize = true;
            this.lblIdProd.Location = new System.Drawing.Point(62, 76);
            this.lblIdProd.Name = "lblIdProd";
            this.lblIdProd.Size = new System.Drawing.Size(99, 13);
            this.lblIdProd.TabIndex = 16;
            this.lblIdProd.Text = "Clave del producto:";
            // 
            // lblIdFab
            // 
            this.lblIdFab.AutoSize = true;
            this.lblIdFab.Location = new System.Drawing.Point(62, 48);
            this.lblIdFab.Name = "lblIdFab";
            this.lblIdFab.Size = new System.Drawing.Size(110, 13);
            this.lblIdFab.TabIndex = 15;
            this.lblIdFab.Text = "Clave del Frabricante:";
            // 
            // FrmEliminarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 331);
            this.Controls.Add(this.lblResEst);
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
            this.Name = "FrmEliminarProd";
            this.Text = "FrmEliminarProd";
            this.Load += new System.EventHandler(this.FrmEliminarProd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResEst;
        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.Label lblResExis;
        private System.Windows.Forms.Label lblResPrec;
        private System.Windows.Forms.Label lblResDesc;
        private System.Windows.Forms.ComboBox cbmIdProd;
        private System.Windows.Forms.ComboBox cmbIdFab;
        private System.Windows.Forms.Label lblEst;
        private System.Windows.Forms.Label lblExs;
        private System.Windows.Forms.Label lblPrec;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblIdProd;
        private System.Windows.Forms.Label lblIdFab;
    }
}