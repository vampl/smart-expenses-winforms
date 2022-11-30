using System;
using System.Windows.Forms;

namespace SmartExpense.Pages
{
    public partial class AccountPage : UserControl
    {
        public AccountPage()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DgvAccountsTable.Rows.Add("", "", "", "");
            
            if (DgvAccountsTable.CurrentRow != null)
                DgvAccountsTable.CurrentCell = DgvAccountsTable
                    .Rows[Math.Min(DgvAccountsTable.CurrentRow.Index + 1, DgvAccountsTable.Rows.Count - 1)].Cells[0];
            
            DgvAccountsTable.BeginEdit(false);
        }
    }
}