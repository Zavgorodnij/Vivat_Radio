using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WPF_Vivat_Radio
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
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

        static int counter = 1;
        static string ur = @"D:\Music\Apache\";
        static int minute;
        static int hours;
        static int block = 0;
        static int now_minute;
        static int mode = 0;
        public MainWindow()
        {
            Task WPF = Task.Run(() =>
             {
                 InitializeComponent();
                 Name.Content = Directory.GetFiles(ur)[0];
             });
            

        }
        static MediaPlayer mp = new MediaPlayer();
        
        public static void PlayMusic(string uri)
        {
            Uri ur = new Uri(uri);
            mp.Open(ur);
            mp.Play();
            counter++;
        }

        public static void Mp_MediaEnded(object sender, EventArgs e)
        {
            if (counter <= Directory.GetFiles(ur).Count() - 1) PlayMusic(Directory.GetFiles(ur)[counter]);
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
            PlayMusic(Directory.GetFiles(ur)[0]);
            Console.WriteLine("iwughirg" + Directory.GetFiles(ur)[0]);
            mp.MediaEnded += Mp_MediaEnded;

        }
        //Перемена 30 минут
        public static void Turn_2()
        {
            
        }
        //Перемена 20 минут
        public static void Turn_3()
        {
            
        }
        //Перемена 10 минут
        public static void Turn_4()
        {
            
        }

        public void Broadcast_Cycle()
        {
            time();
            now_minute = time();
            now_minute = 660;
            do
            {
                
                if (now_minute == 660)
                {
                    Console.WriteLine("start 1");
                    Turn_1();
                    now_minute = now_minute + 1;

                    //now_minute = 670;

                }
                if (now_minute == 670)
                {
                    Console.WriteLine("exit 1");
                    mp.Stop();
                    break;
                    //Завершение трансляции
                }
                if (now_minute == 760)
                {
                    Console.WriteLine("start 2");
                    Turn_2();
                }
                if (now_minute == 790)
                {
                    Console.WriteLine("exit 2");
                    //Завершение трансляции
                }
                if (now_minute == 880)
                {
                    Console.WriteLine("start 3");
                    Turn_3();
                }
                if (now_minute == 900)
                {
                    Console.WriteLine("Exit3");
                    //Завершение трансляции
                }
                if (now_minute == 990)
                {
                    Console.WriteLine("start 4");
                    Turn_4();
                }
                if (now_minute == 1000)
                {
                    Console.WriteLine("Exit 4");
                }
                

            } while (block < 3);

        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Broadcast_Cycle();
        }

        private void stop_Click(object sender, RoutedEventArgs e)
        {
            mp.Stop();
        }
    }

    }
