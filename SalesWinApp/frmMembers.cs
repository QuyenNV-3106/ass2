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
    public partial class frmMembers : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        public bool CheckAdminLogin { get; set; }
        public MemberObject Member { get; set; }
        public frmMembers()
        {
            InitializeComponent();
        }
        public MemberObject GetMemberObject()
        {
            MemberObject member = null;
            try
            {
                member = new MemberObject
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    CompanyName = txtCompany.Text,
                    Email = txtEmail.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Password = txtPassword.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member");
            }
            return member;
        }

        public void Authentication()
        {
            if (!CheckAdminLogin)
            {
                btnInsert.Enabled = false;
                btnDelete.Enabled = false;
                LoadMemberList(memberRepository.GetMemberID(Member.MemberID));
            }
            else
            {
                btnInsert.Enabled = true;
                btnDelete.Enabled = true;
                LoadMemberList(memberRepository.GetMembers());
            }
        }

        public void LoadMemberList(IEnumerable<MemberObject> members)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = members;

                txtMemberID.DataBindings.Clear();
                txtCompany.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtPassword.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtCompany.DataBindings.Add("Text", source, "CompanyName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtPassword.DataBindings.Add("Text", source, "Password");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;

                dgvMemberList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMemberList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                if (members.Count() == 0)
                {
                    btnDelete.Enabled = false;
                    txtMemberID.Clear();
                    txtCompany.Clear();
                    txtEmail.Clear();
                    txtCity.Clear();
                    txtCountry.Clear();
                    txtPassword.Clear();
                }
                else
                {
                    if (!CheckAdminLogin)
                    {
                        btnInsert.Enabled = false;
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnInsert.Enabled = true;
                        btnDelete.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member List");
            }
        }
        private void frmMembers_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            Authentication();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmMemberDetails form = new frmMemberDetails
            {
                Text = "Insert Member",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };
            form.ShowDialog();
            Authentication();
        }

        private void dgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetails form = new frmMemberDetails
            {
                Text = "Update Member",
                InsertOrUpdate = true,
                MemberInfo = GetMemberObject(),
                MemberRepository = memberRepository
            };
            form.ShowDialog();
            Authentication();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult result = MessageBox.Show("Are you sure?", "Confirm Remove", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var member = GetMemberObject();
                    memberRepository.DeleteMem(member.MemberID);
                    txtMemberID.Clear();
                    txtCompany.Clear();
                    txtEmail.Clear();
                    txtCity.Clear();
                    txtCountry.Clear();
                    txtPassword.Clear();
                    LoadMemberList(memberRepository.GetMembers());
                    MessageBox.Show("Remove Success", "Remove Member");
                }
                else
                {
                    MessageBox.Show("Cancel !", "Remove Member");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete member");
            }
        }
    }
}
