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

namespace CSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); // intern calls the load componet => it coverts the XAML to BAML 
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (!listBox1.Items.Contains(textBox1.Text))
            {
                //MessageBox.Show("Addd this Name");
                String s = textBox1.Text;
                String s2 = s.Trim();
                listBox1.Items.Add(s2);
                textBox1.Clear();
            }
            else
                MessageBox.Show("This name is Already Presnet in the List");
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if(listBox1.SelectedItems.Count !=0)
            {
                while(listBox1.SelectedIndex != -1)
                {
                    listBox2.Items.Add(listBox1.SelectedItem);
                    listBox1.Items.Remove(listBox1.SelectedItem);
                }
            }
            else
            {
                //listBox1.Items.Clear();
                MessageBox.Show("Please Select Item");
            }


        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (listBox2.SelectedItems.Count != 0)
            {
                while (listBox2.SelectedIndex != -1)
                {
                    listBox1.Items.Add(listBox2.SelectedItem);
                    listBox2.Items.Remove(listBox2.SelectedItem);
                }
            }
            else
                MessageBox.Show("Please Select Item");
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            {
                listBox2.Items.Clear();
            }
        }
    }
}
