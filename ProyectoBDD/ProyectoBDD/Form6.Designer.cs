
namespace ProyectoBDD
{
    partial class Form6
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.rbGrande = new System.Windows.Forms.RadioButton();
            this.rbMediana = new System.Windows.Forms.RadioButton();
            this.rbChica = new System.Windows.Forms.RadioButton();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tamaño";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(82, 68);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(125, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // rbGrande
            // 
            this.rbGrande.AutoSize = true;
            this.rbGrande.Location = new System.Drawing.Point(87, 109);
            this.rbGrande.Name = "rbGrande";
            this.rbGrande.Size = new System.Drawing.Size(60, 17);
            this.rbGrande.TabIndex = 6;
            this.rbGrande.TabStop = true;
            this.rbGrande.Text = "Grande";
            this.rbGrande.UseVisualStyleBackColor = true;
            // 
            // rbMediana
            // 
            this.rbMediana.AutoSize = true;
            this.rbMediana.Location = new System.Drawing.Point(87, 142);
            this.rbMediana.Name = "rbMediana";
            this.rbMediana.Size = new System.Drawing.Size(66, 17);
            this.rbMediana.TabIndex = 7;
            this.rbMediana.TabStop = true;
            this.rbMediana.Text = "Mediana";
            this.rbMediana.UseVisualStyleBackColor = true;
            // 
            // rbChica
            // 
            this.rbChica.AutoSize = true;
            this.rbChica.Location = new System.Drawing.Point(87, 174);
            this.rbChica.Name = "rbChica";
            this.rbChica.Size = new System.Drawing.Size(52, 17);
            this.rbChica.TabIndex = 8;
            this.rbChica.TabStop = true;
            this.rbChica.Text = "Chica";
            this.rbChica.UseVisualStyleBackColor = true;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(102, 219);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(105, 40);
            this.btnCapturar.TabIndex = 9;
            this.btnCapturar.Text = "Capturar Comida";
            this.btnCapturar.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 292);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.rbChica);
            this.Controls.Add(this.rbMediana);
            this.Controls.Add(this.rbGrande);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Datos de la comida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.RadioButton rbGrande;
        private System.Windows.Forms.RadioButton rbMediana;
        private System.Windows.Forms.RadioButton rbChica;
        private System.Windows.Forms.Button btnCapturar;
    }
}