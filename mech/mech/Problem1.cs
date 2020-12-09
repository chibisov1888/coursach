using System;

namespace mech
{
    public class Problem1

    {
        public void Message1()
        {
            Console.WriteLine("Текст задачи: Два тела бросили одновременно из одной точки: одно —под углом u=  170°  к  горизонту,  другое —под  углом θ=  60°  к  горизонту.  Начальная скорость  каждого  тела  v0=  25  м/с.  Пренебрегая  сопротивлением  воздуха, найти максимальное расстояние между телами через t = 40 с.");
        }
        

        public void Text1()
        {
                    int theta;
                    int v0;
                    int t;
                    int h1;
                    double h2;
                    double dh;
                    double s;
                    double s2;
        
                    Console.WriteLine("Введите данные");
                    Console.WriteLine("Введите градус угла, с которым бросили тело 1");
                    string th = Console.ReadLine();
                    theta = Convert.ToInt32(th);
                    Console.WriteLine("Введитe начальную скорость каждого тела (в м/с)");
                    string v = Console.ReadLine();
                    v0 = Convert.ToInt32(v);
                    Console.WriteLine("Добавьте время движения тел (в секундах)");
                    string time = Console.ReadLine();
                    t = Convert.ToInt32(time);
                
                    h1 = v0 * t;
                    h2 = v0 * Math.Sin(theta*Math.PI) * t;
                    s2 = v0 * Math.Cos(theta*Math.PI) * t;
                    dh = h1 - h2;
                    s = v0 * t * Math.Sqrt(2 - (1 - Math.Sin(theta*Math.PI)));
                   
                
            Console.WriteLine("Ответ: расстояние между телами составляет " + s + " метров");
        }

    }
}