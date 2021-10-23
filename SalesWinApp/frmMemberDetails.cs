using BusinessObject;
using DataAccess.Repository;
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
    public partial class frmMemberDetails : Form
    {
        public frmMemberDetails()
        {
            InitializeComponent();
        }
        public bool InsertOrUpdate { get; set; }
        public MemberObject MemberInfo { get; set; }
        public IMemberRepository MemberRepository { get; set; }
        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            txtMemberID.Enabled = !InsertOrUpdate;
            cboCity.SelectedIndex = 0;
            cboCountry.SelectedIndex = 0;
            if (InsertOrUpdate)
            {
                txtMemberID.Text = MemberInfo.MemberID.ToString();
                txtCompanyName.Text = MemberInfo.CompanyName.ToString();
                txtEmail.Text = MemberInfo.Email.ToString();
                txtPassword.Text = MemberInfo.Password.ToString();
                cboCity.Text = MemberInfo.City.ToString();
                cboCountry.Text = MemberInfo.Country.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new MemberObject
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    CompanyName = txtCompanyName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = cboCity.Text.Trim(),
                    Country = cboCountry.Text.Trim()
                };
                if (InsertOrUpdate)
                {
                    MemberRepository.UpdateMem(member);
                    MessageBox.Show("Success", "Update Member");
                    this.Close();
                }
                else
                {
                    MemberRepository.InsertMember(member);
                    MessageBox.Show("Success", "Insert new member");
                    txtMemberID.Clear();
                    txtEmail.Clear();
                    txtCompanyName.Clear();
                    txtPassword.Clear();
                    cboCity.SelectedIndex = 0;
                    cboCountry.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == true ? "Update member" : "Insert new member");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
