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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClassLibrary2;
using static System.Net.Mime.MediaTypeNames;


namespace Biblioteki
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

        private void Ser(object sender, RoutedEventArgs e)
        {
            Class1 sereal = new Class1();
            sereal.Serialize(Textbl.Text);
        }

        private void Deser(object sender, RoutedEventArgs e)
        {
            Class1 desereal = new Class1();
            Textbl.Text = desereal.Deserialize<string>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Theme = "LightPink";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Theme = "DarkPink";
        }
    }
}
