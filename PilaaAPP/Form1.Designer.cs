namespace PilaaAPP
{
    partial class Form1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbCargo = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnVerTope = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lbResultados = new System.Windows.Forms.ListBox();
            this.lblPila = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(58, 64);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(122, 64);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(129, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(58, 115);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(70, 162);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 3;
            this.lblCargo.Text = "Cargo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 115);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 4;
            // 
            // tbCargo
            // 
            this.tbCargo.Location = new System.Drawing.Point(122, 162);
            this.tbCargo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCargo.Name = "tbCargo";
            this.tbCargo.Size = new System.Drawing.Size(129, 20);
            this.tbCargo.TabIndex = 5;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(61, 206);
            this.lblSalario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 6;
            this.lblSalario.Text = "Salario";
            // 
            // tbSalario
            // 
            this.tbSalario.Location = new System.Drawing.Point(122, 206);
            this.tbSalario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(129, 20);
            this.tbSalario.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(293, 48);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(134, 84);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnVerTope
            // 
            this.btnVerTope.Location = new System.Drawing.Point(470, 48);
            this.btnVerTope.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerTope.Name = "btnVerTope";
            this.btnVerTope.Size = new System.Drawing.Size(109, 84);
            this.btnVerTope.TabIndex = 9;
            this.btnVerTope.Text = "VerTope";
            this.btnVerTope.UseVisualStyleBackColor = true;
            this.btnVerTope.Click += new System.EventHandler(this.btnVerTope_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(391, 160);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(122, 106);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lbResultados
            // 
            this.lbResultados.FormattingEnabled = true;
            this.lbResultados.Location = new System.Drawing.Point(63, 306);
            this.lbResultados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbResultados.Name = "lbResultados";
            this.lbResultados.Size = new System.Drawing.Size(366, 251);
            this.lbResultados.TabIndex = 11;
            // 
            // lblPila
            // 
            this.lblPila.AutoSize = true;
            this.lblPila.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPila.Location = new System.Drawing.Point(71, 252);
            this.lblPila.Name = "lblPila";
            this.lblPila.Size = new System.Drawing.Size(117, 20);
            this.lblPila.TabIndex = 12;
            this.lblPila.Text = "Mostrar ultimo: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 609);
            this.Controls.Add(this.lblPila);
            this.Controls.Add(this.lbResultados);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnVerTope);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.tbCargo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "PilaAPP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbCargo;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVerTope;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListBox lbResultados;
        private System.Windows.Forms.Label lblPila;
    }
}

