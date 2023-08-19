using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_basic
{
    public class ex8_loop
    {
        public static void ex8()
        {
            // While Loop
            // int n = 1;
            // while (n <= 10)
            // {
            //     Console.WriteLine("Loop " + n);
            //     n++;
            // }
            // Console.WriteLine("Loop ended");

            //Do-while Loop
            // int n;

            // Console.WriteLine("Enter 0 to exit the loop");
            // do
            // {
            //     Console.Write("Your number: ");
            //     int.TryParse(Console.ReadLine(), out n);
            //     Console.WriteLine("Number you entered is " + n);
            // } while (n != 0);
            // Console.WriteLine("Loop ended");

            //For Loop
            // for (int i = 7; i <= 10; i+=2)
            // {
            //     Console.WriteLine(i);
            // }

            //Foreach
            // int[] numbers = { 2, 4, -1, 5, 0, 8, 9 };
            // foreach (int i in numbers) //ข้อมูลจะถูกเก็บพักไว้ที่ i
            // {
            //     Console.WriteLine(i);
            // } 

            //Loop with Break
            // for (int i = 1; i <= 10; i++)
            // {
            //     Console.WriteLine(i);
            //     if (i == 5) break; //if บรรทัดเดียวไม่ต้องใส่ {} ก็ได้
            // }

            //Loop Continue
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0) continue; //เจอเลขคู่ให้ไปวนรอบต่อไปต่อ *ถ้าเป็นเลขคี่ก็ทำตามคำสั่งข้างล่างปกติ //ถ้าใช้ return จะออกจากลูปเลย continue จะยังทำรอบต่อไปได้อยู่
                Console.WriteLine(i); //return ใช้ครั้งเดียวเมื่อจบการทำงาน break ใช้ได้เรื่อยๆ
            } 
        }
    }
}