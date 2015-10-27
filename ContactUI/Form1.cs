using System;
using System.Windows.Forms;
using ContactLibrary;
using Contacts;
using static System.String;

namespace ContactUI
{
    public partial class Form1 : Form
    {
        //change repository from RepositoryXml to RepositoryMemory to use the memory repository
        readonly IRepository _repository = new RepositoryXml();

        readonly BindingSource _contactBinding = new BindingSource();
        private const string _empty = "Please fill all textboxes!";

        public Form1()
        {
            InitializeComponent();
            UpdateData();
        }

        private void UpdateData()
        {
            _contactBinding.DataSource = _repository.GetAll();
            ContactList.DataSource = _contactBinding;
            ContactList.DisplayMember = "Display";
            ContactList.ValueMember = "Display";
        }

        private void BUpdate_Click(object sender, EventArgs e)
        {
            if (IsNullOrEmpty(tPhoneNumber.Text) || IsNullOrEmpty(tLastName.Text) || IsNullOrEmpty(tFirstName.Text))
            {
                MessageBox.Show(_empty);
                return;
            }
            var oldContact = MapContact(ContactList.GetItemText(ContactList.SelectedValue));
            lStatus.Text = _repository.Update(
                oldContact,
                new Contact(tFirstName.Text, tLastName.Text, tPhoneNumber.Text)) ? @"Contact updated!" : @"Something went wrong!";
            EmptyTextboxes();
            UpdateData();
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            if (IsNullOrEmpty(tPhoneNumber.Text) || IsNullOrEmpty(tLastName.Text) || IsNullOrEmpty(tFirstName.Text))
            {
                MessageBox.Show(_empty);
                return;
            }
            var c = new Contact(tFirstName.Text, tLastName.Text, tPhoneNumber.Text);
            if(_repository.Add(c))
            {
                _contactBinding.ResetBindings(false);
                lStatus.Text = @"Contact added!";
                EmptyTextboxes();
                UpdateData();
            }
            else
            {
                lStatus.Text = @"The contact is already stored!";
            }
        }

        private void BDelete_Click(object sender, EventArgs e)
        {
            if (IsNullOrEmpty(tPhoneNumber.Text))
            {
                MessageBox.Show("Please fill at least the phone number!");
                return;
            }
            var c = new Contact(tFirstName.Text, tLastName.Text, tPhoneNumber.Text);
            if (_repository.Delete(c))
            {
                _contactBinding.ResetBindings(false);
                lStatus.Text = @"Contact deleted!";
                EmptyTextboxes();
                UpdateData();
            }
            else
            {
                lStatus.Text = @"The contact does not exist!";
            }
        }

        private void EmptyTextboxes()
        {
            tFirstName.Text = "";
            tLastName.Text = "";
            tPhoneNumber.Text = "";
        }

        private static Contact MapContact(string s)
        {
            var list = s.Split();
            return new Contact(list[0], list[1], list[2]);
        }
    }
}
