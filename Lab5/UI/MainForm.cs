using Lab5.Logic.Realisations;
using Lab5.Models;
using Lab5.UI.Dialogs;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5.UI
{
    public partial class MainForm : Form
    {
        private ContactsBindingList _notFilteredContantBindingList;
        private readonly IDatabase _database;
        private Bitmap _printImage;

        public MainForm(IDatabase database)
        {
            InitializeComponent();
            _database = database;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenDb();
        }

        private void menuSearchByEmail_Click(object sender, EventArgs e)
        {
            var searchByEmailDialog = new SearchByEmailDialog();
            var result = searchByEmailDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                ApplySearchFilter(searchByEmailDialog.Email);
            }

            searchByEmailDialog.Dispose();
        }

        private void resetFiltersMenu_Click(object sender, EventArgs e)
        {
            resetFiltersMenu.Enabled = false;
            ResetSearchFilter();

        }

        private void ResetSearchFilter()
        {
            bindingSource1.DataSource = _notFilteredContantBindingList;
            lblCurrentFilter.Text = "Не задано";
        }

        private void ApplySearchFilter(string emailToSearch)
        {
            var searchTerm = emailToSearch.Trim().ToLowerInvariant();
            var filteredList = new ContactsBindingList(_notFilteredContantBindingList.Where(x => x.Email.StartsWith(searchTerm, StringComparison.InvariantCultureIgnoreCase)).ToList());
            bindingSource1.DataSource = filteredList;
            resetFiltersMenu.Enabled = true;
            lblCurrentFilter.Text = searchTerm;
        }

        private void openFileMenu_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Виберіть файл бази даних";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                OpenDb(openFileDialog1.FileName);
            }
        }

        private void вийтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void вПоточнийФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var contancts = bindingSource1.DataSource as ContactsBindingList;
            _database.SaveDatabase(contancts);
        }

        private void зберегтиЗміниToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void вНовийФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Збережіть базу даних як";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            var result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                SaveDb(saveFileDialog1.FileName);
            }
        }
        private void SaveDb(string dbPath)
        {
            var contancts = bindingSource1.DataSource as ContactsBindingList;
            _database.ChangeDbPath(dbPath);
            _database.SaveDatabase(contancts);
            _notFilteredContantBindingList = contancts;
            lblCurrentDb.Text = _database.GetCurrentDbPath();
            ResetSearchFilter();
        }

        private void OpenDb()
        {
            var path = _database.GetCurrentDbPath();
            OpenDb(path);
        }

        private void OpenDb(string dbPath)
        {
            _database.ChangeDbPath(dbPath);
            var contacts = _database.LoadContacts();
            _notFilteredContantBindingList = new ContactsBindingList(contacts);
            bindingSource1.DataSource = _notFilteredContantBindingList;
            dataGridView1.DataSource = bindingSource1;
            lblCurrentDb.Text = _database.GetCurrentDbPath();
            ResetSearchFilter();
        }

        private void додатиНовийКонтактToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var nextId = _notFilteredContantBindingList.Max(x => x.Id) + 1;
            var newContactForm = new AddEditContact(nextId);
            var result = newContactForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                var newContact = newContactForm.Contact;
                var bl = bindingSource1.DataSource as ContactsBindingList;

                bl.Insert(bl.Count, newContact);
            }
        }

        private void перестовритиБазуДанихToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _database.ResetDatabase();
            OpenDb();
        }

        private void роздрукуватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.PrintToFile = true;
            printDialog1.Document = printDocument1;
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            _printImage = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(_printImage, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            dataGridView1.Height = height;

            PrintDialog printDialog = new PrintDialog(); //make a printDialog object

            PrintDocument printDocument = new PrintDocument(); // make a print doc object

            printDialog.Document = printDocument; //document for printing is printDocument

            printDocument.PrintPage += PrintDocument1_PrintPage; //event handler fire



            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(_printImage, 0, 0);
        }
    }
}
