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

namespace WpfListViewCC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class DataType 
        {
            public int no { get; set; }
            public int val { get; set; }
            public DataType(int no, int val) 
            {
                this.no = no;
                this.val = val;
            }
        }
        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < 11; i++)
                data.Add(new DataType(i,i));

            list1.ItemsSource = data;
        }

        public List<DataType> data { get; set; } = new List<DataType>();
        public List<DataType> Data { get { return data; } set { data=value; } }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            list1.Items.Add(new DataType(0, 0));
        }
    }
}
