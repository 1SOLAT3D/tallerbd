﻿
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTabla = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgDatos
            // 
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Location = new System.Drawing.Point(6, 32);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.Size = new System.Drawing.Size(529, 278);
            this.dtgDatos.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(551, 244);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(188, 39);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Regresar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // rbEmpleados
            // 
            this.rbEmpleados.AutoSize = true;
            this.rbEmpleados.Location = new System.Drawing.Point(564, 49);
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
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "DATOS";
            // 
            // rbClientes
            // 
            this.rbClientes.AutoSize = true;
            this.rbClientes.Location = new System.Drawing.Point(564, 84);
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
            this.rbComidas.Location = new System.Drawing.Point(564, 116);
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
            this.rbOrdenes.Location = new System.Drawing.Point(564, 148);
            this.rbOrdenes.Name = "rbOrdenes";
            this.rbOrdenes.Size = new System.Drawing.Size(65, 17);
            this.rbOrdenes.TabIndex = 7;
            this.rbOrdenes.TabStop = true;
            this.rbOrdenes.Text = "Ordenes";
            this.rbOrdenes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.cmbTabla);
            this.groupBox1.Location = new System.Drawing.Point(551, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 60);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de la tabla";
            // 
            // cmbTabla
            // 
            this.cmbTabla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTabla.FormattingEnabled = true;
            this.cmbTabla.Items.AddRange(new object[] {
            "Datos de empleados",
            "Clientes",
            "Comidas",
            "Ordenes"});
            this.cmbTabla.Location = new System.Drawing.Point(7, 20);
            this.cmbTabla.Name = "cmbTabla";
            this.cmbTabla.Size = new System.Drawing.Size(169, 21);
            this.cmbTabla.TabIndex = 0;
            this.cmbTabla.SelectedIndexChanged += new System.EventHandler(this.CmbTabla_SelectedIndexChange);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.dtgDatos);
            this.groupBox2.Controls.Add(this.rbOrdenes);
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.rbComidas);
            this.groupBox2.Controls.Add(this.rbEmpleados);
            this.groupBox2.Controls.Add(this.rbClientes);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 347);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vista";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 347);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form3";
            this.Text = "Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTabla;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}