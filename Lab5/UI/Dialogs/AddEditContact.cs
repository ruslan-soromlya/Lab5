using Lab5.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5.UI.Dialogs
{
    public partial class AddEditContact : Form
    {
        public bool IsEditing;

        public Contact Contact;

        public AddEditContact(int nextId)
        {
            IsEditing = false;
            Contact = new Contact();
            Contact.Id = nextId;
            InitializeComponent();
            FillInputs();
        }

        public AddEditContact(Contact contact)
        {
            IsEditing = true;
            Text = "Редагувати новий контакт";
            Contact = contact;
            InitializeComponent();
            FillInputs();
        }

        private void FillInputs()
        {
            lblId.Text = Contact.Id.ToString();
            txtAddress.Text = Contact.Address;
            txtEmail.Text = Contact.Email;
            txtFirstName.Text = Contact.FirstName;
            txtLastName.Text = Contact.LastName;
            txtPhone.Text = Contact.PhoneNumber;
            txtEmailPhone.Text = Contact.MobilePhoneNumber;
        }

        private void AddEditContact_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Contact.Email = txtEmail.Text;
            Contact.FirstName = txtFirstName.Text;
            Contact.LastName = txtLastName.Text;
            Contact.PhoneNumber = txtPhone.Text;
            Contact.MobilePhoneNumber = txtEmailPhone.Text;
            Contact.Address = txtAddress.Text;
            
            DialogResult = DialogResult.OK;
        }
    }
}
