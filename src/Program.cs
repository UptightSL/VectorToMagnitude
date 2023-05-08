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

            public Vector3(int X, int Y, int Z)
            {
                this.X = X;
                this.Y = Y;
                this.Z = Z;
            }
        }

        public static int Magnitude(Vector3 Vec1, Vector3 Vec2)
        {
            return (Vec2.X - Vec1.X)^2 + (Vec2.Y - Vec1.Y)^2 + (Vec2.Z - Vec1.Z)^2;
        }

        static void Main()
        {
            Vector3 V1 = new Vector3(8734, 1245, 9387);
            Vector3 V2 = new Vector3(2347, 9772, 1247);

            int Mag = Magnitude(V1, V2);

            Console.WriteLine("Magnitude: " + Mag);
        }
    }
}