using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_IHateWindowsForms
{
    /*
     ƒополнительное задание
—оздайте приложение WindowsForms. Ќа главной форме приложени€ разместите 3 кнопки с
названи€ми: IsComplete, End, Callback. ќрганизуйте обработчики нажати€ на кнопки таким
образом, чтобы они инициировали асинхронное выполнение некоторого метода (метод
определите сами, можно воспользоватьс€ чем-то вроде Add или более абстрактного Compute).
ƒл€ каждой из кнопок завершение асинхронного метода должно отслеживатьс€
соответствующим образом: 
    IsComplete Ц с использованием значени€ свойства IsComplete
    End Ц просто примен€€ EndInvoke
    Callback Ц с использованием callback метода 
     */
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
