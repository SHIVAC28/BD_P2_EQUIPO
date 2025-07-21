namespace Ventas_SHIVAC
{
    partial class FrmEstadoProoveedor
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
            this.CMBNombre = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblResE = new System.Windows.Forms.Label();
            this.LblResD = new System.Windows.Forms.Label();
            this.LblResT = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CBActivo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CMBNombre
            // 
            this.CMBNombre.FormattingEnabled = true;
            this.CMBNombre.Location = new System.Drawing.Point(115, 30);
            this.CMBNombre.Name = "CMBNombre";
            this.CMBNombre.Size = new System.Drawing.Size(121, 21);
            this.CMBNombre.TabIndex = 28;
            this.CMBNombre.SelectedIndexChanged += new System.EventHandler(this.CMBNombre_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 42);
            this.button1.TabIndex = 24;
            this.button1.Text = "CAMBIAR ESTADO DE PROVEEDOR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Telefono:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre:";
            // 
            // LblResE
            // 
            this.LblResE.AutoSize = true;
            this.LblResE.Location = new System.Drawing.Point(112, 123);
            this.LblResE.Name = "LblResE";
            this.LblResE.Size = new System.Drawing.Size(17, 13);
            this.LblResE.TabIndex = 31;
            this.LblResE.Text = "\"\"";
            // 
            // LblResD
            // 
            this.LblResD.AutoSize = true;
            this.LblResD.Location = new System.Drawing.Point(112, 94);
            this.LblResD.Name = "LblResD";
            this.LblResD.Size = new System.Drawing.Size(17, 13);
            this.LblResD.TabIndex = 30;
            this.LblResD.Text = "\"\"";
            // 
            // LblResT
            // 
            this.LblResT.AutoSize = true;
            this.LblResT.Location = new System.Drawing.Point(112, 62);
            this.LblResT.Name = "LblResT";
            this.LblResT.Size = new System.Drawing.Size(17, 13);
            this.LblResT.TabIndex = 29;
            this.LblResT.Text = "\"\"";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(47, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Estado:";
            // 
            // CBActivo
            // 
            this.CBActivo.AutoSize = true;
            this.CBActivo.Location = new System.Drawing.Point(115, 152);
            this.CBActivo.Name = "CBActivo";
            this.CBActivo.Size = new System.Drawing.Size(15, 14);
            this.CBActivo.TabIndex = 33;
            this.CBActivo.UseVisualStyleBackColor = true;
            // 
            // FrmEstadoProoveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 266);
            this.Controls.Add(this.CBActivo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LblResE);
            this.Controls.Add(this.LblResD);
            this.Controls.Add(this.LblResT);
            this.Controls.Add(this.CMBNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEstadoProoveedor";
            this.Text = "FrmEstadoProoveedor";
            this.Load += new System.EventHandler(this.FrmEstadoProoveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CMBNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblResE;
        private System.Windows.Forms.Label LblResD;
        private System.Windows.Forms.Label LblResT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox CBActivo;
    }
}