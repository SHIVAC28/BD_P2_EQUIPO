namespace Ventas_SHIVAC
{
    partial class FrmQueryProductos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnListaProd = new System.Windows.Forms.RadioButton();
            this.rbtnProdFab = new System.Windows.Forms.RadioButton();
            this.rbtnProdConExi = new System.Windows.Forms.RadioButton();
            this.rbtnTotIInv = new System.Windows.Forms.RadioButton();
            this.rbtnTotlProv = new System.Windows.Forms.RadioButton();
            this.rbtnEdoProd = new System.Windows.Forms.RadioButton();
            this.cmbFab = new System.Windows.Forms.ComboBox();
            this.cmbInvProv = new System.Windows.Forms.ComboBox();
            this.cmbOperadores = new System.Windows.Forms.ComboBox();
            this.txtProdExi = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(411, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(161, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CONSULTAS DE PRODUCTOS";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elige una opcion y luego presiona \"Mostrar\" para ver la consulta.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProdExi);
            this.groupBox1.Controls.Add(this.cmbOperadores);
            this.groupBox1.Controls.Add(this.cmbFab);
            this.groupBox1.Controls.Add(this.rbtnProdConExi);
            this.groupBox1.Controls.Add(this.rbtnProdFab);
            this.groupBox1.Controls.Add(this.rbtnListaProd);
            this.groupBox1.Location = new System.Drawing.Point(48, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 160);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbInvProv);
            this.groupBox2.Controls.Add(this.rbtnEdoProd);
            this.groupBox2.Controls.Add(this.rbtnTotlProv);
            this.groupBox2.Controls.Add(this.rbtnTotIInv);
            this.groupBox2.Location = new System.Drawing.Point(484, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 160);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inventario de Productos";
            // 
            // rbtnListaProd
            // 
            this.rbtnListaProd.AutoSize = true;
            this.rbtnListaProd.Location = new System.Drawing.Point(7, 29);
            this.rbtnListaProd.Name = "rbtnListaProd";
            this.rbtnListaProd.Size = new System.Drawing.Size(127, 17);
            this.rbtnListaProd.TabIndex = 0;
            this.rbtnListaProd.TabStop = true;
            this.rbtnListaProd.Text = "Listado de productos.";
            this.rbtnListaProd.UseVisualStyleBackColor = true;
            // 
            // rbtnProdFab
            // 
            this.rbtnProdFab.AutoSize = true;
            this.rbtnProdFab.Location = new System.Drawing.Point(7, 70);
            this.rbtnProdFab.Name = "rbtnProdFab";
            this.rbtnProdFab.Size = new System.Drawing.Size(218, 17);
            this.rbtnProdFab.TabIndex = 1;
            this.rbtnProdFab.TabStop = true;
            this.rbtnProdFab.Text = "Productos que pertenecen al fabricante: ";
            this.rbtnProdFab.UseVisualStyleBackColor = true;
            // 
            // rbtnProdConExi
            // 
            this.rbtnProdConExi.AutoSize = true;
            this.rbtnProdConExi.Location = new System.Drawing.Point(7, 110);
            this.rbtnProdConExi.Name = "rbtnProdConExi";
            this.rbtnProdConExi.Size = new System.Drawing.Size(147, 17);
            this.rbtnProdConExi.TabIndex = 2;
            this.rbtnProdConExi.TabStop = true;
            this.rbtnProdConExi.Text = "Productos con existencia.";
            this.rbtnProdConExi.UseVisualStyleBackColor = true;
            // 
            // rbtnTotIInv
            // 
            this.rbtnTotIInv.AutoSize = true;
            this.rbtnTotIInv.Location = new System.Drawing.Point(7, 29);
            this.rbtnTotIInv.Name = "rbtnTotIInv";
            this.rbtnTotIInv.Size = new System.Drawing.Size(118, 17);
            this.rbtnTotIInv.TabIndex = 0;
            this.rbtnTotIInv.TabStop = true;
            this.rbtnTotIInv.Text = "Total del inventario.";
            this.rbtnTotIInv.UseVisualStyleBackColor = true;
            // 
            // rbtnTotlProv
            // 
            this.rbtnTotlProv.AutoSize = true;
            this.rbtnTotlProv.Location = new System.Drawing.Point(7, 70);
            this.rbtnTotlProv.Name = "rbtnTotlProv";
            this.rbtnTotlProv.Size = new System.Drawing.Size(188, 17);
            this.rbtnTotlProv.TabIndex = 1;
            this.rbtnTotlProv.TabStop = true;
            this.rbtnTotlProv.Text = "Total del Inventario por proveedor:";
            this.rbtnTotlProv.UseVisualStyleBackColor = true;
            this.rbtnTotlProv.CheckedChanged += new System.EventHandler(this.rbtnTotlProv_CheckedChanged);
            // 
            // rbtnEdoProd
            // 
            this.rbtnEdoProd.AutoSize = true;
            this.rbtnEdoProd.Location = new System.Drawing.Point(7, 110);
            this.rbtnEdoProd.Name = "rbtnEdoProd";
            this.rbtnEdoProd.Size = new System.Drawing.Size(142, 17);
            this.rbtnEdoProd.TabIndex = 2;
            this.rbtnEdoProd.TabStop = true;
            this.rbtnEdoProd.Text = "Estado de los productos.";
            this.rbtnEdoProd.UseVisualStyleBackColor = true;
            // 
            // cmbFab
            // 
            this.cmbFab.FormattingEnabled = true;
            this.cmbFab.Location = new System.Drawing.Point(226, 68);
            this.cmbFab.Name = "cmbFab";
            this.cmbFab.Size = new System.Drawing.Size(175, 21);
            this.cmbFab.TabIndex = 3;
            // 
            // cmbInvProv
            // 
            this.cmbInvProv.FormattingEnabled = true;
            this.cmbInvProv.Location = new System.Drawing.Point(198, 68);
            this.cmbInvProv.Name = "cmbInvProv";
            this.cmbInvProv.Size = new System.Drawing.Size(174, 21);
            this.cmbInvProv.TabIndex = 3;
            // 
            // cmbOperadores
            // 
            this.cmbOperadores.FormattingEnabled = true;
            this.cmbOperadores.Location = new System.Drawing.Point(157, 110);
            this.cmbOperadores.Name = "cmbOperadores";
            this.cmbOperadores.Size = new System.Drawing.Size(104, 21);
            this.cmbOperadores.TabIndex = 4;
            // 
            // txtProdExi
            // 
            this.txtProdExi.Location = new System.Drawing.Point(281, 110);
            this.txtProdExi.Name = "txtProdExi";
            this.txtProdExi.Size = new System.Drawing.Size(120, 20);
            this.txtProdExi.TabIndex = 5;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(323, 261);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(310, 23);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(821, 188);
            this.dataGridView1.TabIndex = 5;
            // 
            // FrmQueryProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 510);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmQueryProductos";
            this.Text = "FrmQueryProductos";
            this.Load += new System.EventHandler(this.FrmQueryProductos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProdExi;
        private System.Windows.Forms.ComboBox cmbOperadores;
        private System.Windows.Forms.ComboBox cmbFab;
        private System.Windows.Forms.RadioButton rbtnProdConExi;
        private System.Windows.Forms.RadioButton rbtnProdFab;
        private System.Windows.Forms.RadioButton rbtnListaProd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbInvProv;
        private System.Windows.Forms.RadioButton rbtnEdoProd;
        private System.Windows.Forms.RadioButton rbtnTotlProv;
        private System.Windows.Forms.RadioButton rbtnTotIInv;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}