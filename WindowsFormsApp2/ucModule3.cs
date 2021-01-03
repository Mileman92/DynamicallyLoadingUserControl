﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ucModule3 : UserControl
    {
        private static ucModule3 _instance;

        public static ucModule3 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucModule3();
                return _instance;
            }
        }
        public ucModule3()
        {
            InitializeComponent();
        }
    }
}
