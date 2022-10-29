using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace PR_20._101_Goreckaya_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Find = txt_Vvod.Text;
                string res = "";
                int sb = Regex.Matches(Find, @"[qwertyuiopasdfghjklzxcvbnm]", RegexOptions.IgnoreCase).Count;
                if (sb != 0)
                {
                   TextInfo upp = new CultureInfo("ru-RU", false).TextInfo;
                   res = upp.ToTitleCase(Find);
                    string probel = "";
                    probel = res.Replace("  ", "это_пробел");
                    txt_Result.Text = probel;


                }
                else
                {
                    txt_Result.Text = "Введите строку на английском языке";
                }
            }
            catch
            {
                txt_Result.Text = "Введите предложение";
            }
            
        }
    }
}
