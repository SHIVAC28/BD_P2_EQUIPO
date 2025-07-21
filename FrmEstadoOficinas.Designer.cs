namespace Ventas_SHIVAC
{
    partial class FrmEstadoOficinas
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
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVentas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResVentas = new System.Windows.Forms.Label();
            this.lblResHoraCierre = new System.Windows.Forms.Label();
            this.lblResHoraAper = new System.Windows.Forms.Label();
            this.lblResObjetivo = new System.Windows.Forms.Label();
            this.lblResRep = new System.Windows.Forms.Label();
            this.lblResReg = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.CBActivo = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(170, 25);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(121, 21);
            this.cmbCiudad.TabIndex = 31;
            this.cmbCiudad.SelectedIndexChanged += new System.EventHandler(this.cmbCiudad_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ciudad:";
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Location = new System.Drawing.Point(61, 165);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(43, 13);
            this.lblVentas.TabIndex = 37;
            this.lblVentas.Text = "Ventas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Hora de Cierre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Hora de Apertura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Objetivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Representante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Region:";
            // 
            // lblResVentas
            // 
            this.lblResVentas.AutoSize = true;
            this.lblResVentas.Location = new System.Drawing.Point(167, 165);
            this.lblResVentas.Name = "lblResVentas";
            this.lblResVentas.Size = new System.Drawing.Size(17, 13);
            this.lblResVentas.TabIndex = 43;
            this.lblResVentas.Text = "\"\"";
            // 
            // lblResHoraCierre
            // 
            this.lblResHoraCierre.AutoSize = true;
            this.lblResHoraCierre.Location = new System.Drawing.Point(167, 232);
            this.lblResHoraCierre.Name = "lblResHoraCierre";
            this.lblResHoraCierre.Size = new System.Drawing.Size(17, 13);
            this.lblResHoraCierre.TabIndex = 42;
            this.lblResHoraCierre.Text = "\"\"";
            // 
            // lblResHoraAper
            // 
            this.lblResHoraAper.AutoSize = true;
            this.lblResHoraAper.Location = new System.Drawing.Point(167, 196);
            this.lblResHoraAper.Name = "lblResHoraAper";
            this.lblResHoraAper.Size = new System.Drawing.Size(17, 13);
            this.lblResHoraAper.TabIndex = 41;
            this.lblResHoraAper.Text = "\"\"";
            // 
            // lblResObjetivo
            // 
            this.lblResObjetivo.AutoSize = true;
            this.lblResObjetivo.Location = new System.Drawing.Point(167, 139);
            this.lblResObjetivo.Name = "lblResObjetivo";
            this.lblResObjetivo.Size = new System.Drawing.Size(17, 13);
            this.lblResObjetivo.TabIndex = 40;
            this.lblResObjetivo.Text = "\"\"";
            // 
            // lblResRep
            // 
            this.lblResRep.AutoSize = true;
            this.lblResRep.Location = new System.Drawing.Point(167, 102);
            this.lblResRep.Name = "lblResRep";
            this.lblResRep.Size = new System.Drawing.Size(17, 13);
            this.lblResRep.TabIndex = 39;
            this.lblResRep.Text = "\"\"";
            // 
            // lblResReg
            // 
            this.lblResReg.AutoSize = true;
            this.lblResReg.Location = new System.Drawing.Point(167, 66);
            this.lblResReg.Name = "lblResReg";
            this.lblResReg.Size = new System.Drawing.Size(17, 13);
            this.lblResReg.TabIndex = 38;
            this.lblResReg.Text = "\"\"";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(90, 300);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(164, 23);
            this.btnEliminar.TabIndex = 44;
            this.btnEliminar.Text = "GUARDAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // CBActivo
            // 
            this.CBActivo.AutoSize = true;
            this.CBActivo.Location = new System.Drawing.Point(170, 258);
            this.CBActivo.Name = "CBActivo";
            this.CBActivo.Size = new System.Drawing.Size(15, 14);
            this.CBActivo.TabIndex = 46;
            this.CBActivo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Activo:";
            // 
            // FrmEstadoOficinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 344);
            this.Controls.Add(this.CBActivo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblResVentas);
            this.Controls.Add(this.lblResHoraCierre);
            this.Controls.Add(this.lblResHoraAper);
            this.Controls.Add(this.lblResObjetivo);
            this.Controls.Add(this.lblResRep);
            this.Controls.Add(this.lblResReg);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.label1);
            this.Name = "FrmEstadoOficinas";
            this.Text = "FrmEstadoOficinas";
            this.Load += new System.EventHandler(this.FrmEliminarOficinas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResVentas;
        private System.Windows.Forms.Label lblResHoraCierre;
        private System.Windows.Forms.Label lblResHoraAper;
        private System.Windows.Forms.Label lblResObjetivo;
        private System.Windows.Forms.Label lblResRep;
        private System.Windows.Forms.Label lblResReg;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckBox CBActivo;
        private System.Windows.Forms.Label label7;
    }
}