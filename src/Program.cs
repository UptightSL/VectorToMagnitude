using System;

namespace src
{
    class Program
    {
        public struct Vector3
        {
            public int X;
            public int Y;
            public int Z;
            public float Magnitude;

            public Vector3(int X, int Y, int Z)
            {
                this.X = X;
                this.Y = Y;
                this.Z = Z;
                this.Magnitude = (float) Math.Sqrt(Math.Pow(this.X, 2) + Math.Pow(this.Y, 2) + Math.Pow(this.Z, 2));
            }

            public float Distance(Vector3 Vector)
            {
                return (this.Magnitude - Vector.Magnitude);
            }
        }

        static void Main()
        {
            Vector3 V1 = new Vector3(5, 5, 5);
            Vector3 V2 = new Vector3(15, 15, 15);

            Console.WriteLine("V1 Magnitude: " + V1.Magnitude);
            Console.WriteLine("V2 Magnitude: " + V2.Magnitude);
            Console.WriteLine("Distance: " + V1.Distance(V2));
        }
    }
}
