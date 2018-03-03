//https://www.youtube.com/watch?v=hX9b0vtmOhY
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;
using System.IO;

namespace Vivat_Radio
{
    //Первая пара
    //570-Начало первой пары
    //660-Конец первой пары
    //
    //Вторая пара
    //670-начало второй пары
    //760-Конец второй пары
    //
    //Третья пара
    //790-Начало третьей пары
    //880-Конец третьей пары
    //
    //Четвертая пара
    //900-Начало четвёртой пары
    //990-Конец четвёртой пары
    class Program
    {
        static SoundPlayer player = new SoundPlayer();
        static int minute;
        static int hours;
        static int block=0;
        static int now_minute;
        static void Main(string[] args)
        {
            time();
            now_minute = time();
            do
            {
                player.Dispose();
                if (now_minute==660)
                {
                    Console.WriteLine("start 1");
                    Turn_1();
                }
                if (now_minute == 670)
                {
                    Console.WriteLine("exit 1");
                    //Завершение трансляции
                }
                if (now_minute==760)
                {
                    Console.WriteLine("start 2");
                    Turn_2();
                }
                if (now_minute==790)
                {
                    Console.WriteLine("exit 2");
                    status();
                    //Завершение трансляции
                }
                if (now_minute==880)
                {
                    Console.WriteLine("start 3");
                    Turn_3();
                }
                if (now_minute==900)
                {
                    Console.WriteLine("Exit3");
                    //Завершение трансляции
                }
                if (now_minute==990)
                {
                    Console.WriteLine("start 4");
                    Turn_4();
                }
                if (now_minute==1000)
                {
                    Console.WriteLine("Exit 4");
                }
                
            } while (block < 3);
            
        }
        public static int time()
        {
            minute = DateTime.Now.TimeOfDay.Minutes;
            hours = DateTime.Now.TimeOfDay.Hours;
            return ((hours * 60) + minute);
        }
        //Перемена 10 минут
        public static void Turn_1()
        {
            status();
            player.LoadAsync();
            Thread.Sleep(600000);

        }
        //Перемена 30 минут
        public static void Turn_2()
        {
            status();
            Thread.Sleep(1800000);
        }
        //Перемена 20 минут
        public static void Turn_3()
        {
            status();
            Thread.Sleep(1200000);
            
        }
        //Перемена 10 минут
        public static void Turn_4()
        {
            Thread.Sleep(600000);
            status();
        }
        public static void media_player()
        {

        }
        public static void status()
        {
            Console.WriteLine(hours + " " + minute);
        }

    }
}
