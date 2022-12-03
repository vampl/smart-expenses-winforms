using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SmartExpense.Models;

namespace SmartExpense.Pages
{
    public partial class SmartExpenseMain : Form
    {
        public SmartExpenseMain()
        {
            InitializeComponent();
            
            // Main page is the default launch page.
            LoadPage(BtnMainPage).Show();
            
            // Static user record for demo testing
            var user = new User (24242424, "11111111", "Vitaliy");
        }

        // change menu bar state by it's min/max width.
        private string SlideMenuBar()
        {
            try
            {
                // check current menu bar panel state by it's width.
                return PnlMenuBar.Width >= PnlMenuBar.MaximumSize.Width ? CollapseMenu() : ExpandMenu();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Critical Error", MessageBoxButtons.OK);
            }

            // current state.
            return "None";
        }

        // collapse menu method.
        private string CollapseMenu()
        {
            // collapse menu to minimum width size.
            PnlMenuBar.Width = PnlMenuBar.MinimumSize.Width;

            // collapse each menu bar button (with text) and inactivate it.
            foreach (var button in PnlMenuBar.Controls.OfType<Button>())
            {
                button.Width = PnlMenuBar.MinimumSize.Width;
                button.Enabled = false;
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.Text = (button.Tag.ToString()[0]).ToString();
            }

            // current state
            return "Collapsed";
        }

        // expand menu method.
        private string ExpandMenu()
        {
            // expand menu to maximum (default) width size.
            PnlMenuBar.Width = PnlMenuBar.MaximumSize.Width;

            // expand each menu bar button (with text) and activate it.
            foreach (var button in PnlMenuBar.Controls.OfType<Button>())
            {
                button.Width = PnlMenuBar.MaximumSize.Width;
                button.Enabled = true;
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.Text = button.Tag.ToString();
            }

            // current state
            return "Expanded";
        }

        // load page on button request
        private UserControl LoadPage(Button clickedButton)
        {
            var pageType = clickedButton.Tag.ToString();
            var page = PageFactory.CreatePage(pageType);
            
            page.AutoScroll = true;
            page.Dock = DockStyle.Fill;
            
            PnlPageSpace.Controls.Clear();
            PnlPageSpace.Controls.Add(page);
            
            return page;
        }
        
        // slide menu by button click event.
        private void BtnMenu_Click(object sender, EventArgs e) => SlideMenuBar();
        
        // Main page loaded by button click
        private void BtnMainPage_Click(object sender, EventArgs e) => LoadPage((Button)sender).Show();
        
        // Transaction page loaded by button click
        private void BtnTransactionPage_Click(object sender, EventArgs e) => LoadPage((Button)sender).Show();
        
        // Account page loaded by button click
        private void BtnAccountPage_Click(object sender, EventArgs e) => LoadPage((Button)sender).Show();
        
        // Profile page loaded by button click
        private void BtnProfilePage_Click(object sender, EventArgs e) => LoadPage((Button)sender).Show();
    }
}