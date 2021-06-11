using System;

namespace Exercise5
{
    public class Box
    {
        public double length { get; set; }
        public double breadth { get; set; }
        public double height { get; set; }

        public double GetVolume()
        {
            return length * breadth * height;
        }

        public void SetLength(double len)
        {
            length = len;
        }

        public void SetBreadth(double bre)
        {
            breadth = bre;
        }

        public void SetHeight(double hei)
        {
            height = hei;
        }
    }

    public class Box1 : Box
    {
        public double GetBox1Volume() {
            return GetVolume();
        }
    }
    public class Box2 : Box
    { }

    public class Box3 : Box { }
        class Program
    {
        static void Main(string[] args)
        {
            int[] box1 = { 3, 6, 10 }, box2 = { 20, 30, 35}, box3 = { 1, 50, 100};
            Box1 b1 = new Box1();
            b1.SetLength(box1[0]);
            b1.SetBreadth(box1[1]);
            b1.SetHeight(box1[2]);
            double volume = b1.GetVolume();
            Console.WriteLine("Volume of Box1: {0}", volume);

            Box2 b2 = new Box2();
            b2.SetLength(box2[0]);
            b2.SetBreadth(box2[1]);
            b2.SetHeight(box2[2]);
            volume = b2.GetVolume();
            Console.WriteLine("Volume of Box2: {0}", volume);

            Box3 b3 = new Box3();
            b3.SetLength(box3[0]);
            b3.SetBreadth(box3[1]);
            b3.SetHeight(box3[2]);
            volume = b3.GetVolume();
            Console.WriteLine("Volume of Box3: {0}", volume);

        }
    }
}
