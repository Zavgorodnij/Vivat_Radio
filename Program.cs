using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Vivat_Radio
{
    
    class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer player = new SoundPlayer();
            var now = DateTime.Now;
            var hours = new TimeSpan(now.Hour);
            var minute = new TimeSpan(now.Minute);
            if (hours>minute)
            {
                player.LoadAsync();
                player.Play();
                Console.WriteLine("Good");
            }
            else
            {
                Console.WriteLine("Bad");
            }
            Console.WriteLine(hours);
            Console.WriteLine(minute);
            Console.ReadKey();
        }

    }
}
