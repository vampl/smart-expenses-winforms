using System.ComponentModel;

namespace SmartExpense.Pages
{
    partial class MainPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlDataHolder = new System.Windows.Forms.Panel();
            this.PnlBalance = new System.Windows.Forms.Panel();
            this.LblBalanceValue = new System.Windows.Forms.Label();
            this.LblBalance = new System.Windows.Forms.Label();
            this.PnlExpence = new System.Windows.Forms.Panel();
            this.LblExpenceValue = new System.Windows.Forms.Label();
            this.LblExpence = new System.Windows.Forms.Label();
            this.PnlIncome = new System.Windows.Forms.Panel();
            this.LblIncomeValue = new System.Windows.Forms.Label();
            this.LblIncome = new System.Windows.Forms.Label();
            this.PnlDataGridView = new System.Windows.Forms.Panel();
            this.CbAccounts = new System.Windows.Forms.ComboBox();
            this.TbSearch = new System.Windows.Forms.TextBox();
            this.DgvTransactionTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlDataHolder.SuspendLayout();
            this.PnlBalance.SuspendLayout();
            this.PnlExpence.SuspendLayout();
            this.PnlIncome.SuspendLayout();
            this.PnlDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTransactionTable)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlDataHolder
            // 
            this.PnlDataHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlDataHolder.BackColor = System.Drawing.Color.LightGray;
            this.PnlDataHolder.Controls.Add(this.PnlBalance);
            this.PnlDataHolder.Controls.Add(this.PnlExpence);
            this.PnlDataHolder.Controls.Add(this.PnlIncome);
            this.PnlDataHolder.Location = new System.Drawing.Point(10, 10);
            this.PnlDataHolder.Margin = new System.Windows.Forms.Padding(10);
            this.PnlDataHolder.Name = "PnlDataHolder";
            this.PnlDataHolder.Size = new System.Drawing.Size(659, 70);
            this.PnlDataHolder.TabIndex = 0;
            // 
            // PnlBalance
            // 
            this.PnlBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlBalance.BackColor = System.Drawing.Color.LightGray;
            this.PnlBalance.Controls.Add(this.LblBalanceValue);
            this.PnlBalance.Controls.Add(this.LblBalance);
            this.PnlBalance.Location = new System.Drawing.Point(474, 0);
            this.PnlBalance.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.PnlBalance.Name = "PnlBalance";
            this.PnlBalance.Size = new System.Drawing.Size(185, 70);
            this.PnlBalance.TabIndex = 2;
            // 
            // LblBalanceValue
            // 
            this.LblBalanceValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.LblBalanceValue.Location = new System.Drawing.Point(30, 37);
            this.LblBalanceValue.Margin = new System.Windows.Forms.Padding(30, 5, 30, 10);
            this.LblBalanceValue.Name = "LblBalanceValue";
            this.LblBalanceValue.Size = new System.Drawing.Size(125, 23);
            this.LblBalanceValue.TabIndex = 5;
            this.LblBalanceValue.Text = "<value>";
            this.LblBalanceValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblBalance
            // 
            this.LblBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.LblBalance.Location = new System.Drawing.Point(30, 10);
            this.LblBalance.Margin = new System.Windows.Forms.Padding(30, 10, 30, 5);
            this.LblBalance.Name = "LblBalance";
            this.LblBalance.Size = new System.Drawing.Size(125, 23);
            this.LblBalance.TabIndex = 4;
            this.LblBalance.Text = "Balance";
            this.LblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlExpence
            // 
            this.PnlExpence.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PnlExpence.BackColor = System.Drawing.Color.LightGray;
            this.PnlExpence.Controls.Add(this.LblExpenceValue);
            this.PnlExpence.Controls.Add(this.LblExpence);
            this.PnlExpence.Location = new System.Drawing.Point(237, 0);
            this.PnlExpence.Margin = new System.Windows.Forms.Padding(32, 0, 32, 0);
            this.PnlExpence.Name = "PnlExpence";
            this.PnlExpence.Size = new System.Drawing.Size(185, 70);
            this.PnlExpence.TabIndex = 1;
            // 
            // LblExpenceValue
            // 
            this.LblExpenceValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.LblExpenceValue.Location = new System.Drawing.Point(30, 37);
            this.LblExpenceValue.Margin = new System.Windows.Forms.Padding(30, 5, 30, 10);
            this.LblExpenceValue.Name = "LblExpenceValue";
            this.LblExpenceValue.Size = new System.Drawing.Size(125, 23);
            this.LblExpenceValue.TabIndex = 3;
            this.LblExpenceValue.Text = "<value>";
            this.LblExpenceValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblExpence
            // 
            this.LblExpence.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.LblExpence.Location = new System.Drawing.Point(30, 10);
            this.LblExpence.Margin = new System.Windows.Forms.Padding(30, 10, 30, 5);
            this.LblExpence.Name = "LblExpence";
            this.LblExpence.Size = new System.Drawing.Size(125, 23);
            this.LblExpence.TabIndex = 2;
            this.LblExpence.Text = "Expense";
            this.LblExpence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlIncome
            // 
            this.PnlIncome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PnlIncome.BackColor = System.Drawing.Color.LightGray;
            this.PnlIncome.Controls.Add(this.LblIncomeValue);
            this.PnlIncome.Controls.Add(this.LblIncome);
            this.PnlIncome.Location = new System.Drawing.Point(0, 0);
            this.PnlIncome.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.PnlIncome.Name = "PnlIncome";
            this.PnlIncome.Size = new System.Drawing.Size(185, 70);
            this.PnlIncome.TabIndex = 0;
            // 
            // LblIncomeValue
            // 
            this.LblIncomeValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.LblIncomeValue.Location = new System.Drawing.Point(30, 37);
            this.LblIncomeValue.Margin = new System.Windows.Forms.Padding(30, 5, 30, 10);
            this.LblIncomeValue.Name = "LblIncomeValue";
            this.LblIncomeValue.Size = new System.Drawing.Size(125, 23);
            this.LblIncomeValue.TabIndex = 1;
            this.LblIncomeValue.Text = "<value>";
            this.LblIncomeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblIncome
            // 
            this.LblIncome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.LblIncome.Location = new System.Drawing.Point(30, 10);
            this.LblIncome.Margin = new System.Windows.Forms.Padding(30, 10, 30, 5);
            this.LblIncome.Name = "LblIncome";
            this.LblIncome.Size = new System.Drawing.Size(125, 23);
            this.LblIncome.TabIndex = 0;
            this.LblIncome.Text = "Income";
            this.LblIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlDataGridView
            // 
            this.PnlDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlDataGridView.BackColor = System.Drawing.Color.LightGray;
            this.PnlDataGridView.Controls.Add(this.CbAccounts);
            this.PnlDataGridView.Controls.Add(this.TbSearch);
            this.PnlDataGridView.Controls.Add(this.DgvTransactionTable);
            this.PnlDataGridView.Location = new System.Drawing.Point(10, 100);
            this.PnlDataGridView.Margin = new System.Windows.Forms.Padding(10);
            this.PnlDataGridView.Name = "PnlDataGridView";
            this.PnlDataGridView.Size = new System.Drawing.Size(459, 355);
            this.PnlDataGridView.TabIndex = 1;
            // 
            // CbAccounts
            // 
            this.CbAccounts.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CbAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbAccounts.FormattingEnabled = true;
            this.CbAccounts.Location = new System.Drawing.Point(254, 15);
            this.CbAccounts.Margin = new System.Windows.Forms.Padding(15);
            this.CbAccounts.Name = "CbAccounts";
            this.CbAccounts.Size = new System.Drawing.Size(190, 24);
            this.CbAccounts.TabIndex = 4;
            // 
            // TbSearch
            // 
            this.TbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbSearch.Location = new System.Drawing.Point(15, 15);
            this.TbSearch.Margin = new System.Windows.Forms.Padding(15);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Size = new System.Drawing.Size(209, 23);
            this.TbSearch.TabIndex = 2;
            // 
            // DgvTransactionTable
            // 
            this.DgvTransactionTable.AllowUserToAddRows = false;
            this.DgvTransactionTable.AllowUserToDeleteRows = false;
            this.DgvTransactionTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTransactionTable.BackgroundColor = System.Drawing.Color.LightGray;
            this.DgvTransactionTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTransactionTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvTransactionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTransactionTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Amount, this.Type, this.Description, this.Date, this.Account });
            this.DgvTransactionTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvTransactionTable.Location = new System.Drawing.Point(0, 53);
            this.DgvTransactionTable.Margin = new System.Windows.Forms.Padding(0);
            this.DgvTransactionTable.MultiSelect = false;
            this.DgvTransactionTable.Name = "DgvTransactionTable";
            this.DgvTransactionTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvTransactionTable.RowTemplate.Height = 24;
            this.DgvTransactionTable.Size = new System.Drawing.Size(459, 302);
            this.DgvTransactionTable.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(496, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 158);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(496, 278);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 177);
            this.panel2.TabIndex = 3;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Account
            // 
            this.Account.HeaderText = "Account";
            this.Account.Name = "Account";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlDataGridView);
            this.Controls.Add(this.PnlDataHolder);
            this.Font = new System.Drawing.Font("Lucida Fax", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(679, 465);
            this.PnlDataHolder.ResumeLayout(false);
            this.PnlBalance.ResumeLayout(false);
            this.PnlExpence.ResumeLayout(false);
            this.PnlIncome.ResumeLayout(false);
            this.PnlDataGridView.ResumeLayout(false);
            this.PnlDataGridView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTransactionTable)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox CbAccounts;

        private System.Windows.Forms.TextBox TbSearch;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;

        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;

        private System.Windows.Forms.DataGridView DgvTransactionTable;

        private System.Windows.Forms.Label LblIncomeValue;
        private System.Windows.Forms.Label LblExpenceValue;
        private System.Windows.Forms.Label LblExpence;
        private System.Windows.Forms.Label LblBalanceValue;
        private System.Windows.Forms.Label LblBalance;
        private System.Windows.Forms.Panel PnlDataGridView;

        private System.Windows.Forms.Panel PnlIncome;
        private System.Windows.Forms.Panel PnlExpence;
        private System.Windows.Forms.Panel PnlBalance;
        private System.Windows.Forms.Label LblIncome;

        private System.Windows.Forms.Panel PnlDataHolder;

        #endregion
    }
}