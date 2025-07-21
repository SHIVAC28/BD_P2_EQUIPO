namespace Ventas_SHIVAC
{
    partial class FrmExportar
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.mcFechas = new System.Windows.Forms.MonthCalendar();
            this.lblRango = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "EXPORTAR INFROMACIÓN POR FECHA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "RANGO:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "EXPORTAR TODA LA INFROMACIÓN";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // mcFechas
            // 
            this.mcFechas.Location = new System.Drawing.Point(65, 22);
            this.mcFechas.MaxSelectionCount = 15;
            this.mcFechas.Name = "mcFechas";
            this.mcFechas.TabIndex = 6;
            this.mcFechas.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lblRango
            // 
            this.lblRango.AutoSize = true;
            this.lblRango.Location = new System.Drawing.Point(411, 83);
            this.lblRango.Name = "lblRango";
            this.lblRango.Size = new System.Drawing.Size(46, 13);
            this.lblRango.TabIndex = 7;
            this.lblRango.Text = "-------------";
            // 
            // FrmExportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 271);
            this.Controls.Add(this.lblRango);
            this.Controls.Add(this.mcFechas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FrmExportar";
            this.Text = "FrmExportar";
            this.Load += new System.EventHandler(this.FrmExportar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MonthCalendar mcFechas;
        private System.Windows.Forms.Label lblRango;
    }
}