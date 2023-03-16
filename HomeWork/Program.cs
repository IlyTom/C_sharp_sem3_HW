// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double[] PointPosition(int numPoint)
{
    Console.Write($"Введите X координату {numPoint} точки: ");
    double x = Convert.ToDouble(Console.ReadLine());

    Console.Write($"Введите Y координату {numPoint} точки: ");
    double y = Convert.ToDouble(Console.ReadLine());

    Console.Write($"Введите Z координату {numPoint} точки: ");

    double z = Convert.ToDouble(Console.ReadLine());
    double[] PointXYZ = new double[] { x, y, z };

    Console.WriteLine($"Координаты точки {numPoint} : {PointXYZ[0]}, {PointXYZ[1]}, {PointXYZ[2]}");

    return PointXYZ;
}

double CheckDistance(double[] one, double[] two)
{
    double DistX = Math.Pow(one[0] - two[0], 2);
    double DistY = Math.Pow(one[1] - two[1], 2);
    double DistZ = Math.Pow(one[2] - two[2], 2);
    double Distance = Math.Sqrt(DistX + DistY + DistZ);
    return Distance;
}

double[] PointA = PointPosition(1);
double[] PointB = PointPosition(2);

double Distance = CheckDistance(PointA, PointB);
Console.WriteLine($"Расстояние между точками A({PointA[0]},{PointA[1]},{PointA[2]}) и B({PointB[0]},{PointB[1]},{PointB[2]}) равно {Math.Round(Distance,2)}");
