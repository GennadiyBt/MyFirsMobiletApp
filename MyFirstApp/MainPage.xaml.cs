using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyFirstApp
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            /*StackLayout stack = new StackLayout();
            Label label = new Label();
            label.Text = "Hello, World/ Path 2";
            label.TextTransform = TextTransform.Uppercase;

            button = new Button();
            button.Text = "Кнопка";
            button.TextColor = Color.Green;
            button.Clicked += Button_Click;


            stack.Children.Add(label);
            stack.Children.Add(button);

            Content = stack;*/
        }

        private async void Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameField.Text))
                errorText.Text = "Имя не указано";
            else if (string.IsNullOrEmpty(emailField.Text))
                errorText.Text = "Почта не указана";
            else if (string.IsNullOrEmpty(passwordField.Text))
                errorText.Text = "Пароль не указан";
            else if (!checkField.IsChecked)
                errorText.Text = "CheckBox incorrect";
            else
            {
                errorText.Text = "";
                buttonSend.Text = "Done";
                buttonSend.TextColor = Color.Green;
                await DisplayAlert("Данные из формы", "Все данные получены", "Ok");
            }
        }

        
    }
}
