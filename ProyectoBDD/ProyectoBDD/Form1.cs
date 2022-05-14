using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBDD
{
    public partial class Form1 : Form
    {
        private const int IntervaloTimer = 5;//Controla la rapidez de la barra
        public Form1()
        {
            InitializeComponent();
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(IntervaloTimer);
            if (progressBar1.Value == 100)
            {
                Label1_TextChanged();
            }
            else
            {
                label1.Text = progressBar1.Value + "%";
            }
        }
        protected void Label1_TextChanged()
        {
            timer1.Stop();
            //MainWindow mainWindow = new MainWindow();
            Form2 mainWindow = new Form2();
            this.Visible = false;
            mainWindow.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
