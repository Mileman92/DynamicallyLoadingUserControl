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
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonForm1()
        {
            InitializeComponent();
        }

        private void barLinkContainerItem1_LinkAdded(object sender, LinkEventArgs e)
        {
            RibbonForm2 r = new RibbonForm2();
            r.barButtonItem1_ItemClick(sender,null);

        }

        private void barEditItem1_EditValueChanged(object sender, EventArgs e)
        {
            RibbonForm2 r = new RibbonForm2();
            r.barLinkContainerItem2.AddItem(barEditItem1);
        }
    }
}