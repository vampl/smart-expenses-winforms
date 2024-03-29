﻿using System;
using System.Windows.Forms;
using SmartExpense.Database;
using SmartExpense.Models;

namespace SmartExpense.Pages
{
    public partial class TransactionPage : UserControl
    {
        public TransactionPage()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // get general connected database service.
                var db = Locator.GetService<DatabaseController>();
                
                var transaction = new Transaction
                {
                    OwnerId = User.Id,
                    Amount = decimal.Parse(TbAmount.Text),
                    Type = CbType.Text,
                    Description = TbDesctiption.Text,
                    Date = DtpTransactionDay.Value,
                    AccountTitle = CbAccounts.Text
                };
                
                db.InsertTransactionData(transaction);
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Adding account error - " + exception.Message, @"Error", MessageBoxButtons.OK);
            }
        }

        private void TransactionPage_Load(object sender, EventArgs e)
        {
            try
            {
                var db = Locator.GetService<DatabaseController>();
                var accountsTitle = db.GetAccountsTitle();

                foreach (var title in accountsTitle)
                    CbAccounts.Items.Add(title);
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Loading Transaction page error - " + exception.Message, @"Error", MessageBoxButtons.OK);
            }
        }
    }
}