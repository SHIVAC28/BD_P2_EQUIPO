namespace Ventas_SHIVAC
{
    partial class FrmEstadoPagos
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
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.LblTotalPed = new System.Windows.Forms.Label();
            this.LblFechaPed = new System.Windows.Forms.Label();
            this.LblRep = new System.Windows.Forms.Label();
            this.LblCliente = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbIdPedido = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblPago = new System.Windows.Forms.Label();
            this.CBActivo = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(104, 286);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(126, 23);
            this.BtnActualizar.TabIndex = 48;
            this.BtnActualizar.Text = "Actualizar Pago";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // LblTotalPed
            // 
            this.LblTotalPed.AutoSize = true;
            this.LblTotalPed.Location = new System.Drawing.Point(169, 175);
            this.LblTotalPed.Name = "LblTotalPed";
            this.LblTotalPed.Size = new System.Drawing.Size(17, 13);
            this.LblTotalPed.TabIndex = 47;
            this.LblTotalPed.Text = "\"\"";
            // 
            // LblFechaPed
            // 
            this.LblFechaPed.AutoSize = true;
            this.LblFechaPed.Location = new System.Drawing.Point(169, 143);
            this.LblFechaPed.Name = "LblFechaPed";
            this.LblFechaPed.Size = new System.Drawing.Size(17, 13);
            this.LblFechaPed.TabIndex = 46;
            this.LblFechaPed.Text = "\"\"";
            // 
            // LblRep
            // 
            this.LblRep.AutoSize = true;
            this.LblRep.Location = new System.Drawing.Point(169, 111);
            this.LblRep.Name = "LblRep";
            this.LblRep.Size = new System.Drawing.Size(17, 13);
            this.LblRep.TabIndex = 45;
            this.LblRep.Text = "\"\"";
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Location = new System.Drawing.Point(169, 75);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(17, 13);
            this.LblCliente.TabIndex = 44;
            this.LblCliente.Text = "\"\"";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Forma de Pago:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Total del Pedido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Fecha del Pedido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Representante:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Cliente:";
            // 
            // CmbIdPedido
            // 
            this.CmbIdPedido.FormattingEnabled = true;
            this.CmbIdPedido.Location = new System.Drawing.Point(172, 33);
            this.CmbIdPedido.Name = "CmbIdPedido";
            this.CmbIdPedido.Size = new System.Drawing.Size(121, 21);
            this.CmbIdPedido.TabIndex = 37;
            this.CmbIdPedido.SelectedIndexChanged += new System.EventHandler(this.CmbIdPedido_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Clave del Pedido:";
            // 
            // LblPago
            // 
            this.LblPago.AutoSize = true;
            this.LblPago.Location = new System.Drawing.Point(169, 210);
            this.LblPago.Name = "LblPago";
            this.LblPago.Size = new System.Drawing.Size(17, 13);
            this.LblPago.TabIndex = 49;
            this.LblPago.Text = "\"\"";
            // 
            // CBActivo
            // 
            this.CBActivo.AutoSize = true;
            this.CBActivo.Location = new System.Drawing.Point(173, 239);
            this.CBActivo.Name = "CBActivo";
            this.CBActivo.Size = new System.Drawing.Size(15, 14);
            this.CBActivo.TabIndex = 51;
            this.CBActivo.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "Activo:";
            // 
            // FrmEstadoPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 335);
            this.Controls.Add(this.CBActivo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblPago);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.LblTotalPed);
            this.Controls.Add(this.LblFechaPed);
            this.Controls.Add(this.LblRep);
            this.Controls.Add(this.LblCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbIdPedido);
            this.Controls.Add(this.label3);
            this.Name = "FrmEstadoPagos";
            this.Text = "FrmEstadoPagos";
            this.Load += new System.EventHandler(this.FrmEstadoPagos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Label LblTotalPed;
        private System.Windows.Forms.Label LblFechaPed;
        private System.Windows.Forms.Label LblRep;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbIdPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblPago;
        private System.Windows.Forms.CheckBox CBActivo;
        private System.Windows.Forms.Label label8;
    }
}