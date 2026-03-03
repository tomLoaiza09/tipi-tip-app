using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tipitipapp.ViewModels;

namespace tipitipapp.Views
{
    public partial class LoginPage : ContentPage
    {
        private readonly LoginViewModel loginViewModel;
        public LoginPage(LoginViewModel loginViewModel)
        {

            InitializeComponent();
            BindingContext = this.loginViewModel = loginViewModel;
        }

        private void OnEmailCompleted(object sender, EventArgs e)
        {
            PasswordEntry.Focus();
        }

        private void OnPasswordCompleted(object sender, EventArgs e)
        {
            // Trigger login
            var vm = BindingContext as ViewModels.LoginViewModel;
            vm?.LoginCommand.Execute(null);
        }
    }
}
