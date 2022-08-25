using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
using System.Security;

namespace _17_Domains
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*
         Создайте приложение WindowsForms, которое позволит безопасно запускать сборки. В
интерфейсе предусмотрите возможность выбора ограничения привилегий для запускаемой
сборки. 
         */
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Zone[] hostEvidence = { new Zone(SecurityZone.Internet) };
            Evidence evidence = new Evidence(hostEvidence, null);
            AppDomain domain = AppDomain.CreateDomain("MyDomain");
            try
            {
                domain.ExecuteAssembly(@"F:\My Projects\14-EvenNumbers\bin\Debug\net5.0\14-EvenNumbers.exe", evidence);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
