using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace RibbonFormMerging
{
    public partial class RibbonForm2 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonForm2()
        {
            InitializeComponent();
        }

        public void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        public delegate void SimpleDelegate();
        public static void MyFunc()
        {
            
        }
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form1 f = new Form1();
            f.simpleButton1_Click(sender,e);

        }

        private void barLinkContainerItem2_LinkAdded(object sender, LinkEventArgs e)
        {
            RibbonForm1 f = new RibbonForm1();
           barLinkContainerItem1.AddItem(f.barEditItem1);
        }
    }
}