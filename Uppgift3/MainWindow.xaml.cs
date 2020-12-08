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

namespace Uppgift3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int currentNumber = 0;
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private static string GetRandomLetters()
        {
            Random r = new Random();
            string okLetters = "ABCDEFGHJKLMNPRSTUWXYX";
            string letters = "";
            for (int i = 0; i < 3; i++)
            {
                int index = r.Next(okLetters.Length);
                letters += okLetters[index].ToString();
            }
            return letters;
        }

        private static int GetRandomNumbers()
        {
            Random r = new Random();
            int numbers = r.Next(1, 999);
            return numbers;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            string randomLetters = GetRandomLetters();
            int randomNumbers = GetRandomNumbers();
            lblNewNr.Content = $"{randomLetters}{randomNumbers}";

            int latestApprovedNr = currentNumber + 1;

            if (latestApprovedNr == randomNumbers)
            {
                lblLatestNr.Content = $"{randomLetters}{randomNumbers}";
                currentNumber += 1;
            }

        }

        private void btnLoop_Click(object sender, RoutedEventArgs e)
        {
            //if (currentNumber < 999)
            //{
            //    btn_Click(sender, e);
            //}

            while (currentNumber <= 999)
            {
                btn_Click(sender, e);
            }
        }
    }
}
