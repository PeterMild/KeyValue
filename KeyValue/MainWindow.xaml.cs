using System;
using System.Collections;
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

namespace KeyValue
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ArrayList arrayList;
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
            arrayList = new ArrayList();

        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            string key = txtBox.Text;
            string value = txtBox2.Text;

            hashtable.Add(key, value);

            txtBox.Text = "";
            txtBox2.Text = "";

            MessageBox.Show("เพิ่ม " + key.ToString() +" "+value.ToString()+ " เรียบร้อยแล้ว");

        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            string removeKey = txtBox.Text;
            string removeValue = txtBox2.Text;
            MessageBox.Show("เพิ่ม " + removeKey.ToString() + " " + removeValue.ToString() + " เรียบร้อยแล้ว");
            hashtable.Remove(removeKey);
            txtBox.Text = "";
            txtBox2.Text = "";

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ICollection icollection = hashtable.Keys;

            foreach (string key in icollection)
            {
                MessageBox.Show(hashtable[key].ToString());
            }
        }
    }
}

