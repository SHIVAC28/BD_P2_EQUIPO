namespace Ventas_SHIVAC
{
    partial class FrmAltasOficinas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbHoraAper = new System.Windows.Forms.ComboBox();
            this.cmbHoraCier = new System.Windows.Forms.ComboBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.cmbRegion = new System.Windows.Forms.ComboBox();
            this.cmbRep = new System.Windows.Forms.ComboBox();
            this.nudObj = new System.Windows.Forms.NumericUpDown();
            this.BtnInsertar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudObj)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciudad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Region:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Representante:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Objetivo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hora de Apertura:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hora de Cierre:";
            // 
            // cmbHoraAper
            // 
            this.cmbHoraAper.FormattingEnabled = true;
            this.cmbHoraAper.Location = new System.Drawing.Point(167, 185);
            this.cmbHoraAper.Name = "cmbHoraAper";
            this.cmbHoraAper.Size = new System.Drawing.Size(121, 21);
            this.cmbHoraAper.TabIndex = 6;
            // 
            // cmbHoraCier
            // 
            this.cmbHoraCier.FormattingEnabled = true;
            this.cmbHoraCier.Location = new System.Drawing.Point(167, 215);
            this.cmbHoraCier.Name = "cmbHoraCier";
            this.cmbHoraCier.Size = new System.Drawing.Size(121, 21);
            this.cmbHoraCier.TabIndex = 7;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(167, 36);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(121, 20);
            this.txtCiudad.TabIndex = 8;
            // 
            // cmbRegion
            // 
            this.cmbRegion.FormattingEnabled = true;
            this.cmbRegion.Location = new System.Drawing.Point(167, 73);
            this.cmbRegion.Name = "cmbRegion";
            this.cmbRegion.Size = new System.Drawing.Size(121, 21);
            this.cmbRegion.TabIndex = 9;
            // 
            // cmbRep
            // 
            this.cmbRep.FormattingEnabled = true;
            this.cmbRep.Location = new System.Drawing.Point(167, 109);
            this.cmbRep.Name = "cmbRep";
            this.cmbRep.Size = new System.Drawing.Size(121, 21);
            this.cmbRep.TabIndex = 10;
            // 
            // nudObj
            // 
            this.nudObj.DecimalPlaces = 2;
            this.nudObj.Location = new System.Drawing.Point(167, 152);
            this.nudObj.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudObj.Name = "nudObj";
            this.nudObj.Size = new System.Drawing.Size(120, 20);
            this.nudObj.TabIndex = 11;
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(88, 265);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(164, 23);
            this.BtnInsertar.TabIndex = 12;
            this.BtnInsertar.Text = "Insertar Oficina";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // FrmAltasOficinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 317);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.nudObj);
            this.Controls.Add(this.cmbRep);
            this.Controls.Add(this.cmbRegion);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.cmbHoraCier);
            this.Controls.Add(this.cmbHoraAper);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAltasOficinas";
            this.Text = "FrmAltasOficinas";
            this.Load += new System.EventHandler(this.FrmAltasOficinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudObj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbHoraAper;
        private System.Windows.Forms.ComboBox cmbHoraCier;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.ComboBox cmbRegion;
        private System.Windows.Forms.ComboBox cmbRep;
        private System.Windows.Forms.NumericUpDown nudObj;
        private System.Windows.Forms.Button BtnInsertar;
    }
}