using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            //ComboBox cb = new ComboBox();
            Form1 fo = new Form1();
            int pr = comboBox3.SelectedIndex;
            fo.comboBox1.SelectedIndex = pr;
        }

        //private void comboBox3_Click(object sender, EventArgs e)
        //{
        //    //Form1 fo = new Form1();
        //    //int pr = fo.Combo();
        //    //fo.comboBox1.SelectedIndex = pr;
        //}
    }
}
