using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballerForm
{
    public partial class Characteristic : Form
    {
        public Characteristic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Traums();
            form.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_Position(object sender, EventArgs e)
        {

        }

        private void comboBox2_WorkLeg(object sender, EventArgs e)
        {

        }
    }
}
