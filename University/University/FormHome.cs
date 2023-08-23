using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }
        FormInstructors form1;
        FormStudent form2;
        FormAdvisor form3;



        private void btnINSTRUCTOR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (form1 == null || form1.IsDisposed)
            {
                form1 = new FormInstructors();
                form1.MdiParent = this;
                form1.Show();
            }
        }

        private void btnSTUDENTS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(form2==null || form2.IsDisposed)
            {
                form2 = new FormStudent();
                form2.MdiParent = this;
                form2.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (form3 == null || form3.IsDisposed)
            {
                form3 = new FormAdvisor();
                form3.MdiParent = this;
                form3.Show();
            }
        }
    }
}
