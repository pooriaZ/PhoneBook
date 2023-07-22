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
    public partial class frmContacts : Form
    {
        PhoneNumberDBEntities DB;
        public Contact ContactEdit { get; set; }
        public frmContacts()
        {
            DB = new PhoneNumberDBEntities();
            InitializeComponent();
        }

        private void txtRegister_Click(object sender, EventArgs e)
        {
            if (ContactEdit != null)
            {
                ContactEdit.FirstName = txtName.Text.Trim();
                ContactEdit.LastName = txtFamily.Text.Trim();
                ContactEdit.PhoneNumber = txtPhone.Text.Trim();
                ContactEdit.MobileNumber = txtMobile.Text.Trim();
                ContactEdit.Email = txtEmail.Text.Trim();
                ContactEdit.GroupContact = cmbGroup.SelectedIndex;
                ContactEdit.Address = txtAddress.Text.Trim();
                ContactEdit.Description = txtDescription.Text.Trim();

                DB.Entry(ContactEdit).State = System.Data.Entity.EntityState.Modified;
                DB.SaveChanges();
                this.Close();
            }
            else
            {
                Contact myContact = new Contact
                {
                    FirstName = txtName.Text.Trim(),
                    LastName = txtFamily.Text.Trim(),
                    PhoneNumber = txtPhone.Text.Trim(),
                    MobileNumber = txtMobile.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    GroupContact = cmbGroup.SelectedIndex,
                    Address = txtAddress.Text.Trim(),
                    Description = txtDescription.Text.Trim()
                };

                DB.Contacts.Add(myContact);
                DB.SaveChanges();
                this.Close();
            }
           
            
        }

        private void frmContacts_Load(object sender, EventArgs e)
        {
            cmbGroup.SelectedIndex = 0;
        }

        private void frmContacts_Activated(object sender, EventArgs e)
        {
            if (this.ContactEdit != null)
            {
                txtName.Text = ContactEdit.FirstName;
                txtFamily.Text = ContactEdit.LastName;
                txtPhone.Text = ContactEdit.PhoneNumber;
                txtMobile.Text = ContactEdit.MobileNumber;
                txtEmail.Text = ContactEdit.Email;
                cmbGroup.SelectedIndex = ContactEdit.GroupContact;
                txtAddress.Text = ContactEdit.Address;
                txtDescription.Text = ContactEdit.Description;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
