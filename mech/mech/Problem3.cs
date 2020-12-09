using System;

namespace mech
{
    public class Problem3
    {
        public void Message3()
        {
            Console.WriteLine("Текст задачи: Два пловца должны попасть из точки А на одном берегу реки в прямо противоположную точку В на другом берегу. Для этого один из них решил переплыть реку по прямой АВ, другой же — все время держать курс перпендикулярно к течению, а расстояние, на которое его снесет, пройти пешком по берегу со скоростью u. При каком значении u оба пловца достигнут точки В за одинаковое время, если скорость течения v0 = 2,0 км/ч и скорость каждого пловца относительно воды v' = 2,5 км/ч?");
        }
        
        public void Text3()
        {
            double v0;
            double v1;
            double t1;
            double t2;
            double d;
            double u;
            double x;

            Console.WriteLine("Введите данные");
            Console.WriteLine("Введите скорость течения реки");
            string vr = Console.ReadLine();
            v0 = Convert.ToDouble(vr);
            Console.WriteLine("Введите скорость пловцов");
            string vp = Console.ReadLine();
            v1 = Convert.ToDouble(vp);
            Console.WriteLine("Введите ширину реки");
            string dr = Console.ReadLine();
            d = Convert.ToDouble(dr);

            t1 = d / Math.Sqrt(Math.Pow(v1, 2) - Math.Pow(v0, 2));
            t2 = d / v1;
            x = (v0 / v1) * d;
            u = v0 / Math.Pow((1-Math.Pow(v0, 2) / Math.Pow(v1, 2)), -0.5) -1;
            
            Console.WriteLine("Ответ u равен " + u);
        }
    }
}