using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            MyProgressBar1.Value = 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MyProgressBar1.Value += 5;
            MyProgressBar1.Text = MyProgressBar1.Value.ToString() + "%";

            if (MyProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                Form1 second_form = new Form1();
                this.Close();
            }
        }
    }
}
