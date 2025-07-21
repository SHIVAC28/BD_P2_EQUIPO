namespace Ventas_SHIVAC
{
    partial class FrmAltasRepVentas
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
            this.button1 = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.DtpNac = new System.Windows.Forms.DateTimePicker();
            this.CmbCiudad = new System.Windows.Forms.ComboBox();
            this.CmbPuesto = new System.Windows.Forms.ComboBox();
            this.DtpContrato = new System.Windows.Forms.DateTimePicker();
            this.NudCuota = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NudCuota)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de Nacimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ciudad de la Oficina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Puesto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contrato:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cuota:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Insertar Representante";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(170, 35);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(200, 20);
            this.TxtNombre.TabIndex = 7;
            // 
            // DtpNac
            // 
            this.DtpNac.Location = new System.Drawing.Point(170, 65);
            this.DtpNac.Name = "DtpNac";
            this.DtpNac.Size = new System.Drawing.Size(200, 20);
            this.DtpNac.TabIndex = 8;
            // 
            // CmbCiudad
            // 
            this.CmbCiudad.FormattingEnabled = true;
            this.CmbCiudad.Location = new System.Drawing.Point(170, 106);
            this.CmbCiudad.Name = "CmbCiudad";
            this.CmbCiudad.Size = new System.Drawing.Size(121, 21);
            this.CmbCiudad.TabIndex = 9;
            // 
            // CmbPuesto
            // 
            this.CmbPuesto.FormattingEnabled = true;
            this.CmbPuesto.Location = new System.Drawing.Point(170, 142);
            this.CmbPuesto.Name = "CmbPuesto";
            this.CmbPuesto.Size = new System.Drawing.Size(121, 21);
            this.CmbPuesto.TabIndex = 10;
            // 
            // DtpContrato
            // 
            this.DtpContrato.Location = new System.Drawing.Point(170, 177);
            this.DtpContrato.Name = "DtpContrato";
            this.DtpContrato.Size = new System.Drawing.Size(200, 20);
            this.DtpContrato.TabIndex = 11;
            // 
            // NudCuota
            // 
            this.NudCuota.DecimalPlaces = 2;
            this.NudCuota.Location = new System.Drawing.Point(170, 207);
            this.NudCuota.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NudCuota.Name = "NudCuota";
            this.NudCuota.Size = new System.Drawing.Size(120, 20);
            this.NudCuota.TabIndex = 12;
            this.NudCuota.ThousandsSeparator = true;
            // 
            // FrmAltasRepVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 314);
            this.Controls.Add(this.NudCuota);
            this.Controls.Add(this.DtpContrato);
            this.Controls.Add(this.CmbPuesto);
            this.Controls.Add(this.CmbCiudad);
            this.Controls.Add(this.DtpNac);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAltasRepVentas";
            this.Text = "FrmAltasRepVentas";
            this.Load += new System.EventHandler(this.FrmAltasRepVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudCuota)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.DateTimePicker DtpNac;
        private System.Windows.Forms.ComboBox CmbCiudad;
        private System.Windows.Forms.ComboBox CmbPuesto;
        private System.Windows.Forms.DateTimePicker DtpContrato;
        private System.Windows.Forms.NumericUpDown NudCuota;
    }
}