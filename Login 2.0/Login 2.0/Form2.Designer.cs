namespace Login_2._0
{
    partial class ventana2
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
            this.LbVenta = new System.Windows.Forms.Label();
            this.LbPago = new System.Windows.Forms.Label();
            this.CbVCs = new System.Windows.Forms.CheckBox();
            this.CbVB = new System.Windows.Forms.CheckBox();
            this.BtComprar = new System.Windows.Forms.Button();
            this.BtCerrar = new System.Windows.Forms.Button();
            this.RbTC = new System.Windows.Forms.RadioButton();
            this.RbPaypal = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // LbVenta
            // 
            this.LbVenta.AutoSize = true;
            this.LbVenta.Location = new System.Drawing.Point(0, 0);
            this.LbVenta.Name = "LbVenta";
            this.LbVenta.Size = new System.Drawing.Size(84, 13);
            this.LbVenta.TabIndex = 0;
            this.LbVenta.Text = "Cursos de venta";
            // 
            // LbPago
            // 
            this.LbPago.AutoSize = true;
            this.LbPago.Location = new System.Drawing.Point(159, 0);
            this.LbPago.Name = "LbPago";
            this.LbPago.Size = new System.Drawing.Size(83, 13);
            this.LbPago.TabIndex = 1;
            this.LbPago.Text = "Formas de pago";
            // 
            // CbVCs
            // 
            this.CbVCs.AutoSize = true;
            this.CbVCs.Location = new System.Drawing.Point(3, 55);
            this.CbVCs.Name = "CbVCs";
            this.CbVCs.Size = new System.Drawing.Size(71, 17);
            this.CbVCs.TabIndex = 2;
            this.CbVCs.Text = "Visual C#";
            this.CbVCs.UseVisualStyleBackColor = true;
            // 
            // CbVB
            // 
            this.CbVB.AutoSize = true;
            this.CbVB.Location = new System.Drawing.Point(3, 103);
            this.CbVB.Name = "CbVB";
            this.CbVB.Size = new System.Drawing.Size(83, 17);
            this.CbVB.TabIndex = 3;
            this.CbVB.Text = "Visual Basic";
            this.CbVB.UseVisualStyleBackColor = true;
            // 
            // BtComprar
            // 
            this.BtComprar.Location = new System.Drawing.Point(3, 178);
            this.BtComprar.Name = "BtComprar";
            this.BtComprar.Size = new System.Drawing.Size(75, 23);
            this.BtComprar.TabIndex = 6;
            this.BtComprar.Text = "Comprar";
            this.BtComprar.UseVisualStyleBackColor = true;
            this.BtComprar.Click += new System.EventHandler(this.BtComprar_Click);
            // 
            // BtCerrar
            // 
            this.BtCerrar.Location = new System.Drawing.Point(170, 178);
            this.BtCerrar.Name = "BtCerrar";
            this.BtCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtCerrar.TabIndex = 7;
            this.BtCerrar.Text = "Cerrar";
            this.BtCerrar.UseVisualStyleBackColor = true;
            this.BtCerrar.Click += new System.EventHandler(this.BtCerrar_Click);
            // 
            // RbTC
            // 
            this.RbTC.AutoSize = true;
            this.RbTC.Location = new System.Drawing.Point(170, 55);
            this.RbTC.Name = "RbTC";
            this.RbTC.Size = new System.Drawing.Size(109, 17);
            this.RbTC.TabIndex = 8;
            this.RbTC.TabStop = true;
            this.RbTC.Text = "Tarjeta de Crédito";
            this.RbTC.UseVisualStyleBackColor = true;
            // 
            // RbPaypal
            // 
            this.RbPaypal.AutoSize = true;
            this.RbPaypal.Location = new System.Drawing.Point(170, 103);
            this.RbPaypal.Name = "RbPaypal";
            this.RbPaypal.Size = new System.Drawing.Size(58, 17);
            this.RbPaypal.TabIndex = 9;
            this.RbPaypal.TabStop = true;
            this.RbPaypal.Text = "PayPal";
            this.RbPaypal.UseVisualStyleBackColor = true;
            // 
            // ventana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 223);
            this.Controls.Add(this.RbPaypal);
            this.Controls.Add(this.RbTC);
            this.Controls.Add(this.BtCerrar);
            this.Controls.Add(this.BtComprar);
            this.Controls.Add(this.CbVB);
            this.Controls.Add(this.CbVCs);
            this.Controls.Add(this.LbPago);
            this.Controls.Add(this.LbVenta);
            this.Name = "ventana2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbVenta;
        private System.Windows.Forms.Label LbPago;
        private System.Windows.Forms.CheckBox CbVCs;
        private System.Windows.Forms.CheckBox CbVB;
        private System.Windows.Forms.Button BtComprar;
        private System.Windows.Forms.Button BtCerrar;
        private System.Windows.Forms.RadioButton RbTC;
        private System.Windows.Forms.RadioButton RbPaypal;
    }
}