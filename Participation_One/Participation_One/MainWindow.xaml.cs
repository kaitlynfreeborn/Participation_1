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

namespace Participation_One
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
            string name = txtName.Text;
            string address = txtAddress.Text;
            int zipCode = Convert.ToInt32(txtZipCode.Text);

            string entry;
            entry = (EntryForm(name, address, zipCode)).ToString();

            listBox.Items.Add(entry);
            

        }

        static string EntryForm(string name, string address, int zipCode)
        {
            string entry;
            entry = name + " " + address + " " + zipCode;

            return entry;
        }

    }
}
