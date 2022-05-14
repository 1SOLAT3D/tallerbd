
namespace ProyectoBDD
{
    partial class Form4
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
            this.btncliente = new System.Windows.Forms.Button();
            this.btnComida = new System.Windows.Forms.Button();
            this.btnOrden = new System.Windows.Forms.Button();
            this.dtgCajero = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCajero)).BeginInit();
            this.SuspendLayout();
            // 
            // btncliente
            // 
            this.btncliente.Location = new System.Drawing.Point(24, 28);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(132, 39);
            this.btncliente.TabIndex = 0;
            this.btncliente.Text = "Capturar cliente";
            this.btncliente.UseVisualStyleBackColor = true;
            // 
            // btnComida
            // 
            this.btnComida.Location = new System.Drawing.Point(24, 97);
            this.btnComida.Name = "btnComida";
            this.btnComida.Size = new System.Drawing.Size(132, 42);
            this.btnComida.TabIndex = 1;
            this.btnComida.Text = "Capturar Comida";
            this.btnComida.UseVisualStyleBackColor = true;
            // 
            // btnOrden
            // 
            this.btnOrden.Location = new System.Drawing.Point(24, 167);
            this.btnOrden.Name = "btnOrden";
            this.btnOrden.Size = new System.Drawing.Size(132, 49);
            this.btnOrden.TabIndex = 2;
            this.btnOrden.Text = "CapturarOrden";
            this.btnOrden.UseVisualStyleBackColor = true;
            // 
            // dtgCajero
            // 
            this.dtgCajero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCajero.Location = new System.Drawing.Point(172, 28);
            this.dtgCajero.Name = "dtgCajero";
            this.dtgCajero.Size = new System.Drawing.Size(577, 188);
            this.dtgCajero.TabIndex = 3;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 236);
            this.Controls.Add(this.dtgCajero);
            this.Controls.Add(this.btnOrden);
            this.Controls.Add(this.btnComida);
            this.Controls.Add(this.btncliente);
            this.Name = "Form4";
            this.Text = "Cajero";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCajero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.Button btnComida;
        private System.Windows.Forms.Button btnOrden;
        private System.Windows.Forms.DataGridView dtgCajero;
    }
}