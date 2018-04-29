using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> Years = new List<string>();
        bool one = false, two = false;
        public MainWindow()
        {
            InitializeComponent();
            showtxtpassone.Visibility = Visibility.Hidden;
            showtxtpasstwo.Visibility = Visibility.Hidden;
        }

        private void cbYear_Loaded(object sender, RoutedEventArgs e)
        {

            for (int i = 1920; i <= 2017; i++)
            {
                Years.Add(i.ToString());
            }

            var combobox = sender as ComboBox;
            combobox.ItemsSource = Years;
            cbYear.SelectedIndex = 0;
        }

        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(one == false)
            {
                passwordboxone.Visibility = Visibility.Hidden;
                showtxtpassone.Visibility = Visibility.Visible;
                EyeOne.Opacity = 1;
                showtxtpassone.Text = passwordboxone.Password;
                one = true;
            }
            else
            {
                passwordboxone.Visibility = Visibility.Visible;
                showtxtpassone.Visibility = Visibility.Hidden;
                EyeOne.Opacity = 0.5;
                showtxtpassone.Text = passwordboxone.Password;
                one = false;
            }
        }

        private void Panel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void CloseFrm_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void PackIcon_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (two == false)
            {
                passwordboxtwo.Visibility = Visibility.Hidden;
                showtxtpasstwo.Visibility = Visibility.Visible;
                EyeTwo.Opacity = 1;
                showtxtpasstwo.Text = passwordboxone.Password;
                two = true;
            }
            else
            {
                passwordboxtwo.Visibility = Visibility.Visible;
                showtxtpasstwo.Visibility = Visibility.Hidden;
                EyeTwo.Opacity = 0.5;
                showtxtpasstwo.Text = passwordboxone.Password;
                two = false;
            }
        }
    }
}
