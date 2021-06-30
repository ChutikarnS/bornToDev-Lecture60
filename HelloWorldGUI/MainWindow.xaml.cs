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

namespace HelloWorldGUI
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
            double outputValue = 0;
            bool incomeIsNumber = false;
            bool expensesIsNumber = false;
            bool priceIsNumber = false;

            incomeIsNumber = double.TryParse(txtIncome.Text, out outputValue);
            expensesIsNumber = double.TryParse(txtexpenses.Text, out outputValue);
            priceIsNumber = double.TryParse(txtPrice.Text, out outputValue);

            if (!incomeIsNumber || !expensesIsNumber || !priceIsNumber)
            {
                MessageBox.Show("กรุณากรอกข้อมูลเป็นตัวเลข");
            }
            else
            {
                Double income = double.Parse(txtIncome.Text);
                Double expenses = double.Parse(txtexpenses.Text);
                Double price = double.Parse(txtPrice.Text);
                Double sum = price / (income - expenses);
                txtSum.Text = Convert.ToInt32(sum).ToString();
            }
        }
    }
}
