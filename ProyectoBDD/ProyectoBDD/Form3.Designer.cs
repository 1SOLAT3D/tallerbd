
namespace ProyectoBDD
{
    partial class Form3
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
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.rbEmpleados = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbClientes = new System.Windows.Forms.RadioButton();
            this.rbComidas = new System.Windows.Forms.RadioButton();
            this.rbOrdenes = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDatos
            // 
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Location = new System.Drawing.Point(12, 44);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.Size = new System.Drawing.Size(552, 278);
            this.dtgDatos.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(570, 257);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(122, 39);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Regresar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // rbEmpleados
            // 
            this.rbEmpleados.AutoSize = true;
            this.rbEmpleados.Location = new System.Drawing.Point(570, 61);
            this.rbEmpleados.Name = "rbEmpleados";
            this.rbEmpleados.Size = new System.Drawing.Size(138, 17);
            this.rbEmpleados.TabIndex = 3;
            this.rbEmpleados.TabStop = true;
            this.rbEmpleados.Text = "Datos de los empleados";
            this.rbEmpleados.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "DATOS";
            // 
            // rbClientes
            // 
            this.rbClientes.AutoSize = true;
            this.rbClientes.Location = new System.Drawing.Point(570, 96);
            this.rbClientes.Name = "rbClientes";
            this.rbClientes.Size = new System.Drawing.Size(62, 17);
            this.rbClientes.TabIndex = 5;
            this.rbClientes.TabStop = true;
            this.rbClientes.Text = "Clientes";
            this.rbClientes.UseVisualStyleBackColor = true;
            // 
            // rbComidas
            // 
            this.rbComidas.AutoSize = true;
            this.rbComidas.Location = new System.Drawing.Point(570, 128);
            this.rbComidas.Name = "rbComidas";
            this.rbComidas.Size = new System.Drawing.Size(65, 17);
            this.rbComidas.TabIndex = 6;
            this.rbComidas.TabStop = true;
            this.rbComidas.Text = "Comidas";
            this.rbComidas.UseVisualStyleBackColor = true;
            // 
            // rbOrdenes
            // 
            this.rbOrdenes.AutoSize = true;
            this.rbOrdenes.Location = new System.Drawing.Point(570, 160);
            this.rbOrdenes.Name = "rbOrdenes";
            this.rbOrdenes.Size = new System.Drawing.Size(65, 17);
            this.rbOrdenes.TabIndex = 7;
            this.rbOrdenes.TabStop = true;
            this.rbOrdenes.Text = "Ordenes";
            this.rbOrdenes.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 353);
            this.Controls.Add(this.rbOrdenes);
            this.Controls.Add(this.rbComidas);
            this.Controls.Add(this.rbClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbEmpleados);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtgDatos);
            this.Name = "Form3";
            this.Text = "Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDatos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RadioButton rbEmpleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbClientes;
        private System.Windows.Forms.RadioButton rbComidas;
        private System.Windows.Forms.RadioButton rbOrdenes;
    }
}