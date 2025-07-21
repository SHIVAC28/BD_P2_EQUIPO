namespace Ventas_SHIVAC
{
    partial class FrmPedidoDetalles
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
            this.Lbll = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CmbFab = new System.Windows.Forms.ComboBox();
            this.CmbProd = new System.Windows.Forms.ComboBox();
            this.LblResPrecU = new System.Windows.Forms.Label();
            this.LblResCantidadDisponible = new System.Windows.Forms.Label();
            this.NudCantidad = new System.Windows.Forms.NumericUpDown();
            this.LblResImporte = new System.Windows.Forms.Label();
            this.LblResTotalA = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblResEst = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave del Fabricante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave del Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad Disponible:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio Unico:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Importe:";
            // 
            // Lbll
            // 
            this.Lbll.AutoSize = true;
            this.Lbll.Location = new System.Drawing.Point(45, 181);
            this.Lbll.Name = "Lbll";
            this.Lbll.Size = new System.Drawing.Size(43, 13);
            this.Lbll.TabIndex = 6;
            this.Lbll.Text = "Estado:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "REALIZAR COMPRA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CmbFab
            // 
            this.CmbFab.FormattingEnabled = true;
            this.CmbFab.Location = new System.Drawing.Point(170, 34);
            this.CmbFab.Name = "CmbFab";
            this.CmbFab.Size = new System.Drawing.Size(121, 21);
            this.CmbFab.TabIndex = 8;
            this.CmbFab.SelectedIndexChanged += new System.EventHandler(this.CmbFab_SelectedIndexChanged);
            // 
            // CmbProd
            // 
            this.CmbProd.FormattingEnabled = true;
            this.CmbProd.Location = new System.Drawing.Point(170, 66);
            this.CmbProd.Name = "CmbProd";
            this.CmbProd.Size = new System.Drawing.Size(121, 21);
            this.CmbProd.TabIndex = 9;
            this.CmbProd.SelectedIndexChanged += new System.EventHandler(this.CmbProd_SelectedIndexChanged);
            // 
            // LblResPrecU
            // 
            this.LblResPrecU.AutoSize = true;
            this.LblResPrecU.Location = new System.Drawing.Point(167, 130);
            this.LblResPrecU.Name = "LblResPrecU";
            this.LblResPrecU.Size = new System.Drawing.Size(17, 13);
            this.LblResPrecU.TabIndex = 11;
            this.LblResPrecU.Text = "\"\"";
            // 
            // LblResCantidadDisponible
            // 
            this.LblResCantidadDisponible.AutoSize = true;
            this.LblResCantidadDisponible.Location = new System.Drawing.Point(167, 101);
            this.LblResCantidadDisponible.Name = "LblResCantidadDisponible";
            this.LblResCantidadDisponible.Size = new System.Drawing.Size(17, 13);
            this.LblResCantidadDisponible.TabIndex = 12;
            this.LblResCantidadDisponible.Text = "\"\"";
            // 
            // NudCantidad
            // 
            this.NudCantidad.Location = new System.Drawing.Point(170, 208);
            this.NudCantidad.Name = "NudCantidad";
            this.NudCantidad.Size = new System.Drawing.Size(120, 20);
            this.NudCantidad.TabIndex = 13;
            this.NudCantidad.ValueChanged += new System.EventHandler(this.NudCantidad_ValueChanged);
            // 
            // LblResImporte
            // 
            this.LblResImporte.AutoSize = true;
            this.LblResImporte.Location = new System.Drawing.Point(167, 240);
            this.LblResImporte.Name = "LblResImporte";
            this.LblResImporte.Size = new System.Drawing.Size(17, 13);
            this.LblResImporte.TabIndex = 14;
            this.LblResImporte.Text = "\"\"";
            // 
            // LblResTotalA
            // 
            this.LblResTotalA.AutoSize = true;
            this.LblResTotalA.Location = new System.Drawing.Point(167, 270);
            this.LblResTotalA.Name = "LblResTotalA";
            this.LblResTotalA.Size = new System.Drawing.Size(17, 13);
            this.LblResTotalA.TabIndex = 15;
            this.LblResTotalA.Text = "\"\"";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total Acumulado:";
            // 
            // LblResEst
            // 
            this.LblResEst.AutoSize = true;
            this.LblResEst.Location = new System.Drawing.Point(170, 181);
            this.LblResEst.Name = "LblResEst";
            this.LblResEst.Size = new System.Drawing.Size(17, 13);
            this.LblResEst.TabIndex = 17;
            this.LblResEst.Text = "\"\"";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Location = new System.Drawing.Point(167, 155);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(17, 13);
            this.LblDescripcion.TabIndex = 19;
            this.LblDescripcion.Text = "\"\"";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(45, 155);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(66, 13);
            this.lbl.TabIndex = 18;
            this.lbl.Text = "Descripción:";
            // 
            // FrmPedidoDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 360);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.LblResEst);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblResTotalA);
            this.Controls.Add(this.LblResImporte);
            this.Controls.Add(this.NudCantidad);
            this.Controls.Add(this.LblResCantidadDisponible);
            this.Controls.Add(this.LblResPrecU);
            this.Controls.Add(this.CmbProd);
            this.Controls.Add(this.CmbFab);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lbll);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPedidoDetalles";
            this.Text = "FrmPedidoDetalles";
            this.Load += new System.EventHandler(this.FrmPedidoDetalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidad)).EndInit();
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
        private System.Windows.Forms.Label Lbll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CmbFab;
        private System.Windows.Forms.ComboBox CmbProd;
        private System.Windows.Forms.Label LblResPrecU;
        private System.Windows.Forms.Label LblResCantidadDisponible;
        private System.Windows.Forms.NumericUpDown NudCantidad;
        private System.Windows.Forms.Label LblResImporte;
        private System.Windows.Forms.Label LblResTotalA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblResEst;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label lbl;
    }
}