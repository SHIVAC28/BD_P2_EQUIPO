namespace Ventas_SHIVAC
{
    partial class FrmAltasPagos
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
            this.CmbIdPedido = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbPago = new System.Windows.Forms.ComboBox();
            this.LblTotalPed = new System.Windows.Forms.Label();
            this.LblFechaPed = new System.Windows.Forms.Label();
            this.LblRep = new System.Windows.Forms.Label();
            this.LblCliente = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbIdPedido
            // 
            this.CmbIdPedido.FormattingEnabled = true;
            this.CmbIdPedido.Location = new System.Drawing.Point(159, 39);
            this.CmbIdPedido.Name = "CmbIdPedido";
            this.CmbIdPedido.Size = new System.Drawing.Size(121, 21);
            this.CmbIdPedido.TabIndex = 11;
            this.CmbIdPedido.SelectedIndexChanged += new System.EventHandler(this.CmbIdPedido_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Clave del Pedido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Representante:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fecha del Pedido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total del Pedido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Forma de Pago:";
            // 
            // CmbPago
            // 
            this.CmbPago.FormattingEnabled = true;
            this.CmbPago.Location = new System.Drawing.Point(159, 213);
            this.CmbPago.Name = "CmbPago";
            this.CmbPago.Size = new System.Drawing.Size(121, 21);
            this.CmbPago.TabIndex = 17;
            // 
            // LblTotalPed
            // 
            this.LblTotalPed.AutoSize = true;
            this.LblTotalPed.Location = new System.Drawing.Point(156, 181);
            this.LblTotalPed.Name = "LblTotalPed";
            this.LblTotalPed.Size = new System.Drawing.Size(17, 13);
            this.LblTotalPed.TabIndex = 21;
            this.LblTotalPed.Text = "\"\"";
            // 
            // LblFechaPed
            // 
            this.LblFechaPed.AutoSize = true;
            this.LblFechaPed.Location = new System.Drawing.Point(156, 149);
            this.LblFechaPed.Name = "LblFechaPed";
            this.LblFechaPed.Size = new System.Drawing.Size(17, 13);
            this.LblFechaPed.TabIndex = 20;
            this.LblFechaPed.Text = "\"\"";
            // 
            // LblRep
            // 
            this.LblRep.AutoSize = true;
            this.LblRep.Location = new System.Drawing.Point(156, 117);
            this.LblRep.Name = "LblRep";
            this.LblRep.Size = new System.Drawing.Size(17, 13);
            this.LblRep.TabIndex = 19;
            this.LblRep.Text = "\"\"";
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Location = new System.Drawing.Point(156, 81);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(17, 13);
            this.LblCliente.TabIndex = 18;
            this.LblCliente.Text = "\"\"";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Insertar Pago";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAltasPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 329);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblTotalPed);
            this.Controls.Add(this.LblFechaPed);
            this.Controls.Add(this.LblRep);
            this.Controls.Add(this.LblCliente);
            this.Controls.Add(this.CmbPago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbIdPedido);
            this.Controls.Add(this.label3);
            this.Name = "FrmAltasPagos";
            this.Text = "FrmAltasPagos";
            this.Load += new System.EventHandler(this.FrmAltasPagos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbIdPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbPago;
        private System.Windows.Forms.Label LblTotalPed;
        private System.Windows.Forms.Label LblFechaPed;
        private System.Windows.Forms.Label LblRep;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.Button button1;
    }
}