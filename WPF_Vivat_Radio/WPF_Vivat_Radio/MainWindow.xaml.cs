using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

        int counter = 1;
        string ur = @"D:\Music\Apache\";
        static int minute;
        static int hours;
        static int block = 0;
        static int now_minute;
        static int mode = 0;
        public MainWindow()
        {
            InitializeComponent();
            
            
        }
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            mode++;
            if (mode==1)
            {
                mode = 0;
            }
        }
        MediaPlayer mp = new MediaPlayer();

        private void PlayMusic(string uri)
        {
            Uri ur = new Uri(uri);
            mp.Open(ur);
            mp.Play();
            counter++;
        }

        private void Mp_MediaEnded(object sender, EventArgs e)
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
    }
}
