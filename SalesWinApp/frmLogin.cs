using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using System.IO;
using Microsoft.Extensions.Configuration;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IMemberRepository repo = new MemberRepository();
            Form form = null;
            var adminDefault = Program.Configuration.GetSection("AdminAccount").Get<MemberObject>();
            if (adminDefault.Email.Equals(txtEmail.Text) && adminDefault.Password.Equals(txtPassword.Text))
            {
                form = new frmMain
                {
                    CheckAdminLogin = true
                };
                form.Show();
                this.Hide();
            }
            else
            {
                MemberObject member = repo.GetMemberLogin(txtEmail.Text, txtPassword.Text);
                if (member != null)
                {
                    if ((member.Email.Equals(txtEmail.Text) && member.Password.Equals(txtPassword.Text)))
                    {
                        form = new frmMain
                        {
                            CheckAdminLogin = false,
                            Member = member
                        };
                        form.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("User not found", "Login");
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
