﻿
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
            this.btnOrden = new System.Windows.Forms.Button();
            this.dtgCajero = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCajero)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrden
            // 
            this.btnOrden.Location = new System.Drawing.Point(22, 28);
            this.btnOrden.Name = "btnOrden";
            this.btnOrden.Size = new System.Drawing.Size(132, 49);
            this.btnOrden.TabIndex = 2;
            this.btnOrden.Text = "Capturar Orden";
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
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(22, 110);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(132, 41);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 236);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dtgCajero);
            this.Controls.Add(this.btnOrden);
            this.Name = "Form4";
            this.Text = "Cajero";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCajero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOrden;
        private System.Windows.Forms.DataGridView dtgCajero;
        private System.Windows.Forms.Button btnRegresar;
    }
}