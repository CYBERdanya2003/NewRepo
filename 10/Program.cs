using System;
class Program
{
    static Random rnd = new Random();
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество строк массива в пределах от 5 до 20");
        Console.WriteLine("------------------------------------------------------");
        var rowNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов массива в пределах от 5 до 20");
        Console.WriteLine("---------------------------------------------------------");
        var columnNumber = int.Parse(Console.ReadLine());

        var MMM = new int[rowNumber, columnNumber];
        FillRandom(MMM);
        PrintMatrix(MMM);

        var sr = GetAverageByRow(MMM);
        for (var i = 0; i < sr.Length; i++)
            Console.WriteLine($"Строка:{i,2} Среднее: {sr[i]}");

        Console.ReadKey();
    }

    static void PrintMatrix(int[,] MMM)
    {
        for (var i = 0; i < MMM.GetLength(0); i++)
        {
            for (var j = 0; j < MMM.GetLength(1); j++)
                Console.Write($"{MMM[i, j],3} ");
            Console.WriteLine();
        }

        Console.WriteLine();
    }

    static void FillRandom(int[,] MMM)
    {

        for (var i = 0; i < MMM.GetLength(0); i++)
            for (var j = 0; j < MMM.GetLength(1); j++)
                MMM[i, j] = rnd.Next(0, 100);

    }

    static double[] GetAverageByRow(int[,] MMM)
    {
        var res = new double[MMM.GetLength(0)];

        for (var i = 0; i < MMM.GetLength(0); i++)
        {
            var avg = 0.0;

            for (var j = 0; j < MMM.GetLength(1); j++)
                avg += MMM[i, j];

            res[i] = avg / MMM.GetLength(1);
        }

        return res;

    }
}