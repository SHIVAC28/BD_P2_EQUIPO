namespace Ventas_SHIVAC
{
    partial class FrmAltasProducto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIDFab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDFab = new System.Windows.Forms.TextBox();
            this.txtIDProd = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.nudPre = new System.Windows.Forms.NumericUpDown();
            this.nudExis = new System.Windows.Forms.NumericUpDown();
            this.btnlns = new System.Windows.Forms.Button();
            this.btnProc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExis)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDFab
            // 
            this.lblIDFab.AutoSize = true;
            this.lblIDFab.Location = new System.Drawing.Point(36, 28);
            this.lblIDFab.Name = "lblIDFab";
            this.lblIDFab.Size = new System.Drawing.Size(102, 13);
            this.lblIDFab.TabIndex = 0;
            this.lblIDFab.Text = "Clave de Fabricante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave del Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Existencias";
            // 
            // txtIDFab
            // 
            this.txtIDFab.Location = new System.Drawing.Point(145, 28);
            this.txtIDFab.Name = "txtIDFab";
            this.txtIDFab.Size = new System.Drawing.Size(100, 20);
            this.txtIDFab.TabIndex = 6;
            // 
            // txtIDProd
            // 
            this.txtIDProd.Location = new System.Drawing.Point(145, 64);
            this.txtIDProd.Name = "txtIDProd";
            this.txtIDProd.Size = new System.Drawing.Size(100, 20);
            this.txtIDProd.TabIndex = 7;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(145, 99);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(202, 20);
            this.txtDescripcion.TabIndex = 8;
            // 
            // nudPre
            // 
            this.nudPre.Location = new System.Drawing.Point(145, 135);
            this.nudPre.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPre.Name = "nudPre";
            this.nudPre.Size = new System.Drawing.Size(120, 20);
            this.nudPre.TabIndex = 9;
            // 
            // nudExis
            // 
            this.nudExis.Location = new System.Drawing.Point(145, 183);
            this.nudExis.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudExis.Name = "nudExis";
            this.nudExis.Size = new System.Drawing.Size(120, 20);
            this.nudExis.TabIndex = 10;
            // 
            // btnlns
            // 
            this.btnlns.Location = new System.Drawing.Point(70, 241);
            this.btnlns.Name = "btnlns";
            this.btnlns.Size = new System.Drawing.Size(137, 23);
            this.btnlns.TabIndex = 11;
            this.btnlns.Text = "Insertar Regristro";
            this.btnlns.UseVisualStyleBackColor = true;
            this.btnlns.Click += new System.EventHandler(this.btnlns_Click);
            // 
            // btnProc
            // 
            this.btnProc.Location = new System.Drawing.Point(264, 241);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(148, 23);
            this.btnProc.TabIndex = 12;
            this.btnProc.Text = "Insertar Procedimiento";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // FrmAltasProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 297);
            this.Controls.Add(this.btnProc);
            this.Controls.Add(this.btnlns);
            this.Controls.Add(this.nudExis);
            this.Controls.Add(this.nudPre);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtIDProd);
            this.Controls.Add(this.txtIDFab);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIDFab);
            this.Name = "FrmAltasProducto";
            this.Text = "AltasProducto";
            this.Load += new System.EventHandler(this.FrmAltasProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDFab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDFab;
        private System.Windows.Forms.TextBox txtIDProd;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.NumericUpDown nudPre;
        private System.Windows.Forms.NumericUpDown nudExis;
        private System.Windows.Forms.Button btnlns;
        private System.Windows.Forms.Button btnProc;
    }
}

