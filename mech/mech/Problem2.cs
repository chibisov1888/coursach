using System;

namespace mech
{
    public class Problem2
    {
        public void Message2()
        {
            Console.WriteLine("Текст задачи: Корабль движется по экватору на восток со скоростью v0 = 30 км/ч. С юго-востока под углом φ = 60° к экватору дует ветер со скоростью v = 15 км/ч. Найти скорость v' ветра относительно корабля и угол φ' между экватором и направлением ветра в системе отсчета, связанной с кораблем.");
        }

       

        public void Text2()
        {
            double v0;
            double v;
            double v1;
            double f;
            double f1;
            double fi;
            
            Console.WriteLine("Введите данные");
            Console.WriteLine("Введите скорость корабля");
            string vk = Console.ReadLine();
            v0 = Convert.ToInt32(vk);
            Console.WriteLine("Под каким углом дует ветер");
            string fg = Console.ReadLine();
            f = Convert.ToDouble(fg);
            Console.WriteLine("Введите сокрость ветра (в км/ч)");
            string vv = Console.ReadLine();
            v = Convert.ToInt32(vv);
            
            fi = f * Math.PI/180;
            
            v1 = Math.Sqrt(Math.Pow(v0, 2) + Math.Pow(v, 2) + 2 * v0 * v * Math.Cos(f*Math.PI/180));
            f1 = Math.Asin(v*Math.Sin(fi)/v1);
            
            Console.WriteLine("Ответ: скорость ветра относительно корабля составляет " + v1 + " км/ч и угол между экватором и направлением ветра в системе отсчета, связанной с кораблем составляет " + f1 + " градусов");
        }
    }
    
    

}