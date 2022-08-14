// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
 {
    System.Console.Write(message);//вывести сообщение
    string readValue = Console.ReadLine();   //считывает с консоли строку
    int result = int.Parse(readValue);// преобразует строку в целое число
    return result;//возвращает результат
}
int GetDistance(int x1, int x2)
{
int x = x1-x2;
if (x < 0)
{
x = x2-x1;
}
return x*x;
}

int x1 = Prompt("Введите X1 : ");
int x2 = Prompt("Введите X2 : ");
int y1 = Prompt("Введите Y1 : ");
int y2 = Prompt("Введите Y2 : ");
int z1 = Prompt("Введите Z1 : ");
int z2 = Prompt("Введите Z2 : ");
double Dist = Math.Sqrt(GetDistance(x1,x2)+GetDistance(y1,y2)+GetDistance(z1,z2));


System.Console.WriteLine($"расстояние равно {Dist}");

