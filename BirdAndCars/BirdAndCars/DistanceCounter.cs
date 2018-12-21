using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BirdAndCars.Entities;

namespace BirdAndCars
{
    public class DistanceCounter
    {
        public Car Car1 { get; set; }
        public Car Car2 { get; set; }
        public Bird Bird { get; set; }
        public double Distance { get; set; }

        private double totalDistanceBird; // Результирующее растояние, которое пролетит птицы
        private bool birdFliesFromCar1ToCar2; // Значение, которое указывает в какую сторону летит птица
        private decimal TotalTime { get; set; } // Время за которое встретятся машины
        private decimal currentTime { get; set; } // Сумматор времени полетов
        private double timeForOneFly { get; set; } // Время полета в одну сторону 
        private int depth { get; set; } // Глубина рекурсии, чтобы предотвратить ситуации переполнения стека и выскакивание исключения
                                        //из-за ограничений по используемому кол-ву памяти

        public double TotalDistanceBird
        {
            get
            {
                return totalDistanceBird;
            }
        }

        public DistanceCounter(Car _car1, Car _car2, Bird _bird, double _distance)
        {
            Car1 = _car1;
            Car2 = _car2;
            Bird = _bird;
            Distance = _distance;
            depth = 0;
        }

        //метод подсчета расстояния, которое пролетела птица
        public void CountDistance()
        {
            birdFliesFromCar1ToCar2 = true; // т.к. птица стартует от первой машины то явно при старте она полетит от машины 1 до машины 2
            TotalTime = Convert.ToDecimal(Distance / (Car1.Speed + Car2.Speed));
            BirdFlies(birdFliesFromCar1ToCar2, Distance);            
        }

        //т.к. используется рекурсия возможны ситуации переполнения стека и выскакивание исключения
        //из-за ограничений по используемому кол-ву памяти
        //можно убрать данное ограничение в настройках, но все-равно рано рано или поздно можно упереться в объем оперативной памяти
        private void BirdFlies(bool _fromCar1ToCar2, double _distance)
        {            
            //проверка на то, относительно которой машины считать расстояние
            if (_fromCar1ToCar2)
            {
                //ListWithTime.Add(Distance / (Bird.Speed + Car2.Speed));
                timeForOneFly = _distance / (Bird.Speed + Car2.Speed);
                birdFliesFromCar1ToCar2 = false;
            }
            else
            {
                //ListWithTime.Add(Distance / (Bird.Speed + Car1.Speed));
                timeForOneFly = _distance / (Bird.Speed + Car2.Speed);
                birdFliesFromCar1ToCar2 = true;
            }

            //проверка сравнения скоростей птицы и машин, возможна ситуация, что машины едут быстрее, чем летит птица
            if(TotalTime <= Convert.ToDecimal(timeForOneFly))
            {
                currentTime += Convert.ToDecimal(TotalTime);
                totalDistanceBird = Convert.ToDouble(currentTime) * Bird.Speed;
                return;
            }
            else
            {
                currentTime += Convert.ToDecimal(timeForOneFly);
            }

            // расстояния, которые проехали машины пока птица летела в определенную сторону
            double distanceForCar1 = Car1.Speed * timeForOneFly; 
            double distanceForCar2 = Car2.Speed * timeForOneFly;

            //подсчет дистанции между машинами
            double distance = _distance - distanceForCar1 - distanceForCar2;

            //Узнаем, сможет ли птица пролететь еще раз в другой конец, до того как машины встретятся ?
            if (TotalTime > currentTime && depth < 500)
            {
                ++depth;
                BirdFlies(birdFliesFromCar1ToCar2, distance);
            }
            //Если узнаем что птица уже не успеет слетать в другую сторону, то вычисляем время
            //ее последнего полета (delta)
            //т.к. последний полет будет длиться меньше, чем если бы птица летела до машины(текущее последнее значение)
            else
            {
                // чтобы различить ситуации, когда вышли за диапозон глубины рекурсии или же птица не успевает
                //слетать в другую сторону
                if(TotalTime < currentTime)
                {
                    decimal delta = TotalTime - (currentTime - Convert.ToDecimal(timeForOneFly)); // разница времени
                    currentTime -= Convert.ToDecimal(timeForOneFly); // вычитаем время последнего полета, т.к. птица не успеет его совершить (машины встретятся быстрее)
                    currentTime += Convert.ToDecimal(delta);
                }
                else
                {
                    currentTime += Convert.ToDecimal(timeForOneFly);
                }
                
                //Вычисляем сколько же суммарно пролетела птица после последнего того как машины встретились           
                totalDistanceBird = Convert.ToDouble(currentTime) * Bird.Speed;                           
            }           
        }       

    }
}
