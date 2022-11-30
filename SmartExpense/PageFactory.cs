using System;
using System.Windows.Forms;
using SmartExpense.Pages;

namespace SmartExpense
{
    public static class PageFactory
    {
        // gets request to build page of pageType.
        public static UserControl CreatePage(string pageType)
        {
            // return created and ready to use page.
            return pageType switch
            {
                "Main" => CreateMainPage(),
                "Transaction" => CreateTransactionPage(),
                "Account" => CreateAccountPage(),
                "Profile" => CreateProfilePage(),
                _ => throw new ArgumentException($@"Page {pageType} cannot be created!", nameof(pageType), null)
            };
        }

        // method to rebuild configured page to correct type (Main page).
        private static UserControl CreateMainPage() => new MainPage();

        // method to rebuild configured page to correct type (Transaction page).
        private static UserControl CreateTransactionPage() => new TransactionPage();
        
        // method to rebuild configured page to correct type (Account page).
        private static UserControl CreateAccountPage() => new AccountPage();

        // method to rebuild configured page to correct type (Profile page).
        private static UserControl CreateProfilePage() => new ProfilePage();
    }
}