﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ucModule2 : UserControl
    {
        private static ucModule2 _instance;

        public static ucModule2 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucModule2();
                return _instance;
            }
        }
        public ucModule2()
        {
            InitializeComponent();
        }
    }
}
