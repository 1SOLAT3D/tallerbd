
namespace ProyectoBDD
{
    partial class Form7
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
            this.txtidCliente = new System.Windows.Forms.TextBox();
            this.txtidcombo = new System.Windows.Forms.TextBox();
            this.txtIdComida = new System.Windows.Forms.TextBox();
            this.txtIdempleado = new System.Windows.Forms.TextBox();
            this.dtpFechaPe = new System.Windows.Forms.DateTimePicker();
            this.txtHoraEsperada = new System.Windows.Forms.TextBox();
            this.btnCapturarOrden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id combo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "id comida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de pedido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hora de entrega esperada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Id empleado";
            // 
            // txtidCliente
            // 
            this.txtidCliente.Location = new System.Drawing.Point(100, 38);
            this.txtidCliente.Name = "txtidCliente";
            this.txtidCliente.Size = new System.Drawing.Size(74, 20);
            this.txtidCliente.TabIndex = 6;
            // 
            // txtidcombo
            // 
            this.txtidcombo.Location = new System.Drawing.Point(100, 75);
            this.txtidcombo.Name = "txtidcombo";
            this.txtidcombo.Size = new System.Drawing.Size(74, 20);
            this.txtidcombo.TabIndex = 7;
            // 
            // txtIdComida
            // 
            this.txtIdComida.Location = new System.Drawing.Point(102, 113);
            this.txtIdComida.Name = "txtIdComida";
            this.txtIdComida.Size = new System.Drawing.Size(74, 20);
            this.txtIdComida.TabIndex = 8;
            // 
            // txtIdempleado
            // 
            this.txtIdempleado.Location = new System.Drawing.Point(115, 244);
            this.txtIdempleado.Name = "txtIdempleado";
            this.txtIdempleado.Size = new System.Drawing.Size(74, 20);
            this.txtIdempleado.TabIndex = 9;
            // 
            // dtpFechaPe
            // 
            this.dtpFechaPe.Location = new System.Drawing.Point(137, 154);
            this.dtpFechaPe.Name = "dtpFechaPe";
            this.dtpFechaPe.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPe.TabIndex = 10;
            // 
            // txtHoraEsperada
            // 
            this.txtHoraEsperada.Location = new System.Drawing.Point(181, 202);
            this.txtHoraEsperada.Name = "txtHoraEsperada";
            this.txtHoraEsperada.Size = new System.Drawing.Size(100, 20);
            this.txtHoraEsperada.TabIndex = 11;
            // 
            // btnCapturarOrden
            // 
            this.btnCapturarOrden.Location = new System.Drawing.Point(126, 283);
            this.btnCapturarOrden.Name = "btnCapturarOrden";
            this.btnCapturarOrden.Size = new System.Drawing.Size(109, 32);
            this.btnCapturarOrden.TabIndex = 12;
            this.btnCapturarOrden.Text = "Capturar Orden";
            this.btnCapturarOrden.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 340);
            this.Controls.Add(this.btnCapturarOrden);
            this.Controls.Add(this.txtHoraEsperada);
            this.Controls.Add(this.dtpFechaPe);
            this.Controls.Add(this.txtIdempleado);
            this.Controls.Add(this.txtIdComida);
            this.Controls.Add(this.txtidcombo);
            this.Controls.Add(this.txtidCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Datos de la Orden";
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
        private System.Windows.Forms.TextBox txtidCliente;
        private System.Windows.Forms.TextBox txtidcombo;
        private System.Windows.Forms.TextBox txtIdComida;
        private System.Windows.Forms.TextBox txtIdempleado;
        private System.Windows.Forms.DateTimePicker dtpFechaPe;
        private System.Windows.Forms.TextBox txtHoraEsperada;
        private System.Windows.Forms.Button btnCapturarOrden;
    }
}