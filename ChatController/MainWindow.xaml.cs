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
        /// <summary>
        /// when user types in Console send it to the chat
        /// </summary>
        static string userCommand;

        /// <summary>
        /// read only array of strings for Bot keywords
        /// </summary>
        private static readonly string[] reservedWords = new string[] { "w", "stop", "close", "enter" };

        public bool isOnline = false;

        public MainWindow()
        {
            InitializeComponent();
             
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            userNameTB.Text = 
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
