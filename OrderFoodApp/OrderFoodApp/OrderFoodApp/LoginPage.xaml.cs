using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OrderFoodApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void ButtonSignUp_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }

        private void ButtonForgot_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ForgetPasswordPage());
        }
    }
}