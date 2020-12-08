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

namespace Uppgift2
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

        public bool HasCorrectLength(string indata)
        {
            
            if (indata.Length == 7)
            {
                MessageBox.Show("Skylten har rätt antal tecken");
                return true;
            }
            else
            {
                MessageBox.Show("Skylten har ett felaktigt antal tecken");
                return false;
            }
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            HasCorrectLength(txtBox.Text);
        }
    }
}
