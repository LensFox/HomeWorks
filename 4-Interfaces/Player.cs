using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Interfaces
{
    public class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("I'm playing");
        }
        public void Pause()
        {
            Console.WriteLine("I'm paused");
        }
        public void Stop()
        {
            Console.WriteLine("I'm stopped");
        }
        public void Record()
        {
            Console.WriteLine("I'm recording");
        }
    }
}
