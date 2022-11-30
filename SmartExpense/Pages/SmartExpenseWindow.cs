using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SmartExpense.Pages
{
    public partial class SmartExpenseMain : Form
    {
        public SmartExpenseMain()
        {
            InitializeComponent();
            LoadPage(BtnMainPage).Show();
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
                // change button by menu bar width to correct fit in.
                button.Width = PnlMenuBar.MinimumSize.Width;

                // make button inactive when collapsed.
                button.Enabled = false;
                
                // change data to correct displaying.
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.Text = (button.Tag.ToString()[0]).ToString();
            }

            // current state (debug feature).
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
                // change button by menu bar width to correct fit in.
                button.Width = PnlMenuBar.MaximumSize.Width;
                
                // make button active when expanded.
                button.Enabled = true;
                
                // change data to correct displaying.
                button.TextAlign = ContentAlignment.MiddleCenter;
                button.Text = button.Tag.ToString();
            }

            // current state (debug feature).
            return "Expanded";
        }

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