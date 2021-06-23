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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber;
        double result;

        public MainWindow()
        {
            InitializeComponent();
            acBtn.Click += AcBtn_Click;
            negativeBtn.Click += NegativeBtn_Click;          
            equalBtn.Click += EqualBtn_Click;
            percentageBtn.Click += PercentageBtn_Click;
        }

        private void NegativeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * -1;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void PercentageBtn_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber / 100;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void EqualBtn_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AcBtn_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            int selectedValue = 0;

            if (sender == zeroBtn)
                selectedValue = 0;
            if (sender == oneBtn)
                selectedValue = 1;
            if (sender == twoBtn)
                selectedValue = 2;
            if (sender == threeBtn)
                selectedValue = 3;
            if (sender == fourBtn)
                selectedValue = 4;
            if (sender == fiveBtn)
                selectedValue = 5;
            if (sender == sixBtnn)
                selectedValue = 6;
            if (sender == sevenBtn)
                selectedValue = 7;
            if (sender == eightBtnn)
                selectedValue = 8;
            if (sender == nineBtn)
                selectedValue = 9;

            if (resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = $"{selectedValue}";
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}{selectedValue}";
            }
        }
    }

    
}
