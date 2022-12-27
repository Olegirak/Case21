// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Write("Введите координату X точки A");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y точки A");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z точки A");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату X точки B");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y точки B");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z точки B");
int z2 = int.Parse(Console.ReadLine());

double Distance(int X1,int X2,int Y1,int Y2,int Z1,int Z2)
{
    double result = Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2));
    result = Math.Sqrt(Math.Pow((Z2-Z1),2)+Math.Pow(result,2));
    
    return Math.Round(result,2);
}
Console.WriteLine(Distance(x1,x2,y1,y2,z1,z2));