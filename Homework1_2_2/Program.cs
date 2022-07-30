using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endGame=false;
            string message;
            string messageForExit = "exit";

            while (endGame==false)
            {
                Console.Write("Введите сообщение: ");
                message = Console.ReadLine();
                if (message == messageForExit)
                {
                    endGame = true;
                }
                else
                {
                    Console.WriteLine("Сообщение не верно, продолжаем");
                }
            }
        }
    }
}