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

namespace Kalkulator
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //String liczba1 = liczba1TextBox.Text;
            //int liczba1a = int.Parse(liczba1TextBox.Text);
            int liczba1;
            int liczba2;
            int wynik = 0;
            if (int.TryParse(liczba1TextBox.Text, out liczba1))
            {
                if (int.TryParse(liczba2TextBox.Text, out liczba2))
                {
                    wynik = liczba1+liczba2;
                    MessageBox.Show("Wynik dodawania:"+wynik.ToString(), 
                        "Wynik", MessageBoxButton.OK, MessageBoxImage.Information);
                } 
            }
            else
            {
                MessageBox.Show("Niepoprawne dane","Komunikat",MessageBoxButton.OK, 
                    MessageBoxImage.Warning);
            }
            
        }
    }
}
