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

namespace Book_Club_Points
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int numOfBooks;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                numOfBooks = int.Parse(textBox.Text);
                if (numOfBooks == 0)
                {
                    MessageBox.Show("You have zero points");
                }
                if (numOfBooks == 1)
                {
                    MessageBox.Show("You have 5 points");
                }
                if (numOfBooks == 2)
                {
                    MessageBox.Show("You have 15 points");
                }
                if (numOfBooks == 3)
                {
                    MessageBox.Show("You have 30 points");
                }
                if (numOfBooks >= 4)
                {
                    MessageBox.Show("You have 60 points");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Please enter a valid number");
            }

        }
    }
}
