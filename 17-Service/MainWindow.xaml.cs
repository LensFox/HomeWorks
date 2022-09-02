using System.Configuration.Install;
using System.ServiceProcess;
using System.Windows;
using System.Collections.Generic;
namespace _17_Service
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IEnumerable<T>
    {
        /*
         Задание 2
Создайте службу Windows, которая будет мониторить жесткие диски и при удалении из этих
дисков файла записывать информацию (полный путь) в текстовый файл.
Создайте WPF приложение. Разместите в нем TextBox, в который с определенной
периодичностью будет считываться информация из текстового файла (в который пишет
сервис). Также разместите четыре кнопки, которые будут отвечать за установку, деинсталяцию,
старт и остановку сервиса.
         */
        ServiceController controller;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void InstallButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ManagedInstallerClass.InstallHelper(new string[]
                {
                    @"F:\Tests\111\17-WinService.exe"
                });
                TextBox.Text = "Service is installed";
            }
            catch (System.Exception ex)
            {
                TextBox.Text = ex.Message;
            }
        }

        private void UninstallButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ManagedInstallerClass.InstallHelper(new string[]
               {
                   @"-u", @"F:\Tests\111\17-WinService.exe"
                });
                TextBox.Text = "Service is uninstalled";
            }
            catch (System.Exception ex)
            {
                TextBox.Text = ex.Message;
                IEnumerable
            }
        }


        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                controller = new ServiceController();
                controller.ServiceName = "TEST SERVICE";
                controller.Start();
            }
            catch (System.Exception ex)
            {
                TextBox.Text = ex.Message;
            }
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                controller = new ServiceController();
                controller.ServiceName = "TEST SERVICE";
                controller.Stop();
            }
            catch (System.Exception ex)
            {
                TextBox.Text = ex.Message;
            }
        }
    }
}


