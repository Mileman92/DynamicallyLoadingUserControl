using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

       
        public void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            //int pr = Combo();
            int pr = comboBox1.SelectedIndex;

            comboBox2.SelectedIndex = pr;
            f2.comboBox3.SelectedIndex = pr;
            //f2.comboBox3.SelectedIndex = pr;
            //f2.comboBox1_SelectedValueChanged(sender, e);
           
        }

        //public int Combo()
        //{
        //    int pr = comboBox1.SelectedIndex;
        //    return pr;
        //}
        public void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            int pr2 = comboBox2.SelectedIndex;
            comboBox1.SelectedIndex = pr2;
        }
    }
}
