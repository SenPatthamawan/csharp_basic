using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_basic
{
    public class ex13_inheritance
    {
        public static void ex13()
        {

            Rectangle rec1 = new Rectangle(3, 4);
            Console.WriteLine("Rectangle 1");
            Console.WriteLine("size [{0}, {1}]", rec1.x, rec1.y);
            Console.WriteLine("Area = {0}", rec1.GetArea());
            Console.WriteLine();

            Cuboid cub1 = new Cuboid(5, 3, 4); //กว้าง สูง ลึก
            Console.WriteLine("Cuboid 1");
            Console.WriteLine("size [{0}, {1}, {2}]",
            cub1.x, cub1.y, cub1.z);
            Console.WriteLine("Volume = {0}", cub1.GetVolume());
            Console.WriteLine();

            Cuboid cub2 = new Cuboid(10, 10, 10);
            Console.WriteLine("Cuboid 2");
            Console.WriteLine("size [{0}, {1}, {2}]",
            cub2.x, cub2.y, cub2.z);
            Console.WriteLine("Volume = {0}", cub2.GetVolume());

        }
    }

    //สร้าง Class Rectangle เป็น Base Class (คลาสแม่)
    class Rectangle
    {
        public int x;
        public int y;

        public Rectangle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double GetArea()
        {
            return x * y;
        }
    }

    //สร้าง Class Cuboid เป็น child Class (คลาสลูก)
    class Cuboid : Rectangle
    {
        public int z;

        public Cuboid(int x, int y, int z) : base(x, y) //ตอนที่ inherit *constructor จะไม่ได้มาด้วย มาแค่ method เลยต้องระบุ base ไว้ จะได้เข้าถึง propertie ของแม่ได้
        {
            this.z = z; // this เข้าถึงตัวแปรที่อยู่ในคลาสตัวเองเท่านั้น
        }

        public double GetVolume()
        {
            return GetArea() * z;
        }
    }

}
