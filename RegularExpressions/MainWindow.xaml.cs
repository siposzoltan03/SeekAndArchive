using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RegularExpressions
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

            if (!ValidName(txtName.Text))
                MessageBox.Show("The name is invalid (only alphabetical characters are allowed)");
            if (!ValidPhone(txtPhone.Text))
            {
                MessageBox.Show("The Phone number is invalid ( only numeric characters are allowed, 10 digits)");
            }
            else
            {
                txtPhone.Text = Regex.Replace(txtPhone.Text, @"^\(?(\d{3})\)?[\s\-]?(\d{3})\-?(\d{4})$",
                    "(${1}) ${2} - ${3}");
            }

            if (!ValidEmail(txtEmail.Text))
            {
                MessageBox.Show("The Email format is invalid ( Correct format: XXX@XXX.XXX)");
            }
        }

        private bool ValidName(string text)
        {
            return Regex.IsMatch(text, @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$");
        }

        private bool ValidPhone(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^[0-9\-\+]{10}$");
        }

        private bool ValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                        + "@"
                                        + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
        }
    }
}
