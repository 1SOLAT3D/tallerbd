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
            this.lblLetreroCliente = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.gbCOrden = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnComida = new System.Windows.Forms.Button();
            this.cmbComida = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCombo = new System.Windows.Forms.Button();
            this.cmbCombos = new System.Windows.Forms.ComboBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbPequeño = new System.Windows.Forms.RadioButton();
            this.rdbMediano = new System.Windows.Forms.RadioButton();
            this.rdbGrande = new System.Windows.Forms.RadioButton();
            this.rdbEGrande = new System.Windows.Forms.RadioButton();
            this.dtg_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtg_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtg_FechaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtg_Hora_Estimada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtg_Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCajero)).BeginInit();
            this.gbCOrden.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrden
            // 
            this.btnOrden.Location = new System.Drawing.Point(22, 46);
            this.btnOrden.Name = "btnOrden";
            this.btnOrden.Size = new System.Drawing.Size(132, 49);
            this.btnOrden.TabIndex = 2;
            this.btnOrden.Text = "Capturar Orden";
            this.btnOrden.UseVisualStyleBackColor = true;
            this.btnOrden.Click += new System.EventHandler(this.btnOrden_Click);
            // 
            // dtgCajero
            // 
            this.dtgCajero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCajero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtg_Nombre,
            this.dtg_Cantidad,
            this.dtg_FechaPedido,
            this.dtg_Hora_Estimada,
            this.dtg_Monto});
            this.dtgCajero.Location = new System.Drawing.Point(172, 46);
            this.dtgCajero.Name = "dtgCajero";
            this.dtgCajero.Size = new System.Drawing.Size(683, 170);
            this.dtgCajero.TabIndex = 3;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(22, 223);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(132, 41);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblLetreroCliente
            // 
            this.lblLetreroCliente.AutoSize = true;
            this.lblLetreroCliente.Location = new System.Drawing.Point(22, 13);
            this.lblLetreroCliente.Name = "lblLetreroCliente";
            this.lblLetreroCliente.Size = new System.Drawing.Size(74, 13);
            this.lblLetreroCliente.TabIndex = 5;
            this.lblLetreroCliente.Text = "Cliente actual:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(281, 13);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(68, 13);
            this.lblEmpleado.TabIndex = 6;
            this.lblEmpleado.Text = "Empleado/a:";
            // 
            // gbCOrden
            // 
            this.gbCOrden.Controls.Add(this.groupBox4);
            this.gbCOrden.Controls.Add(this.lblTotal);
            this.gbCOrden.Controls.Add(this.label1);
            this.gbCOrden.Controls.Add(this.groupBox3);
            this.gbCOrden.Controls.Add(this.groupBox1);
            this.gbCOrden.Location = new System.Drawing.Point(172, 223);
            this.gbCOrden.Name = "gbCOrden";
            this.gbCOrden.Size = new System.Drawing.Size(683, 139);
            this.gbCOrden.TabIndex = 7;
            this.gbCOrden.TabStop = false;
            this.gbCOrden.Text = "Cuadro de ordenes";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(557, 46);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "$00.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tolal";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnComida);
            this.groupBox3.Controls.Add(this.cmbComida);
            this.groupBox3.Location = new System.Drawing.Point(235, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 114);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comida por individual";
            // 
            // btnComida
            // 
            this.btnComida.Location = new System.Drawing.Point(7, 78);
            this.btnComida.Name = "btnComida";
            this.btnComida.Size = new System.Drawing.Size(164, 30);
            this.btnComida.TabIndex = 1;
            this.btnComida.Text = "Insertar";
            this.btnComida.UseVisualStyleBackColor = true;
            this.btnComida.Click += new System.EventHandler(this.btnComida_Click);
            // 
            // cmbComida
            // 
            this.cmbComida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComida.FormattingEnabled = true;
            this.cmbComida.Items.AddRange(new object[] {
            "Pizza pepperoni",
            "Pizza Extra Queso",
            "Pizza hawaiana",
            "Panecillos",
            "Coca",
            "Pizza pepperoni",
            "Pizza Extra Queso",
            "Pizza Batman",
            "Pizza pepperoni",
            "Pizza Batman"});
            this.cmbComida.Location = new System.Drawing.Point(6, 19);
            this.cmbComida.Name = "cmbComida";
            this.cmbComida.Size = new System.Drawing.Size(165, 21);
            this.cmbComida.TabIndex = 0;
            this.cmbComida.SelectedIndexChanged += new System.EventHandler(this.cmbComida_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCombo);
            this.groupBox1.Controls.Add(this.cmbCombos);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 114);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Combos";
            // 
            // btnCombo
            // 
            this.btnCombo.Location = new System.Drawing.Point(7, 78);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(164, 30);
            this.btnCombo.TabIndex = 1;
            this.btnCombo.Text = "Insertar";
            this.btnCombo.UseVisualStyleBackColor = true;
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // cmbCombos
            // 
            this.cmbCombos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCombos.FormattingEnabled = true;
            this.cmbCombos.Items.AddRange(new object[] {
            "Amigos",
            "Familiar",
            "Extra Queso",
            "Grande",
            "Infantil",
            "Batman",
            "Fiesta"});
            this.cmbCombos.Location = new System.Drawing.Point(6, 19);
            this.cmbCombos.Name = "cmbCombos";
            this.cmbCombos.Size = new System.Drawing.Size(165, 21);
            this.cmbCombos.TabIndex = 0;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(22, 178);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(129, 38);
            this.btnFinalizar.TabIndex = 8;
            this.btnFinalizar.Text = "Finalizar orden";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPago);
            this.groupBox2.Location = new System.Drawing.Point(22, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 58);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cantidad de pago";
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(7, 20);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(116, 20);
            this.txtPago.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hora de inicio: ";
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Location = new System.Drawing.Point(631, 13);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(34, 13);
            this.lblClock.TabIndex = 11;
            this.lblClock.Text = "00:00";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdbEGrande);
            this.groupBox4.Controls.Add(this.rdbGrande);
            this.groupBox4.Controls.Add(this.rdbMediano);
            this.groupBox4.Controls.Add(this.rdbPequeño);
            this.groupBox4.Location = new System.Drawing.Point(445, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(93, 120);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tamaño";
            // 
            // rdbPequeño
            // 
            this.rdbPequeño.AutoSize = true;
            this.rdbPequeño.Checked = true;
            this.rdbPequeño.Location = new System.Drawing.Point(7, 20);
            this.rdbPequeño.Name = "rdbPequeño";
            this.rdbPequeño.Size = new System.Drawing.Size(68, 17);
            this.rdbPequeño.TabIndex = 0;
            this.rdbPequeño.TabStop = true;
            this.rdbPequeño.Text = "Pequeño";
            this.rdbPequeño.UseVisualStyleBackColor = true;
            // 
            // rdbMediano
            // 
            this.rdbMediano.AutoSize = true;
            this.rdbMediano.Location = new System.Drawing.Point(7, 44);
            this.rdbMediano.Name = "rdbMediano";
            this.rdbMediano.Size = new System.Drawing.Size(66, 17);
            this.rdbMediano.TabIndex = 1;
            this.rdbMediano.Text = "Mediano";
            this.rdbMediano.UseVisualStyleBackColor = true;
            // 
            // rdbGrande
            // 
            this.rdbGrande.AutoSize = true;
            this.rdbGrande.Location = new System.Drawing.Point(7, 70);
            this.rdbGrande.Name = "rdbGrande";
            this.rdbGrande.Size = new System.Drawing.Size(60, 17);
            this.rdbGrande.TabIndex = 2;
            this.rdbGrande.Text = "Grande";
            this.rdbGrande.UseVisualStyleBackColor = true;
            // 
            // rdbEGrande
            // 
            this.rdbEGrande.AutoSize = true;
            this.rdbEGrande.Location = new System.Drawing.Point(7, 96);
            this.rdbEGrande.Name = "rdbEGrande";
            this.rdbEGrande.Size = new System.Drawing.Size(85, 17);
            this.rdbEGrande.TabIndex = 3;
            this.rdbEGrande.Text = "Extra grande";
            this.rdbEGrande.UseVisualStyleBackColor = true;
            // 
            // dtg_Nombre
            // 
            this.dtg_Nombre.HeaderText = "Nombre";
            this.dtg_Nombre.Name = "dtg_Nombre";
            this.dtg_Nombre.ReadOnly = true;
            // 
            // dtg_Cantidad
            // 
            this.dtg_Cantidad.HeaderText = "Cantidad";
            this.dtg_Cantidad.Name = "dtg_Cantidad";
            this.dtg_Cantidad.ReadOnly = true;
            // 
            // dtg_FechaPedido
            // 
            this.dtg_FechaPedido.HeaderText = "Fecha del pedido";
            this.dtg_FechaPedido.Name = "dtg_FechaPedido";
            this.dtg_FechaPedido.ReadOnly = true;
            this.dtg_FechaPedido.Width = 150;
            // 
            // dtg_Hora_Estimada
            // 
            this.dtg_Hora_Estimada.HeaderText = "Hora estimada de entrega";
            this.dtg_Hora_Estimada.Name = "dtg_Hora_Estimada";
            this.dtg_Hora_Estimada.ReadOnly = true;
            this.dtg_Hora_Estimada.Width = 170;
            // 
            // dtg_Monto
            // 
            this.dtg_Monto.HeaderText = "Monto";
            this.dtg_Monto.Name = "dtg_Monto";
            this.dtg_Monto.ReadOnly = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 374);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.gbCOrden);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblLetreroCliente);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dtgCajero);
            this.Controls.Add(this.btnOrden);
            this.Name = "Form4";
            this.Text = "Cajero";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCajero)).EndInit();
            this.gbCOrden.ResumeLayout(false);
            this.gbCOrden.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOrden;
        private System.Windows.Forms.DataGridView dtgCajero;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblLetreroCliente;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.GroupBox gbCOrden;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnComida;
        private System.Windows.Forms.ComboBox cmbComida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.ComboBox cmbCombos;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdbEGrande;
        private System.Windows.Forms.RadioButton rdbGrande;
        private System.Windows.Forms.RadioButton rdbMediano;
        private System.Windows.Forms.RadioButton rdbPequeño;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtg_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtg_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtg_FechaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtg_Hora_Estimada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtg_Monto;
    }
}