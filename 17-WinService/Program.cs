using System.IO;
using System.ServiceProcess;

namespace _17_WinService
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new MyService()
            };
            ServiceBase.Run(ServicesToRun);
        }
        public class MyService : ServiceBase
        {
            FileInfo file;
            StreamWriter writer;
            FileSystemWatcher watcher;
            public MyService()
            {
                file = new FileInfo(@"F:\Tests\Log.txt");
                writer = file.CreateText();

                watcher = new FileSystemWatcher(@"F:\", @"D:\");
                watcher.Created += WatcherChanged;
                watcher.Deleted += WatcherChanged;
                watcher.Renamed += WatcherChanged;
                watcher.Changed += WatcherChanged;
            }
            void WatcherChanged(object sender, FileSystemEventArgs e)
            {
                writer.WriteLine("Changed:{0}, {1}", e.ChangeType, e.FullPath);
            }
            protected override void OnStart(string[] args)
            {
                watcher.EnableRaisingEvents = true;
            }
            protected override void OnStop()
            {
                watcher.EnableRaisingEvents = false;
            }
        }
    }
}
