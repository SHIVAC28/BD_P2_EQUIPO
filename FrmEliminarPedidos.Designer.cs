namespace Ventas_SHIVAC
{
    partial class FrmEliminarPedidos
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
            this.label7 = new System.Windows.Forms.Label();
            this.LblCant = new System.Windows.Forms.Label();
            this.LblPrec = new System.Windows.Forms.Label();
            this.LblImport = new System.Windows.Forms.Label();
            this.CmbCliente = new System.Windows.Forms.ComboBox();
            this.CmbPedido = new System.Windows.Forms.ComboBox();
            this.CmbFab = new System.Windows.Forms.ComboBox();
            this.CmbProd = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LblTotalPedido = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "No. Pedido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clave del Fabricante:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Clave del Producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Importe:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cantidad:";
            // 
            // LblCant
            // 
            this.LblCant.AutoSize = true;
            this.LblCant.Location = new System.Drawing.Point(183, 150);
            this.LblCant.Name = "LblCant";
            this.LblCant.Size = new System.Drawing.Size(17, 13);
            this.LblCant.TabIndex = 9;
            this.LblCant.Text = "\"\"";
            // 
            // LblPrec
            // 
            this.LblPrec.AutoSize = true;
            this.LblPrec.Location = new System.Drawing.Point(183, 174);
            this.LblPrec.Name = "LblPrec";
            this.LblPrec.Size = new System.Drawing.Size(17, 13);
            this.LblPrec.TabIndex = 8;
            this.LblPrec.Text = "\"\"";
            // 
            // LblImport
            // 
            this.LblImport.AutoSize = true;
            this.LblImport.Location = new System.Drawing.Point(183, 199);
            this.LblImport.Name = "LblImport";
            this.LblImport.Size = new System.Drawing.Size(17, 13);
            this.LblImport.TabIndex = 7;
            this.LblImport.Text = "\"\"";
            // 
            // CmbCliente
            // 
            this.CmbCliente.FormattingEnabled = true;
            this.CmbCliente.Location = new System.Drawing.Point(186, 30);
            this.CmbCliente.Name = "CmbCliente";
            this.CmbCliente.Size = new System.Drawing.Size(121, 21);
            this.CmbCliente.TabIndex = 10;
            this.CmbCliente.SelectedIndexChanged += new System.EventHandler(this.CmbCliente_SelectedIndexChanged);
            // 
            // CmbPedido
            // 
            this.CmbPedido.FormattingEnabled = true;
            this.CmbPedido.Location = new System.Drawing.Point(186, 60);
            this.CmbPedido.Name = "CmbPedido";
            this.CmbPedido.Size = new System.Drawing.Size(121, 21);
            this.CmbPedido.TabIndex = 11;
            this.CmbPedido.SelectedIndexChanged += new System.EventHandler(this.CmbPedido_SelectedIndexChanged);
            // 
            // CmbFab
            // 
            this.CmbFab.FormattingEnabled = true;
            this.CmbFab.Location = new System.Drawing.Point(186, 89);
            this.CmbFab.Name = "CmbFab";
            this.CmbFab.Size = new System.Drawing.Size(121, 21);
            this.CmbFab.TabIndex = 12;
            this.CmbFab.SelectedIndexChanged += new System.EventHandler(this.CmbFab_SelectedIndexChanged);
            // 
            // CmbProd
            // 
            this.CmbProd.FormattingEnabled = true;
            this.CmbProd.Location = new System.Drawing.Point(186, 119);
            this.CmbProd.Name = "CmbProd";
            this.CmbProd.Size = new System.Drawing.Size(121, 21);
            this.CmbProd.TabIndex = 13;
            this.CmbProd.SelectedIndexChanged += new System.EventHandler(this.CmbProd_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Total de todo el pedido:";
            // 
            // LblTotalPedido
            // 
            this.LblTotalPedido.AutoSize = true;
            this.LblTotalPedido.Location = new System.Drawing.Point(183, 222);
            this.LblTotalPedido.Name = "LblTotalPedido";
            this.LblTotalPedido.Size = new System.Drawing.Size(17, 13);
            this.LblTotalPedido.TabIndex = 15;
            this.LblTotalPedido.Text = "\"\"";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "ELIMINAR PRODUCTO DEL PEDIDO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmEliminarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 305);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblTotalPedido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CmbProd);
            this.Controls.Add(this.CmbFab);
            this.Controls.Add(this.CmbPedido);
            this.Controls.Add(this.CmbCliente);
            this.Controls.Add(this.LblCant);
            this.Controls.Add(this.LblPrec);
            this.Controls.Add(this.LblImport);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEliminarPedidos";
            this.Text = "FrmEliminarPedidos";
            this.Load += new System.EventHandler(this.FrmEliminarPedidos_Load);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblCant;
        private System.Windows.Forms.Label LblPrec;
        private System.Windows.Forms.Label LblImport;
        private System.Windows.Forms.ComboBox CmbCliente;
        private System.Windows.Forms.ComboBox CmbPedido;
        private System.Windows.Forms.ComboBox CmbFab;
        private System.Windows.Forms.ComboBox CmbProd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblTotalPedido;
        private System.Windows.Forms.Button button1;
    }
}