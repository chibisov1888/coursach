using System;

namespace mech
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите номер задачи");
            string number = Console.ReadLine();
            int n = Convert.ToInt32(number);
            
            switch (n)
            {
                case 1:
                    Problem1 problem1 = new Problem1();

                    problem1.Message1();

                    problem1.Text1();
                    break;
                case 2:
                    Problem2 problem2 = new Problem2();
                    problem2.Message2();
                    
                    problem2.Text2();
                    break;
                case 3:
                    Problem3 problem3 = new Problem3();
                    
                    problem3.Message3();
                    
                    problem3.Text3();
                    
                    break;
                default:
                    Console.WriteLine("Такой задачи нет");
                    break;
            }
        }
    }
}