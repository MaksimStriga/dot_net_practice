using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        { int[] nums6 = new int[6];
            for (int i = 0; i < 6;i++)
            {
                Console.WriteLine("Введите" +(i+1)+ "элемент массива");
                string a1 = Console.ReadLine();
                int b1 = Convert.ToInt32(a1);
                nums6[i] = b1;

            }
               Console.WriteLine("Полученый массив");
            for (int i = 0; i < 6;i++)
            {
                
                Console.WriteLine(nums6[i]);
         
            }
            Console.WriteLine("Измененный массив");
            nums6[2] = nums6[2] * 10;
            for (int i = 0; i < 6; i++)
            {

                Console.WriteLine(nums6[i]);

            }
            //Console.WriteLine("Введите первый элемент массива");
            //string a1 = Console.ReadLine();
            //int b1 = Convert.ToInt32(a1);
            //nums6[0] = b1;
            //Console.WriteLine("Введите второй элемент массива");
            //string a2 = Console.ReadLine();
            //int b2 = Convert.ToInt32(a2);
            //nums6[1] = b2;
            //Console.WriteLine("Введите третий элемент массива");
            //string a3 = Console.ReadLine();
            //int b3 = Convert.ToInt32(a3);
            //nums6[2] = b3;
            //Console.WriteLine("Введите четвертый элемент массива");
            //string a4 = Console.ReadLine();
            //int b4 = Convert.ToInt32(a4);
            //nums6[3] = b4;
            //Console.WriteLine("Введите пятый элемент массива");
            //string a5 = Console.ReadLine();
            //int b5 = Convert.ToInt32(a5);
            //nums6[4] = b5;
            //Console.WriteLine("Введите шестой элемент массива");
            //string a6 = Console.ReadLine();
            //int b6 = Convert.ToInt32(a6);
            //nums6[5] = b6;
            //Console.WriteLine(nums6[2]*10);

            Console.ReadLine();
        }
    }
}
