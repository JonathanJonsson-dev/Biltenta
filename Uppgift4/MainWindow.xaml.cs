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

namespace Uppgift4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] scores = new int[3];

        public MainWindow()
        {
            InitializeComponent();
        }

        private static int[] GetRandomNumbers()
        {
            Random r = new Random();
            
            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = r.Next(1, 9);
                numbers[i] = number;
            }

            return numbers;
        }

        private void btnBet_Click(object sender, RoutedEventArgs e)
        {
            int[] numbers = GetRandomNumbers();
            lblCode1.Content = numbers[0].ToString();
            lblCode2.Content = numbers[1].ToString();
            lblCode3.Content = numbers[2].ToString();

            int[] scores = CalculateSum(numbers);
            
            if (chk1.IsChecked != true)
            {
                scores[0] = scores[0] + numbers[0];
                lblTotal1.Content = scores[0].ToString();
            }
            if (chk2.IsChecked != true)
            {
                scores[1] = scores[1] + numbers[1];
                lblTotal2.Content = scores[1].ToString();
            }
            if (chk3.IsChecked != true)
            {
                scores[2] = scores[2] + numbers[2];
                lblTotal3.Content = scores[2].ToString();
                
            }
        }

        private int[] CalculateSum(int[] numbers)
        {
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = scores[i] + numbers[i];
            }
            return scores;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
