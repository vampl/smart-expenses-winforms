using System.ComponentModel;

namespace SmartExpense.Pages
{
    partial class TransactionPage
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
            this.PnlDataTake = new System.Windows.Forms.Panel();
            this.DtpTransactionDay = new System.Windows.Forms.DateTimePicker();
            this.TbDesctiption = new System.Windows.Forms.TextBox();
            this.TbAmount = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.CbAccounts = new System.Windows.Forms.ComboBox();
            this.LblAccountTitle = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblType = new System.Windows.Forms.Label();
            this.LblAmount = new System.Windows.Forms.Label();
            this.CbType = new System.Windows.Forms.ComboBox();
            this.PnlDataTake.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlDataTake
            // 
            this.PnlDataTake.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlDataTake.Controls.Add(this.DtpTransactionDay);
            this.PnlDataTake.Controls.Add(this.TbDesctiption);
            this.PnlDataTake.Controls.Add(this.TbAmount);
            this.PnlDataTake.Controls.Add(this.BtnAdd);
            this.PnlDataTake.Controls.Add(this.CbAccounts);
            this.PnlDataTake.Controls.Add(this.LblAccountTitle);
            this.PnlDataTake.Controls.Add(this.LblDate);
            this.PnlDataTake.Controls.Add(this.LblDescription);
            this.PnlDataTake.Controls.Add(this.LblType);
            this.PnlDataTake.Controls.Add(this.LblAmount);
            this.PnlDataTake.Controls.Add(this.CbType);
            this.PnlDataTake.Location = new System.Drawing.Point(15, 15);
            this.PnlDataTake.Margin = new System.Windows.Forms.Padding(15);
            this.PnlDataTake.Name = "PnlDataTake";
            this.PnlDataTake.Size = new System.Drawing.Size(649, 435);
            this.PnlDataTake.TabIndex = 0;
            // 
            // DtpTransactionDay
            // 
            this.DtpTransactionDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpTransactionDay.CustomFormat = "dd-MM-yyyy";
            this.DtpTransactionDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpTransactionDay.Location = new System.Drawing.Point(382, 210);
            this.DtpTransactionDay.Margin = new System.Windows.Forms.Padding(5);
            this.DtpTransactionDay.Name = "DtpTransactionDay";
            this.DtpTransactionDay.Size = new System.Drawing.Size(252, 23);
            this.DtpTransactionDay.TabIndex = 10;
            // 
            // TbDesctiption
            // 
            this.TbDesctiption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TbDesctiption.Location = new System.Drawing.Point(382, 181);
            this.TbDesctiption.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.TbDesctiption.Name = "TbDesctiption";
            this.TbDesctiption.Size = new System.Drawing.Size(252, 23);
            this.TbDesctiption.TabIndex = 9;
            // 
            // TbAmount
            // 
            this.TbAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TbAmount.Location = new System.Drawing.Point(382, 113);
            this.TbAmount.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.TbAmount.Name = "TbAmount";
            this.TbAmount.Size = new System.Drawing.Size(252, 23);
            this.TbAmount.TabIndex = 8;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAdd.Location = new System.Drawing.Point(491, 386);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(15);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(143, 34);
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // CbAccounts
            // 
            this.CbAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbAccounts.FormattingEnabled = true;
            this.CbAccounts.Location = new System.Drawing.Point(382, 243);
            this.CbAccounts.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.CbAccounts.Name = "CbAccounts";
            this.CbAccounts.Size = new System.Drawing.Size(252, 24);
            this.CbAccounts.TabIndex = 6;
            // 
            // LblAccountTitle
            // 
            this.LblAccountTitle.Location = new System.Drawing.Point(15, 249);
            this.LblAccountTitle.Margin = new System.Windows.Forms.Padding(15, 5, 15, 131);
            this.LblAccountTitle.Name = "LblAccountTitle";
            this.LblAccountTitle.Size = new System.Drawing.Size(200, 24);
            this.LblAccountTitle.TabIndex = 5;
            this.LblAccountTitle.Text = "Account Title";
            // 
            // LblDate
            // 
            this.LblDate.Location = new System.Drawing.Point(15, 215);
            this.LblDate.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(200, 24);
            this.LblDate.TabIndex = 4;
            this.LblDate.Text = "Date";
            // 
            // LblDescription
            // 
            this.LblDescription.Location = new System.Drawing.Point(15, 181);
            this.LblDescription.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(200, 24);
            this.LblDescription.TabIndex = 3;
            this.LblDescription.Text = "Description";
            // 
            // LblType
            // 
            this.LblType.Location = new System.Drawing.Point(15, 149);
            this.LblType.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(237, 24);
            this.LblType.TabIndex = 2;
            this.LblType.Text = "Type";
            // 
            // LblAmount
            // 
            this.LblAmount.Location = new System.Drawing.Point(15, 116);
            this.LblAmount.Margin = new System.Windows.Forms.Padding(15, 131, 15, 5);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(200, 24);
            this.LblAmount.TabIndex = 1;
            this.LblAmount.Text = "Amount";
            // 
            // CbType
            // 
            this.CbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbType.FormattingEnabled = true;
            this.CbType.Items.AddRange(new object[] { "Income", "Expense" });
            this.CbType.Location = new System.Drawing.Point(382, 146);
            this.CbType.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.CbType.Name = "CbType";
            this.CbType.Size = new System.Drawing.Size(252, 24);
            this.CbType.TabIndex = 0;
            // 
            // TransactionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.PnlDataTake);
            this.Font = new System.Drawing.Font("Lucida Fax", 7.8F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TransactionPage";
            this.Size = new System.Drawing.Size(679, 465);
            this.Load += new System.EventHandler(this.TransactionPage_Load);
            this.PnlDataTake.ResumeLayout(false);
            this.PnlDataTake.PerformLayout();
            this.ResumeLayout(false);
        }

        internal System.Windows.Forms.TextBox TbAmount;
        internal System.Windows.Forms.TextBox TbDesctiption;
        internal System.Windows.Forms.DateTimePicker DtpTransactionDay;

        internal System.Windows.Forms.ComboBox CbAccounts;
        private System.Windows.Forms.Button BtnAdd;

        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblAccountTitle;

        private System.Windows.Forms.Label LblDescription;

        private System.Windows.Forms.Label LblAmount;

        internal System.Windows.Forms.ComboBox CbType;
        private System.Windows.Forms.Label LblType;

        private System.Windows.Forms.Panel PnlDataTake;

        #endregion
    }
}