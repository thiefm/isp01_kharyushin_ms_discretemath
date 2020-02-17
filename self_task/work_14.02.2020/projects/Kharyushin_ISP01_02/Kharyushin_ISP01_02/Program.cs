using System;

namespace Kharyushin_ISP01_02
{
    class Program
    {
        static void Main()
        {
            Vector3D vector01 = new Vector3D(5, 10, 3);
            Console.WriteLine(vector01.ToString());

            Vector3D vector02 = new Vector3D(15, 2, 25);
            Console.WriteLine(vector02.ToString());

            Console.WriteLine();

            Console.WriteLine($"Длина 1-го вектора: {vector01.Length()}; Длина 2-го вектора: {vector02.Length()}");
            Console.WriteLine($"Скалярное произведение векторов: {vector01.ScalarProductVectors(vector02)}");
            Console.WriteLine($"Векторное произведение векторов: {vector01.VectorsProduct(vector02)}");

            Console.ReadKey();
        }
    }
}
