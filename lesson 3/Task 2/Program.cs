// *Задача 21: Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

Console.WriteLine(" введите координаты x,y,z первой точки");
int Xa = Convert.ToInt32(Console.ReadLine());
int Ya = Convert.ToInt32(Console.ReadLine());
int Za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" введите координаты x,y,z второй точки");
int Xb = Convert.ToInt32(Console.ReadLine());
int Yb = Convert.ToInt32(Console.ReadLine());
int Zb = Convert.ToInt32(Console.ReadLine());

Dist(Xa, Ya, Za, Xb, Yb, Zb);


void Dist(int Xa, int Ya, int Za, int  Xb, int Yb, int Zb){
    double dist = Math.Sqrt((Xb-Xa)*(Xb-Xa)+(Yb-Ya)*(Yb-Ya)+(Zb-Za)*(Zb-Za));
     Console.WriteLine(" расстояние между точками = " + dist);
}