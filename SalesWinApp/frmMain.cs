using BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public bool CheckAdminLogin { get; set; }
        public MemberObject Member { get; set; }
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (!CheckAdminLogin)
            {
                productToolStripMenuItem.Enabled = false;
            }
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form proFrm = new frmProducts();
            proFrm.MdiParent = this;
            proFrm.Show();
        }
        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form proFrm;
            if (!CheckAdminLogin)
            {
                proFrm = new frmMembers
                {
                    Member = Member,
                    CheckAdminLogin = false
                };
                proFrm.MdiParent = this;
            }
            else
            {
                proFrm = new frmMembers
                {
                    CheckAdminLogin = true
                };
                proFrm.MdiParent = this;
            }
            proFrm.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
