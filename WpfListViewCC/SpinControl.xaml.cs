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
    /// Логика взаимодействия для SpinControl.xaml
    /// </summary>
    public partial class SpinControl : UserControl
    {
        public SpinControl()
        {
            InitializeComponent();
        }
        //DependencyProperty
        static SpinControl()
        {
            ValueProperty = DependencyProperty.Register("Value", typeof(int), typeof(SpinControl), new FrameworkPropertyMetadata(MyPropertyChangedCallback));
            MinValProperty = DependencyProperty.Register("MinVal", typeof(int), typeof(SpinControl));
            MaxValProperty = DependencyProperty.Register("MaxVal", typeof(int), typeof(SpinControl));
        }
        public static void MyPropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            int new_val=(int)e.NewValue;
            SpinControl spinControl = (SpinControl)d;

            if(spinControl.IsInitialized||spinControl.MinVal <= new_val&& new_val<= spinControl.MaxVal)
                spinControl.textBox1.Text = new_val.ToString();
            
        }
        public static readonly DependencyProperty ValueProperty;
        public static readonly DependencyProperty MinValProperty;
        public static readonly DependencyProperty MaxValProperty;
        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }
        // Buttons
        private void Button_Click_Up(object sender, RoutedEventArgs e)
        {
            if(Value +1 <= MaxVal)
            Value++;
        }
        private void Button_Click_Dw(object sender, RoutedEventArgs e)
        {
            if(MinVal <= Value -1)
            Value--;
        }
        //proretis
        public int MinVal
        {
            get { return (int)GetValue(MinValProperty); }
            set { SetValue(MinValProperty, value); }
        }
        public int MaxVal 
        {
            get { return (int)GetValue(MaxValProperty); }
            set { SetValue(MaxValProperty, value); }
        }
    }
}
