using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace обучалка
{
    class airport
    {
        private
        int maxspeed = 0;
        int speed = 0;
        int fuel = 0;
        int fuelpersec = 0;
        int maxfuel = 10;
        int height = 0;
        int maxheight = 900;
        bool engine = false;

        int ind; //это индекс объекта. это временная переменная, которую можно удалить, если реализуешь иначе. но она пока для того, что бы вызов метода "респаун" не ругался.***


        public airport()
        {
            fuel = 10;
            Console.WriteLine("Диспетчерская. Система управления самолетами.");
            
        }
        public void getfuel()  // заправка     
        {
            fuel = maxfuel;
        }
        public void morespeed(int a)   // увелич. скорости
        {
            
            fuel = fuel - a * maxfuel * 5 / 100;  //на каждое изм. скорости требуется 5 проц от макс кол-ва топлива
            if (speed + a < maxspeed)
            {
                speed = speed + a;
            }
            else
            {
                Console.WriteLine("Нельзя увеличить скорость на данное значение, превышает макс. скорость.");
            }
            
        }
        public void lessspeed(int a)   // уменьш. скорости
        {
            fuel = fuel - a * maxfuel * 5 / 100;
            if (speed - a > 0)
            {
                speed = speed - a;
            }
            else
            {
                speed = 0;
            }
            if (speed < maxspeed / 100)   // при слишком низкой скорости самолет разбивается
            {
                height = 0;
                Console.WriteLine("Слишком низкая скорость. Самолет упал и разбился.");
            }
        }
        public void moreheight(int a)   // увелич. высоты
        {
            fuel = fuel - a * maxfuel / 100;  //на каждое изм. высоты требуется 10 проц от макс кол-ва топлива
            if (height + a < maxspeed)
            {
                height = height + a;
            }
            else
            {
                Console.WriteLine("Нельзя увеличить высоту на данное значение, превышает макс. высоту.");
            }
        }
        public void lessheight(int a)   // уменьш. высоты
        {
            fuel = fuel - a * maxfuel / 100;
            if (height - a > 0)
            {
                height = height + a;
            }
            else   // при уменьш. высоты до уровня земли проверяется скорость самолета, если она слишком большая самолет разбивается
            {
                if (speed > maxspeed * 50 / 100)
                {
                    height = 0;
                    Console.WriteLine("Самолет разбился.");
                    
                }
                else
                {
                    height = 0;
                    Console.WriteLine("Самолет приземлился.");
                }
            }
        }
        public void startengine()
        {
            engine = true;
            Console.WriteLine("Запуск двигателя.");
        }
        public void stopengine()
        {
            engine = false;
            Console.WriteLine("Отключение двигателя.");
            met.plane.startengine();   //////////////////////*****************************вот мы вызываем 
        }
    }
    





    static class met()
    {
        public static airport plane = new airport();
        //
        //коллекция Авиапарк объектов класса самолёт
        //
        static void StartProgramm()       //метод, создающий объекты самолёт и заносящий их в Авиапарк. принимаемый параметр = количеству самолётов в авиапарке
        {}
        
        public static void center()
        {}
        //met.plane.startengine(); а это пример обращения к полю и тд

    }



    class Program  //базовый класс
    {
        public airport plane = new airport();
        //
        //коллекция Авиапарк объектов класса самолёт
        //
        void StartProgramm()       //метод, создающий объекты самолёт и заносящий их в Авиапарк. принимаемый параметр = количеству самолётов в авиапарке
        {
            
            Console.WriteLine("Введите команду (1 - запуск двиг., 2 - остановка двиг., 3 - заправка, 4 - увелич. скорость, 5 - уменьшить скорость, 6 - увелич. высоту, 7 - уменьш. высоту). ");
            center();
        }
        
        public static void center()
        {
            int command = Convert.ToInt32(Console.ReadLine());

            switch (command)
            {
                case 1:
                    newplane.startengine();
                    break;
                case 2:
                    newplane.stopengine();
                    if (height > 0)
                    {

                    }
                case 3:
                    newplane.

            }
            public airport newplane = new airport();
        }

        static void Main(string[] args) //точка входа в программу
        {
            
            
            
            StartProgramm();      //вызов метода стартпрограмм с передачей количества самолётов
    



            Console.WriteLine("финиш");
            Console.ReadKey();
        }
    }
}