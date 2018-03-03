//https://www.youtube.com/watch?v=hX9b0vtmOhY
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

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
        static int minute;
        static int hours;
        static void Main(string[] args)
        {
            time();
            
        }
        public static int time()
        {
            minute = DateTime.Now.TimeOfDay.Minutes;
            hours = DateTime.Now.TimeOfDay.Hours;
            return ((hours * 60) + minute);
        }
        public static void player()
        {

        }

    }
}
