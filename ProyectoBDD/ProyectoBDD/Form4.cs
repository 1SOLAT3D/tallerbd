using RegisComida;
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
    public partial class Form4 : Form
    {
        BaseDato BD;
        public Form4(BaseDato db)
        {
            InitializeComponent();
            BD = db;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Visible = false;
        }
    }
}
