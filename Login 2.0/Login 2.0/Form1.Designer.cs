namespace Login_2._0
{
    partial class formulario
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
            this.LbNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.TbContra = new System.Windows.Forms.TextBox();
            this.BtSalir = new System.Windows.Forms.Button();
            this.BtIniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Location = new System.Drawing.Point(12, 57);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(43, 13);
            this.LbNombre.TabIndex = 0;
            this.LbNombre.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(114, 57);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(100, 20);
            this.TbNombre.TabIndex = 2;
            // 
            // TbContra
            // 
            this.TbContra.Location = new System.Drawing.Point(114, 122);
            this.TbContra.Name = "TbContra";
            this.TbContra.PasswordChar = 'x';
            this.TbContra.Size = new System.Drawing.Size(100, 20);
            this.TbContra.TabIndex = 3;
            this.TbContra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbContra_KeyPress);
            // 
            // BtSalir
            // 
            this.BtSalir.Location = new System.Drawing.Point(15, 204);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(75, 23);
            this.BtSalir.TabIndex = 4;
            this.BtSalir.Text = "Salir";
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // BtIniciar
            // 
            this.BtIniciar.Location = new System.Drawing.Point(129, 204);
            this.BtIniciar.Name = "BtIniciar";
            this.BtIniciar.Size = new System.Drawing.Size(75, 23);
            this.BtIniciar.TabIndex = 5;
            this.BtIniciar.Text = "Iniciar";
            this.BtIniciar.UseVisualStyleBackColor = true;
            this.BtIniciar.Click += new System.EventHandler(this.BtIniciar_Click);
            // 
            // formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 321);
            this.Controls.Add(this.BtIniciar);
            this.Controls.Add(this.BtSalir);
            this.Controls.Add(this.TbContra);
            this.Controls.Add(this.TbNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbNombre);
            this.Name = "formulario";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.TextBox TbContra;
        private System.Windows.Forms.Button BtSalir;
        private System.Windows.Forms.Button BtIniciar;
    }
}

