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
using System.Threading;

namespace kakuka
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

        private void btn_result_Click(object sender, RoutedEventArgs e)
        {
            double tb_one = Convert.ToDouble(tb_first_num.Text);
            double tb_two = Convert.ToDouble(tb_second_num.Text);
            if (rb_add.IsChecked.Value)
            {
                string result = Convert.ToString(tb_one + tb_two);
                MessageBox.Show(result);
            }
            else if (rb_sub.IsChecked.Value)
            {
                string result = Convert.ToString(tb_one - tb_two);
                MessageBox.Show(result);
            }
            else if (rb_multi.IsChecked.Value)
            {
                string result = Convert.ToString(tb_one * tb_two);
                MessageBox.Show(result);
            }
            else if (rb_div.IsChecked.Value)
            {
                while (tb_two == 0)
                {
                    MessageBox.Show("Измените значение второго числа.", "Упс!");
                    break;
                }
                string result = Convert.ToString(tb_one / tb_two);
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("Выберите оператор.", "Упс!");
            }
        }
    }
}
