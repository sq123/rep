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


        /*public airport(int startfuel)
        {
            fuel = startfuel;
            Console.WriteLine("Диспетчерская. Система управления самолетами.");

        }*/
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
                    //Program.RespawnPlane(ind);   //передаём индекс объекта, который нужно перезаполнить******
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
        }
    }
    class Program  //базовый класс
    {      
        
        //коллекция Авиапарк объектов класса самолёт
        //
        static void StartProgramm(int kol_planes)       //метод, создающий объекты самолёт и заносящий их в Авиапарк. принимаемый параметр = количеству самолётов в авиапарке
        {
            for (int i = 0; i < kol_planes; i++)        //
            {                                           //заполнение коллекции Авиапарк. точнее тут будет цикл, для заполнения. в принципе сам процесс создания одного элемента     
                CreatePlane(i);                         //
            }                                           //
        }
        static void RespawnPlane(int n)         //метод для респауна самолётов. вызывается при взрыве и тд. передаётся индекс объекта, который требуется заменить
        {
            CreatePlane(n);
            //
            //заполнение элемента
            //
        }
        static void CreatePlane(int n)             //заполнение/вызов конструктора класса Самолёт
        {
            //airport plane = new airport(n);
        }
        static void center()
        {
            int command = Convert.ToInt32(Console.ReadLine());

            switch (command)
            {
                case 1:
                    
                    

            }
        }

        static void Main(string[] args) //точка входа в программу
        {
            Console.WriteLine("Введите количество летательных средств:");
            int kol_planes = Convert.ToInt32(Console.ReadLine());
            StartProgramm(kol_planes);      //вызов метода стартпрограмм с передачей количества самолётов


            airport p = new airport();
            p.startengine();


            


            Console.WriteLine("Введите команду (1 - запуск двиг., 2 - остановка двиг., 3 - заправка, 4 - увелич. скорость, 5 - уменьшить скорость, 6 - увелич. высоту, 7 - уменьш. высоту). ");
            center();


            //cl cl1 = new cl(n);         //создание экземпляра класса. тут мы используем конструктор с параметром
            //cl cl2 = new cl();          //тут конструктор без параметров


            //Console.WriteLine(cl1.MetN());      //
            //Console.WriteLine(cl2.MetN());      //вызов методов 1 у обоих классов


            //cl1.MetM(5);        //
            //cl2.MetM(5);        //вызов второго метода у обоих экземпляров класса 


            Console.WriteLine("финиш");
            Console.ReadKey();
        }
    }
}