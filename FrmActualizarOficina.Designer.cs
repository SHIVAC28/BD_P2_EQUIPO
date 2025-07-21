namespace Ventas_SHIVAC
{
    partial class FrmActualizarOficina
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
            this.nudObj = new System.Windows.Forms.NumericUpDown();
            this.cmbRep = new System.Windows.Forms.ComboBox();
            this.cmbRegion = new System.Windows.Forms.ComboBox();
            this.cmbHoraCier = new System.Windows.Forms.ComboBox();
            this.cmbHoraAper = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.nudVentas = new System.Windows.Forms.NumericUpDown();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudObj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(92, 293);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(164, 23);
            this.btnActualizar.TabIndex = 25;
            this.btnActualizar.Text = "Actualizar Oficina";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // nudObj
            // 
            this.nudObj.DecimalPlaces = 2;
            this.nudObj.Location = new System.Drawing.Point(163, 155);
            this.nudObj.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudObj.Name = "nudObj";
            this.nudObj.Size = new System.Drawing.Size(120, 20);
            this.nudObj.TabIndex = 24;
            this.nudObj.ThousandsSeparator = true;
            // 
            // cmbRep
            // 
            this.cmbRep.FormattingEnabled = true;
            this.cmbRep.Location = new System.Drawing.Point(163, 115);
            this.cmbRep.Name = "cmbRep";
            this.cmbRep.Size = new System.Drawing.Size(121, 21);
            this.cmbRep.TabIndex = 23;
            // 
            // cmbRegion
            // 
            this.cmbRegion.FormattingEnabled = true;
            this.cmbRegion.Location = new System.Drawing.Point(163, 79);
            this.cmbRegion.Name = "cmbRegion";
            this.cmbRegion.Size = new System.Drawing.Size(121, 21);
            this.cmbRegion.TabIndex = 22;
            // 
            // cmbHoraCier
            // 
            this.cmbHoraCier.FormattingEnabled = true;
            this.cmbHoraCier.Items.AddRange(new object[] {
            ""});
            this.cmbHoraCier.Location = new System.Drawing.Point(163, 251);
            this.cmbHoraCier.Name = "cmbHoraCier";
            this.cmbHoraCier.Size = new System.Drawing.Size(121, 21);
            this.cmbHoraCier.TabIndex = 20;
            // 
            // cmbHoraAper
            // 
            this.cmbHoraAper.FormattingEnabled = true;
            this.cmbHoraAper.Location = new System.Drawing.Point(162, 215);
            this.cmbHoraAper.Name = "cmbHoraAper";
            this.cmbHoraAper.Size = new System.Drawing.Size(121, 21);
            this.cmbHoraAper.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Hora de Cierre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Hora de Apertura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Objetivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Representante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Region:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ciudad:";
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Location = new System.Drawing.Point(65, 187);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(43, 13);
            this.lblVentas.TabIndex = 27;
            this.lblVentas.Text = "Ventas:";
            // 
            // nudVentas
            // 
            this.nudVentas.DecimalPlaces = 2;
            this.nudVentas.Location = new System.Drawing.Point(162, 184);
            this.nudVentas.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudVentas.Name = "nudVentas";
            this.nudVentas.Size = new System.Drawing.Size(120, 20);
            this.nudVentas.TabIndex = 28;
            this.nudVentas.ThousandsSeparator = true;
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(163, 42);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(121, 21);
            this.cmbCiudad.TabIndex = 29;
            this.cmbCiudad.SelectedIndexChanged += new System.EventHandler(this.cmbCiudad_SelectedIndexChanged);
            // 
            // FrmActualizarOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 344);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.nudVentas);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.nudObj);
            this.Controls.Add(this.cmbRep);
            this.Controls.Add(this.cmbRegion);
            this.Controls.Add(this.cmbHoraCier);
            this.Controls.Add(this.cmbHoraAper);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmActualizarOficina";
            this.Text = "FrmActualizarOficina";
            this.Load += new System.EventHandler(this.FrmActualizarOficina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudObj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.NumericUpDown nudObj;
        private System.Windows.Forms.ComboBox cmbRep;
        private System.Windows.Forms.ComboBox cmbRegion;
        private System.Windows.Forms.ComboBox cmbHoraCier;
        private System.Windows.Forms.ComboBox cmbHoraAper;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.NumericUpDown nudVentas;
        private System.Windows.Forms.ComboBox cmbCiudad;
    }
}