using System;
using System.Windows;
using System.Windows.Media;

namespace formularz
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnZapisz_Click(object sender, RoutedEventArgs e)
        {
            TxtKomunikat.Text = " ";

            if (string.IsNullOrWhiteSpace(TxtImie.Text))
            {
                TxtKomunikat.Text = "Pole 'Imię' nie może być puste.";
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtNazwisko.Text))
            {
                TxtKomunikat.Text = "Pole 'Nazwisko' nie może być puste.";
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtEmail.Text))
            {
                TxtKomunikat.Text = "Pole 'E-mail' nie może być puste.";
                return;
            }

            if (RbKobieta.IsChecked != true && RbMezczyzna.IsChecked != true)
            {
                TxtKomunikat.Text = "Musisz wybrać płeć.";
                return;
            }

            if (!DpDataUrodzenia.SelectedDate.HasValue)
            {
                TxtKomunikat.Text = "Musisz wybrać datę urodzenia.";
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtUwagi.Text))
            {
                TxtKomunikat.Text = "Pole 'Dodatkowe informacje' nie może być puste.";
                return;
            }

            TxtKomunikat.Text = "Formularz został poprawnie zapisany!";
        }
    }
}