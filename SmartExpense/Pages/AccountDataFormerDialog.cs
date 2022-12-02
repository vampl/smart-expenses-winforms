using System;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using SmartExpense.Models;

namespace SmartExpense.Pages
{
    public partial class AccountDataFormerDialog : Form
    {
        public Account Account { get; set; }
        
        public AccountDataFormerDialog()
        {
            InitializeComponent();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            Account = new Account
            {
                OwnerId = User.Id,
                Title = TbTitle.Text,
                Type = CbTypes.Text,
                Description = TbDescription.Text,
                Amount = int.Parse(TbBalance.Text)
            };
            
            Close();
        }
    }
}