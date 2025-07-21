namespace Ventas_SHIVAC
{
    partial class FmrActualizarRepVentas
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
            this.NudCuota = new System.Windows.Forms.NumericUpDown();
            this.DtpContrato = new System.Windows.Forms.DateTimePicker();
            this.CmbPuesto = new System.Windows.Forms.ComboBox();
            this.CmbCiudad = new System.Windows.Forms.ComboBox();
            this.DtpNac = new System.Windows.Forms.DateTimePicker();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NudVentas = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbNombres = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NudCuota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // NudCuota
            // 
            this.NudCuota.DecimalPlaces = 2;
            this.NudCuota.Location = new System.Drawing.Point(189, 212);
            this.NudCuota.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NudCuota.Name = "NudCuota";
            this.NudCuota.Size = new System.Drawing.Size(120, 20);
            this.NudCuota.TabIndex = 25;
            this.NudCuota.ThousandsSeparator = true;
            // 
            // DtpContrato
            // 
            this.DtpContrato.Location = new System.Drawing.Point(189, 182);
            this.DtpContrato.Name = "DtpContrato";
            this.DtpContrato.Size = new System.Drawing.Size(200, 20);
            this.DtpContrato.TabIndex = 24;
            // 
            // CmbPuesto
            // 
            this.CmbPuesto.FormattingEnabled = true;
            this.CmbPuesto.Location = new System.Drawing.Point(189, 147);
            this.CmbPuesto.Name = "CmbPuesto";
            this.CmbPuesto.Size = new System.Drawing.Size(121, 21);
            this.CmbPuesto.TabIndex = 23;
            // 
            // CmbCiudad
            // 
            this.CmbCiudad.FormattingEnabled = true;
            this.CmbCiudad.Location = new System.Drawing.Point(189, 111);
            this.CmbCiudad.Name = "CmbCiudad";
            this.CmbCiudad.Size = new System.Drawing.Size(121, 21);
            this.CmbCiudad.TabIndex = 22;
            // 
            // DtpNac
            // 
            this.DtpNac.Location = new System.Drawing.Point(189, 70);
            this.DtpNac.Name = "DtpNac";
            this.DtpNac.Size = new System.Drawing.Size(200, 20);
            this.DtpNac.TabIndex = 21;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(134, 293);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(176, 23);
            this.BtnActualizar.TabIndex = 19;
            this.BtnActualizar.Text = "Actualizar Representante";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cuota:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Contrato:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Puesto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ciudad de la Oficina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Fecha de Nacimiento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre:";
            // 
            // NudVentas
            // 
            this.NudVentas.DecimalPlaces = 2;
            this.NudVentas.Location = new System.Drawing.Point(190, 247);
            this.NudVentas.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NudVentas.Name = "NudVentas";
            this.NudVentas.Size = new System.Drawing.Size(120, 20);
            this.NudVentas.TabIndex = 27;
            this.NudVentas.ThousandsSeparator = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Ventas:";
            // 
            // CmbNombres
            // 
            this.CmbNombres.FormattingEnabled = true;
            this.CmbNombres.Location = new System.Drawing.Point(188, 37);
            this.CmbNombres.Name = "CmbNombres";
            this.CmbNombres.Size = new System.Drawing.Size(121, 21);
            this.CmbNombres.TabIndex = 28;
            this.CmbNombres.SelectedIndexChanged += new System.EventHandler(this.CmbNombres_SelectedIndexChanged);
            // 
            // FmrActualizarRepVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 355);
            this.Controls.Add(this.CmbNombres);
            this.Controls.Add(this.NudVentas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NudCuota);
            this.Controls.Add(this.DtpContrato);
            this.Controls.Add(this.CmbPuesto);
            this.Controls.Add(this.CmbCiudad);
            this.Controls.Add(this.DtpNac);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FmrActualizarRepVentas";
            this.Text = "FmrActualizarRepVentas";
            this.Load += new System.EventHandler(this.FmrActualizarRepVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudCuota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NudCuota;
        private System.Windows.Forms.DateTimePicker DtpContrato;
        private System.Windows.Forms.ComboBox CmbPuesto;
        private System.Windows.Forms.ComboBox CmbCiudad;
        private System.Windows.Forms.DateTimePicker DtpNac;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NudVentas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbNombres;
    }
}