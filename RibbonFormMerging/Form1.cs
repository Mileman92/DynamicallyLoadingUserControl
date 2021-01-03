using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RibbonFormMerging
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void navBarItem1_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(RibbonForm1))
                {
                    form.Activate();
                    return;
                }
            }
            var forma = new RibbonForm1();
            forma.MdiParent = this;
            forma.Show();
        }

        private void navBarItem2_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(RibbonForm2))
                {
                    form.Activate();
                    return;
                }
            }
            var forma = new RibbonForm2();

            forma.MdiParent = this;
            forma.Show();
        }



        public void navBarItem3_LinkPressed(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //foreach (Form form in Application.OpenForms)
            //{
            //    if (form.GetType() == typeof(RibbonForm3))
            //    {
            //        form.Activate();
            //        return;
            //    }
            //}
            //var forma = new RibbonForm3();
            //forma.MdiParent = this;
            //forma.Show();
        }
        Boolean b = false;
        private void navBarItem3_ItemChanged(object sender, EventArgs e)
        {
            //b = true;
            //foreach (Form form in Application.OpenForms)
            //{
            //    if (form.GetType() == typeof(RibbonForm3))
            //    {
            //        form.Activate();
            //        return;
            //    }
            //}
            //var forma = new RibbonForm3();
            //forma.MdiParent = this;
            //forma.Show();
        }

        public void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //foreach (Form form in Application.OpenForms)
            //{
            //    if (form.GetType() == typeof(RibbonForm3))
            //    {
            //        form.Activate();
            //        return;
            //    }
            //}
            //var forma = new RibbonForm3();
            //forma.MdiParent = this;
            //forma.Show();
        }

       
        private void barButtonItem1_ItemPress(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }

        public void simpleButton1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(RibbonForm3))
                {
                    form.Activate();
                    return;
                }
            }
            var forma = new RibbonForm3();
            forma.MdiParent = this;
            forma.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            simpleButton1_Click(sender,e);
        }
    }
}
