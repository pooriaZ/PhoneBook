using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneNumber
{
    public partial class frmMain : Form
    {
        PhoneNumberDBEntities DB;
        public frmMain()
        {
            DB = new PhoneNumberDBEntities();
            InitializeComponent();
        }

        private void btnContactAdd_Click(object sender, EventArgs e)
        {
            frmContacts contactForm = new frmContacts();
            contactForm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UpdateContactGridView();
        }

        public string GetGroupName(int groupNumber)
        {
            var result = "";
            switch (groupNumber)
            {
                case 0:
                    result = "normal";
                    break;
                case 1:
                    result = "partner";
                    break;
                case 2:
                    result = "friend";
                    break;
                case 3 : 
                    result = "family";
                    break;
                case 4:
                    result = "emergency";
                    break;
            }
            return result;
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            UpdateContactGridView();
        }

        private void UpdateContactGridView()
        {
            dataGridView1.DataSource = DB.Contacts.ToList().Select(x => new
            {
                x.Id,
                x.FirstName,
                x.LastName,
                x.MobileNumber,
                x.PhoneNumber,
                x.Email,
                GroupContact = GetGroupName(x.GroupContact),
                x.Address,
                x.Description
            }
           ).ToList();

            dataGridView1.Columns[0].HeaderText = "row";
            dataGridView1.Columns[1].HeaderText = "name";
            dataGridView1.Columns[2].HeaderText = "last name";
            dataGridView1.Columns[3].HeaderText = "phone";
            dataGridView1.Columns[4].HeaderText = "cell";
            dataGridView1.Columns[5].HeaderText = "email";
            dataGridView1.Columns[6].HeaderText = "group";
            dataGridView1.Columns[7].HeaderText = "address";
            dataGridView1.Columns[8].HeaderText = "description";
        }

        private void btnContactEdit_Click(object sender, EventArgs e)
        {
            var ContactId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            var con = DB.Contacts.Where(x => x.Id == ContactId).FirstOrDefault();
            frmContacts contactForm = new frmContacts();
            contactForm.ContactEdit = con;
            contactForm.ShowDialog();
        }

        private void btnContactRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var ContactId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                var con = DB.Contacts.Where(x => x.Id == ContactId).FirstOrDefault();
                DB.Contacts.Remove(con);
                DB.SaveChanges();
                UpdateContactGridView();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() != string.Empty)
            {
                var ListOfContact = DB.Contacts.Where(x => x.FirstName.Contains(txtSearch.Text.Trim()) ||
                                                       x.LastName.Contains(txtSearch.Text.Trim()));

                dataGridView1.DataSource = ListOfContact.ToList().Select(x => new
                {
                    x.Id,
                    x.FirstName,
                    x.LastName,
                    x.MobileNumber,
                    x.PhoneNumber,
                    x.Email,
                    GroupContact = GetGroupName(x.GroupContact),
                    x.Address,
                    x.Description
                }
              ).ToList();

                dataGridView1.Columns[0].HeaderText = "row";
                dataGridView1.Columns[1].HeaderText = "name";
                dataGridView1.Columns[2].HeaderText = "last name";
                dataGridView1.Columns[3].HeaderText = "phone";
                dataGridView1.Columns[4].HeaderText = "cell";
                dataGridView1.Columns[5].HeaderText = "email";
                dataGridView1.Columns[6].HeaderText = "group";
                dataGridView1.Columns[7].HeaderText = "address";
                dataGridView1.Columns[8].HeaderText = "description";
            }
            else
            {
                UpdateContactGridView();
            }
            

        }

        private void mnuItemAddContacts_Click(object sender, EventArgs e)
        {
            frmContacts contact = new frmContacts();
            contact.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }

    public enum ContactGroupEnum
    {
        Normal, 
        Partner,
        Friend,
        Family,
        Emergency,
    }

}
