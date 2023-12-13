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
    public partial class SearchByEmailDialog : Form
    {
        public string Email { get; set; }

        public SearchByEmailDialog()
        {
            InitializeComponent();
        }

        private void btnSetSearchedEmail_Click(object sender, EventArgs e)
        {
            Email = txtSearchByEmail.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
